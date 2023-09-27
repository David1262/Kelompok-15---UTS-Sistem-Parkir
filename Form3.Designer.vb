<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.labelTanggalHari = New System.Windows.Forms.Label()
        Me.labelPerhatian = New System.Windows.Forms.Label()
        Me.labelPerhatian2 = New System.Windows.Forms.Label()
        Me.labelPerhatian3 = New System.Windows.Forms.Label()
        Me.labelInfoKendaraan = New System.Windows.Forms.Label()
        Me.labelNomorTiket = New System.Windows.Forms.Label()
        Me.labelPlatNomor = New System.Windows.Forms.Label()
        Me.labelJamMasuk = New System.Windows.Forms.Label()
        Me.labelJenisKendaraan = New System.Windows.Forms.Label()
        Me.labelTiketNo = New System.Windows.Forms.Label()
        Me.labelPlatNo = New System.Windows.Forms.Label()
        Me.labelGenerateJamMasuk = New System.Windows.Forms.Label()
        Me.labelGenerateJenisKendaraan = New System.Windows.Forms.Label()
        Me.buttonKembali = New System.Windows.Forms.Button()
        Me.buttonCetakKarcisMasuk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelTanggalHari
        '
        Me.labelTanggalHari.AutoSize = True
        Me.labelTanggalHari.BackColor = System.Drawing.Color.OrangeRed
        Me.labelTanggalHari.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTanggalHari.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTanggalHari.Location = New System.Drawing.Point(462, 17)
        Me.labelTanggalHari.Name = "labelTanggalHari"
        Me.labelTanggalHari.Size = New System.Drawing.Size(296, 42)
        Me.labelTanggalHari.TabIndex = 0
        Me.labelTanggalHari.Text = "Tanggal Hari Ini"
        '
        'labelPerhatian
        '
        Me.labelPerhatian.AutoSize = True
        Me.labelPerhatian.BackColor = System.Drawing.Color.Transparent
        Me.labelPerhatian.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPerhatian.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelPerhatian.Location = New System.Drawing.Point(633, 339)
        Me.labelPerhatian.Name = "labelPerhatian"
        Me.labelPerhatian.Size = New System.Drawing.Size(200, 42)
        Me.labelPerhatian.TabIndex = 1
        Me.labelPerhatian.Text = "Perhatian!"
        '
        'labelPerhatian2
        '
        Me.labelPerhatian2.AutoSize = True
        Me.labelPerhatian2.BackColor = System.Drawing.Color.Transparent
        Me.labelPerhatian2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPerhatian2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelPerhatian2.Location = New System.Drawing.Point(560, 390)
        Me.labelPerhatian2.Name = "labelPerhatian2"
        Me.labelPerhatian2.Size = New System.Drawing.Size(332, 23)
        Me.labelPerhatian2.TabIndex = 2
        Me.labelPerhatian2.Text = "Simpan Tiket Masuk Dengan Baik"
        '
        'labelPerhatian3
        '
        Me.labelPerhatian3.AutoSize = True
        Me.labelPerhatian3.BackColor = System.Drawing.Color.Transparent
        Me.labelPerhatian3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPerhatian3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelPerhatian3.Location = New System.Drawing.Point(526, 425)
        Me.labelPerhatian3.Name = "labelPerhatian3"
        Me.labelPerhatian3.Size = New System.Drawing.Size(403, 23)
        Me.labelPerhatian3.TabIndex = 3
        Me.labelPerhatian3.Text = "Kehilangan Tiket Akan Dikenakan Denda"
        '
        'labelInfoKendaraan
        '
        Me.labelInfoKendaraan.AutoSize = True
        Me.labelInfoKendaraan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelInfoKendaraan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInfoKendaraan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelInfoKendaraan.Location = New System.Drawing.Point(23, 28)
        Me.labelInfoKendaraan.Name = "labelInfoKendaraan"
        Me.labelInfoKendaraan.Size = New System.Drawing.Size(279, 28)
        Me.labelInfoKendaraan.TabIndex = 4
        Me.labelInfoKendaraan.Text = "Info Kendaraan Masuk:"
        '
        'labelNomorTiket
        '
        Me.labelNomorTiket.AutoSize = True
        Me.labelNomorTiket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelNomorTiket.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNomorTiket.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelNomorTiket.Location = New System.Drawing.Point(23, 90)
        Me.labelNomorTiket.Name = "labelNomorTiket"
        Me.labelNomorTiket.Size = New System.Drawing.Size(162, 28)
        Me.labelNomorTiket.TabIndex = 5
        Me.labelNomorTiket.Text = "Nomor Tiket:"
        '
        'labelPlatNomor
        '
        Me.labelPlatNomor.AutoSize = True
        Me.labelPlatNomor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelPlatNomor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlatNomor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelPlatNomor.Location = New System.Drawing.Point(23, 160)
        Me.labelPlatNomor.Name = "labelPlatNomor"
        Me.labelPlatNomor.Size = New System.Drawing.Size(149, 28)
        Me.labelPlatNomor.TabIndex = 6
        Me.labelPlatNomor.Text = "Plat Nomor:"
        '
        'labelJamMasuk
        '
        Me.labelJamMasuk.AutoSize = True
        Me.labelJamMasuk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelJamMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJamMasuk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelJamMasuk.Location = New System.Drawing.Point(23, 230)
        Me.labelJamMasuk.Name = "labelJamMasuk"
        Me.labelJamMasuk.Size = New System.Drawing.Size(150, 28)
        Me.labelJamMasuk.TabIndex = 7
        Me.labelJamMasuk.Text = "Jam Masuk:"
        '
        'labelJenisKendaraan
        '
        Me.labelJenisKendaraan.AutoSize = True
        Me.labelJenisKendaraan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelJenisKendaraan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJenisKendaraan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelJenisKendaraan.Location = New System.Drawing.Point(23, 296)
        Me.labelJenisKendaraan.Name = "labelJenisKendaraan"
        Me.labelJenisKendaraan.Size = New System.Drawing.Size(216, 28)
        Me.labelJenisKendaraan.TabIndex = 8
        Me.labelJenisKendaraan.Text = "Jenis Kendaraan:"
        '
        'labelTiketNo
        '
        Me.labelTiketNo.AutoSize = True
        Me.labelTiketNo.BackColor = System.Drawing.Color.Black
        Me.labelTiketNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTiketNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTiketNo.Location = New System.Drawing.Point(191, 90)
        Me.labelTiketNo.Name = "labelTiketNo"
        Me.labelTiketNo.Size = New System.Drawing.Size(222, 28)
        Me.labelTiketNo.TabIndex = 9
        Me.labelTiketNo.Text = "Generate Tiket No"
        '
        'labelPlatNo
        '
        Me.labelPlatNo.AutoSize = True
        Me.labelPlatNo.BackColor = System.Drawing.Color.Black
        Me.labelPlatNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlatNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelPlatNo.Location = New System.Drawing.Point(178, 160)
        Me.labelPlatNo.Name = "labelPlatNo"
        Me.labelPlatNo.Size = New System.Drawing.Size(209, 28)
        Me.labelPlatNo.TabIndex = 10
        Me.labelPlatNo.Text = "Generate Plat No"
        '
        'labelGenerateJamMasuk
        '
        Me.labelGenerateJamMasuk.AutoSize = True
        Me.labelGenerateJamMasuk.BackColor = System.Drawing.Color.Black
        Me.labelGenerateJamMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGenerateJamMasuk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelGenerateJamMasuk.Location = New System.Drawing.Point(179, 230)
        Me.labelGenerateJamMasuk.Name = "labelGenerateJamMasuk"
        Me.labelGenerateJamMasuk.Size = New System.Drawing.Size(256, 28)
        Me.labelGenerateJamMasuk.TabIndex = 11
        Me.labelGenerateJamMasuk.Text = "Generate Jam Masuk"
        '
        'labelGenerateJenisKendaraan
        '
        Me.labelGenerateJenisKendaraan.AutoSize = True
        Me.labelGenerateJenisKendaraan.BackColor = System.Drawing.Color.Black
        Me.labelGenerateJenisKendaraan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGenerateJenisKendaraan.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelGenerateJenisKendaraan.Location = New System.Drawing.Point(245, 296)
        Me.labelGenerateJenisKendaraan.Name = "labelGenerateJenisKendaraan"
        Me.labelGenerateJenisKendaraan.Size = New System.Drawing.Size(322, 28)
        Me.labelGenerateJenisKendaraan.TabIndex = 12
        Me.labelGenerateJenisKendaraan.Text = "Generate Jenis Kendaraan"
        '
        'buttonKembali
        '
        Me.buttonKembali.BackColor = System.Drawing.Color.OrangeRed
        Me.buttonKembali.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonKembali.Location = New System.Drawing.Point(28, 380)
        Me.buttonKembali.Name = "buttonKembali"
        Me.buttonKembali.Size = New System.Drawing.Size(207, 91)
        Me.buttonKembali.TabIndex = 13
        Me.buttonKembali.Text = "Kembali"
        Me.buttonKembali.UseVisualStyleBackColor = False
        '
        'buttonCetakKarcisMasuk
        '
        Me.buttonCetakKarcisMasuk.BackColor = System.Drawing.Color.SpringGreen
        Me.buttonCetakKarcisMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCetakKarcisMasuk.Location = New System.Drawing.Point(284, 380)
        Me.buttonCetakKarcisMasuk.Name = "buttonCetakKarcisMasuk"
        Me.buttonCetakKarcisMasuk.Size = New System.Drawing.Size(207, 91)
        Me.buttonCetakKarcisMasuk.TabIndex = 15
        Me.buttonCetakKarcisMasuk.Text = "Cetak Karcis Masuk"
        Me.buttonCetakKarcisMasuk.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(951, 492)
        Me.Controls.Add(Me.buttonCetakKarcisMasuk)
        Me.Controls.Add(Me.buttonKembali)
        Me.Controls.Add(Me.labelGenerateJenisKendaraan)
        Me.Controls.Add(Me.labelGenerateJamMasuk)
        Me.Controls.Add(Me.labelPlatNo)
        Me.Controls.Add(Me.labelTiketNo)
        Me.Controls.Add(Me.labelJenisKendaraan)
        Me.Controls.Add(Me.labelJamMasuk)
        Me.Controls.Add(Me.labelPlatNomor)
        Me.Controls.Add(Me.labelNomorTiket)
        Me.Controls.Add(Me.labelInfoKendaraan)
        Me.Controls.Add(Me.labelPerhatian3)
        Me.Controls.Add(Me.labelPerhatian2)
        Me.Controls.Add(Me.labelPerhatian)
        Me.Controls.Add(Me.labelTanggalHari)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Kendaraan Masuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTanggalHari As Label
    Friend WithEvents labelPerhatian As Label
    Friend WithEvents labelPerhatian2 As Label
    Friend WithEvents labelPerhatian3 As Label
    Friend WithEvents labelInfoKendaraan As Label
    Friend WithEvents labelNomorTiket As Label
    Friend WithEvents labelPlatNomor As Label
    Friend WithEvents labelJamMasuk As Label
    Friend WithEvents labelJenisKendaraan As Label
    Friend WithEvents labelTiketNo As Label
    Friend WithEvents labelPlatNo As Label
    Friend WithEvents labelGenerateJamMasuk As Label
    Friend WithEvents labelGenerateJenisKendaraan As Label
    Friend WithEvents buttonKembali As Button

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

    Private Sub buttonKembali_Click(sender As Object, e As EventArgs) Handles buttonKembali.Click
        Dim Form2 As New Form2
        Form2.Show()
        Me.Close()
    End Sub

    Friend WithEvents buttonCetakKarcisMasuk As Button

    Private Sub buttonCetakKarcisMasuk_Click(sender As Object, e As EventArgs) Handles buttonCetakKarcisMasuk.Click
        MessageBox.Show("Anda Berhasil Cetak!", "Berhasil Mencetak Karcis Masuk!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class