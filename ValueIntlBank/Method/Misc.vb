﻿Imports VB = Microsoft.VisualBasic
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
            val = GenID(8)
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

    Function GetGroupBoxCheckedButton(grpb As GroupBox) As RadioButton
        For Each ctrl As RadioButton In grpb.Controls
            If ctrl.Checked Then Return ctrl
        Next
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

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

    Public Sub Wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
End Module
