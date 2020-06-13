Imports VB = Microsoft.VisualBasic
Module Misc
    Function GenID(ByVal length As Integer) As String
        Dim value As String = ""
        Dim num As Integer
        For i = 1 To length
            If i = 1 Then
                num = (CInt(Rnd() * 8) + 1)
                value += CStr(num)
            Else
                num = CInt(Rnd() * 9)
                value += CStr(num)
            End If
        Next i
        Return value
    End Function
    Function GetID(ByVal len As Integer, ByVal table As String, ByVal col As String) As String
        Dim val As String = GenID(len)
        Do Until GetRowCount(val, table, col) = 0
            val = GenID(len)
        Loop
        Return val
    End Function
    Function GetSno(ByVal table As String, ByVal col As String)
        Dim val As Integer = 1
        Do Until GetRowCount(val, table, col) = 0
            val += 1
        Loop
        Return val
    End Function

    Function GetGroupBoxCheckedButton(grpb As GroupBox) As Bunifu.UI.WinForms.BunifuRadioButton
        Dim rb As Bunifu.UI.WinForms.BunifuRadioButton
        For Each ctrl As Object In grpb.Controls
            If ctrl.GetType Is GetType(Bunifu.UI.WinForms.BunifuRadioButton) Then
                rb = ctrl
                If rb.Checked Then
                    Return rb
                End If
            End If

        Next
        Return Nothing
    End Function


    Function CurDate() As String
        Dim CurrentDate As String = Date.Now.ToString("yyyy-MM-dd")
        Return CurrentDate
    End Function
    Function CurDateTime() As String
        Dim CurrentDateTime As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
        Return CurrentDateTime
    End Function

    Function Capitalise(ByVal word As String) As String
        word = StrConv(word, vbProperCase)
        Return word
    End Function

    Public Sub Wait(ByVal seconds As Integer)
        Static start As Integer
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            Application.DoEvents()
        Loop
    End Sub

    Function ContainsNumber(ByVal str As String) As Boolean
        Dim Result As Boolean = False
        If str.Contains(0) = True Then
            Result = True
        End If
        If str.Contains(1) = True Then
            Result = True
        End If
        If str.Contains(2) = True Then
            Result = True
        End If
        If str.Contains(3) = True Then
            Result = True
        End If
        If str.Contains(4) = True Then
            Result = True
        End If
        If str.Contains(5) = True Then
            Result = True
        End If
        If str.Contains(6) = True Then
            Result = True
        End If
        If str.Contains(7) = True Then
            Result = True
        End If
        If str.Contains(8) = True Then
            Result = True
        End If
        If str.Contains(9) = True Then
            Result = True
        End If
        Return Result
    End Function

    Public Function isValidName(ByVal str As String) As Boolean
        Dim Len As Integer = str.Length - 1
        Dim character As Char
        Dim Result As Boolean = True
        For i = 0 To Len
            character = str.ElementAt(i)
            If Char.IsLetter(character) = False Then
                Result = False
            End If
        Next
        Return Result
    End Function

    Public Function isValidNumber(ByVal str As String) As Boolean
        Dim Len As Integer = str.Length - 1
        Dim character As Char
        Dim Result As Boolean = True
        For i = 0 To Len
            character = str.ElementAt(i)
            If Char.IsDigit(character) = False Then
                Result = False
                Return Result
                Exit Function
            End If
        Next
        Return Result
    End Function
End Module
