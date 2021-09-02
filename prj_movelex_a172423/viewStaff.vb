Public Class viewStaff
    Private Sub frm_viewStaff_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM STAFF WHERE STAFF_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        txt_name.Text = table.Rows(0).Item(1)
        txt_id.Text = table.Rows(0).Item(0)
        If table.Rows(0).Item(2) = "MALE" Then
            rbt_male.Checked = True
        Else
            rbt_female.Checked = True
        End If
        txt_created_at.Text = table.Rows(0).Item(3)
        txt_updated_at.Text = table.Rows(0).Item(4)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        staff.Show()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim mysql As String = "SELECT * FROM STAFF WHERE STAFF_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this staff?", MsgBoxStyle.YesNoCancel)

        If delete_confirmation = MsgBoxResult.Yes Then

            Me.Hide()
            run_sql_command("DELETE FROM STAFF WHERE STAFF_ID='" & product_id & "'")
            staff.Show()
            Me.Close()
            MsgBox("Your staff has been deleted!")

        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Me.Refresh()

        Dim checkInput As Boolean = True

        'name
        If String.IsNullOrEmpty(txt_name.Text) Then
            lbl_error_name.Visible = True
            lbl_error_name.Text = "Enter customer name!"
            checkInput = False
        Else
            lbl_error_name.Visible = False
        End If

        'gender
        Dim gender As String = ""
        If rbt_female.Checked = True Then
            gender = "FEMALE"
        Else
            gender = "MALE"
        End If

        If checkInput = True Then
            Try
                'name
                run_sql_command("UPDATE STAFF SET STAFF_NAME='" & txt_name.Text & "' WHERE STAFF_ID='" & product_id & "'")
                'id
                run_sql_command("UPDATE STAFF SET STAFF_ID='" & txt_id.Text & "' WHERE STAFF_ID='" & product_id & "'")
                'gender
                run_sql_command("UPDATE STAFF SET STAFF_GENDER='" & gender & "' WHERE STAFF_ID='" & product_id & "'")
                'updated_at
                run_sql_command("UPDATE STAFF SET UPDATED_AT='" & today & "' WHERE STAFF_ID='" & product_id & "'")
                'created_at
                run_sql_command("UPDATE STAFF SET CREATED_AT='" & txt_created_at.Text & "' WHERE STAFF_ID='" & product_id & "'")

                Dim reopen As New viewStaff
                Me.Close()
                reopen.Show()
                Beep()
                MsgBox("Your change has been save!")
            Catch ex As Exception
                Dim reopen As New viewStaff
                Me.Close()
                reopen.Show()

                MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
            End Try
        End If
    End Sub
End Class