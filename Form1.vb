Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tgl_sekarang As Date
        Dim tgl_lahir As Date

        tgl_sekarang = Now.Date
        tgl_lahir = SettingTime.Value

        Dim usia_tahun As Integer
        Dim usia_bulan As Integer
        Dim usia_hari As Integer
        Dim usia_jam As Integer
        usia_tahun = tgl_sekarang.Year - tgl_lahir.Year
        usia_bulan = tgl_sekarang.Month - tgl_lahir.Month
        usia_hari = tgl_lahir.Day - tgl_sekarang.Day
        usia_jam = tgl_sekarang.Day
        If usia_bulan < 0 Then
            usia_bulan = usia_bulan + 12
            usia_tahun = usia_tahun - 1
            usia_hari = usia_hari + 365

        End If
        If tgl_lahir.Year < tgl_sekarang.Year Then
            usia_bulan = tgl_lahir.Month - tgl_sekarang.Month
            usia_hari = tgl_lahir.Day - tgl_sekarang.Day

        End If
        If tgl_lahir.Month < tgl_sekarang.Month Then
            usia_hari = tgl_lahir.Day - tgl_sekarang.Day

        End If

        Select Case True
            Case usia_bulan = 1 And usia_tahun = 0 And usia_hari < 31
                usia_bulan = 0
        End Select
        Dim hasil_usia As String
        hasil_usia = $"Nama saya :  {TextBox1.Text}
                       Tanggal lahir : {tgl_lahir}
                       Saat ini kamu berusia : {usia_tahun} Tahun {usia_bulan} Bulan {usia_hari} Hari"
        Result.Text = hasil_usia
    End Sub
End Class
