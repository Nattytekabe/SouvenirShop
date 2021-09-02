Public Class createStaff
    Private Sub frm_createStaff_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        staff.Show()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Me.Refresh()

        Dim checkInput As Boolean = True

        'name
        If String.IsNullOrEmpty(txt_name.Text) Then
            lbl_error_name.Visible = True
            lbl_error_name.Text = "Enter staff name!"
            checkInput = False
        Else
            lbl_error_name.Visible = False
        End If

        'id
        If String.IsNullOrEmpty(txt_id.Text) Then
            lbl_error_id.Visible = True
            lbl_error_id.Text = "Enter staff id!"
            checkInput = False
        ElseIf IsNumeric(txt_id.Text) = False Then
            lbl_error_id.Visible = True
            lbl_error_id.Text = "Number only!"
            checkInput = False
        Else
            lbl_error_id.Visible = False
        End If

        'checked
        Dim gender As String = ""
        If rbt_male.Checked = True Then
            gender = "MALE"
            lbl_error_gender.Visible = False
        ElseIf rbt_female.Checked = True Then
            gender = "FEMALE"
            lbl_error_gender.Visible = False
        Else
            lbl_error_gender.Visible = True
            lbl_error_gender.Text = "Select one gender!"
            checkInput = False
        End If

        If checkInput = True Then
            Try
                Dim mysql As String = "INSERT INTO STAFF VALUES ('" & "STAFF" + txt_id.Text & "','" & txt_name.Text & "','" & gender & "','" & today & "','" & today & "' )"
                Dim save As New OleDb.OleDbCommand(mysql, myconnection2)

                'close again if error accour
                save.Connection.Close()
                save.Connection.Open()
                save.ExecuteNonQuery()
                save.Connection.Close()

                Me.Close()
                staff.Show()

                Beep()
                MsgBox("Your new staff has been created!")
            Catch ex As Exception
                Dim reopen As New createStaff
                Me.Close()
                reopen.Show()

                MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Hide()
    End Sub
End Class