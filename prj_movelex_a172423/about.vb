Public Class about
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://nattytekabe.webflow.io")
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class