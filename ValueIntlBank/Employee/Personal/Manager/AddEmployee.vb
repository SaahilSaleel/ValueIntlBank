Public Class AddEmployee
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AccList As String() = GetSingleCol("Accno", "bankacc", "Cus_ID", TextBox1.Text)
        ComboBox1.Items.AddRange(AccList)
        ComboBox1.SelectedIndex = 0
        ComboBox1.Enabled = True
        TextBox2.Text = GetID(8, "empdetails", "Emp_ID")
        TextBox3.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pass As String = TextBox3.Text
        Dim arr(3) As String
        arr(0) = TextBox2.Text
        arr(1) = TextBox3.Text
        arr(2) = TextBox1.Text
        arr(3) = ComboBox1.SelectedItem
        If Len(pass) > 7 Then
            If InsertSingleRow(arr, "empdetails") = 1 Then
                MessageBox.Show("Creation Succesful" & vbNewLine & "Your New Account " & arr(0) & " has been created")
                Dim Form = New SalaryManager(arr(0).ToString)
                Form.Show()
            End If
        Else
            TextBox3.Text = ""
        MessageBox.Show("Your password should be at least 8 characters")
        End If
    End Sub
End Class