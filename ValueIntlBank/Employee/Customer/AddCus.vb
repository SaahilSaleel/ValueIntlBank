Public Class AddCus
    Private Sub AddCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(10) As String
        arr(0) = GetID(8, "cusdetails", "Cus_ID")
        arr(1) = InputBox("Please Enter a Password")
        arr(2) = TextBox1.Text
        arr(3) = TextBox2.Text
        arr(4) = TextBox3.Text
        arr(5) = TextBox4.Text
        arr(6) = TextBox5.Text
        arr(7) = TextBox6.Text
        arr(8) = MonthCalendar1.SelectionEnd.ToString("yyyy-MM-dd")
        arr(9) = GetGroupBoxCheckedButton(GroupBox1).Text
        arr(10) = TextBox7.Text
        If InsertSingleRow(arr, "cusdetails") = 1 Then
            MessageBox.Show("Creation Succesful" & vbNewLine & "Your New Account " & arr(0) & " has been created")
            Dim Form = New CreateBankAcc(arr(0).ToString)
            Form.Show()
        End If

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = Capitalise(TextBox1.Text)
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox2.Text = Capitalise(TextBox2.Text)
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox3.Text = Capitalise(TextBox3.Text)
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox4.Text = Capitalise(TextBox4.Text)
    End Sub
End Class