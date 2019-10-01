Public Class AllTransactions
    Dim query As String
    Private Sub AllTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT * FROM vib.receipts;"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReceiptsBindingSource.DataSource = GetTable(query)
    End Sub
End Class