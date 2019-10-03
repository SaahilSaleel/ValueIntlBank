Public Class CustomerModule
    Dim MousePressedDown As Boolean
    Dim lastLocation As Point
    Dim Cusid As String
    Dim Accno As String
    Dim cusdetails As Dictionary(Of String, String)
    Dim AddCus As Integer = 0
    Dim AddAcc As Integer = 0
    Private Sub EmpCusModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Color.Magenta
        DepositTotal()
        WithdrawTotal()
        ProgressCard.Hide()
        MenuCard.Hide()
        Step4_btn.Hide()
        AccTypeDropdown.Hide()
        AccTypeCreate_Btn.Hide()
        AddAccDropdown.Hide()
        CreateAcc_Btn.Hide()
        InitialDeposit_btn.Hide()
    End Sub

    Private Sub LockStatus(ByVal status As String)
        If status = "Lock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Lock.png")
        ElseIf status = "Unlock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Unlock.png")
        End If
    End Sub

    Private Sub BalanceUpdate()
        Balance_lbl.Text = "Bal:-" + GetSingleField("Balance", "bankacc", "accno", Accno)
    End Sub

#Region "Dragging Function"
    Private Sub LoginGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles LoginGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub LoginGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles LoginGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub LoginGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles LogInGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub HomeGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles HomeGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub HomeGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles HomeGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub HomeGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles HomeGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub AddCusGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles AddCusGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub AddCusGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles AddCusGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub AddCusGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles AddCusGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub DepositGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles DepositGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub DepositGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles DepositGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub DepositGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles DepositGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub WithdrawGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles WithdrawGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub WithdrawGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles WithdrawGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub WithdrawGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles WithdrawGradientPanel.MouseUp
        MousePressedDown = False
    End Sub
#End Region

#Region "Menu Card"
    Private Sub MenuDeselectAll()
        DepositSelect.selected = False
        WithdrawSelect.selected = False
        EditDetailsSelect.selected = False
        AddAccSelect.selected = False
    End Sub
    Private Sub AccnoDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccnoDropdown.SelectedIndexChanged
        Accno = AccnoDropdown.SelectedItem
        BalanceUpdate()
    End Sub
    Private Sub DepositSelect_Click(sender As Object, e As EventArgs) Handles DepositSelect.Click
        HomePage.SelectedTab() = DepositTab
        MenuDeselectAll()
        DepositSelect.selected = True
        DepositResetFields()
    End Sub

    Private Sub WithdrawSelect_Click(sender As Object, e As EventArgs) Handles WithdrawSelect.Click
        HomePage.SelectedTab = WithdrawTab
        MenuDeselectAll()
        WithdrawSelect.selected = True
        WithdrawResetFields()
    End Sub
    Private Sub LogOut_Btn_Click(sender As Object, e As EventArgs) Handles LogOut_Btn.Click
        LockStatus("Lock")
        PasswordTextBox.Text = ""
        MainPage.SelectedTab() = LoginTab
        AccnoDropdown.Items.Clear()
        Wait(1)
        MenuCard.Hide()
    End Sub
    Private Sub EditDetailsSelect_Click(sender As Object, e As EventArgs) Handles EditDetailsSelect.Click
        HomePage.SelectedTab = EditDetailsTab
        MenuDeselectAll()
        EditDetailsSelect.selected = True
    End Sub

    Private Sub AddAccSelect_Click(sender As Object, e As EventArgs) Handles AddAccSelect.Click
        MenuDeselectAll()
        AddAccSelect.selected = True
        AccTypeDropdown.Show()
        AccTypeCreate_Btn.Show()
    End Sub

    Private Sub AccTypeCreate_Btn_Click(sender As Object, e As EventArgs) Handles AccTypeCreate_Btn.Click
        Dim arr(7) As String
        arr(0) = GetID(8, "bankacc", "Accno")
        arr(1) = cusdetails("First_Name")
        arr(2) = cusdetails("Mid_Name")
        arr(3) = cusdetails("Last_Name")
        arr(4) = Cusid
        arr(5) = AccTypeDropdown.SelectedItem
        arr(6) = "0"
        arr(7) = CurDate()
        If InsertSingleRow(arr, "bankacc") = 1 Then
            MessageBox.Show("Your " + arr(5) + " account has been created succesfully")
            AccType_lbl.Text = "Acc:- " + arr(0)
            AccTypeDropdown.Text = arr(0)
            InitialDeposit_btn.Show()
            Accno = arr(0)
            HomePage.SelectedTab = DepositTab
            AddAcc = 1
        End If
    End Sub

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Dim Form As New CustomerModule
        Form.Close()
    End Sub
