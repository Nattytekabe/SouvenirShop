Module mod_global
    'database connection (read only)
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_Souvenir.accdb;
        Persist Security Info=False;"

    'database connection (read & write)
    Public myconnection2 As New OleDb.OleDbConnection(connection)

    'search product
    Public product_id As String = ""

    'date today
    Public today As Date = Date.Now()

    Public Sub run_sql_command(sql As String)
        Dim command As New OleDb.OleDbCommand(sql, myconnection2)

        Try

            command.Connection.Close()
            command.Connection.Open()
            command.ExecuteNonQuery()
            command.Connection.Close()

        Catch ex As Exception

            Beep()
            MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
            command.Connection.Close()

        End Try
    End Sub

End Module
