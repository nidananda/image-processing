Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "Training"
        OpenFileDialog1.Title = "Input"
        OpenFileDialog1.Filter = "PNG|*.PNG|BMP|*.BMP"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Warning")
            Exit Sub
        End If
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim x, y, warna As Integer
        For x = 0 To picture.Width - 1
            For y = 0 To picture.Height - 1
                Dim p = picture.GetPixel(x, y)
                warna = CInt((p.R * 1 + p.G + p.B * 1) / 3)
                picture.SetPixel(x, y, Color.FromArgb(warna, warna, warna))

            Next y
        Next x
        PictureBox2.Image = picture
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi Variabel bertipe bitmap'
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra'
        Dim baris, kolom As Integer 'Variabel Perulangan/looping'
        Dim Merah As Integer 'Menampung intensitas warna R'
        For baris = 1 To gambar.Width - 1
            For kolom = 1 To gambar.Height - 1
                Merah = gambar.GetPixel(baris, kolom).R
                gambar.SetPixel(baris, kolom, Color.FromArgb(Merah, 0, 0))
            Next
        Next
        PictureBox2.Image = gambar
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi Variabel bertipe bitmap'
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra'
        Dim baris, kolom As Integer 'Variabel Perulangan/looping'
        Dim Hijau As Integer 'Menampung intensitas warna G'
        For baris = 1 To gambar.Width - 1
            For kolom = 1 To gambar.Height - 1
                Hijau = gambar.GetPixel(baris, kolom).G
                gambar.SetPixel(baris, kolom, Color.FromArgb(0, Hijau, 0))
            Next
        Next
        PictureBox2.Image = gambar
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim gambar As New Bitmap(PictureBox1.Image) 'Deklarasi Variabel bertipe bitmap'
        PictureBox2.Image = gambar 'Meletakkan hasil pengolahan citra'
        Dim baris, kolom As Integer 'Variabel Perulangan/looping'
        Dim Biru As Integer 'Menampung intensitas warna B'
        For baris = 1 To gambar.Width - 1
            For kolom = 1 To gambar.Height - 1
                Biru = gambar.GetPixel(baris, kolom).B
                gambar.SetPixel(baris, kolom, Color.FromArgb(0, 0, Biru))
            Next
        Next
        PictureBox2.Image = gambar
    End Sub

End Class
