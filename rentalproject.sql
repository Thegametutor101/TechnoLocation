-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Oct 09, 2020 at 01:13 PM
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
-- Database: `rentalproject`
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
-- Table structure for table `equipment`
--

DROP TABLE IF EXISTS `equipment`;
CREATE TABLE IF NOT EXISTS `equipment` (
  `code` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `kit` int(10) NOT NULL,
  `state` varchar(50) NOT NULL,
  `available` tinyint(1) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`code`),
  KEY `kit` (`kit`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `history`
--

DROP TABLE IF EXISTS `history`;
CREATE TABLE IF NOT EXISTS `history` (
  `code` int(10) NOT NULL,
  `date` datetime NOT NULL,
  `admin` int(20) NOT NULL,
  `broken` tinyint(1) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`code`),
  KEY `admin` (`admin`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `kit`
--

DROP TABLE IF EXISTS `kit`;
CREATE TABLE IF NOT EXISTS `kit` (
  `code` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
CREATE TABLE IF NOT EXISTS `log` (
  `code` int(10) NOT NULL AUTO_INCREMENT,
  `admin` int(20) NOT NULL,
  `action` varchar(100) NOT NULL,
  `dateModified` datetime NOT NULL,
  `tableName` varchar(20) NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
  `comments` text NOT NULL,
  PRIMARY KEY (`code`),
  KEY `renter` (`renter`),
  KEY `lender` (`lender`),
  KEY `equipment` (`equipment`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `code` int(20) NOT NULL AUTO_INCREMENT,
  `password` text NOT NULL,
  `firstName` varchar(100) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phoneMain` varchar(14) NOT NULL,
  `phone2` varchar(14) NOT NULL,
  `job` int(1) NOT NULL,
  `permissions` int(1) NOT NULL,
  `balance` int(10) NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
