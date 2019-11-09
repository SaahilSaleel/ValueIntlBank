Public Class SelfServiceModule
    Dim MousePressedDown As Boolean
    Dim lastLocation As Point
    Dim Cusid As String
    Dim Accno As String
    Dim cusdetails As Dictionary(Of String, String)
    Private Sub EmpCusModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VibDataSet.receipts' table. You can move, or remove it, as needed.
        Me.ReceiptsTableAdapter.Fill(Me.VibDataSet.receipts)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Color.Magenta
        MenuCard.Hide()
    End Sub

    Private Sub LockStatus(ByVal status As String)
        If status = "Lock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Lock.png")
        ElseIf status = "Unlock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Unlock.png")
        End If
    End Sub

    Private Sub BalanceUpdate()
        Balance_lbl.Text = "Bal: " + GetSingleField("Balance", "bankacc", "accno", Accno)
    End Sub

    Private Sub PassbookUpdate()
        Dim PassbookQuery As String = "SELECT * FROM vib.receipts where Debit_Accno = '" + Accno + "' or Credit_Accno = '" + Accno + "';"
        ReceiptsBindingSource.DataSource = GetTable(PassbookQuery)
    End Sub

#Region "Dragging Function"

    Private Sub MenuGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub MenuGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub MenuGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuGradientPanel.MouseUp
        MousePressedDown = False
    End Sub
    Private Sub LoginGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles LogInGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub LoginGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles LogInGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub LoginGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles LogInGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub AddBeneficiaryGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles AddBeneficiaryGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub AddBeneficiaryGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles AddBeneficiaryGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub AddBeneficiaryGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles AddBeneficiaryGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub TransferGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TransferGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub TransferGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TransferGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub TransferGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles TransferGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub EditPasswordGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles EditPasswordGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub EditPasswordGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles EditPasswordGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub EditPasswordGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles EditPasswordGradientPanel.MouseUp
        MousePressedDown = False
    End Sub

    Private Sub PassbookGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles PassbookGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub PassbookGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles PassbookGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub PassbookGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles PassbookGradientPanel.MouseUp
        MousePressedDown = False
    End Sub
#End Region

#Region "Reset"

    Private Sub EditPassReset()
        OldPassword_txt.Text = ""
        NewPassword_txt.Text = ""
        ConfirmNewPassword_txt.Text = ""
    End Sub
    Private Sub TransferReset()
        BeneficiaryDropdown.SelectedIndex = 0
        TransferComment_txt.Text = ""
        TransferAmount_txt.Text = ""
    End Sub

    Private Sub AddBenificiaryReset()
        BankDropdown.SelectedIndex = 0
        Accno_txt.Text = ""
        Name_txt.Text = ""
        Nickname_txt.Text = ""
        IFSC_txt.Text = ""
        Bank_txt.Text = ""
    End Sub

#End Region

#Region "Menu Card"
    Private Sub MenuDeselectAll()
        BankTransferSelect.selected = False
        EditPasswordSelect.selected = False
        PassbookSelect.selected = False
        AddBeneficiarySelect.selected = False
    End Sub
    Private Sub AccnoDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccnoDropdown.SelectedIndexChanged
        Accno = AccnoDropdown.SelectedItem
        BalanceUpdate()
        PassbookUpdate()
    End Sub
    Private Sub BankTransferSelect_Click(sender As Object, e As EventArgs) Handles BankTransferSelect.Click
        BeneficiaryDropdown.Items.Clear()
        Dim BeneficiaryAccList As String() = GetSingleCol("Ben_Accno", "beneficiaries", "Creator_AccNo", Accno)
        Dim BeneficiaryNickList As String() = GetSingleCol("Ben_Nick", "beneficiaries", "Creator_AccNo", Accno)
        Dim BeneficiaryList(UBound(BeneficiaryNickList)) As String
        For i As Long = LBound(BeneficiaryAccList) To UBound(BeneficiaryNickList)
            BeneficiaryList(i) = BeneficiaryAccList(i) + " - " + BeneficiaryNickList(i)
        Next
        Me.BeneficiaryDropdown.Items.AddRange(BeneficiaryList)


        HomePage.SelectedTab() = MoneyTransferTab
        MenuDeselectAll()
        TransferReset()
        BankTransferSelect.selected = True
    End Sub

    Private Sub EditPasswordSelect_Click(sender As Object, e As EventArgs) Handles EditPasswordSelect.Click
        HomePage.SelectedTab = EditPasswordTab
        MenuDeselectAll()
        EditPassReset()
        EditPasswordSelect.selected = True
    End Sub
    Private Sub LogOut_Btn_Click(sender As Object, e As EventArgs) Handles LogOut_Btn.Click
        LockStatus("Lock")
        PasswordTextBox.Text = ""
        MainPage.SelectedTab() = LoginTab
        AccnoDropdown.Items.Clear()
        Wait(1)
        MenuCard.Hide()
    End Sub
    Private Sub PassbookSelect_Click(sender As Object, e As EventArgs) Handles PassbookSelect.Click
        HomePage.SelectedTab = PassbookTab
        MenuDeselectAll()
        PassbookSelect.selected = True
        PassbookUpdate()
    End Sub

    Private Sub AddBeneficiarySelect_Click(sender As Object, e As EventArgs) Handles AddBeneficiarySelect.Click
        MenuDeselectAll()
        AddBeneficiarySelect.selected = True
        HomePage.SelectedTab = AddBenificiaryTab
        AddBenificiaryReset()
    End Sub

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Dim Form As New SelfServiceModule
        Form.Close()
    End Sub
