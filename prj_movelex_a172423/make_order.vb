Imports System.Data.OleDb

Public Class make_order
    Private Sub frm_make_order_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'all table
        Dim mysql1 As String = "SELECT * FROM CUSTOMER"
        Dim mysql2 As String = "SELECT * FROM STAFF"
        Dim mysql3 As String = "SELECT * FROM PRODUCT"
        Dim table1 As New DataTable
        Dim table2 As New DataTable
        Dim table3 As New DataTable
        Dim reader1 As New OleDb.OleDbDataAdapter(mysql1, connection)
        Dim reader2 As New OleDb.OleDbDataAdapter(mysql2, connection)
        Dim reader3 As New OleDb.OleDbDataAdapter(mysql3, connection)
        reader1.Fill(table1)
        reader2.Fill(table2)
        reader3.Fill(table3)

        'Customer
        cmb_customer.DataSource = table1
        cmb_customer.DisplayMember = "CUSTOMER_NAME"

        'Staff
        cmb_staff.DataSource = table2
        cmb_staff.DisplayMember = "STAFF_NAME"

        'Product
        cmb_product.DataSource = table3
        cmb_product.DisplayMember = "PRODUCT_NAME"

        'total
        txt_total.Text = 0
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim mysql As String = "SELECT * FROM PRODUCT WHERE PRODUCT_NAME='" & cmb_product.Text & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        'check
        Dim check As Boolean = True
        If txt_quantity.Text = String.Empty Then
            lbl_error_quantity.Text = "Please fill quantity"
            lbl_error_quantity.Visible = True
            check = False
        ElseIf IsNumeric(txt_quantity.Text) = False Then
            check = False
            lbl_error_quantity.Text = "Number only"
            lbl_error_quantity.Visible = True
        ElseIf IsNumeric(txt_quantity.Text) = True Then
            If txt_quantity.Text > table.Rows(0).Item("PRODUCT_QUANTITY") Then
                check = False
                lbl_error_quantity.Text = "The quantity is more than stock"
                lbl_error_quantity.Visible = True
            ElseIf txt_quantity.Text = 0 Then
                check = False
                lbl_error_quantity.Text = "Please put more than 0"
                lbl_error_quantity.Visible = True
            End If
        Else
            lbl_error_quantity.Visible = False
            check = True
        End If

        If check = True Then
            lbl_error_quantity.Visible = False
            Dim total As Integer = table.Rows(0).Item("PRODUCT_PRICE") * txt_quantity.Text
            Dim row As String() = New String() {table.Rows(0).Item("PRODUCT_ID"), cmb_product.Text, txt_quantity.Text, total}
            dg_cart.Rows.Add(row)
            txt_total.Text += total
        Else
            lbl_error_quantity.Visible = True
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        dg_cart.Rows.Clear()
        txt_total.Text = 0
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        orders.Show()
        Me.Hide()
    End Sub

    Private Sub btn_make_Click(sender As Object, e As EventArgs) Handles btn_make.Click
        'row in dataGridView
        Dim row As Integer = dg_cart.Rows.Count
        Label4.Text = row

        'All specific data
        Dim customer As String = "SELECT * FROM CUSTOMER WHERE CUSTOMER_NAME='" & cmb_customer.Text & "'"
        Dim staff As String = "SELECT * FROM STAFF WHERE STAFF_NAME='" & cmb_staff.Text & "'"
        Dim tbl_customer As New DataTable
        Dim tbl_staff As New DataTable
        Dim read_customer As New OleDb.OleDbDataAdapter(customer, connection)
        Dim read_staff As New OleDb.OleDbDataAdapter(staff, connection)
        read_customer.Fill(tbl_customer)
        read_staff.Fill(tbl_staff)

        'order id
        Dim new_id As Date = Now
        Dim order_id As String = "ORD" + Format(new_id, "yyyyMMddHHmmss").ToString

        'create order
        Try
            Dim order As String = "INSERT INTO ORDERS VALUES ('" & order_id & "','" & tbl_customer.Rows(0).Item("CUSTOMER_ID") & "','" & tbl_staff.Rows(0).Item("STAFF_ID") & "','" & txt_total.Text & "','" & today & "','" & today & "')"
            Dim save_order As New OleDb.OleDbCommand(order, myconnection2)

            'close again if error accour
            save_order.Connection.Close()
            save_order.Connection.Open()
            save_order.ExecuteNonQuery()
            save_order.Connection.Close()
        Catch ex As Exception
            MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
        End Try

        'loop product in datagridview
        For i As Integer = 0 To (row - 1)
            Try
                'item id
                Dim dateNow As Date = Now
                Dim item_id As String = "ITM" + Format(dateNow, "yyyyMMddHHmmssFFF").ToString

                'create item
                Dim item As String = "INSERT INTO ITEM VALUES ('" & item_id & "','" & order_id & "','" & dg_cart.Rows(i).Cells(0).Value & "','" & dg_cart.Rows(i).Cells(3).Value & "','" & today & "','" & today & "')"
                Dim save_item As New OleDb.OleDbCommand(item, myconnection2)

                'close again if error accour
                save_item.Connection.Close()
                save_item.Connection.Open()
                save_item.ExecuteNonQuery()
                save_item.Connection.Close()
            Catch ex As Exception
                MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
            End Try
        Next

        Beep()
        MsgBox("Success!")
    End Sub

    Private Sub dg_cart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_cart.CellContentClick

    End Sub

    Private Sub txt_quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_quantity.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class