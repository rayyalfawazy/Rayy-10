Public Class Form2
    Dim m, a, b, c As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Baiklah Anda Akan Terkurung Selamanya...")
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        m = m + 10
        If m < 1000 Then
            a = Int(1 + Rnd() * 3)
            b = Int(1 + Rnd() * 3)
            c = Int(1 + Rnd() * 3)
            Button1.Text = "..."
            Select Case a
                Case 1
                    PictureBox1.Image = My.Resources.GOYI
                Case 2
                    PictureBox1.Image = My.Resources.ROGI
                Case 3
                    PictureBox1.Image = My.Resources.YORI
            End Select

            Select Case b
                Case 1
                    PictureBox2.Image = My.Resources.GOYI
                Case 2
                    PictureBox2.Image = My.Resources.ROGI
                Case 3
                    PictureBox2.Image = My.Resources.YORI
            End Select

            Select Case c
                Case 1
                    PictureBox3.Image = My.Resources.GOYI
                Case 2
                    PictureBox3.Image = My.Resources.ROGI
                Case 3
                    PictureBox3.Image = My.Resources.YORI
            End Select

        Else
            Timer1.Enabled = False
            Button1.Text = "Spin..."
            m = 0
            If a = b And b = c Then
                MessageBox.Show("Kamu Berhasil Bebas Dari Kurungan Nun")
            Else
                MessageBox.Show("Sayang sekali, kamu gagal! Coba lagi kembali")
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
End Class