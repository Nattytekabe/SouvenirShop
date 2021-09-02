Public Class staff
    Private Sub frm_staff_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM STAFF"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_staff.DataSource = table                             'grd_staff = datagridview

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Me.Close()
        createStaff.Show()
    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick
        Dim num As Integer = grd_staff.CurrentCell.RowIndex
        Dim value = grd_staff.Rows(num).Cells(0).Value.ToString
        product_id = value
        viewStaff.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class