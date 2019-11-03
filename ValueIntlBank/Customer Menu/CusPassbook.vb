Public Class CusPassbook
    Dim Accno As String
    Dim query As String
    Dim CusId As String
    Public Sub New(user As String, cus As String)
        InitializeComponent()
        Accno = user
        CusId = cus
        query = "SELECT * FROM vib.receipts where Debit_Accno = '" + Accno + "' or Credit_Accno = '" + Accno + "';"
    End Sub

    Private Sub Passbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Button1.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReceiptsBindingSource.DataSource = GetTable(query)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form = New CusHome(CusId)
        Form.Show()
        Me.Close()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As Integer = DataGridView1.CurrentRow.Index
        Dim transid As String = DataGridView1.Rows(row).Cells(0).Value
        Dim Msg As String = GetSingleField("Type", "receipts", "Trans_ID", transid)
        TextBox1.Text = Msg
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class