#End Region

#Region "Login Page"

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

#Region "Add Beneficiary"
    Private Sub BankDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BankDropdown.SelectedIndexChanged
        If BankDropdown.Text = "Same Bank" Then
            Bank_txt.Text = "VIB"
            Bank_txt.Enabled = False
        ElseIf BankDropdown.Text = "Other Bank" Then
            Bank_txt.Text = ""
            Bank_txt.Enabled = True
        End If
    End Sub
    Private Sub AddBeneficiary_btn_Click(sender As Object, e As EventArgs) Handles AddBeneficiary_btn.Click
        Dim arr(6) As String
        If Bank_txt.Text = "VIB" Then
            If GetRowCount(Accno_txt.Text, "bankacc", "accno") < 1 Then
                MessageBox.Show("Account does not exist")
                Exit Sub
            End If
        End If
        If Accno_txt.Text.Length <> 8 Then
            ToolTip.Show("Account number must be 8 digits", Accno_txt)
            Exit Sub
        Else
            ToolTip.Hide(Accno_txt)
        End If
        arr(0) = GetSno("beneficiaries", "Sno")
        arr(1) = Accno
        arr(2) = Accno_txt.Text
        arr(3) = Name_txt.Text
        arr(4) = Nickname_txt.Text
        arr(5) = Bank_txt.Text
        arr(6) = IFSC_txt.Text
        If InsertSingleRow(arr, "beneficiaries") = 1 Then
            MessageBox.Show("Your Beneficiary has been added succesfully")
        End If
    End Sub
#End Region

#Region "Passbook"
    Private Sub PassbookRefresh_btn_Click(sender As Object, e As EventArgs) Handles PassbookRefresh_btn.Click
        PassbookUpdate()
    End Sub
#End Region

#Region "Bank Transfer"
    Private Sub Transfer_Btn_Click(sender As Object, e As EventArgs) Handles Transfer_Btn.Click
        Dim Receiver As Integer = CInt(BeneficiaryDropdown.SelectedItem.ToString.Substring(0, 12))
        If BankTransfer(Accno, TransferAmount_txt.Text, Receiver, TransferComment_txt.Text) = 1 Then
            Dim msg = "Rs " & TransferAmount_txt.Text & " has been succesfully transferred to receiver AccNo:- " & BeneficiaryDropdown.SelectedItem
            MessageBox.Show(msg)
            BalanceUpdate()
        End If
    End Sub


#End Region

#Region "Edit Password"
    Private Sub ConfirmNewPassword_txt_TextChanged(sender As Object, e As EventArgs) Handles ConfirmNewPassword_txt.TextChanged
        If ConfirmNewPassword_txt.Text IsNot NewPassword_txt.Text Then
            ToolTip.Show("Does not match", ConfirmNewPassword_txt)
        Else
            ToolTip.Hide(ConfirmNewPassword_txt)
        End If
    End Sub

    Private Sub EditPassword_btn_Click(sender As Object, e As EventArgs) Handles EditPassword_btn.Click
        If String.Equals(OldPassword_txt.Text, cusdetails("Password")) = False Then
            MessageBox.Show("Old password is Incorrect")
            Exit Sub
        End If

        If NewPassword_txt.Text.Length < 8 Then
            MessageBox.Show("Password should be at least 8 characters")
            Exit Sub
        End If

        If String.Equals(NewPassword_txt.Text, ConfirmNewPassword_txt.Text) = False Then
            MessageBox.Show("Passwords dont match")
            Exit Sub
        End If
        EditPassword(Cusid, NewPassword_txt.Text, "cus")
    End Sub

    Private Sub Hamburger_Btn_Click(sender As Object, e As EventArgs)
        If MenuCard.Width = 309 Then
            MenuCard.Width = 67
        ElseIf MenuCard.Width = 67 Then
            MenuCard.Width = 309
        End If
    End Sub

#End Region

End Class