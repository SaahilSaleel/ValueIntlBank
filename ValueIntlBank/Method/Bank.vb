Module Bank
    Function Deposit(ByVal Acc As Integer, ByVal Amount As Integer) As Integer
        Dim bal As Integer = CInt(GetSingleField("Balance", "bankacc", "Accno", Acc))
        bal = bal + Amount
        Dim Success = 0
        If UpdateSingleField("bankacc", "Balance", bal, "Accno", Acc) = 1 Then
            Dim msg = "Rs " & Amount & " has been succesfully deposited to AccNo:- " & Acc
            MessageBox.Show(msg)
            Success = 1
        End If
        Return Success
    End Function

    Function Withdraw(ByVal Acc As Integer, ByVal Amount As Integer) As Integer
        Dim bal As Integer = CInt(GetSingleField("Balance", "bankacc", "Accno", Acc))
        bal = bal - Amount
        Dim Success = 0
        If bal > 0 Then

            If UpdateSingleField("bankacc", "Balance", bal, "Accno", Acc) = 1 Then
                Dim msg = "Rs " & Amount & " has been succesfully withdrawn from AccNo:- " & Acc
                MessageBox.Show(msg)
                Success = 1
            End If
        ElseIf bal = 0 Then
            MessageBox.Show("Enter a value")
        ElseIf bal < 0 Then
            MessageBox.Show("Value cannot be negative")
        End If
        Return Success
    End Function
    Function Receipt(ByVal arr() As String)
        Dim Success As Integer = 0
        If InsertSingleRow(arr, "receipts") = 1 Then
            MessageBox.Show("Your transaction Id is " + arr(0))
            Success = 1
        End If
        Return Success
    End Function
End Module
