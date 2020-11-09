Public Class Form1
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim todayDate As DateTime = DateTime.Today
        Dim twoWeeksAgo As DateTime = todayDate.AddDays(-14)
        Me.dtpStartingDate.Value = twoWeeksAgo
    End Sub



    
    Private Sub dtpStartingDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartingDate.ValueChanged
        ' Get the starting date
        Dim dteStart As DateTime = Me.dtpStartingDate.Value
        ' Find out if the user selected a day that is not Monday
        If dteStart.DayOfWeek <> DayOfWeek.Monday Then
            MsgBox("The date you selected in invalid\n" & _
            "The time period should start on a Monday")
        End If
        Me.dtpStartingDate.Focus()
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        ' Get the starting date
        Dim dteStart As DateTime = Me.dtpStartingDate.Value
        ' Get the ending date
        Dim dteEnd As DateTime = Me.dtpEndDate.Value
        ' Make sure the first day of the period is Monday
        If dteStart.DayOfWeek <> DayOfWeek.Monday Then
            MsgBox("The starting date you selected in invalid\n" & _
                        "The time period should start on a Monday")
        End If
        Me.dtpStartingDate.Focus()
        ' Find the number of days that separate the start and end
        Dim timeDifference As TimeSpan = dteEnd.Subtract(dteStart)
        Dim fourteenDaysLater As Double = timeDifference.Days

If (dteEnd.DayOfWeek <> DayOfWeek.Sunday) Or (fourteenDaysLater <> 13) then 

            MsgBox("The ending date you selected in invalid\n" & _
            "The time period should span 2 weeks and end on a Sunday")
        End If
        Me.dtpEndDate.Focus()
    End Sub

    Private Sub btnProcessIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessIt.Click
        Dim monday1 As Double
        Dim tuesday1 As Double
        Dim wednesday1 As Double
        Dim thursday1 As Double
        Dim friday1 As Double
        Dim saturday1 As Double
        Dim sunday1 As Double

        Dim monday2 As Double
        Dim tuesday2 As Double
        Dim wednesday2 As Double
        Dim thursday2 As Double
        Dim friday2 As Double
        Dim saturday2 As Double
        Dim sunday2 As Double

        Dim totalHoursWeek1 As Double
        Dim totalHoursWeek2 As Double
        Dim regHours1 As Double
        Dim regHours2 As Double
        Dim ovtHours1 As Double
        Dim ovtHours2 As Double
        Dim regAmount1 As Double
        Dim regAmount2 As Double
        Dim ovtAmount1 As Double
        Dim ovtAmount2 As Double
        Dim regularHours As Double
        Dim overtimeHours As Double
        Dim regularAmount As Double
        Dim overtimeAmount As Double
        Dim totalEarnings As Double
        Dim hourlySalary As Double
        ' Retrieve the hourly salary
        hourlySalary = CDbl(Me.txtHourlySalary.Text)
        ' Retrieve the time for each day
        ' First Week
        monday1 = CDbl(Me.txtMonday1.Text)
        tuesday1 = CDbl(Me.txtTuesday1.Text)
        wednesday1 = CDbl(Me.txtWednesday1.Text)
        thursday1 = CDbl(Me.txtThursday1.Text)
        friday1 = CDbl(Me.txtFriday1.Text)
        saturday1 = CDbl(Me.txtSaturday1.Text)
        sunday1 = CDbl(Me.txtSunday1.Text)
        ' Second Week
        monday2 = CDbl(Me.txtMonday2.Text)
        tuesday2 = CDbl(Me.txtTuesday2.Text)
        wednesday2 = CDbl(Me.txtWednesday2.Text)
        thursday2 = CDbl(Me.txtThursday2.Text)
        friday2 = CDbl(Me.txtFriday2.Text)
        saturday2 = CDbl(Me.txtSaturday2.Text)
        sunday2 = CDbl(Me.txtSunday2.Text)
        ' Calculate the total number of hours for each week
        totalHoursWeek1 = monday1 + tuesday1 + wednesday1 + thursday1 + _
        friday1 + saturday1 + sunday1
        totalHoursWeek2 = monday2 + tuesday2 + wednesday2 + thursday2 + _
        friday2 + saturday2 + sunday2
        ' The overtime is paid time and half
        Dim ovtSalary As Double
        ovtSalary = hourlySalary * 1.5
        ' If the employee worked under 40 hours, there is no overtime
        If totalHoursWeek1 < 40 Then
            regHours1 = totalHoursWeek1
            regAmount1 = hourlySalary * regHours1
            ovtHours1 = 0
            ovtAmount1 = 0
            ' If the employee worked over 40 hours, calculate the overtime
        ElseIf totalHoursWeek1 >= 40 Then
            regHours1 = 40
            regAmount1 = hourlySalary * 40
            ovtHours1 = totalHoursWeek1 - 40
            ovtAmount1 = ovtHours1 * ovtSalary
        End If
        If totalHoursWeek2 < 40 Then
            regHours2 = totalHoursWeek2
            regAmount2 = hourlySalary * regHours2
            ovtHours2 = 0
            ovtAmount2 = 0
        ElseIf totalHoursWeek2 >= 40 Then
            regHours2 = 40
            regAmount2 = hourlySalary * 40
            ovtHours2 = totalHoursWeek2 - 40
            ovtAmount2 = ovtHours2 * ovtSalary
        End If
        regularHours = regHours1 + regHours2
        overtimeHours = ovtHours1 + ovtHours2
        regularAmount = regAmount1 + regAmount2
        overtimeAmount = ovtAmount1 + ovtAmount2

        totalEarnings = regularAmount + overtimeAmount
        Me.txtRegularHours.Text = regularHours.ToString("F")
        Me.txtOvertimeHours.Text = overtimeHours.ToString("F")
        Me.txtRegularAmount.Text = regularAmount.ToString("C")
        Me.txtOvertimeAmount.Text = overtimeAmount.ToString("C")
        Me.txtNetPay.Text = totalEarnings.ToString("C")
    End Sub
End Class
