Public Class EmpCusHome
    Dim CusID As String
    Public Sub New(cus As String)
        InitializeComponent()
        CusId = cus
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form = New AccDeposit(CusID)
        Form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form = New AccWithdraw(CusID)
        Form.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form = New CreateBankAcc(CusID)
        Form.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Form = New EditCusDetails(CusID)
        Form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Form = New EmpCusLogin
        Form.Show()
    End Sub
End Class