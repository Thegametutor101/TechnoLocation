-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Dec 02, 2020 at 09:05 PM
-- Server version: 8.0.18
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `technolocation`
--

DELIMITER $$
--
-- Functions
--
DROP FUNCTION IF EXISTS `initcap`$$
CREATE DEFINER=`root`@`localhost` FUNCTION `initcap` (`x` VARCHAR(100)) RETURNS VARCHAR(100) CHARSET utf8 BEGIN
SET @str='';
SET @l_str='';
WHILE x REGEXP ' ' DO
SELECT SUBSTRING_INDEX(x, ' ', 1) INTO @l_str;
SELECT SUBSTRING(x, LOCATE(' ', x)+1) INTO x;
SELECT CONCAT(@str, ' ', CONCAT(UPPER(SUBSTRING(@l_str,1,1)),LOWER(SUBSTRING(@l_str,2)))) INTO @str;
END WHILE;
RETURN LTRIM(CONCAT(@str, ' ', CONCAT(UPPER(SUBSTRING(x,1,1)),LOWER(SUBSTRING(x,2)))));
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `characters`
--

DROP TABLE IF EXISTS `characters`;
CREATE TABLE IF NOT EXISTS `characters` (
  `passChar` varchar(1) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `value` varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`passChar`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `characters`
--

INSERT INTO `characters` (`passChar`, `value`) VALUES
('4', '1857.85510737517'),
('3', '2104.55524992812'),
('2', '1430.3147905269'),
('1', '618.867029336674'),
('t', '465.527657610157'),
('r', '680.89441178497'),
('c', '1593.61312745597'),
('e', '2065.89234956713'),
('S', '878.056945761492');

-- --------------------------------------------------------

--
-- Table structure for table `equipment`
--

DROP TABLE IF EXISTS `equipment`;
CREATE TABLE IF NOT EXISTS `equipment` (
  `code` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `kit` int(10) NOT NULL,
  `state` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `available` tinyint(1) NOT NULL,
  `comments` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`code`),
  KEY `kit` (`kit`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `equipment`
--

INSERT INTO `equipment` (`code`, `name`, `kit`, `state`, `available`, `comments`) VALUES
(1, 'test', 1, 'good', 0, 'blabla'),
(2, 'test', 1, 'good', 1, 'je sais pas trop quoi dire mais bon hffhhfhfhfhfhfhfhfhfhfhfhhfhfhfhf'),
(3, 'test', 1, 'good', 0, 'blabla'),
(4, 'test', 2, 'good', 0, 'blabla hehehehehehehehjkfvsrudjnbskj jutcinvgt bjkxhndfsd ghrj fjndfkuvijk ecalfdugilfjcn fjthfjac lfjh hfils'),
(5, 'test', 1, 'good', 0, 'blabla'),
(6, 'test', 1, 'good', 1, 'blabla'),
(7, 'test', 1, 'good', 1, 'blabla'),
(8, 'test', 1, 'good', 0, 'blabla'),
(9, 'test', 1, 'good', 1, 'blabla'),
(10, 'test', 1, 'good', 1, 'blabla'),
(11, 'test', 1, 'good', 0, 'blabla'),
(12, 'test', 1, 'good', 1, 'blabla'),
(13, 'test', 1, 'good', 0, 'blabla');

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

DROP TABLE IF EXISTS `history`;
CREATE TABLE IF NOT EXISTS `history` (
  `code` int(10) NOT NULL,
  `date` datetime NOT NULL,
  `renter` int(20) NOT NULL,
  `admin` int(20) NOT NULL,
  `broken` tinyint(1) NOT NULL,
  `comments` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`code`),
  KEY `admin` (`admin`),
  KEY `renter` (`renter`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `history`
--

INSERT INTO `history` (`code`, `date`, `renter`, `admin`, `broken`, `comments`) VALUES
(123, '2019-08-13 00:00:00', 222, 2345, 0, 'this is fake');

-- --------------------------------------------------------

--
-- Table structure for table `kit`
--

DROP TABLE IF EXISTS `kit`;
CREATE TABLE IF NOT EXISTS `kit` (
  `code` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `kit`
--

INSERT INTO `kit` (`code`, `name`) VALUES
(1, 'Full Equip'),
(2, 'ima Test');

-- --------------------------------------------------------

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
CREATE TABLE IF NOT EXISTS `log` (
  `code` int(10) NOT NULL AUTO_INCREMENT,
  `admin` int(20) NOT NULL,
  `action` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `dateModified` datetime NOT NULL,
  `tableName` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `rent`
--

DROP TABLE IF EXISTS `rent`;
CREATE TABLE IF NOT EXISTS `rent` (
  `code` int(10) NOT NULL AUTO_INCREMENT,
  `renter` int(20) NOT NULL,
  `lender` int(20) NOT NULL,
  `equipment` int(10) NOT NULL,
  `rentDate` datetime NOT NULL,
  `returnDate` datetime NOT NULL,
  `deposit` double NOT NULL,
  `comments` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`code`),
  KEY `renter` (`renter`),
  KEY `lender` (`lender`),
  KEY `equipment` (`equipment`)
) ENGINE=MyISAM AUTO_INCREMENT=6679 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `rent`
--

INSERT INTO `rent` (`code`, `renter`, `lender`, `equipment`, `rentDate`, `returnDate`, `deposit`, `comments`) VALUES
(111, 111, 111, 11, '2020-11-06 00:00:00', '2020-11-09 00:00:00', 10.57, 'test'),
(6678, 852, 111, 664, '2018-03-15 00:00:00', '2020-11-25 00:00:00', 27.33, 'gaga gaga');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `code` int(20) NOT NULL AUTO_INCREMENT,
  `password` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `firstName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `lastName` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `phoneMain` varchar(14) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `phone2` varchar(14) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `job` int(1) NOT NULL,
  `permissions` int(1) NOT NULL,
  `balance` double NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM AUTO_INCREMENT=1763238 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`code`, `password`, `firstName`, `lastName`, `email`, `phoneMain`, `phone2`, `job`, `permissions`, `balance`) VALUES
(1763237, '3179708354712418707216942329509073896552', 'Daniel', 'Navarro', 'theendercraftgaming@gmail.com', '(819) 944-9576', '', 0, 0, 0),
(222, 'gvtevyctrgvffnhtrdf', 'bgrs', 'vgrsfg', 'vtvresger', 'vfref', 're', 0, 0, 0),
(111, 'bhsrgfgf', 'xvfefdsvef', 'dvefrfdsg', 'vsrfd', 'fr', '', 0, 0, 0),
(852, 'gaga', 'gaga', 'gaga', 'gaga', 'gaga', '', 0, 0, 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
