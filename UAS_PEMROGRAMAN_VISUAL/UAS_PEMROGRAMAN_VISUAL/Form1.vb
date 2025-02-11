Imports System.IO

Public Class Form1
    ' Simpan file di direktori aplikasi agar lebih mudah ditemukan
    Private filePath As String = Path.Combine(Application.StartupPath, "history.txt")

    ' Prosedur untuk menyimpan riwayat perhitungan ke file
    Private Sub SimpanHistory(hasil As String)
        Try
            Using writer As StreamWriter = File.AppendText(filePath)
                writer.WriteLine(hasil)
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Prosedur untuk membaca riwayat perhitungan dari file dan menampilkannya di TextBox
    Private Sub BacaHistory()
        Try
            txtHistory.Clear() ' Bersihkan TextBox sebelum menampilkan history
            If File.Exists(filePath) Then
                Dim historyText As String = File.ReadAllText(filePath)
                If historyText.Trim() = "" Then
                    MessageBox.Show("Riwayat masih kosong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtHistory.Text = historyText
                End If
            Else
                MessageBox.Show("File history belum ada. Lakukan perhitungan dulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membaca history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Tombol untuk membaca history dari file
    Private Sub btnBacaHistory_Click(sender As Object, e As EventArgs) Handles btnBacaHistory.Click
        BacaHistory()
    End Sub

    ' Tombol untuk menghitung
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim angka1, angka2, hasil As Double
        Dim operasi As String = cmbOperasi.Text

        If Double.TryParse(txtAngka1.Text, angka1) AndAlso Double.TryParse(txtAngka2.Text, angka2) Then
            Select Case operasi
                Case "+"
                    hasil = angka1 + angka2
                Case "-"
                    hasil = angka1 - angka2
                Case "*"
                    hasil = angka1 * angka2
                Case "/"
                    If angka2 <> 0 Then
                        hasil = angka1 / angka2
                    Else
                        MessageBox.Show("Tidak bisa dibagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Case Else
                    MessageBox.Show("Pilih operasi yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
            End Select

            ' Menampilkan hasil di Label
            lblHasil.Text = "Hasil: " & hasil.ToString()

            ' Simpan history
            Dim hasilString As String = angka1 & " " & operasi & " " & angka2 & " = " & hasil
            SimpanHistory(hasilString)
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
