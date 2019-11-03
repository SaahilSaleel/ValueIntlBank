Public Class Hub
    Private Sub SelfServiceSelect_Click(sender As Object, e As EventArgs) Handles SelfServiceSelect.Click
        CustomerModule.Show()
    End Sub

    Private Sub CustomerServiceSelect_Click(sender As Object, e As EventArgs) Handles CustomerServiceSelect.Click
        EmpCusModule.Show()
    End Sub

    Private Sub EmployeeServiceSelect_Click(sender As Object, e As EventArgs) Handles EmployeeSelect.Click

    End Sub
End Class