#End Region

#Region "Deposit"
    Private Sub Deposit2000_Btn_Click(sender As Object, e As EventArgs) Handles Deposit2000_Btn.Click
        Dim i As Integer = Deposit2000_Txt.Text
        i += 1
        Deposit2000_Txt.Text = i
    End Sub

    Private Sub Deposit500_Btn_Click(sender As Object, e As EventArgs) Handles Deposit500_Btn.Click
        Dim i As Integer = Deposit500_Txt.Text
        i += 1
        Deposit500_Txt.Text = i
    End Sub

    Private Sub Deposit200_Btn_Click(sender As Object, e As EventArgs) Handles Deposit200_Btn.Click
        Dim i As Integer = Deposit200_Txt.Text
        i += 1
        Deposit200_Txt.Text = i
    End Sub

    Private Sub Deposit100_Btn_Click(sender As Object, e As EventArgs) Handles Deposit100_Btn.Click
        Dim i As Integer = Deposit100_Txt.Text
        i += 1
        Deposit100_Txt.Text = i
    End Sub

    Private Sub Deposit50_Btn_Click(sender As Object, e As EventArgs) Handles Deposit50_Btn.Click
        Dim i As Integer = Deposit50_Txt.Text
        i += 1
        Deposit50_Txt.Text = i
    End Sub

    Private Sub Deposit20_Btn_Click(sender As Object, e As EventArgs) Handles Deposit20_Btn.Click
        Dim i As Integer = Deposit20_Txt.Text
        i += 1
        Deposit20_Txt.Text = i
    End Sub

    Private Sub Deposit10_Btn_Click(sender As Object, e As EventArgs) Handles Deposit10_Btn.Click
        Dim i As Integer = Deposit10_Txt.Text
        i += 1
        Deposit10_Txt.Text = i
    End Sub

    Private Sub Deposit5_Btn_Click(sender As Object, e As EventArgs) Handles Deposit5_Btn.Click
        Dim i As Integer = Deposit5_Txt.Text
        i += 1
        Deposit5_Txt.Text = i
    End Sub

    Private Sub Deposit2_Btn_Click(sender As Object, e As EventArgs) Handles Deposit2_Btn.Click
        Dim i As Integer = Deposit2_Txt.Text
        i += 1
        Deposit2_Txt.Text = i
    End Sub

    Private Sub Deposit1_Btn_Click(sender As Object, e As EventArgs) Handles Deposit1_Btn.Click
        Dim i As Integer = Deposit1_Txt.Text
        i += 1
        Deposit1_Txt.Text = i
    End Sub
    Dim DepositTotalInr As Integer
    Private Sub DepositTotal()
        If Deposit2000_Txt.Text IsNot "" And Deposit500_Txt.Text IsNot "" And Deposit200_Txt.Text IsNot "" And Deposit100_Txt.Text IsNot "" And Deposit50_Txt.Text IsNot "" And Deposit1_Txt.Text IsNot "" And Deposit2_Txt.Text IsNot "" And Deposit5_Txt.Text IsNot "" And Deposit10_Txt.Text IsNot "" And Deposit20_Txt.Text IsNot "" Then
            Dim inr2000 As Integer = Deposit2000_Txt.Text * 2000
            Dim inr500 As Integer = Deposit500_Txt.Text * 500
            Dim inr200 As Integer = Deposit200_Txt.Text * 200
            Dim inr100 As Integer = Deposit100_Txt.Text * 100
            Dim inr50 As Integer = Deposit50_Txt.Text * 50
            Dim inr20 As Integer = Deposit20_Txt.Text * 20
            Dim inr10 As Integer = Deposit10_Txt.Text * 10
            Dim inr5 As Integer = Deposit5_Txt.Text * 5
            Dim inr2 As Integer = Deposit2_Txt.Text * 2
            Dim inr1 As Integer = Deposit1_Txt.Text * 1
            DepositTotalInr = inr2000 + inr500 + inr200 + inr100 + inr50 + inr20 + inr10 + inr5 + inr2 + inr1
            DepositTotal_lbl.Text = DepositTotalInr & " Rs"
        End If
    End Sub

    Sub DepositResetFields()
        Deposit2000_Txt.Text = "0"
        Deposit500_Txt.Text = "0"
        Deposit200_Txt.Text = "0"
        Deposit100_Txt.Text = "0"
        Deposit50_Txt.Text = "0"
        Deposit1_Txt.Text = "0"
        Deposit2_Txt.Text = "0"
        Deposit5_Txt.Text = "0"
        Deposit10_Txt.Text = "0"
        Deposit20_Txt.Text = "0"
    End Sub

    Private Sub Deposit_Btn_Click(sender As Object, e As EventArgs) Handles Deposit_Btn.Click
        Dim arr(7) As String
        arr(0) = GetID(8, "receipts", "Trans_ID")
        arr(1) = DepositTotalInr
        arr(2) = "Deposit"
        arr(3) = ""
        arr(4) = ""
        arr(5) = Cusid
        arr(6) = Accno
        arr(7) = CurDateTime()
        If Deposit(Accno, DepositTotalInr) = 1 Then
            If Receipt(arr) = 1 Then
                DepositResetFields()
                BalanceUpdate()

                If AddCus = 1 Then
                    Step3_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
                    Step4_btn.Show()
                    AddAccDropdown.Hide()
                    CreateAcc_Btn.Hide()
                    InitialDeposit_btn.Hide()
                    AddAcc_lbl.Text = ""
                    AddCus_lbl.Text = ""
                    AddCus = 0
                ElseIf AddAcc = 1 Then
                    AccTypeCreate_Btn.Hide()
                    AccTypeDropdown.Hide()
                    AccType_lbl.Text = ""
                    AddAcc = 0
                End If
            End If
        End If
    End Sub

    Private Sub Deposit2000_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit2000_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit500_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit500_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit200_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit200_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit100_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit100_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit50_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit50_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit20_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit20_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit10_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit10_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit5_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit5_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit2_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit2_Txt.TextChanged
        DepositTotal()
    End Sub

    Private Sub Deposit1_Txt_TextChanged(sender As Object, e As EventArgs) Handles Deposit1_Txt.TextChanged
        DepositTotal()
    End Sub
