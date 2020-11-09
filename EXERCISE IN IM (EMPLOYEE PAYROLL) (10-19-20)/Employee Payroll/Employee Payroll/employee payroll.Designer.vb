<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHourlySalary = New System.Windows.Forms.TextBox()
        Me.txtEmployeeNbr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSunday2 = New System.Windows.Forms.TextBox()
        Me.txtSaturday2 = New System.Windows.Forms.TextBox()
        Me.txtFriday2 = New System.Windows.Forms.TextBox()
        Me.txtThursday2 = New System.Windows.Forms.TextBox()
        Me.txtWednesday2 = New System.Windows.Forms.TextBox()
        Me.txtTuesday2 = New System.Windows.Forms.TextBox()
        Me.txtMonday2 = New System.Windows.Forms.TextBox()
        Me.txtSunday1 = New System.Windows.Forms.TextBox()
        Me.txtSaturday1 = New System.Windows.Forms.TextBox()
        Me.txtFriday1 = New System.Windows.Forms.TextBox()
        Me.txtThursday1 = New System.Windows.Forms.TextBox()
        Me.txtWednesday1 = New System.Windows.Forms.TextBox()
        Me.txtTuesday1 = New System.Windows.Forms.TextBox()
        Me.txtMonday1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtOvertimeAmount = New System.Windows.Forms.TextBox()
        Me.txtOvertimeHours = New System.Windows.Forms.TextBox()
        Me.txtRegularAmount = New System.Windows.Forms.TextBox()
        Me.txtRegularHours = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnProcessIt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHourlySalary)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeNbr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Identification"
        '
        'txtHourlySalary
        '
        Me.txtHourlySalary.Location = New System.Drawing.Point(91, 70)
        Me.txtHourlySalary.Name = "txtHourlySalary"
        Me.txtHourlySalary.Size = New System.Drawing.Size(100, 20)
        Me.txtHourlySalary.TabIndex = 3
        '
        'txtEmployeeNbr
        '
        Me.txtEmployeeNbr.Location = New System.Drawing.Point(91, 30)
        Me.txtEmployeeNbr.Name = "txtEmployeeNbr"
        Me.txtEmployeeNbr.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeNbr.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hourly Salary "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpEndDate)
        Me.GroupBox2.Controls.Add(Me.dtpStartingDate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(256, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Period"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(104, 67)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 3
        '
        'dtpStartingDate
        '
        Me.dtpStartingDate.Location = New System.Drawing.Point(104, 24)
        Me.dtpStartingDate.Name = "dtpStartingDate"
        Me.dtpStartingDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStartingDate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Starting Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSunday2)
        Me.GroupBox3.Controls.Add(Me.txtSaturday2)
        Me.GroupBox3.Controls.Add(Me.txtFriday2)
        Me.GroupBox3.Controls.Add(Me.txtThursday2)
        Me.GroupBox3.Controls.Add(Me.txtWednesday2)
        Me.GroupBox3.Controls.Add(Me.txtTuesday2)
        Me.GroupBox3.Controls.Add(Me.txtMonday2)
        Me.GroupBox3.Controls.Add(Me.txtSunday1)
        Me.GroupBox3.Controls.Add(Me.txtSaturday1)
        Me.GroupBox3.Controls.Add(Me.txtFriday1)
        Me.GroupBox3.Controls.Add(Me.txtThursday1)
        Me.GroupBox3.Controls.Add(Me.txtWednesday1)
        Me.GroupBox3.Controls.Add(Me.txtTuesday1)
        Me.GroupBox3.Controls.Add(Me.txtMonday1)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(618, 123)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Time Sheet"
        '
        'txtSunday2
        '
        Me.txtSunday2.Location = New System.Drawing.Point(552, 80)
        Me.txtSunday2.Name = "txtSunday2"
        Me.txtSunday2.Size = New System.Drawing.Size(46, 20)
        Me.txtSunday2.TabIndex = 23
        Me.txtSunday2.Text = "0.00"
        Me.txtSunday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaturday2
        '
        Me.txtSaturday2.Location = New System.Drawing.Point(479, 80)
        Me.txtSaturday2.Name = "txtSaturday2"
        Me.txtSaturday2.Size = New System.Drawing.Size(46, 20)
        Me.txtSaturday2.TabIndex = 22
        Me.txtSaturday2.Text = "0.00"
        Me.txtSaturday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFriday2
        '
        Me.txtFriday2.Location = New System.Drawing.Point(405, 80)
        Me.txtFriday2.Name = "txtFriday2"
        Me.txtFriday2.Size = New System.Drawing.Size(46, 20)
        Me.txtFriday2.TabIndex = 21
        Me.txtFriday2.Text = "0.00"
        Me.txtFriday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtThursday2
        '
        Me.txtThursday2.Location = New System.Drawing.Point(339, 80)
        Me.txtThursday2.Name = "txtThursday2"
        Me.txtThursday2.Size = New System.Drawing.Size(46, 20)
        Me.txtThursday2.TabIndex = 20
        Me.txtThursday2.Text = "0.00"
        Me.txtThursday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWednesday2
        '
        Me.txtWednesday2.Location = New System.Drawing.Point(270, 80)
        Me.txtWednesday2.Name = "txtWednesday2"
        Me.txtWednesday2.Size = New System.Drawing.Size(46, 20)
        Me.txtWednesday2.TabIndex = 19
        Me.txtWednesday2.Text = "0.00"
        Me.txtWednesday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTuesday2
        '
        Me.txtTuesday2.Location = New System.Drawing.Point(187, 83)
        Me.txtTuesday2.Name = "txtTuesday2"
        Me.txtTuesday2.Size = New System.Drawing.Size(46, 20)
        Me.txtTuesday2.TabIndex = 18
        Me.txtTuesday2.Text = "0.00"
        Me.txtTuesday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonday2
        '
        Me.txtMonday2.Location = New System.Drawing.Point(110, 80)
        Me.txtMonday2.Name = "txtMonday2"
        Me.txtMonday2.Size = New System.Drawing.Size(46, 20)
        Me.txtMonday2.TabIndex = 17
        Me.txtMonday2.Text = "0.00"
        Me.txtMonday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSunday1
        '
        Me.txtSunday1.Location = New System.Drawing.Point(552, 37)
        Me.txtSunday1.Name = "txtSunday1"
        Me.txtSunday1.Size = New System.Drawing.Size(46, 20)
        Me.txtSunday1.TabIndex = 16
        Me.txtSunday1.Text = "0.00"
        Me.txtSunday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaturday1
        '
        Me.txtSaturday1.Location = New System.Drawing.Point(479, 37)
        Me.txtSaturday1.Name = "txtSaturday1"
        Me.txtSaturday1.Size = New System.Drawing.Size(46, 20)
        Me.txtSaturday1.TabIndex = 15
        Me.txtSaturday1.Text = "0.00"
        Me.txtSaturday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFriday1
        '
        Me.txtFriday1.Location = New System.Drawing.Point(405, 37)
        Me.txtFriday1.Name = "txtFriday1"
        Me.txtFriday1.Size = New System.Drawing.Size(46, 20)
        Me.txtFriday1.TabIndex = 14
        Me.txtFriday1.Text = "0.00"
        Me.txtFriday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtThursday1
        '
        Me.txtThursday1.Location = New System.Drawing.Point(339, 37)
        Me.txtThursday1.Name = "txtThursday1"
        Me.txtThursday1.Size = New System.Drawing.Size(46, 20)
        Me.txtThursday1.TabIndex = 13
        Me.txtThursday1.Text = "0.00"
        Me.txtThursday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWednesday1
        '
        Me.txtWednesday1.Location = New System.Drawing.Point(270, 37)
        Me.txtWednesday1.Name = "txtWednesday1"
        Me.txtWednesday1.Size = New System.Drawing.Size(46, 20)
        Me.txtWednesday1.TabIndex = 12
        Me.txtWednesday1.Text = "0.00"
        Me.txtWednesday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTuesday1
        '
        Me.txtTuesday1.Location = New System.Drawing.Point(187, 37)
        Me.txtTuesday1.Name = "txtTuesday1"
        Me.txtTuesday1.Size = New System.Drawing.Size(46, 20)
        Me.txtTuesday1.TabIndex = 11
        Me.txtTuesday1.Text = "0.00"
        Me.txtTuesday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonday1
        '
        Me.txtMonday1.Location = New System.Drawing.Point(110, 37)
        Me.txtMonday1.Name = "txtMonday1"
        Me.txtMonday1.Size = New System.Drawing.Size(46, 20)
        Me.txtMonday1.TabIndex = 10
        Me.txtMonday1.Text = "0.00"
        Me.txtMonday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(336, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Thursday "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(552, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Sunday "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(476, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Saturday "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(416, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Friday"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(317, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(252, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Wednesday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Tuesday"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Monday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Second Week"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "First Week"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClose)
        Me.GroupBox4.Controls.Add(Me.txtNetPay)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtOvertimeAmount)
        Me.GroupBox4.Controls.Add(Me.txtOvertimeHours)
        Me.GroupBox4.Controls.Add(Me.txtRegularAmount)
        Me.GroupBox4.Controls.Add(Me.txtRegularHours)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.btnProcessIt)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 270)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(618, 127)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payroll Processing"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(419, 87)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 23)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtNetPay
        '
        Me.txtNetPay.Location = New System.Drawing.Point(500, 57)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(83, 20)
        Me.txtNetPay.TabIndex = 29
        Me.txtNetPay.Text = "0.00"
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(407, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Total Earnings : "
        '
        'txtOvertimeAmount
        '
        Me.txtOvertimeAmount.Location = New System.Drawing.Point(329, 75)
        Me.txtOvertimeAmount.Name = "txtOvertimeAmount"
        Me.txtOvertimeAmount.Size = New System.Drawing.Size(61, 20)
        Me.txtOvertimeAmount.TabIndex = 27
        Me.txtOvertimeAmount.Text = "0.00"
        Me.txtOvertimeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOvertimeHours
        '
        Me.txtOvertimeHours.Location = New System.Drawing.Point(255, 75)
        Me.txtOvertimeHours.Name = "txtOvertimeHours"
        Me.txtOvertimeHours.Size = New System.Drawing.Size(46, 20)
        Me.txtOvertimeHours.TabIndex = 26
        Me.txtOvertimeHours.Text = "0.00"
        Me.txtOvertimeHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegularAmount
        '
        Me.txtRegularAmount.Location = New System.Drawing.Point(329, 38)
        Me.txtRegularAmount.Name = "txtRegularAmount"
        Me.txtRegularAmount.Size = New System.Drawing.Size(61, 20)
        Me.txtRegularAmount.TabIndex = 25
        Me.txtRegularAmount.Text = "0.00"
        Me.txtRegularAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegularHours
        '
        Me.txtRegularHours.Location = New System.Drawing.Point(255, 41)
        Me.txtRegularHours.Name = "txtRegularHours"
        Me.txtRegularHours.Size = New System.Drawing.Size(46, 20)
        Me.txtRegularHours.TabIndex = 24
        Me.txtRegularHours.Text = "0.00"
        Me.txtRegularHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(326, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Amount"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(259, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Hours"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(185, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Overtime"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(184, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Regular"
        '
        'btnProcessIt
        '
        Me.btnProcessIt.Location = New System.Drawing.Point(15, 41)
        Me.btnProcessIt.Name = "btnProcessIt"
        Me.btnProcessIt.Size = New System.Drawing.Size(122, 50)
        Me.btnProcessIt.TabIndex = 0
        Me.btnProcessIt.Text = "Process It "
        Me.btnProcessIt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 424)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Georgetown Cleaning Services - Employee Payroll"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHourlySalary As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeNbr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMonday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSunday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSaturday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFriday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtThursday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtWednesday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTuesday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMonday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSunday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSaturday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFriday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtThursday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtWednesday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTuesday2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRegularHours As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnProcessIt As System.Windows.Forms.Button
    Friend WithEvents txtRegularAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtOvertimeAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtOvertimeHours As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label

End Class
