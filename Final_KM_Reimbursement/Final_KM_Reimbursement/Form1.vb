Public Class KM_Calc

    '-----------------------------------------------------------------------------
    'Program Info
    '-----------------------------------------------------------------------------
    'Program: Final_KM_Reimbursement
    'Date: 12/18/2020
    'Author: Ethan Schaller
    'Operation: This program calculates the amount thst is to be reimbursed to the
    '           workers who travel for deliveries, meetings, ect. It also will 
    '           factor in the flat rate of $150 if they travelled over 300km.
    '           
    '-----------------------------------------------------------------------------
    'Change Log
    '-----------------------------------------------------------------------------
    'Date       Programmer          Change
    '-----------------------------------------------------------------------------

    'Setting up the two constants that will be used in calculations
    Const dPerKM As Decimal = 0.55
    Const dFlatRate As Double = 150

    'Seting up the variables to be used later in the program
    Dim iValidityCase As Integer = -1
    Dim dKMTravel As Double = 0
    Dim iDayTtl As Integer = 0
    Dim dReimbursement As Decimal = 0
    Dim dFRateKMTravel As Double = 0
    Dim iFRateDayTtl As Integer = 0
    Dim iFRateTtl As Integer = 0

    'Checks the validity of the inputted data
    Function Validity() As Integer

        iValidityCase = -1

        If Txt_Input.Text = "" Then
            iValidityCase = 0

        ElseIf Not IsNumeric(Txt_Input.Text) Then
            iValidityCase = 1

        ElseIf Txt_Input.Text < 0 Then
            iValidityCase = 2

        End If

        Return iValidityCase
    End Function

    'checks which error occurred
    Function ErrorMsg() As String

        Dim arr_sError(2) As String
        arr_sError(0) = "Nothing was entered into the list"
        arr_sError(1) = "You did not enter a number "
        arr_sError(2) = "You entered a negative number"

        Return arr_sError(iValidityCase)
    End Function

    'Calculates the total KMs travelled by the employee
    Function TtlKM() As Double
        dKMTravel = 0

        For iCounter = 0 To Lst_KmTravelled.Items.Count() - 1

            dKMTravel += Lst_KmTravelled.Items(iCounter)

        Next

        Return dKMTravel
    End Function

    'Calculates the total days travelled
    Function TtlDays() As Integer

        iDayTtl = 0

        iDayTtl = Lst_KmTravelled.Items.Count()

        Return iDayTtl
    End Function

    'Calculates the total KMs travelled that fall under the Flat rate requirement
    Function TtlFrKMTravel() As Double

        dFRateKMTravel = 0

        For iCounter = 0 To Lst_KmTravelled.Items.Count() - 1
            If Lst_KmTravelled.Items(iCounter) >= 300 Then
                dFRateKMTravel += Lst_KmTravelled.Items(iCounter)
            End If
        Next

        Return dFRateKMTravel
    End Function

    'Calculates the total days that fall under the Flat rate requirement 
    Function TtlFrDays() As Integer

        iFRateDayTtl = 0

        For iCounter = 0 To Lst_KmTravelled.Items.Count() - 1
            If Lst_KmTravelled.Items(iCounter) >= 300 Then
                iFRateDayTtl += 1
            End If
        Next

        Return iFRateDayTtl
    End Function

    'Calculates the total reimbursement of the flat rate days
    Function TtlFrCash() As Decimal

        iFRateTtl = 0

        iFRateTtl = TtlFrDays() * dFlatRate

        Return iFRateTtl
    End Function

    'Calculates the total reimbursement of the non-flat rate hours
    Function TtlCash() As Decimal

        dReimbursement = 0

        For iCounter = 0 To Lst_KmTravelled.Items.Count() - 1
            If Lst_KmTravelled.Items(iCounter) < 300 Then
                dReimbursement += Lst_KmTravelled.Items(iCounter) * dPerKM
            End If
        Next

        dReimbursement += TtlFrCash()

        Return dReimbursement
    End Function

    'Checks validity and either adds the number to the list or outputs an error
    Private Sub Btn_AddKM_Click(sender As Object, e As EventArgs) Handles Btn_AddKM.Click

        If Validity() = -1 Then
            Lst_KmTravelled.Items.Add(Txt_Input.Text)
            Txt_Input.Focus()
            Txt_Input.Text = ""

        Else
            MsgBox(ErrorMsg())
            Txt_Input.Focus()
            Txt_Input.Text = ""

        End If

    End Sub

    'Calculates all the needed numbers and outputs them or it outputs an error
    Private Sub Btn_Calculate_Click(sender As Object, e As EventArgs) Handles Btn_Calculate.Click

        Lbl_TravelledAns.Text = TtlKM()
        Lbl_DaysAns.Text = TtlDays()
        Lbl_TtlCashAns.Text = TtlCash()
        Lbl_FRateKMAns.Text = TtlFrKMTravel()
        Lbl_FRateDaysAns.Text = TtlFrDays()
        Lbl_TtlFRateAns.Text = TtlFrCash()

    End Sub

    'Clears/resets all the variables
    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click

        Txt_Input.Text = ""
        Lst_KmTravelled.Items.Clear()
        Lbl_TravelledAns.Text = "- - -"
        Lbl_DaysAns.Text = "- - -"
        Lbl_FRateDaysAns.Text = "- - -"
        Lbl_FRateKMAns.Text = "- - -"
        Lbl_TtlCashAns.Text = "- - -"
        Lbl_TtlFRateAns.Text = "- - -"
        iValidityCase = -1
        dKMTravel = 0
        iDayTtl = 0
        dFRateKMTravel = 0
        iFRateDayTtl = 0
        iFRateTtl = 0
        dReimbursement = 0

    End Sub

End Class
