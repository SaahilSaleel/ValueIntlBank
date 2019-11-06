Public Class AdminModule
    Dim MousePressedDown As Boolean
    Dim lastLocation As Point
    Private Sub EmpCusModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BanklistTableAdapter.Fill(Me.VibDataSet.banklist)
        Me.ReceiptsTableAdapter.Fill(Me.VibDataSet.receipts)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Color.Magenta
        MenuCard.Hide()

        Dim StateList As String() = GetSingleCol("Name", "States")
        Me.StateDropdown.Items.AddRange(StateList)
        Me.StateDropdown.SelectedIndex = 0

        Me.EditStateDropdown.Items.AddRange(StateList)
        Me.EditStateDropdown.SelectedIndex = 0
    End Sub

    Private Sub LockStatus(ByVal status As String)
        If status = "Lock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Lock.png")
        ElseIf status = "Unlock" Then
            BunifuPictureBox1.Image = Image.FromFile("D:\ValueIntlBank\ValueIntlBank\ValueIntlBank\Images\Lock\Unlock.png")
        End If
    End Sub

    Private Sub TransactionsUpdate()
        Dim PassbookQuery As String = "SELECT Trans_ID, Amount,DateTime, Debit_AccNo, Credit_Accno FROM vib.receipts;"
        ReceiptsBindingSource.DataSource = GetTable(PassbookQuery)
    End Sub

    Private Sub BankListUpdate()
        Dim BankListQuery As String = "SELECT * FROM vib.banklist;"
        BanklistBindingSource.DataSource = GetTable(BankListQuery)
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
#End Region

#Region "Menu Card"
    Private Sub MenuDeselectAll()
        AddBankSelect.selected = False
        EditBankSelect.selected = False
        TransactionSelect.selected = False
        AddEmployeeSelect.selected = False
    End Sub
    Private Sub AddBankSelect_Click(sender As Object, e As EventArgs) Handles AddBankSelect.Click
        HomePage.SelectedTab() = AddBankTab
        MenuDeselectAll()
        AddBankSelect.selected = True
    End Sub

    Private Sub EditBankSelect_Click(sender As Object, e As EventArgs) Handles EditBankSelect.Click
        HomePage.SelectedTab = EditBankTab
        MenuDeselectAll()
        EditBankSelect.selected = True
        BankListUpdate()
    End Sub

    Private Sub TransactionSelect_Click(sender As Object, e As EventArgs) Handles TransactionSelect.Click
        HomePage.SelectedTab = TransactionTab
        MenuDeselectAll()
        TransactionSelect.selected = True
        TransactionsUpdate()
    End Sub

    Private Sub AddEmployeeSelect_Click(sender As Object, e As EventArgs) Handles AddEmployeeSelect.Click
        MenuDeselectAll()
        AddEmployeeSelect.selected = True
        HomePage.SelectedTab = AddEmployeeTab
    End Sub
    Private Sub LogOut_Btn_Click(sender As Object, e As EventArgs) Handles LogOut_Btn.Click
        LockStatus("Lock")
        PasswordTextBox.Text = ""
        MainPage.SelectedTab() = LoginTab
        Wait(1)
        MenuCard.Hide()
    End Sub

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Hide()
    End Sub

#End Region

#Region "Login Page"

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        If LogIn(UsernameTextBox.Text, PasswordTextBox.Text, "admin") = 1 Then
            ToolTip.Hide(UsernameTextBox)
            HomePage.SelectedTab = SelectionTab
            MenuCard.Show()
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

#Region "Add Employee"

    Private Sub AddEmpGen_btn_Click(sender As Object, e As EventArgs) Handles AddEmpGen_btn.Click
        Dim cusdetails As Dictionary(Of String, String)
        Dim Cusid As String = CusID_txt.Text
        cusdetails = GetSingleRowDict("cusdetails", "Cus_Id", Cusid)
        EmpId_txt.Text = GetID(8, "empdetails", "Emp_ID")
        Dim AccList As String() = GetSingleCol("Accno", "bankacc", "Cus_ID", Cusid)
        AccDropdown.Items.Clear()
        AccDropdown.Items.AddRange(AccList)
        AccDropdown.SelectedIndex = 0
        Empname_txt.Text = cusdetails("First_Name") + " " + cusdetails("Mid_Name") + " " + cusdetails("Last_Name")
        EmpMail_txt.Text = cusdetails("First_Name") + cusdetails("Last_Name") + EmpId_txt.Text.Substring(4) + "@vib.com"
    End Sub

    Private Sub AddEmp_btn_Click(sender As Object, e As EventArgs) Handles AddEmp_btn.Click
        Dim arr(5) As String
        arr(0) = EmpId_txt.Text
        arr(1) = InputBox("Please Enter a Password")
        While arr(1).Length < 8
            MessageBox.Show("Password should be at least 8 characters")
            arr(1) = InputBox("Please Enter a Password")
        End While
        arr(2) = CusID_txt.Text
        arr(3) = AccDropdown.SelectedItem
        arr(4) = Empname_txt.Text
        arr(5) = EmpMail_txt.Text
        If InsertSingleRow(arr, "empdetails") = 1 Then
            MessageBox.Show("Creation Succesful" & vbNewLine & "Your New Account " & arr(0) & " has been created")
            AddCus_lbl.Text = "ID:- " + arr(0)
        End If

        If AdminSwitch.Value = True Then
            Dim adminarr As String() = {arr(0), arr(1)}
            InsertSingleRow(adminarr, "adminlist")
        End If
    End Sub

