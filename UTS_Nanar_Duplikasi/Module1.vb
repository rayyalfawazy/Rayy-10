Module Module1
    Sub CheckbButton(ByRef button1 As Button, ByRef button2 As Button)
        If button2.Text = "" Then
            button2.Text = button1.Text
            button1.Text = ""
        End If
    End Sub

    Sub CheckBenar()
        If Form5.Button1.Text = "1" And
            Form5.Button2.Text = "2" And
            Form5.Button3.Text = "3" And
            Form5.Button4.Text = "4" And
            Form5.Button5.Text = "5" And
            Form5.Button6.Text = "6" And
            Form5.Button7.Text = "7" And
            Form5.Button8.Text = "8" And
            Form5.Button9.Text = "9" And
            Form5.Button10.Text = "10" And
            Form5.Button11.Text = "11" And
            Form5.Button12.Text = "12" And
            Form5.Button13.Text = "13" And
            Form5.Button14.Text = "14" And
            Form5.Button15.Text = "15" And
            Form5.Button16.Text = "" Then
            MsgBox("Di dalam kotak, ditemukan surat yang bertuliskan : " & Environment.NewLine &
                   "[ Biarawati itu memperhatikanku setiap waktu, seakan ingin menerkamku. " & Environment.NewLine &
                   "Aku merasa sangat resah dan ketakutan ] ")
            Duplikasi.Show()
            Form5.Hide()
        End If
    End Sub

    Sub Shuffle()
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop

        Form5.Button1.Text = a(1)
        Form5.Button2.Text = a(2)
        Form5.Button3.Text = a(3)
        Form5.Button4.Text = a(4)
        Form5.Button5.Text = a(5)
        Form5.Button6.Text = a(6)
        Form5.Button7.Text = a(7)
        Form5.Button8.Text = a(8)
        Form5.Button9.Text = a(9)
        Form5.Button10.Text = a(10)
        Form5.Button11.Text = a(11)
        Form5.Button12.Text = a(12)
        Form5.Button13.Text = a(13)
        Form5.Button14.Text = a(14)
        Form5.Button15.Text = a(15)
        Form5.Button16.Text = ""

    End Sub

End Module
