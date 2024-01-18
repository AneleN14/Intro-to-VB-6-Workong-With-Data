Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String

        Dim Birthyear As Integer
        YourMessage = "Happy birthday! How old are you now"

        MsgBox(YourMessage)
        Birthyear = Val(InputBox("Enter year Of birth"))
        MsgBox("you are " & 2023 - Birthyear & " years old today")

    End Sub
End Class
