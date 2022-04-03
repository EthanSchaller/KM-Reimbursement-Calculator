<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KM_Calc
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
        Me.Lst_KmTravelled = New System.Windows.Forms.ListBox()
        Me.Txt_Input = New System.Windows.Forms.TextBox()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Lbl_Instructions = New System.Windows.Forms.Label()
        Me.Btn_AddKM = New System.Windows.Forms.Button()
        Me.Btn_Calculate = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Lbl_Travelled = New System.Windows.Forms.Label()
        Me.Lbl_TravelledAns = New System.Windows.Forms.Label()
        Me.Lbl_Days = New System.Windows.Forms.Label()
        Me.Lbl_DaysAns = New System.Windows.Forms.Label()
        Me.Lbl_TtlCash = New System.Windows.Forms.Label()
        Me.Lbl_TtlCashAns = New System.Windows.Forms.Label()
        Me.Lbl_FRateKM = New System.Windows.Forms.Label()
        Me.Lbl_FRateKMAns = New System.Windows.Forms.Label()
        Me.Lbl_FRateDays = New System.Windows.Forms.Label()
        Me.Lbl_FRateDaysAns = New System.Windows.Forms.Label()
        Me.Lbl_TtlFRate = New System.Windows.Forms.Label()
        Me.Lbl_TtlFRateAns = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lst_KmTravelled
        '
        Me.Lst_KmTravelled.FormattingEnabled = True
        Me.Lst_KmTravelled.Location = New System.Drawing.Point(12, 60)
        Me.Lst_KmTravelled.Name = "Lst_KmTravelled"
        Me.Lst_KmTravelled.Size = New System.Drawing.Size(48, 316)
        Me.Lst_KmTravelled.TabIndex = 0
        '
        'Txt_Input
        '
        Me.Txt_Input.Location = New System.Drawing.Point(66, 60)
        Me.Txt_Input.Name = "Txt_Input"
        Me.Txt_Input.Size = New System.Drawing.Size(67, 20)
        Me.Txt_Input.TabIndex = 1
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Title.Font = New System.Drawing.Font("Agency FB", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl_Title.Location = New System.Drawing.Point(30, 2)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(272, 34)
        Me.Lbl_Title.TabIndex = 2
        Me.Lbl_Title.Text = "KM Reimbursement Calculator"
        '
        'Lbl_Instructions
        '
        Me.Lbl_Instructions.AutoSize = True
        Me.Lbl_Instructions.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Instructions.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Instructions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl_Instructions.Location = New System.Drawing.Point(14, 39)
        Me.Lbl_Instructions.Name = "Lbl_Instructions"
        Me.Lbl_Instructions.Size = New System.Drawing.Size(117, 20)
        Me.Lbl_Instructions.TabIndex = 3
        Me.Lbl_Instructions.Text = "Enter  the KMs Travelled"
        '
        'Btn_AddKM
        '
        Me.Btn_AddKM.BackColor = System.Drawing.Color.Lime
        Me.Btn_AddKM.Location = New System.Drawing.Point(66, 93)
        Me.Btn_AddKM.Name = "Btn_AddKM"
        Me.Btn_AddKM.Size = New System.Drawing.Size(67, 23)
        Me.Btn_AddKM.TabIndex = 4
        Me.Btn_AddKM.Text = "Add Km"
        Me.Btn_AddKM.UseVisualStyleBackColor = False
        '
        'Btn_Calculate
        '
        Me.Btn_Calculate.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Calculate.Location = New System.Drawing.Point(67, 131)
        Me.Btn_Calculate.Name = "Btn_Calculate"
        Me.Btn_Calculate.Size = New System.Drawing.Size(66, 23)
        Me.Btn_Calculate.TabIndex = 5
        Me.Btn_Calculate.Text = "Calculate"
        Me.Btn_Calculate.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.Red
        Me.Btn_Clear.Location = New System.Drawing.Point(67, 169)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(66, 23)
        Me.Btn_Clear.TabIndex = 6
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'Lbl_Travelled
        '
        Me.Lbl_Travelled.AutoSize = True
        Me.Lbl_Travelled.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Travelled.Font = New System.Drawing.Font("Agency FB", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Travelled.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_Travelled.Location = New System.Drawing.Point(66, 213)
        Me.Lbl_Travelled.Name = "Lbl_Travelled"
        Me.Lbl_Travelled.Size = New System.Drawing.Size(108, 17)
        Me.Lbl_Travelled.TabIndex = 7
        Me.Lbl_Travelled.Text = "Total KMs Travelled"
        '
        'Lbl_TravelledAns
        '
        Me.Lbl_TravelledAns.AutoSize = True
        Me.Lbl_TravelledAns.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TravelledAns.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TravelledAns.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_TravelledAns.Location = New System.Drawing.Point(71, 241)
        Me.Lbl_TravelledAns.Name = "Lbl_TravelledAns"
        Me.Lbl_TravelledAns.Size = New System.Drawing.Size(26, 17)
        Me.Lbl_TravelledAns.TabIndex = 8
        Me.Lbl_TravelledAns.Text = "- - -"
        '
        'Lbl_Days
        '
        Me.Lbl_Days.AutoSize = True
        Me.Lbl_Days.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Days.Font = New System.Drawing.Font("Agency FB", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Days.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_Days.Location = New System.Drawing.Point(66, 269)
        Me.Lbl_Days.Name = "Lbl_Days"
        Me.Lbl_Days.Size = New System.Drawing.Size(61, 17)
        Me.Lbl_Days.TabIndex = 9
        Me.Lbl_Days.Text = "Total Days"
        '
        'Lbl_DaysAns
        '
        Me.Lbl_DaysAns.AutoSize = True
        Me.Lbl_DaysAns.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DaysAns.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DaysAns.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_DaysAns.Location = New System.Drawing.Point(71, 299)
        Me.Lbl_DaysAns.Name = "Lbl_DaysAns"
        Me.Lbl_DaysAns.Size = New System.Drawing.Size(26, 17)
        Me.Lbl_DaysAns.TabIndex = 10
        Me.Lbl_DaysAns.Text = "- - -"
        '
        'Lbl_TtlCash
        '
        Me.Lbl_TtlCash.AutoSize = True
        Me.Lbl_TtlCash.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TtlCash.Font = New System.Drawing.Font("Agency FB", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TtlCash.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_TtlCash.Location = New System.Drawing.Point(66, 329)
        Me.Lbl_TtlCash.Name = "Lbl_TtlCash"
        Me.Lbl_TtlCash.Size = New System.Drawing.Size(132, 17)
        Me.Lbl_TtlCash.TabIndex = 11
        Me.Lbl_TtlCash.Text = "Total Reimbursement ($)"
        '
        'Lbl_TtlCashAns
        '
        Me.Lbl_TtlCashAns.AutoSize = True
        Me.Lbl_TtlCashAns.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TtlCashAns.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TtlCashAns.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_TtlCashAns.Location = New System.Drawing.Point(71, 357)
        Me.Lbl_TtlCashAns.Name = "Lbl_TtlCashAns"
        Me.Lbl_TtlCashAns.Size = New System.Drawing.Size(26, 17)
        Me.Lbl_TtlCashAns.TabIndex = 12
        Me.Lbl_TtlCashAns.Text = "- - -"
        '
        'Lbl_FRateKM
        '
        Me.Lbl_FRateKM.AutoSize = True
        Me.Lbl_FRateKM.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FRateKM.Font = New System.Drawing.Font("Agency FB", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FRateKM.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_FRateKM.Location = New System.Drawing.Point(201, 213)
        Me.Lbl_FRateKM.Name = "Lbl_FRateKM"
        Me.Lbl_FRateKM.Size = New System.Drawing.Size(99, 17)
        Me.Lbl_FRateKM.TabIndex = 13
        Me.Lbl_FRateKM.Text = "Total Flat Rate KMs"
        '
        'Lbl_FRateKMAns
        '
        Me.Lbl_FRateKMAns.AutoSize = True
        Me.Lbl_FRateKMAns.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FRateKMAns.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FRateKMAns.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_FRateKMAns.Location = New System.Drawing.Point(206, 241)
        Me.Lbl_FRateKMAns.Name = "Lbl_FRateKMAns"
        Me.Lbl_FRateKMAns.Size = New System.Drawing.Size(26, 17)
        Me.Lbl_FRateKMAns.TabIndex = 14
        Me.Lbl_FRateKMAns.Text = "- - -"
        '
        'Lbl_FRateDays
        '
        Me.Lbl_FRateDays.AutoSize = True
        Me.Lbl_FRateDays.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FRateDays.Font = New System.Drawing.Font("Agency FB", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FRateDays.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_FRateDays.Location = New System.Drawing.Point(201, 269)
        Me.Lbl_FRateDays.Name = "Lbl_FRateDays"
        Me.Lbl_FRateDays.Size = New System.Drawing.Size(104, 17)
        Me.Lbl_FRateDays.TabIndex = 15
        Me.Lbl_FRateDays.Text = "Total Flat Rate Days"
        '
        'Lbl_FRateDaysAns
        '
        Me.Lbl_FRateDaysAns.AutoSize = True
        Me.Lbl_FRateDaysAns.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FRateDaysAns.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FRateDaysAns.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_FRateDaysAns.Location = New System.Drawing.Point(206, 299)
        Me.Lbl_FRateDaysAns.Name = "Lbl_FRateDaysAns"
        Me.Lbl_FRateDaysAns.Size = New System.Drawing.Size(26, 17)
        Me.Lbl_FRateDaysAns.TabIndex = 16
        Me.Lbl_FRateDaysAns.Text = "- - -"
        '
        'Lbl_TtlFRate
        '
        Me.Lbl_TtlFRate.AutoSize = True
        Me.Lbl_TtlFRate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TtlFRate.Font = New System.Drawing.Font("Agency FB", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TtlFRate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_TtlFRate.Location = New System.Drawing.Point(201, 329)
        Me.Lbl_TtlFRate.Name = "Lbl_TtlFRate"
        Me.Lbl_TtlFRate.Size = New System.Drawing.Size(135, 17)
        Me.Lbl_TtlFRate.TabIndex = 17
        Me.Lbl_TtlFRate.Text = "Total Flat Rate Amount ($)"
        '
        'Lbl_TtlFRateAns
        '
        Me.Lbl_TtlFRateAns.AutoSize = True
        Me.Lbl_TtlFRateAns.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TtlFRateAns.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TtlFRateAns.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_TtlFRateAns.Location = New System.Drawing.Point(206, 357)
        Me.Lbl_TtlFRateAns.Name = "Lbl_TtlFRateAns"
        Me.Lbl_TtlFRateAns.Size = New System.Drawing.Size(26, 17)
        Me.Lbl_TtlFRateAns.TabIndex = 18
        Me.Lbl_TtlFRateAns.Text = "- - -"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Final_KM_Reimbursement.My.Resources.Resources.Calculator
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(159, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 153)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'KM_Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_KM_Reimbursement.My.Resources.Resources.Road
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(338, 389)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_TtlFRateAns)
        Me.Controls.Add(Me.Lbl_TtlFRate)
        Me.Controls.Add(Me.Lbl_FRateDaysAns)
        Me.Controls.Add(Me.Lbl_FRateDays)
        Me.Controls.Add(Me.Lbl_FRateKMAns)
        Me.Controls.Add(Me.Lbl_FRateKM)
        Me.Controls.Add(Me.Lbl_TtlCashAns)
        Me.Controls.Add(Me.Lbl_TtlCash)
        Me.Controls.Add(Me.Lbl_DaysAns)
        Me.Controls.Add(Me.Lbl_Days)
        Me.Controls.Add(Me.Lbl_TravelledAns)
        Me.Controls.Add(Me.Lbl_Travelled)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Calculate)
        Me.Controls.Add(Me.Btn_AddKM)
        Me.Controls.Add(Me.Lbl_Instructions)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.Txt_Input)
        Me.Controls.Add(Me.Lst_KmTravelled)
        Me.Name = "KM_Calc"
        Me.Tag = ""
        Me.Text = "KM Reimbursement Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lst_KmTravelled As ListBox
    Friend WithEvents Txt_Input As TextBox
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Lbl_Instructions As Label
    Friend WithEvents Btn_AddKM As Button
    Friend WithEvents Btn_Calculate As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Lbl_Travelled As Label
    Friend WithEvents Lbl_TravelledAns As Label
    Friend WithEvents Lbl_Days As Label
    Friend WithEvents Lbl_DaysAns As Label
    Friend WithEvents Lbl_TtlCash As Label
    Friend WithEvents Lbl_TtlCashAns As Label
    Friend WithEvents Lbl_FRateKM As Label
    Friend WithEvents Lbl_FRateKMAns As Label
    Friend WithEvents Lbl_FRateDays As Label
    Friend WithEvents Lbl_FRateDaysAns As Label
    Friend WithEvents Lbl_TtlFRate As Label
    Friend WithEvents Lbl_TtlFRateAns As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