#End Region

#Region "Transaction"
    Private Sub TransactionRefresh_btn_Click(sender As Object, e As EventArgs) Handles TransactionRefresh_btn.Click
        TransactionsUpdate()
    End Sub
#End Region

#Region "Edit Bank"
    Dim Branchno As String
    Private Sub BankDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BankDataGridView.CellClick
        Dim row As Integer = BankDataGridView.CurrentRow.Index
        Branchno = BankDataGridView.Rows(row).Cells(0).Value
        Branchno_lbl.Text = Branchno
        EditName_txt.Text = GetSingleField("Name", "banklist", "Branchno", Branchno)
        EditStateDropdown.SelectedItem = GetSingleField("State", "banklist", "Branchno", Branchno)
        EditCityDropdown.SelectedItem = GetSingleField("City", "banklist", "Branchno", Branchno)
    End Sub

    Private Sub EditStateDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EditStateDropdown.SelectedIndexChanged
        Me.EditCityDropdown.Items.Clear()
        Dim CityList As String() = GetSingleCol("city", "city_state", "state", StateDropdown.SelectedItem)
        Me.EditCityDropdown.Items.AddRange(CityList)
        Me.EditCityDropdown.SelectedIndex = 0
    End Sub

    Private Sub UpdateName_btn_Click(sender As Object, e As EventArgs) Handles UpdateName_btn.Click
        EditName_txt.Text = Capitalise(EditName_txt.Text)
        If UpdateSingleField("banklist", "Name", EditName_txt.Text, "Branchno", Branchno) = 1 Then
            MessageBox.Show("Edited succesfully")
            BankListUpdate()
        End If
    End Sub

    Private Sub UpdateState_btn_Click(sender As Object, e As EventArgs) Handles UpdateState_btn.Click
        If UpdateSingleField("banklist", "State", EditStateDropdown.SelectedItem, "Branchno", Branchno) = 1 Then
            MessageBox.Show("Edited succesfully")
            BankListUpdate()
        End If
    End Sub

    Private Sub UpdateCity_btn_Click(sender As Object, e As EventArgs) Handles UpdateCity_btn.Click
        If UpdateSingleField("banklist", "City", EditCityDropdown.SelectedItem, "Branchno", Branchno) = 1 Then
            MessageBox.Show("Edited succesfully")
            BankListUpdate()
        End If
    End Sub

#End Region

#Region "Add Bank"
    Private Sub AddBank_Btn_Click(sender As Object, e As EventArgs) Handles AddBank_Btn.Click

        Dim sno As String = GetSno("banklist", "branchno")
        While sno.Length < 5
            sno = "0" + sno
        End While
        BankName_txt.Text = Capitalise(BankName_txt.Text)

        Dim arr(4) As String
        arr(0) = sno
        arr(1) = BankName_txt.Text
        arr(2) = CityDropdown.SelectedItem
        arr(3) = StateDropdown.SelectedItem
        arr(4) = "VIB" + arr(0)
        If InsertSingleRow(arr, "banklist") = 1 Then
            Branchno_txt.Text = arr(0)
            IFSC_txt.Text = arr(4)
            Dim msg = "Bank number " & Branchno_txt.Text & " " & BankName_txt.Text & " has been succesfully added"
            MessageBox.Show(msg)
        End If
    End Sub
    Private Sub StateDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StateDropdown.SelectedIndexChanged
        Me.CityDropdown.Items.Clear()
        Dim CityList As String() = GetSingleCol("city", "city_state", "state", StateDropdown.SelectedItem)
        Me.CityDropdown.Items.AddRange(CityList)
        Me.CityDropdown.SelectedIndex = 0
    End Sub

#End Region

End Class