#End Region

#Region "Withdraw"
    Private Sub Withdraw2000_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw2000_Btn.Click
        Dim i As Integer = Withdraw2000_Txt.Text
        i += 1
        Withdraw2000_Txt.Text = i
    End Sub

    Private Sub Withdraw500_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw500_Btn.Click
        Dim i As Integer = Withdraw500_Txt.Text
        i += 1
        Withdraw500_Txt.Text = i
    End Sub

    Private Sub Withdraw200_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw200_Btn.Click
        Dim i As Integer = Withdraw200_Txt.Text
        i += 1
        Withdraw200_Txt.Text = i
    End Sub

    Private Sub Withdraw100_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw100_Btn.Click
        Dim i As Integer = Withdraw100_Txt.Text
        i += 1
        Withdraw100_Txt.Text = i
    End Sub

    Private Sub Withdraw50_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw50_Btn.Click
        Dim i As Integer = Withdraw50_Txt.Text
        i += 1
        Withdraw50_Txt.Text = i
    End Sub

    Private Sub Withdraw20_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw20_Btn.Click
        Dim i As Integer = Withdraw20_Txt.Text
        i += 1
        Withdraw20_Txt.Text = i
    End Sub

    Private Sub Withdraw10_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw10_Btn.Click
        Dim i As Integer = Withdraw10_Txt.Text
        i += 1
        Withdraw10_Txt.Text = i
    End Sub

    Private Sub Withdraw5_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw5_Btn.Click
        Dim i As Integer = Withdraw5_Txt.Text
        i += 1
        Withdraw5_Txt.Text = i
    End Sub

    Private Sub Withdraw2_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw2_Btn.Click
        Dim i As Integer = Withdraw2_Txt.Text
        i += 1
        Withdraw2_Txt.Text = i
    End Sub

    Private Sub Withdraw1_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw1_Btn.Click
        Dim i As Integer = Withdraw1_Txt.Text
        i += 1
        Withdraw1_Txt.Text = i
    End Sub
    Dim WithdrawTotalInr As Integer
    Private Sub WithdrawTotal()
        If Withdraw2000_Txt.Text IsNot "" And Withdraw500_Txt.Text IsNot "" And Withdraw200_Txt.Text IsNot "" And Withdraw100_Txt.Text IsNot "" And Withdraw50_Txt.Text IsNot "" And Withdraw1_Txt.Text IsNot "" And Withdraw2_Txt.Text IsNot "" And Withdraw5_Txt.Text IsNot "" And Withdraw10_Txt.Text IsNot "" And Withdraw20_Txt.Text IsNot "" Then
            Dim inr2000 As Integer = Withdraw2000_Txt.Text * 2000
            Dim inr500 As Integer = Withdraw500_Txt.Text * 500
            Dim inr200 As Integer = Withdraw200_Txt.Text * 200
            Dim inr100 As Integer = Withdraw100_Txt.Text * 100
            Dim inr50 As Integer = Withdraw50_Txt.Text * 50
            Dim inr20 As Integer = Withdraw20_Txt.Text * 20
            Dim inr10 As Integer = Withdraw10_Txt.Text * 10
            Dim inr5 As Integer = Withdraw5_Txt.Text * 5
            Dim inr2 As Integer = Withdraw2_Txt.Text * 2
            Dim inr1 As Integer = Withdraw1_Txt.Text * 1
            WithdrawTotalInr = inr2000 + inr500 + inr200 + inr100 + inr50 + inr20 + inr10 + inr5 + inr2 + inr1
            WithdrawTotal_lbl.Text = WithdrawTotalInr & " Rs"
        End If
    End Sub

    Sub WithdrawResetFields()
        Withdraw2000_Txt.Text = "0"
        Withdraw500_Txt.Text = "0"
        Withdraw200_Txt.Text = "0"
        Withdraw100_Txt.Text = "0"
        Withdraw50_Txt.Text = "0"
        Withdraw1_Txt.Text = "0"
        Withdraw2_Txt.Text = "0"
        Withdraw5_Txt.Text = "0"
        Withdraw10_Txt.Text = "0"
        Withdraw20_Txt.Text = "0"
    End Sub

    Private Sub Withdraw_Btn_Click(sender As Object, e As EventArgs) Handles Withdraw_Btn.Click
        Dim arr(7) As String
        arr(0) = GetID(8, "receipts", "Trans_ID")
        arr(1) = WithdrawTotalInr
        arr(2) = "Withdraw"
        arr(3) = Cusid
        arr(4) = Accno
        arr(5) = ""
        arr(6) = ""
        arr(7) = CurDateTime()
        If Withdraw(Accno, WithdrawTotalInr) = 1 Then
            If Receipt(arr) = 1 Then
                WithdrawResetFields()
                BalanceUpdate()
            End If
        End If
    End Sub

    Private Sub Withdraw2000_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw2000_Txt.TextChanged
        WithdrawTotal()
        If Withdraw2000_Txt.Text < 0 Then
            Withdraw2000_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw500_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw500_Txt.TextChanged
        WithdrawTotal()
        If Withdraw500_Txt.Text < 0 Then
            Withdraw500_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw200_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw200_Txt.TextChanged
        WithdrawTotal()
        If Withdraw200_Txt.Text < 0 Then
            Withdraw200_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw100_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw100_Txt.TextChanged
        WithdrawTotal()
        If Withdraw100_Txt.Text < 0 Then
            Withdraw100_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw50_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw50_Txt.TextChanged
        WithdrawTotal()
        If Withdraw50_Txt.Text < 0 Then
            Withdraw50_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw20_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw20_Txt.TextChanged
        WithdrawTotal()
        If Withdraw20_Txt.Text < 0 Then
            Withdraw20_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw10_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw10_Txt.TextChanged
        WithdrawTotal()
        If Withdraw10_Txt.Text < 0 Then
            Withdraw10_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw5_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw5_Txt.TextChanged
        WithdrawTotal()
        If Withdraw5_Txt.Text < 0 Then
            Withdraw5_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw2_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw2_Txt.TextChanged
        WithdrawTotal()
        If Withdraw2_Txt.Text < 0 Then
            Withdraw2_Txt.Text = 0
        End If
    End Sub

    Private Sub Withdraw1_Txt_TextChanged(sender As Object, e As EventArgs) Handles Withdraw1_Txt.TextChanged
        WithdrawTotal()
        If Withdraw1_Txt.Text < 0 Then
            Withdraw1_Txt.Text = 0
        End If
    End Sub

    Private Sub WithdrawCal_txt_TextChanged(sender As Object, e As EventArgs) Handles WithdrawCal_txt.TextChanged

        Dim amt As Integer
        If Int32.TryParse(WithdrawCal_txt.Text, amt) = True And amt > -1 Then
            WithdrawResetFields()
            ToolTip.Hide(WithdrawCal_txt)
            Dim num As Integer
            num = Math.Floor(amt / 2000) - 1
            If num <= 0 Then
                num = 0
            End If
            Withdraw2000_Txt.Text = num

            amt -= (num * 2000)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 500) - 1
            If num <= 0 Then
                num = 0
            End If
            Withdraw500_Txt.Text = num

            amt -= (num * 500)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 200)
            Withdraw200_Txt.Text = num

            amt -= (num * 200)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 100)
            Withdraw100_Txt.Text = num

            amt -= (num * 100)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 50)
            Withdraw50_Txt.Text = num

            amt -= (num * 50)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 20)
            Withdraw20_Txt.Text = num

            amt -= (num * 20)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 10)
            Withdraw10_Txt.Text = num

            amt -= (num * 10)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 5)
            Withdraw5_Txt.Text = num

            amt -= (num * 5)
            If amt <= 0 Then
                Exit Sub
            End If
            num = Math.Floor(amt / 2)
            Withdraw2_Txt.Text = num

            amt -= (num * 2)
            If amt <= 0 Then
                Exit Sub
            End If
            Withdraw1_Txt.Text = amt
        Else
            ToolTip.Show("Enter a positive Integer Value", WithdrawCal_txt)
        End If
    End Sub

