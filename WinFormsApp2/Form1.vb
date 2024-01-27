Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "cessy" And txtpassword.Text = "2006" Then
            MsgBox("Login Successfully:)")

        Else
            MsgBox("Error. Plese Try Again:(")
        End If
    End Sub
End Class
