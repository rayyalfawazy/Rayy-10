Public Class Form4
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Selamat Bermain", "Mulai")
        Me.Hide()
        Form5.Show()
    End Sub
End Class