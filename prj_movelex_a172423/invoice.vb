Public Class invoice
    Private Sub frm_invois_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'order
        Dim sql_order As String = "SELECT * FROM ORDERS WHERE ORDER_ID='" & product_id & "'"
        Dim tbl_order As New DataTable
        Dim read_order As New OleDb.OleDbDataAdapter(sql_order, connection)
        read_order.Fill(tbl_order)

        'item
        Dim sql_item As String = "SELECT * FROM ITEM WHERE ORDER_ID='" & product_id & "'"
        Dim tbl_item As New DataTable
        Dim read_item As New OleDb.OleDbDataAdapter(sql_item, connection)
        read_item.Fill(tbl_item)

        'table header
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Name"
        DataGridView1.Columns(1).Name = "Quantity"
        DataGridView1.Columns(2).Name = "Price Per Unit"
        DataGridView1.Columns(3).Name = "Total"

        'column data
        Dim row_total As Integer = tbl_item.Rows.Count
        For i As Integer = 0 To (row_total - 1)
            'product
            Dim sql_product As String = "SELECT * FROM PRODUCT WHERE PRODUCT_ID='" & tbl_item.Rows(i).Item(2) & "'"
            Dim tbl_product As New DataTable
            Dim read_product As New OleDb.OleDbDataAdapter(sql_product, connection)
            read_product.Fill(tbl_product)

            Dim row As String() = New String() {tbl_product.Rows(0).Item("PRODUCT_NAME"), (tbl_item.Rows(i).Item("PRODUCT_TOTAL") / tbl_product.Rows(0).Item("PRODUCT_PRICE")), tbl_product.Rows(0).Item("PRODUCT_PRICE"), tbl_item.Rows(i).Item("PRODUCT_TOTAL")}
            DataGridView1.Rows.Add(row)
        Next

        'all label
        lbl_date.Text = tbl_order.Rows(0).Item("CREATED_AT")
        lbl_id.Text = tbl_order.Rows(0).Item("ORDER_ID")
        lbl.Text = tbl_order.Rows(0).Item("CART_TOTAL")
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        orders.Show()
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub PrintPreviewDialog1_Shown(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub lbl_id_Click(sender As Object, e As EventArgs) Handles lbl_id.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class