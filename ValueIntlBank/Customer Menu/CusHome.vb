Public Class CusHome
    Dim Accno As String
    Dim CusId As String

    Public Sub New(ByVal user As String)
        InitializeComponent()
        CusId = user
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm As New CusPassbook(Accno, CusId)
        MyForm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm As New TransferMenu(Accno, CusId)
        MyForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyForm As New CusLogin
        MyForm.Show()
        Me.Close()
        MessageBox.Show("Logout Succesful")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Accno = ComboBox1.SelectedItem
    End Sub

    Private Sub CusHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AccList As String() = GetSingleCol("Accno", "bankacc", "Cus_ID", CusId)
        Me.ComboBox1.Items.AddRange(AccList)
        Me.ComboBox1.SelectedIndex = 0
        Accno = ComboBox1.SelectedItem
    End Sub
End Class