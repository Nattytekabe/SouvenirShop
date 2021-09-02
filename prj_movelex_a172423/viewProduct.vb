Public Class viewProduct

    Private Sub frm_viewProduct_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM PRODUCT WHERE PRODUCT_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        txt_name.Text = table.Rows(0).Item(1)
        txt_price.Text = table.Rows(0).Item(2)
        txt_quantity.Text = table.Rows(0).Item(3)
        cmb_type.Text = table.Rows(0).Item(4)
        cmb_type.Items.Add("Small")
        cmb_type.Items.Add("Medium")
        cmb_type.Items.Add("Large")
        txt_material.Text = table.Rows(0).Item(5)
        txt_battery.Text = table.Rows(0).Item(6)
        txt_created_at.Text = table.Rows(0).Item(8)
        txt_updated_at.Text = table.Rows(0).Item(9)
        pic_product.ImageLocation = "pictures/" + table.Rows(0).Item(7)
        pic_product.SizeMode = PictureBoxSizeMode.StretchImage
        Label1.Text = today

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        product_id = ""
        product.Show()
        Me.Close()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim mysql As String = "SELECT * FROM PRODUCT WHERE PRODUCT_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this product?", MsgBoxStyle.YesNoCancel)
        My.Computer.FileSystem.DeleteFile("pictures/" + table.Rows(0).Item(7))

        If delete_confirmation = MsgBoxResult.Yes Then

            Me.Hide()
            run_sql_command("DELETE FROM PRODUCT WHERE PRODUCT_ID='" & product_id & "'")
            product.Show()
            Me.Close()
            MsgBox("Your product has been deleted!")

        End If

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Me.Refresh()

        Dim checkInput As Boolean = True

        'name
        If String.IsNullOrEmpty(txt_name.Text) Then
            lbl_error_name.Visible = True
            lbl_error_name.Text = "Enter product name!"
            checkInput = False
        Else
            lbl_error_name.Visible = False
        End If

        'price
        If String.IsNullOrEmpty(txt_price.Text) Then
            lbl_error_price.Visible = True
            lbl_error_price.Text = "Enter product price!"
            checkInput = False
        ElseIf IsNumeric(txt_price.Text) = False Then
            lbl_error_price.Visible = True
            lbl_error_price.Text = "Number only!"
            checkInput = False
        Else
            lbl_error_price.Visible = False
        End If

        'quantity
        If String.IsNullOrEmpty(txt_quantity.Text) Then
            lbl_error_quantity.Visible = True
            lbl_error_quantity.Text = "Enter product quantity!"
            checkInput = False
        ElseIf IsNumeric(txt_quantity.Text) = False Then
            lbl_error_quantity.Visible = True
            lbl_error_quantity.Text = "Number only!"
            checkInput = False
        Else
            lbl_error_quantity.Visible = False
        End If

        'material
        If String.IsNullOrEmpty(txt_material.Text) Then
            lbl_error_material.Visible = True
            lbl_error_material.Text = "Enter product material!"
            checkInput = False
        Else
            lbl_error_material.Visible = False
        End If

        'battery
        If String.IsNullOrEmpty(txt_battery.Text) Then
            lbl_error_country.Visible = True
            lbl_error_country.Text = "Enter product country!"
            checkInput = False
        Else
            lbl_error_country.Visible = False
        End If

        'image
        If String.IsNullOrEmpty(lbl_filename_image.Text) Then
            lbl_error_image.Visible = True
            lbl_error_image.Text = "Select product image!"
            checkInput = False
        Else
            lbl_error_image.Visible = False
        End If

        'load table
        Dim mysql As String = "SELECT * FROM PRODUCT WHERE PRODUCT_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        If checkInput = True Then
            Try
                'name
                run_sql_command("UPDATE PRODUCT SET PRODUCT_NAME='" & txt_name.Text & "' WHERE PRODUCT_ID='" & product_id & "'")
                'price
                run_sql_command("UPDATE PRODUCT SET PRODUCT_PRICE='" & txt_price.Text & "' WHERE PRODUCT_ID='" & product_id & "'")
                'quantity
                run_sql_command("UPDATE PRODUCT SET PRODUCT_QUANTITY='" & txt_quantity.Text & "' WHERE PRODUCT_ID='" & product_id & "'")
                'type
                run_sql_command("UPDATE PRODUCT SET PRODUCT_TYPE='" & cmb_type.Text & "' WHERE PRODUCT_ID='" & product_id & "'")
                'material
                run_sql_command("UPDATE PRODUCT SET PRODUCT_MATERIAL='" & txt_material.Text & "' WHERE PRODUCT_ID='" & product_id & "'")
                'battery
                run_sql_command("UPDATE PRODUCT SET PRODUCT_country='" & txt_battery.Text & "' WHERE PRODUCT_ID='" & product_id & "'")
                'updated_at
                run_sql_command("UPDATE PRODUCT SET CREATED_AT='" & today & "' WHERE PRODUCT_ID='" & product_id & "'")
                'created_at
                run_sql_command("UPDATE PRODUCT SET UPDATED_AT='" & txt_created_at.Text & "' WHERE PRODUCT_ID='" & product_id & "'")
                'image
                If (lbl_filename_image.Text = "") Then
                    run_sql_command("UPDATE PRODUCT SET PRODUCT_IMAGE='" & table.Rows(0).Item(7) & "' WHERE PRODUCT_ID='" & product_id & "'")
                Else
                    My.Computer.FileSystem.DeleteFile("pictures/" + table.Rows(0).Item(7))
                    Dim saveImage As New Bitmap(pic_product.Image)
                    saveImage.Save("pictures/" + table.Rows(0).Item(7))
                    saveImage.Dispose()
                    run_sql_command("UPDATE PRODUCT SET PRODUCT_IMAGE='" & table.Rows(0).Item(7) & "' WHERE PRODUCT_ID='" & product_id & "'")
                End If

                Dim reopen As New viewProduct
                Me.Close()
                reopen.Show()
                Beep()
                MsgBox("Your change has been save!")
            Catch ex As Exception
                Dim reopen As New viewProduct
                Me.Close()
                reopen.Show()

                MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim folder As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = folder
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        Try
            lbl_error_image.Visible = False
            pic_product.ImageLocation = OpenFileDialog1.FileName
            pic_product.SizeMode = PictureBoxSizeMode.StretchImage
            lbl_filename_image.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            If String.IsNullOrEmpty(lbl_filename_image.Text) Then
                lbl_error_image.Visible = True
                lbl_error_image.Text = "Please select a image!"
            Else
            End If
        End Try

    End Sub

    Private Sub lbl_error_country_Click(sender As Object, e As EventArgs) Handles lbl_error_country.Click

    End Sub
End Class