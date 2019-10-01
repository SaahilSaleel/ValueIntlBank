Imports MySql.Data.MySqlClient

Module SQL
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Function LogIn(ByVal user As String, ByVal pass As String, ByVal table As String) As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim Success As Integer = 0

        Try
            MysqlConn.Open()
            Dim Query As String = ""
            If table = "cus" Then
                Query = "select * from vib.cusdetails where Cus_ID='" & user & "' and password='" & pass & "' "
            ElseIf table = "emp" Then
                Query = "select * from vib.empdetails where Emp_ID='" & user & "' and password='" & pass & "' "
            End If
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count += 1

            End While

            If count = 1 Then
                Success = 1
            End If


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        Return Success
    End Function

    Function GetRowCount(ByVal table As String) As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim count As Integer
        count = 0
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from vib." + table
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                count += 1

            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        Return count
    End Function

    Function GetRowCount(ByVal val As String, ByVal table As String, ByVal col As String) As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim count As Integer
        count = 0
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from vib." + table + " where " + col + "='" & val & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                count += 1

            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        Return count
    End Function


    Function InsertSingleRow(ByVal arr() As String, ByVal table As String) As Integer
        Dim length As Integer = arr.Length
        Dim query As String = "INSERT INTO `vib`.`" + table + "` values ("
        For i = 0 To length - 1
            If i > 0 Then
                query += ","
            End If
            query += "'" + arr(i) + "'"
        Next i
        query += ");"
        MessageBox.Show(query)
        Dim success = ExecuteQuery(query)
        Return success
    End Function

    Function ExecuteQuery(ByVal Query As String) As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()
            'MessageBox.Show(Query)
            Return 1

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return 0

        Finally
            MysqlConn.Dispose()

        End Try

    End Function

    Function GetSingleField(ByVal field As String, ByVal table As String, ByVal col As String, ByVal val As String) As String
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim value As String = ""
        If GetRowCount(val, table, col) = 1 Then

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "select " + field + " from vib." + table + " where " + col + "='" + val + "' "
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                    value = (READER.GetString(0))

                End While

                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        End If
        Return value
    End Function
    Function GetSingleRowDict(ByVal table As String, ByVal col As String, ByVal val As String) As Dictionary(Of String, String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim value As New Dictionary(Of String, String)
        Dim keyArr() As String = GetColNames(table)
        Dim len As Integer = keyArr.Length - 1
        Dim str As String
        If GetRowCount(val, table, col) = 1 Then

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "select * from vib." + table + " where " + col + "='" + val + "' "
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                    For i As Integer = 0 To len
                        str = READER.GetString(i)
                        value.Add(keyArr(i), str)
                    Next i
                End While

                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        End If
        Return value
    End Function

    Function GetTable(ByVal query As String) As DataTable
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim Dt As DataTable = New DataTable
        Try
            MysqlConn.Open()
            COMMAND = New MySqlCommand(query, MysqlConn)
            Dt.Load(COMMAND.ExecuteReader)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        Return Dt
    End Function

    Function GetColNames(ByVal table As String) As String()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim value(0) As String
        Dim i As Integer = 0

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select COLUMN_NAME from information_schema.columns where TABLE_SCHEMA = 'vib' and TABLE_NAME = '" + table + "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                value(i) = READER.GetString(0)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                i += 1
                ReDim Preserve value(i)
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        i = value.Length - 2
        ReDim Preserve value(i)
        Return value
    End Function

    Function GetSingleCol(ByVal field As String, ByVal table As String) As String()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim value(0) As String
        Dim i As Integer = 0

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "
select " + field + " from vib." + table
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                value(i) = READER.GetString(0)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                i += 1
                ReDim Preserve value(i)
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        i = value.Length - 2
        ReDim Preserve value(i)
        Return value
    End Function

    Function GetSingleCol(ByVal field As String, ByVal table As String, ByVal col As String, ByVal val As String) As String()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
       "server=localhost;userid=root;password=root;database=vib"
        Dim READER As MySqlDataReader
        Dim value(0) As String
        Dim i As Integer = 0

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select " + field + " from vib." + table + " where " + col + "='" + val + "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                value(i) = READER.GetString(0)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                i += 1
                ReDim Preserve value(i)
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
        i = value.Length - 2
        ReDim Preserve value(i)
        Return value
    End Function

    Function UpdateSingleField(ByVal table As String, ByVal updatecol As String, ByVal updateVal As String, ByVal conditionCol As String, ByVal conditionVal As String) As Integer
        Dim query As String = "Update " + table + " Set " + updatecol + " = " + updateVal + " where " + conditionCol + " = " + conditionVal
        Return ExecuteQuery(query)
    End Function

End Module
