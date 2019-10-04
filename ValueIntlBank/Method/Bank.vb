Module Bank
    Function Deposit(ByVal Acc As Integer, ByVal Amount As Integer) As Integer
        Dim bal As Integer = CInt(GetSingleField("Balance", "bankacc", "Accno", Acc))
        bal += Amount
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
        bal -= Amount
        Dim Success = 0
        If bal > 0 Then

            If UpdateSingleField("bankacc", "Balance", bal, "Accno", Acc) = 1 Then
                Dim msg = "Rs " & Amount & " has been succesfully withdrawn from AccNo:- " & Acc
                MessageBox.Show(msg)
                Success = 1
            End If
        Else
            MessageBox.Show("Value cannot be negative")
        End If
        Return Success
    End Function

    Function BankTransfer(ByVal Sender_Acc As Integer, ByVal Amount As Integer, ByVal Receiver_Acc As Integer)
        Dim bal As Integer = CInt(GetSingleField("Balance", "bankacc", "Accno", Sender_Acc))
        Dim bank As String = GetSingleField("Bank", "beneficiaries", "Accno", Receiver_Acc)
        bal -= Amount
        Dim Success = 0
        If bal > 0 Then

            If UpdateSingleField("bankacc", "Balance", bal, "Accno", Sender_Acc) = 1 Then
                If bank = "VIB" Then
                    bal = CInt(GetSingleField("Balance", "bankacc", "Accno", Receiver_Acc))
                    bal += Amount
                    UpdateSingleField("bankacc", "Balance", bal, "Accno", Receiver_Acc)
                End If
                Dim msg = "Rs " & Amount & " has been succesfully transferred to receiver AccNo:- " & Sender_Acc
                MessageBox.Show(msg)
                Success = 1
            End If
        Else
            MessageBox.Show("Value cannot be negative")
        End If
        Return Success
    End Function

    Function EditPassword(ByVal id As String, ByVal newpassword As String, ByVal table As String)
        Dim Success As Integer = 0
        If table = "cus" Then
            UpdateSingleField(table, "password", newpassword, "Cus_id", id)
            Success = 1
        ElseIf table = "emp" Then
            UpdateSingleField(table, "password", newpassword, "Emp_id", id)
            Success = 1
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