#End Region

#Region "Login Page"
    Private Sub Register_Btn_Click(sender As Object, e As EventArgs) Handles Register_Btn.Click
        Dim StateList As String() = GetSingleCol("Name", "States")
        Me.StateDropdown.Items.AddRange(StateList)
        Me.StateDropdown.SelectedIndex = 0

        Dim CityList As String() = GetSingleCol("city", "city_state", "state", StateDropdown.SelectedItem)
        Me.CityDropdown.Items.AddRange(CityList)
        Me.CityDropdown.SelectedIndex = 0

        Dim BranchList As String() = GetSingleCol("branchno", "banklist")
        Me.BranchDropdown.Items.AddRange(BranchList)
        Me.BranchDropdown.SelectedIndex = 0

        HomePage.SelectedTab = AddCusTab
        ProgressCard.Show()
        Step1_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Indeterminate
        Step2_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Step3_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Step4_btn.Enabled = False
        MainPage.SelectedTab() = HomeTab
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        If LogIn(UsernameTextBox.Text, PasswordTextBox.Text, "cus") = 1 Then
            ToolTip.Hide(UsernameTextBox)
            HomePage.SelectedTab = SelectionTab
            Cusid = UsernameTextBox.Text
            Dim AccList As String() = GetSingleCol("Accno", "bankacc", "Cus_ID", Cusid)
            Me.AccnoDropdown.Items.AddRange(AccList)
            Me.AccnoDropdown.SelectedIndex = 0
            Accno = AccnoDropdown.SelectedItem
            MenuCard.Show()
            cusdetails = GetSingleRowDict("cusdetails", "Cus_ID", Cusid)
            LockStatus("Unlock")
            MainPage.SelectedTab() = HomeTab()
            cusdetails = GetSingleRowDict("cusdetails", "Cus_Id", Cusid)
        Else
            ToolTip.Show("Username and Password does not match", UsernameTextBox)
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            LogInButton.Focus()
        End If
    End Sub



