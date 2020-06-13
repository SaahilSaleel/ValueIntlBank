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

    Function BankTransfer(ByVal Sender_Acc As Integer, ByVal Amount As Integer, ByVal Receiver_Acc As Integer, ByVal Comment As String)
        Dim bal As Integer = CInt(GetSingleField("Balance", "bankacc", "Accno", Sender_Acc))
        Dim bank As String = GetSingleField("Ben_Bank", "beneficiaries", "Ben_Accno", Receiver_Acc)
        bal -= Amount
        Dim Success = 0
        Dim arr(7) As String
        arr(0) = GetID(8, "receipts", "Trans_ID")
        arr(1) = Amount
        arr(2) = Comment
        arr(3) = GetSingleField("Cus_ID", "bankacc", "Accno", Sender_Acc)
        arr(4) = Sender_Acc
        arr(5) = GetSingleField("Cus_ID", "bankacc", "Accno", Receiver_Acc)
        arr(6) = Receiver_Acc
        arr(7) = CurDateTime()


        If bal > 0 Then

            If UpdateSingleField("bankacc", "Balance", bal, "Accno", Sender_Acc) = 1 Then
                If bank = "VIB" Then
                    bal = CInt(GetSingleField("Balance", "bankacc", "Accno", Receiver_Acc))
                    bal += Amount
                    If UpdateSingleField("bankacc", "Balance", bal, "Accno", Receiver_Acc) = 1 Then
                        MessageBox.Show("Succesful")
                    End If
                End If
                If Receipt(arr) = 1 Then
                    Success = 1
                End If
            End If
            Else
            MessageBox.Show("Value cannot be negative")
        End If
        Return Success
    End Function

    Function EditPassword(ByVal id As String, ByVal newpassword As String, ByVal table As String)
        Dim Success As Integer = 0
        If table = "cus" Then
            UpdateSingleField("cusdetails", "password", newpassword, "Cus_id", id)
            Success = 1
        ElseIf table = "emp" Then
            UpdateSingleField("empdetails", "password", newpassword, "Emp_id", id)
            Success = 1
        End If
        If Success = 1 Then
            MessageBox.Show("Password has been updated succesfully")
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
