Public Class CustomerMenu

    Private Sub Passbook_btn_Click(sender As Object, e As EventArgs) Handles Passbook_btn.Click
        Dim MyForm As New Passbook
        MyForm.Show()
        Me.Close()
    End Sub

    Private Sub Edit_Btn_Click(sender As Object, e As EventArgs) Handles Edit_Btn.Click
        Dim MyForm As New EditCusDetails
        MyForm.Show()
        Me.Close()
    End Sub

    Private Sub Transfer_btn_Click(sender As Object, e As EventArgs) Handles Transfer_btn.Click
        Dim MyForm As New TransferMenu
        MyForm.Show()
        Me.Close()
    End Sub

    Private Sub Logout_Btn_Click(sender As Object, e As EventArgs) Handles Logout_Btn.Click
        Dim MyForm As New CusLogin
        MyForm.Show()
        Me.Close()
        MessageBox.Show("Logout Succesful")
    End Sub
End Class