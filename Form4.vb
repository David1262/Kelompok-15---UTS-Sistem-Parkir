Public Class Form4
    Public Property TanggalHariText As String
        Get
            Return labelTanggalHari.Text
        End Get
        Set(value As String)
            labelTanggalHari.Text = value
        End Set
    End Property

    Public Property NomorTiketText As String
        Get
            Return labelTiketNo.Text
        End Get
        Set(value As String)
            labelTiketNo.Text = value
        End Set
    End Property

    Public Property PlatNomorText As String
        Get
            Return labelPlatNo.Text
        End Get
        Set(value As String)
            labelPlatNo.Text = value
        End Set
    End Property

    Public Property JenisKendaraanText() As String
        Get
            Return labelGenerateJenisKendaraan.Text
        End Get
        Set(ByVal value As String)
            labelGenerateJenisKendaraan.Text = value
        End Set
    End Property

    Public Property JamMasukText() As String
        Get
            Return labelGenerateJamMasuk.Text
        End Get
        Set(ByVal value As String)
            labelGenerateJamMasuk.Text = value
        End Set
    End Property

    Public Property TarifPerJamText() As String
        Get
            Return labelGenerateTarif.Text
        End Get
        Set(ByVal value As String)
            labelGenerateTarif.Text = value
        End Set
    End Property

    Public Property JamKeluarText() As String
        Get
            Return labelGenerateJamKeluar.Text
        End Get
        Set(ByVal value As String)
            labelGenerateJamKeluar.Text = value
        End Set
    End Property

    Public Property DurasiParkirText() As String
        Get
            Return labelGenerateDurasiParkir.Text
        End Get
        Set(ByVal value As String)
            labelGenerateDurasiParkir.Text = value
        End Set
    End Property

    Private Sub buttonKembali_Click(sender As Object, e As EventArgs) Handles buttonKembali.Click
        Dim Form2 As New Form2
        Form2.Show()
        Me.Close()
    End Sub

    Friend WithEvents buttonCetakKarcisMasuk As Button

    Private Sub buttonCetakKarcisKeluar_Click(sender As Object, e As EventArgs) Handles buttonCetakKarcisKeluar.Click
        MessageBox.Show("Anda Berhasil Cetak!", "Berhasil Mencetak Karcis Keluar!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class