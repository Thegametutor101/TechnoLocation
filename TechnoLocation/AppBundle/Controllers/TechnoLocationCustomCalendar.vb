Public Class TechnoLocationCustomCalendar
    Inherits MonthCalendar

    Public Property CurrentDayColor As Color

    Sub New()
        CurrentDayColor = Color.SpringGreen
        Me.TrailingForeColor = CurrentDayColor
    End Sub

End Class
