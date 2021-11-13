Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Tombol 2,5
        CheckbButton(Button1, Button2)
        CheckbButton(Button1, Button5)

        CheckBenar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Tombol 1,6,3
        CheckbButton(Button2, Button1)
        CheckbButton(Button2, Button6)
        CheckbButton(Button2, Button3)

        CheckBenar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Tombol 2,7,4
        CheckbButton(Button3, Button2)
        CheckbButton(Button3, Button7)
        CheckbButton(Button3, Button4)

        CheckBenar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Tombol 3,8
        CheckbButton(Button4, Button3)
        CheckbButton(Button4, Button8)

        CheckBenar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Tombol 1,6,9
        CheckbButton(Button5, Button1)
        CheckbButton(Button5, Button6)
        CheckbButton(Button5, Button9)

        CheckBenar()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Tombol 2,5,7,10
        CheckbButton(Button6, Button2)
        CheckbButton(Button6, Button5)
        CheckbButton(Button6, Button7)
        CheckbButton(Button6, Button10)

        CheckBenar()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Tombol 3,6,8,11
        CheckbButton(Button7, Button3)
        CheckbButton(Button7, Button6)
        CheckbButton(Button7, Button8)
        CheckbButton(Button7, Button11)

        CheckBenar()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Tombol 4,7,12
        CheckbButton(Button8, Button4)
        CheckbButton(Button8, Button7)
        CheckbButton(Button8, Button12)

        CheckBenar()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' Tombol 5,10,13
        CheckbButton(Button9, Button5)
        CheckbButton(Button9, Button10)
        CheckbButton(Button9, Button13)

        CheckBenar()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Tombol 6,9,11,14
        CheckbButton(Button10, Button6)
        CheckbButton(Button10, Button9)
        CheckbButton(Button10, Button11)
        CheckbButton(Button10, Button14)

        CheckBenar()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' Tombol 7,10,12,15
        CheckbButton(Button11, Button7)
        CheckbButton(Button11, Button10)
        CheckbButton(Button11, Button12)
        CheckbButton(Button11, Button15)

        CheckBenar()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ' Tombol 8,11,16
        CheckbButton(Button12, Button8)
        CheckbButton(Button12, Button11)
        CheckbButton(Button12, Button16)

        CheckBenar()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ' Tombol 9,14
        CheckbButton(Button13, Button9)
        CheckbButton(Button13, Button14)

        CheckBenar()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ' Tombol 10,13,15
        CheckbButton(Button14, Button10)
        CheckbButton(Button14, Button13)
        CheckbButton(Button14, Button15)

        CheckBenar()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ' Tombol 11,14,16
        CheckbButton(Button15, Button11)
        CheckbButton(Button15, Button14)
        CheckbButton(Button15, Button16)

        CheckBenar()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ' Tombol 12,15
        CheckbButton(Button16, Button12)
        CheckbButton(Button16, Button15)

        CheckBenar()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Shuffle()
    End Sub
End Class