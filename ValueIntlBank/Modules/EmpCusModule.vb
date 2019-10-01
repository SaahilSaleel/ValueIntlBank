Public Class EmpCusModule
    Dim MousePressedDown As Boolean
    Dim lastLocation As Point
    Dim Cusid As String
    Dim Accno As String
    Dim cusdetails As Dictionary(Of String, String)

    Private Sub Template_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Color.Magenta
        DepositTotal()
        ProgressCard.Hide()
        MenuCard.Hide()
        Step4_btn.Hide()
    End Sub
    Private Sub LockStatus(ByVal status As String)
        If status = "Lock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Lock.png")
        ElseIf status = "Unlock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Unlock.png")
        End If
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

    Private Sub LoginGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles LoginGradientPanel.MouseUp
        MousePressedDown = False
    End Sub
#End Region

#Region "Menu Card"
    Private Sub AccnoDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccnoDropdown.SelectedIndexChanged
        Accno = AccnoDropdown.SelectedItem
    End Sub
    Private Sub DepositSelect_Click(sender As Object, e As EventArgs) Handles DepositSelect.Click
        HomePage.SelectedTab() = DepositTab
    End Sub

    Private Sub WithdrawSelect_Click(sender As Object, e As EventArgs) Handles WithdrawSelect.Click
        HomePage.SelectedTab = WithdrawTab
    End Sub
    Private Sub LogOut_Btn_Click(sender As Object, e As EventArgs) Handles LogOut_Btn.Click
        LockStatus("Lock")
        PasswordTextBox.Text = ""
        MainPage.SelectedTab() = HomeTab
        AccnoDropdown.Items.Clear()
        Wait(1)
        MenuCard.Hide()
    End Sub
    Private Sub EditDetailsSelect_Click(sender As Object, e As EventArgs) Handles EditDetailsSelect.Click
        HomePage.SelectedTab = EditDetailsTab
    End Sub

    Private Sub AddAccSelect_Click(sender As Object, e As EventArgs) Handles AddAccSelect.Click
        HomePage.SelectedTab = AddAccTab
    End Sub
#End Region

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        If LogIn(UsernameTextBox.Text, PasswordTextBox.Text, "cus") = 1 Then
            Cusid = UsernameTextBox.Text
            cusdetails = GetSingleRowDict("cusdetails", "Cus_ID", Cusid)
            MenuCard.Show()
            LockStatus("Unlock")
            MainPage.SelectedTab() = LoginTab
            Wait(1)
            HomePage.SelectedTab = SelectionTab
            Dim AccList As String() = GetSingleCol("Accno", "bankacc", "Cus_ID", Cusid)
            Me.AccnoDropdown.Items.AddRange(AccList)
            Me.AccnoDropdown.SelectedIndex = 0
            Accno = AccnoDropdown.SelectedItem
        Else
            ToolTip.Show("Username and Password does not match", UsernameTextBox)
        End If
    End Sub


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

    Sub ResetFields()
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
                ResetFields()
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


    Private Sub Step4_btn_Click(sender As Object, e As EventArgs) Handles Step4_btn.Click
        MainPage.SelectedTab() = HomeTab
        Wait(2)
        ProgressCard.Hide()
    End Sub

    Private Sub Register_Btn_Click(sender As Object, e As EventArgs) Handles Register_Btn.Click

        HomePage.SelectedTab = AddCusTab
        ProgressCard.Show()
        Step1_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Indeterminate
        Step2_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Step3_chk.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked
        Step4_btn.Enabled = False
        MainPage.SelectedTab() = LoginTab
    End Sub

    Private Sub EmpCusModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#Region "Add Cus"

#End Region
End Class