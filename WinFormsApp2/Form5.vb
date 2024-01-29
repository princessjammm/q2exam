Imports System.Reflection.Emit

Public Class Form5
    Dim playerPosition As Integer = 1
    Dim isDone As Boolean = False
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button13.Enabled = False
        Label1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button3.Enabled = True
        Button4.Enabled = True
        Button13.Enabled = False
        Label1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Enabled = True
        Button4.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button5.Enabled = True
        Button6.Enabled = True
        Button4.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button5.Enabled = True
        Button6.Enabled = True
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button7.Enabled = True
        Button8.Enabled = True
        Button6.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button7.Enabled = True
        Button8.Enabled = True
        Button6.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button9.Enabled = True
        Button10.Enabled = True
        Button8.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button9.Enabled = True
        Button10.Enabled = True
        Button8.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button11.Enabled = True
        Button12.Enabled = True
        Button10.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button11.Enabled = True
        Button12.Enabled = True
        Button10.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        randomFoot()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button13.Enabled = True
        Button12.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        lastGlas()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button13.Enabled = True
        Button12.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        lastGlas()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label1.Text = "You Won!"
        resetGame()

    End Sub

    Private Sub gameOver()
        isDone = True
        If isDone Then
            Label1.Text = "You Lose!"
            resetGame()
        End If
    End Sub

    Private Sub randomFoot()
        Dim rando As Integer = GetRandom(1, 3)
        If rando = 1 Then
            gameOver()
        Else
            Label1.Text = "👍"
        End If

    End Sub
    Private Sub lastGlas()
        Dim rando As Integer = GetRandom(1, 3)
        If rando = 1 Then
            gameOver()
        Else
            Button14.Enabled = True
        End If

    End Sub

    Private Sub resetGame()
        Button13.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button14.Enabled = False
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

