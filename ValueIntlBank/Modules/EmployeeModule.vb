Public Class EmployeeModule
    Dim MousePressedDown As Boolean
    Dim lastLocation As Point
    Dim Empid As String
    Dim empdetails As Dictionary(Of String, String)
    Private Sub EmpCusModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Color.Magenta
        MenuCard.Hide()
    End Sub

    Private Sub LockStatus(ByVal status As String)
        If status = "Lock" Then
            LockPictureBox.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Lock.png")
        ElseIf status = "Unlock" Then
            LockPictureBox.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Unlock.png")
        End If
    End Sub

    Private Sub BankListUpdate()
        Dim BankListQuery As String = "SELECT * FROM vib.banklist;"
        BanklistBindingSource.DataSource = GetTable(BankListQuery)
    End Sub

    Private Sub InboxUpdate()
        Dim ReceivedListQuery As String = "Select Msg_No, Date_Time, Sender_ID, Sender_Name, Subject from vib.messagehub where Receiver_ID = '" + empdetails("Emp_Email") + "'"
        MessagehubBindingSource.DataSource = GetTable(ReceivedListQuery)
        Dim SentListQuery As String = "Select Msg_No, Date_Time, Receiver_ID, Receiver_Name, Subject from vib.messagehub where Sender_ID = '" + empdetails("Emp_Email") + "'"
        MessagehubBindingSource1.DataSource = GetTable(SentListQuery)
    End Sub

#Region "Dragging Function"
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

    Private Sub HomeGradientPanel_MouseDown(sender As Object, e As MouseEventArgs)
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub HomeGradientPanel_MouseMove(sender As Object, e As MouseEventArgs)
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub HomeGradientPanel_MouseUp(sender As Object, e As MouseEventArgs)
        MousePressedDown = False
    End Sub

    Private Sub AddCusGradientPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles ComposeGradientPanel.MouseDown
        MousePressedDown = True
        lastLocation = e.Location
    End Sub

    Private Sub AddCusGradientPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles ComposeGradientPanel.MouseMove
        If MousePressedDown = True Then
            Me.Location = New Point((Me.Location.X - lastLocation.X) + e.X, (Me.Location.Y - lastLocation.Y) + e.Y)
            Me.Update()
        End If
    End Sub

    Private Sub AddCusGradientPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles ComposeGradientPanel.MouseUp
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
    Private Sub Hamburger_Btn_Click(sender As Object, e As EventArgs) Handles Hamburger_Btn.Click
        If MenuCard.Width = 309 Then
            MenuCard.Width = 67
        ElseIf MenuCard.Width = 67 Then
            MenuCard.Width = 309
        End If
    End Sub
    Private Sub MenuDeselectAll()
        EditDetailsSelect.selected = False
        InboxSelect.selected = False
        BankListSelect.selected = False
        ComposeSelect.selected = False
    End Sub
    Private Sub EditDetailsSelect_Click(sender As Object, e As EventArgs) Handles EditDetailsSelect.Click
        HomePage.SelectedTab() = EditDetailsTab
        MenuDeselectAll()
        EditDetailsSelect.selected = True
    End Sub

    Private Sub InboxdSelect_Click(sender As Object, e As EventArgs) Handles InboxSelect.Click
        HomePage.SelectedTab = InboxTab
        MenuDeselectAll()
        InboxSelect.selected = True
        InboxUpdate()
    End Sub

    Private Sub BankListSelect_Click(sender As Object, e As EventArgs) Handles BankListSelect.Click
        HomePage.SelectedTab = BankListTab
        MenuDeselectAll()
        BankListSelect.selected = True
        BankListUpdate()
    End Sub

    Private Sub ComposeSelect_Click(sender As Object, e As EventArgs) Handles ComposeSelect.Click
        MenuDeselectAll()
        ComposeSelect.selected = True
        HomePage.SelectedTab = ComposeTab
    End Sub
    Private Sub LogOut_Btn_Click(sender As Object, e As EventArgs) Handles LogOut_Btn.Click
        LockStatus("Lock")
        PasswordTextBox.Text = ""
        MainPage.SelectedTab() = LoginTab
        Wait(1)
        MenuCard.Hide()
    End Sub

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Dim Form As New EmployeeModule
        Form.Close()
    End Sub
#End Region

#Region "Login Page"

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        If LogIn(UsernameTextBox.Text, PasswordTextBox.Text, "emp") = 1 Then
            ToolTip.Hide(UsernameTextBox)
            HomePage.SelectedTab = SelectionTab
            Empid = UsernameTextBox.Text
            empdetails = GetSingleRowDict("empdetails", "Emp_Id", Empid)
            Dim AccList As String() = GetSingleCol("Accno", "empdetails", "Emp_ID", Empid)
            Me.AccnoDropdown.Items.AddRange(AccList)
            MenuCard.Show()
            MenuCard.Width = 309
            LockStatus("Unlock")
            MainPage.SelectedTab() = HomeTab()
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

#Region "Bank List"
    Private Sub BankListRefresh_btn_Click(sender As Object, e As EventArgs) Handles BankListRefresh_btn.Click
        BankListUpdate()
    End Sub
#End Region

#Region "Edit Details"
    Private Sub EditPassword_btn_Click(sender As Object, e As EventArgs) Handles EditPassword_btn.Click
        If OldPassword_txt.Text IsNot empdetails("Password") Then
            MessageBox.Show("Old password is Incorrect")
            Exit Sub
        End If
        If NewPassword_txt.Text.Length < 8 Then
            MessageBox.Show("Too Short")
            Exit Sub
        End If
        EditPassword(Empid, NewPassword_txt.Text, "emp")
    End Sub

    Private Sub UpdateAcc_Btn_Click(sender As Object, e As EventArgs) Handles UpdateAcc_Btn.Click
        If UpdateSingleField("empdetails", "Accno", AccnoDropdown.SelectedItem, "Emp_ID", Empid) = 1 Then
            MessageBox.Show("Edited succesfully")
        End If
    End Sub

#End Region

#Region "Inbox"
    Private Sub ReceivedDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReceivedDataGridView.CellClick
        Dim row As Integer = ReceivedDataGridView.CurrentRow.Index
        Dim Msgno As String = ReceivedDataGridView.Rows(row).Cells(0).Value
        Dim Msg As String = GetSingleField("Message", "MessageHub", "Msg_No", Msgno)
        MessagePreview_txt.Text = Msg
    End Sub

    Private Sub SentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SentDataGridView.CellClick
        Dim row As Integer = SentDataGridView.CurrentRow.Index
        Dim Msgno As String = SentDataGridView.Rows(row).Cells(0).Value
        Dim Msg As String = GetSingleField("Message", "MessageHub", "Msg_No", Msgno)
        MessagePreview_txt.Text = Msg
    End Sub

#End Region

#Region "Compose"
    Private Sub Send_btn_Click(sender As Object, e As EventArgs) Handles Send_btn.Click
        Dim arr(8) As String
        arr(0) = GetSno("messagehub", "msgno")
        arr(1) = CurDateTime()
        arr(2) = empdetails("Emp_Email")
        arr(3) = empdetails("Emp_name")
        arr(4) = EmailDropdown.Text
        arr(5) = GetSingleField("Emp_name", "empdetails", "Emp_Email", EmailDropdown.Text)
        arr(6) = Subject_txt.Text
        arr(7) = Message_txt.Text
        If InsertSingleRow(arr, "messagehub") = 1 Then
            MessageBox.Show("Your Message has been sent succesfully")
        End If
    End Sub
#End Region

End Class