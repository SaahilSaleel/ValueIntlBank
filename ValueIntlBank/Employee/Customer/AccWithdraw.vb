Public Class AccWithdraw

    Dim CusID As String = ""
    Dim inrtotal As Integer = 0
    Public Sub New(Optional ByVal cus As String = "")
        InitializeComponent()
        CusID = cus
    End Sub
    Private Sub Total()
        If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" And TextBox3.Text IsNot "" And TextBox4.Text IsNot "" And TextBox5.Text IsNot "" And TextBox6.Text IsNot "" And TextBox7.Text IsNot "" And TextBox8.Text IsNot "" And TextBox9.Text IsNot "" And TextBox10.Text IsNot "" Then
            Dim inr2000 As Integer = TextBox1.Text * 2000
            Dim inr500 As Integer = TextBox2.Text * 500
            Dim inr200 As Integer = TextBox3.Text * 200
            Dim inr100 As Integer = TextBox4.Text * 100
            Dim inr50 As Integer = TextBox5.Text * 50
            Dim inr20 As Integer = TextBox10.Text * 20
            Dim inr10 As Integer = TextBox9.Text * 10
            Dim inr5 As Integer = TextBox8.Text * 5
            Dim inr2 As Integer = TextBox7.Text * 2
            Dim inr1 As Integer = TextBox6.Text * 1
            inrtotal = inr2000 + inr500 + inr200 + inr100 + inr50 + inr20 + inr10 + inr5 + inr2 + inr1
            Label3.Text = inrTotal & ".00 Rs"
        End If
    End Sub

    Sub ResetFields()
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox6.Text = "0"
        TextBox7.Text = "0"
        TextBox8.Text = "0"
        TextBox9.Text = "0"
        TextBox10.Text = "0"
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim i As Integer = TextBox1.Text
        i += 1
        TextBox1.Text = i
    End Sub

    Private Sub AccWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CusID IsNot "" Then
            TextBox11.Text = CusID
            Me.Button1.PerformClick()
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim i As Integer = TextBox1.Text
        i += 1
        TextBox1.Text = i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AccList As String() = GetSingleCol("Accno", "bankacc", "Cus_ID", TextBox11.Text)
        Me.ComboBox1.Items.AddRange(AccList)
        Me.ComboBox1.SelectedIndex = 0
        TabControl1.Enabled = True

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim i As Integer = TextBox2.Text
        i += 1
        TextBox2.Text = i
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim i As Integer = TextBox3.Text
        i += 1
        TextBox3.Text = i
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim i As Integer = TextBox4.Text
        i += 1
        TextBox4.Text = i
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim i As Integer = TextBox5.Text
        i += 1
        TextBox5.Text = i
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim i As Integer = TextBox10.Text
        i += 1
        TextBox10.Text = i
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim i As Integer = TextBox9.Text
        i += 1
        TextBox9.Text = i
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim i As Integer = TextBox8.Text
        i += 1
        TextBox8.Text = i
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim i As Integer = TextBox7.Text
        i += 1
        TextBox7.Text = i
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim i As Integer = TextBox6.Text
        i += 1
        TextBox6.Text = i
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text < 0 Then
            TextBox1.Text = 0
        End If
        Total()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text < 0 Then
            TextBox2.Text = 0
        End If
        Total()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Total()
        If TextBox3.Text < 0 Then
            TextBox3.Text = 0
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text < 0 Then
            TextBox4.Text = 0
        End If
        Total()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text < 0 Then
            TextBox5.Text = 0
        End If
        Total()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text < 0 Then
            TextBox10.Text = 0
        End If
        Total()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text < 0 Then
            TextBox9.Text = 0
        End If
        Total()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text < 0 Then
            TextBox8.Text = 0
        End If
        Total()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text < 0 Then
            TextBox7.Text = 0
        End If
        Total()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text < 0 Then
            TextBox6.Text = 0
        End If
        Total()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Acc As Integer = Me.ComboBox1.SelectedItem
        Dim arr(7) As String
        arr(0) = GetID(8, "receipts", "Trans_ID")
        arr(1) = inrtotal
        arr(2) = "Withdraw"
        arr(3) = TextBox11.Text
        arr(4) = Acc
        arr(5) = ""
        arr(6) = ""
        arr(7) = CurDateTime()
        If Withdraw(Acc, inrtotal) = 1 Then
            If Receipt(arr) = 1 Then
                ResetFields()
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResetFields()
        Dim amt As Integer = TextBox12.Text
        Dim num As Integer
        num = Math.Floor(amt / 2000) - 1
        If num <= 0 Then
            num = 0
        End If
        TextBox1.Text = num

        amt -= (num * 2000)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 500) - 1
        TextBox2.Text = num

        amt -= (num * 500)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 200)
        TextBox3.Text = num

        amt -= (num * 200)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 100)
        TextBox4.Text = num

        amt -= (num * 100)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 50)
        TextBox5.Text = num

        amt -= (num * 50)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 20)
        TextBox10.Text = num

        amt -= (num * 20)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 10)
        TextBox9.Text = num

        amt -= (num * 10)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 5)
        TextBox8.Text = num

        amt -= (num * 5)
        If amt <= 0 Then
            Exit Sub
        End If
        num = Math.Floor(amt / 2)
        TextBox7.Text = num

        amt -= (num * 2)
        If amt <= 0 Then
            Exit Sub
        End If
        TextBox6.Text = amt
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Form = New EmpCusHome(CusID)
        Form.Show()
        Me.Close()
    End Sub
End Class