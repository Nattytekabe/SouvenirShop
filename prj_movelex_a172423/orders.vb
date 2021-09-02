Public Class orders
    Private Sub frm_orders_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM ORDERS"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_order.DataSource = table
        lbl_total.Text = "Total Order : " & table.Rows.Count() & ""
        Dim btn As New DataGridViewButtonColumn()

        'button
        grd_order.Columns.Add(btn)
        btn.HeaderText = "Detail"
        btn.Text = "View"
        btn.Name = "btn_view"
        btn.UseColumnTextForButtonValue = True
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_make_Click(sender As Object, e As EventArgs) Handles btn_make.Click
        Me.Close()
        make_order.Show()
    End Sub

    Private Sub grd_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_order.CellContentClick
        Dim num As Integer = grd_order.CurrentCell.RowIndex
        Dim value = grd_order.Rows(num).Cells(0).Value.ToString
        product_id = value
        invoice.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Close()
    End Sub


    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''  mainmenu.Show()
    '  Me.Hide()
    '  End Sub
End Class