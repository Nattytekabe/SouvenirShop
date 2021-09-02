Public Class customer
    Private Sub frm_customer_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM CUSTOMER"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_customer.DataSource = table
        Dim btn As New DataGridViewButtonColumn()
        grd_customer.Columns.Add(btn)
        btn.HeaderText = "Detail"
        btn.Text = "View"
        btn.Name = "btn_view"
        btn.UseColumnTextForButtonValue = True
        lbl_total.Text = "Total Customer : " & table.Rows.Count() & ""
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        mainmenu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub grd_customer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick
        Dim num As Integer = grd_customer.CurrentCell.RowIndex
        Dim value = grd_customer.Rows(num).Cells(0).Value.ToString
        product_id = value
        viewCustomer.Show()
        Me.Close()
    End Sub

    Private Sub btn_create_customer_Click(sender As Object, e As EventArgs) Handles btn_create_customer.Click
        Me.Close()
        createCustomer.Show()
    End Sub
End Class