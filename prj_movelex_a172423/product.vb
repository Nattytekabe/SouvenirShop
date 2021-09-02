Public Class product

    Private Sub frm_product_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM PRODUCT"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_product.DataSource = table
        Dim btn As New DataGridViewButtonColumn()
        grd_product.Columns.Add(btn)
        btn.HeaderText = "Detail"
        btn.Text = "View"
        btn.Name = "btn_view"
        btn.UseColumnTextForButtonValue = True
        lbl_total.Text = "Total Product : " & table.Rows.Count() & ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grd_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellContentClick
        Dim num As Integer = grd_product.CurrentCell.RowIndex
        Dim value = grd_product.Rows(num).Cells(0).Value.ToString
        product_id = value
        viewProduct.Show()
        Me.Close()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        createProduct.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Close()
    End Sub
End Class