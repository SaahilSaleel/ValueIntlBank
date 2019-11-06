Public Class Hub
    Private Sub SelfServiceSelect_Click(sender As Object, e As EventArgs) Handles SelfServiceSelect.Click
        CustomerModule.Show()
    End Sub

    Private Sub CustomerServiceSelect_Click(sender As Object, e As EventArgs) Handles CustomerServiceSelect.Click
        EmpCusModule.Show()
    End Sub

    Private Sub EmployeeServiceSelect_Click(sender As Object, e As EventArgs) Handles EmployeeSelect.Click
        EmployeeModule.Show()
    End Sub

    Private Sub AdminSelect_btn_Click(sender As Object, e As EventArgs) Handles AdminSelect_btn.Click
        AdminModule.Show()
    End Sub
End Class