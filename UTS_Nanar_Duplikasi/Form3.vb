Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Baiklah Anda Akan Terkurung Selamanya...", "Keluar Game")
        Me.Hide()
        Duplikasi.Show()
    End Sub
End Class