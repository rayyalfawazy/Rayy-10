Public Class Duplikasi
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub
    Private Sub Duplikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Pada permainan ini kamu diminta untuk menyelesaikan" & vbCrLf & "beberapa teka teki untuk keluar dari sekolah Mountland School")
        MessageBox.Show("Untuk melihat jawaban dari teka-teki pertama" & vbCrLf & "klik pada angka 2 judul game")
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MessageBox.Show("A = Hijau Luar Kuning Dalam")
        MessageBox.Show("B = Merah Luar Hijau Dalam")
        MessageBox.Show("C = Hijau Luar Kuning Dalam")
    End Sub
End Class
