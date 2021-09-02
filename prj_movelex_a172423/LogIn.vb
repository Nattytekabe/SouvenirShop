Imports System.Data.OleDb

Public Class LogIn

    Dim con As New OleDbConnection



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If ask() = True Then
            mainmenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


   





    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=microsoft.ace.oledb.12.0; Data Source=C:\Users\Natty Rock\source\repos\New Folder\Souvenir-shop\prj_movelex_a172423\bin\Debug\DB_Souvenir.accdb"

    End Sub
    Public Function ask()
        'login
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from Staff", con)
        da.Fill(dt)

        For Each datarow In dt.Rows

            If UsernameTextBox.Text = datarow.item(1) And PasswordTextBox.Text = datarow(5) Then
                con.Close()
                Return True
            End If
        Next

        con.Close()
        Return False

    End Function

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
