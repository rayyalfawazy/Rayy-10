Public Class Form2
    Dim a, b, c As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("KAMU TERKURUNG DI DALAM PENJARA NUN...." & vbCrLf & "Buka kunci dengan mencari sandi warna" & vbCrLf & "yang terdapat pada tombol [bantuan] halaman utama", "Bantuan")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Baiklah Anda Akan Terkurung Selamanya...", "Keluar Game")
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        Me.Hide()
        Duplikasi.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If a = 1 And b = 2 And c = 1 Then
            MessageBox.Show("Kamu Berhasil Membuka Kunci!", "Berhasil!")
            Me.Hide()
            Duplikasi.Show()
        Else
            MessageBox.Show("Kamu Gagal, Coba Lagi! Tekan ? untuk melihat bantuan", "Gagal!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles prev_b.Click
        b = b - 1
        If b < 1 Then
            b = 3
        End If
        If b = 1 Then
            PictureBox2.Image = My.Resources.GOYI
        ElseIf b = 2 Then
            PictureBox2.Image = My.Resources.ROGI
        ElseIf b = 3 Then
            PictureBox2.Image = My.Resources.YORI
        End If
    End Sub

    Private Sub next_b_Click(sender As Object, e As EventArgs) Handles next_b.Click
        b = b + 1
        If b > 3 Then
            b = 1
        End If
        If b = 1 Then
            PictureBox2.Image = My.Resources.GOYI
        ElseIf b = 2 Then
            PictureBox2.Image = My.Resources.ROGI
        ElseIf b = 3 Then
            PictureBox2.Image = My.Resources.YORI
        End If
    End Sub

    Private Sub prev_c_Click(sender As Object, e As EventArgs) Handles prev_c.Click
        c = c - 1
        If c < c Then
            c = 3
        End If
        If c = 1 Then
            PictureBox3.Image = My.Resources.GOYI
        ElseIf c = 2 Then
            PictureBox3.Image = My.Resources.ROGI
        ElseIf c = 3 Then
            PictureBox3.Image = My.Resources.YORI
        End If
    End Sub

    Private Sub next_c_Click(sender As Object, e As EventArgs) Handles next_c.Click
        c = c + 1
        If c > 3 Then
            c = 1
        End If
        If c = 1 Then
            PictureBox3.Image = My.Resources.GOYI
        ElseIf c = 2 Then
            PictureBox3.Image = My.Resources.ROGI
        ElseIf c = 3 Then
            PictureBox3.Image = My.Resources.YORI
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles next_a.Click
        a = a + 1
        If a > 3 Then
            a = 1
        End If
        If a = 1 Then
            PictureBox1.Image = My.Resources.GOYI
        ElseIf a = 2 Then
            PictureBox1.Image = My.Resources.ROGI
        ElseIf a = 3 Then
            PictureBox1.Image = My.Resources.YORI
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles prev_a.Click
        a = a - 1
        If a < 1 Then
            a = 3
        End If
        If a = 1 Then
            PictureBox1.Image = My.Resources.GOYI
        ElseIf a = 2 Then
            PictureBox1.Image = My.Resources.ROGI
        ElseIf a = 3 Then
            PictureBox1.Image = My.Resources.YORI
        End If
    End Sub
End Class