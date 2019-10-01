Imports System.ComponentModel

Public Class AddBeneficiary
    Dim CusId As String
    Dim Accno As String
    Function GetIFSC()
        Dim IFSC As Integer

        Return ifsc
    End Function
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox4.Enabled = False
            TextBox4.Text = "VIB"
            TextBox5.Enabled = False
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox4.Enabled = True
            TextBox4.Text = ""
            TextBox5.Enabled = True
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass As String = TextBox3.Text
        Dim arr(6) As String
        arr(0) = GetSno("beneficiaries", "Sno")
        arr(1) = CusId
        arr(2) = TextBox1.Text
        arr(3) = TextBox2.Text
        arr(4) = TextBox3.Text
        arr(5) = TextBox4.Text
        If RadioButton1.Checked = True Then
            arr(6) = "vib"
        ElseIf RadioButton2.Checked Then
            arr(6) = TextBox5.Text
        End If

        If InsertSingleRow(arr, "beneficiaries") = 1 Then
            MessageBox.Show("Your Beneficiary " & arr(3) & " has been added")
            Dim Form = New TransferMenu(CusId, Accno)
            Form.Show()
        End If

    End Sub

    Private Sub New(ByVal cus As String, ByVal acc As String)
        CusId = cus
        Accno = acc
    End Sub
End Class