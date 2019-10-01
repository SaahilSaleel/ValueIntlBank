Public Class CreateBankAcc
    Dim CusID As String = ""
    Dim cusdetails As Dictionary(Of String, String)
    Public Sub New(Optional ByVal cus As String = "")
        InitializeComponent()
        CusID = cus
    End Sub
    Private Sub CreateBankAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = CusID
        If CusID IsNot "" Then
            Me.Button1.PerformClick()
            Me.Button1.Visible() = False
            Me.TextBox1.Enabled() = False
        End If
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cusdetails = GetSingleRowDict("cusdetails", "Cus_ID", TextBox1.Text)
        TextBox2.Text = cusdetails("First_Name")
        TextBox3.Text = cusdetails("Mid_Name")
        TextBox4.Text = cusdetails("Last_Name")
        Dim accno As String = GetID(8, "bankacc", "Accno")
        TextBox5.Text = accno
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim arr(7) As String
        arr(0) = TextBox5.Text
        arr(1) = TextBox2.Text
        arr(2) = TextBox3.Text
        arr(3) = TextBox4.Text
        arr(4) = TextBox1.Text
        arr(5) = ComboBox1.SelectedItem
        arr(6) = "0"
        arr(7) = CurDate()
        If InsertSingleRow(arr, "bankacc") = 1 Then
            MessageBox.Show("Your " + arr(5) + " account has been created succesfully")
            Dim Form = New AccDeposit(arr(4).ToString)
            Form.Show()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class