#End Region

#Region "Add Cus"
    Private Sub Step4_btn_Click(sender As Object, e As EventArgs) Handles Step4_btn.Click
        MainPage.SelectedTab() = LoginTab
        Wait(2)
        ProgressCard.Hide()
        Me.CityDropdown.Items.Clear()
        Me.StateDropdown.Items.Clear()
        Me.BranchDropdown.Items.Clear()
    End Sub

    Private Sub StateDropdown_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.CityDropdown.Items.Clear()
        Dim CityList As String() = GetSingleCol("city", "city_state", "state", StateDropdown.SelectedItem)
        Me.CityDropdown.Items.AddRange(CityList)
        Me.CityDropdown.SelectedIndex = 0
    End Sub


    Private Sub AddCus_btn_Click(sender As Object, e As EventArgs) Handles AddCus_btn.Click
        Dim arr(12) As String
        arr(0) = GetID(8, "cusdetails", "Cus_ID")
        arr(1) = InputBox("Please Enter a Password")
        arr(2) = Accno_txt.Text
        arr(3) = MName_txt.Text
        arr(4) = Name_txt.Text
        arr(5) = CityDropdown.SelectedItem
        arr(6) = StateDropdown.SelectedItem
        arr(7) = Address_txt.Text
        arr(8) = IFSC_txt.Text
        arr(9) = Nickname_txt.Text
        arr(10) = DOB_DatePicker.Value.ToString("yyyy-MM-dd")
        arr(11) = GetChar(GetGroupBoxCheckedButton(SexGroupBox).Name, 1)
        arr(12) = BranchDropdown.SelectedItem

        If InsertSingleRow(arr, "cusdetails") = 1 Then
            MessageBox.Show("Creation Succesful" & vbNewLine & "Your New Account " & arr(0) & " has been created")
            AddCus_lbl.Text = "ID:- " + arr(0)
            Cusid = arr(0)
            AddAccDropdown.Show()
            CreateAcc_Btn.Show()
            cusdetails = GetSingleRowDict("cusdetails", "Cus_Id", Cusid)
            Step1_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
            Step2_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Indeterminate
        End If
    End Sub

    Private Sub CreateAcc_Btn_Click(sender As Object, e As EventArgs)
        Dim arr(7) As String
        arr(0) = GetID(8, "bankacc", "Accno")
        arr(1) = cusdetails("First_Name")
        arr(2) = cusdetails("Mid_Name")
        arr(3) = cusdetails("Last_Name")
        arr(4) = Cusid
        arr(5) = AddAccDropdown.SelectedItem
        arr(6) = "0"
        arr(7) = CurDate()
        If InsertSingleRow(arr, "bankacc") = 1 Then
            MessageBox.Show("Your " + arr(5) + " account has been created succesfully")
            AddAcc_lbl.Text = "Acc:- " + arr(0)
            InitialDeposit_btn.Show()
            Accno = arr(0)
            Step2_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
            Step3_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Indeterminate
        End If
    End Sub

    Private Sub InitialDeposit_btn_Click(sender As Object, e As EventArgs)
        HomePage.SelectedTab = DepositTab
        AddCus = 1
    End Sub

#End Region

End Class