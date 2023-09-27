<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.labelInfoKendaraan = New System.Windows.Forms.Label()
        Me.labelNomorTiket = New System.Windows.Forms.Label()
        Me.labelPlatNomor = New System.Windows.Forms.Label()
        Me.labelJamMasuk = New System.Windows.Forms.Label()
        Me.labelJenisKendaraan = New System.Windows.Forms.Label()
        Me.labelJamKeluar = New System.Windows.Forms.Label()
        Me.labelTanggalHari = New System.Windows.Forms.Label()
        Me.labelTiketNo = New System.Windows.Forms.Label()
        Me.labelPlatNo = New System.Windows.Forms.Label()
        Me.labelGenerateJamMasuk = New System.Windows.Forms.Label()
        Me.labelGenerateJenisKendaraan = New System.Windows.Forms.Label()
        Me.labelGenerateJamKeluar = New System.Windows.Forms.Label()
        Me.labelBiaya = New System.Windows.Forms.Label()
        Me.labelDurasiParkir = New System.Windows.Forms.Label()
        Me.labelGenerateTarif = New System.Windows.Forms.Label()
        Me.labelGenerateDurasiParkir = New System.Windows.Forms.Label()
        Me.buttonKembali = New System.Windows.Forms.Button()
        Me.buttonCetakKarcisKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelInfoKendaraan
        '
        Me.labelInfoKendaraan.AutoSize = True
        Me.labelInfoKendaraan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelInfoKendaraan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInfoKendaraan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelInfoKendaraan.Location = New System.Drawing.Point(23, 26)
        Me.labelInfoKendaraan.Name = "labelInfoKendaraan"
        Me.labelInfoKendaraan.Size = New System.Drawing.Size(282, 28)
        Me.labelInfoKendaraan.TabIndex = 5
        Me.labelInfoKendaraan.Text = "Info Kendaraan Keluar:"
        '
        'labelNomorTiket
        '
        Me.labelNomorTiket.AutoSize = True
        Me.labelNomorTiket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelNomorTiket.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNomorTiket.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelNomorTiket.Location = New System.Drawing.Point(23, 86)
        Me.labelNomorTiket.Name = "labelNomorTiket"
        Me.labelNomorTiket.Size = New System.Drawing.Size(162, 28)
        Me.labelNomorTiket.TabIndex = 6
        Me.labelNomorTiket.Text = "Nomor Tiket:"
        '
        'labelPlatNomor
        '
        Me.labelPlatNomor.AutoSize = True
        Me.labelPlatNomor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelPlatNomor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlatNomor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelPlatNomor.Location = New System.Drawing.Point(23, 150)
        Me.labelPlatNomor.Name = "labelPlatNomor"
        Me.labelPlatNomor.Size = New System.Drawing.Size(149, 28)
        Me.labelPlatNomor.TabIndex = 7
        Me.labelPlatNomor.Text = "Plat Nomor:"
        '
        'labelJamMasuk
        '
        Me.labelJamMasuk.AutoSize = True
        Me.labelJamMasuk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelJamMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJamMasuk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelJamMasuk.Location = New System.Drawing.Point(23, 215)
        Me.labelJamMasuk.Name = "labelJamMasuk"
        Me.labelJamMasuk.Size = New System.Drawing.Size(150, 28)
        Me.labelJamMasuk.TabIndex = 8
        Me.labelJamMasuk.Text = "Jam Masuk:"
        '
        'labelJenisKendaraan
        '
        Me.labelJenisKendaraan.AutoSize = True
        Me.labelJenisKendaraan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelJenisKendaraan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJenisKendaraan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelJenisKendaraan.Location = New System.Drawing.Point(23, 277)
        Me.labelJenisKendaraan.Name = "labelJenisKendaraan"
        Me.labelJenisKendaraan.Size = New System.Drawing.Size(216, 28)
        Me.labelJenisKendaraan.TabIndex = 9
        Me.labelJenisKendaraan.Text = "Jenis Kendaraan:"
        '
        'labelJamKeluar
        '
        Me.labelJamKeluar.AutoSize = True
        Me.labelJamKeluar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelJamKeluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJamKeluar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelJamKeluar.Location = New System.Drawing.Point(23, 339)
        Me.labelJamKeluar.Name = "labelJamKeluar"
        Me.labelJamKeluar.Size = New System.Drawing.Size(153, 28)
        Me.labelJamKeluar.TabIndex = 10
        Me.labelJamKeluar.Text = "Jam Keluar:"
        '
        'labelTanggalHari
        '
        Me.labelTanggalHari.AutoSize = True
        Me.labelTanggalHari.BackColor = System.Drawing.Color.OrangeRed
        Me.labelTanggalHari.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTanggalHari.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTanggalHari.Location = New System.Drawing.Point(631, 15)
        Me.labelTanggalHari.Name = "labelTanggalHari"
        Me.labelTanggalHari.Size = New System.Drawing.Size(296, 42)
        Me.labelTanggalHari.TabIndex = 11
        Me.labelTanggalHari.Text = "Tanggal Hari Ini"
        '
        'labelTiketNo
        '
        Me.labelTiketNo.AutoSize = True
        Me.labelTiketNo.BackColor = System.Drawing.Color.Black
        Me.labelTiketNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTiketNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTiketNo.Location = New System.Drawing.Point(191, 86)
        Me.labelTiketNo.Name = "labelTiketNo"
        Me.labelTiketNo.Size = New System.Drawing.Size(222, 28)
        Me.labelTiketNo.TabIndex = 12
        Me.labelTiketNo.Text = "Generate Tiket No"
        '
        'labelPlatNo
        '
        Me.labelPlatNo.AutoSize = True
        Me.labelPlatNo.BackColor = System.Drawing.Color.Black
        Me.labelPlatNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlatNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelPlatNo.Location = New System.Drawing.Point(178, 150)
        Me.labelPlatNo.Name = "labelPlatNo"
        Me.labelPlatNo.Size = New System.Drawing.Size(209, 28)
        Me.labelPlatNo.TabIndex = 13
        Me.labelPlatNo.Text = "Generate Plat No"
        '
        'labelGenerateJamMasuk
        '
        Me.labelGenerateJamMasuk.AutoSize = True
        Me.labelGenerateJamMasuk.BackColor = System.Drawing.Color.Black
        Me.labelGenerateJamMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGenerateJamMasuk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelGenerateJamMasuk.Location = New System.Drawing.Point(179, 215)
        Me.labelGenerateJamMasuk.Name = "labelGenerateJamMasuk"
        Me.labelGenerateJamMasuk.Size = New System.Drawing.Size(256, 28)
        Me.labelGenerateJamMasuk.TabIndex = 14
        Me.labelGenerateJamMasuk.Text = "Generate Jam Masuk"
        '
        'labelGenerateJenisKendaraan
        '
        Me.labelGenerateJenisKendaraan.AutoSize = True
        Me.labelGenerateJenisKendaraan.BackColor = System.Drawing.Color.Black
        Me.labelGenerateJenisKendaraan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGenerateJenisKendaraan.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelGenerateJenisKendaraan.Location = New System.Drawing.Point(245, 277)
        Me.labelGenerateJenisKendaraan.Name = "labelGenerateJenisKendaraan"
        Me.labelGenerateJenisKendaraan.Size = New System.Drawing.Size(322, 28)
        Me.labelGenerateJenisKendaraan.TabIndex = 15
        Me.labelGenerateJenisKendaraan.Text = "Generate Jenis Kendaraan"
        '
        'labelGenerateJamKeluar
        '
        Me.labelGenerateJamKeluar.AutoSize = True
        Me.labelGenerateJamKeluar.BackColor = System.Drawing.Color.Black
        Me.labelGenerateJamKeluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGenerateJamKeluar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelGenerateJamKeluar.Location = New System.Drawing.Point(182, 339)
        Me.labelGenerateJamKeluar.Name = "labelGenerateJamKeluar"
        Me.labelGenerateJamKeluar.Size = New System.Drawing.Size(259, 28)
        Me.labelGenerateJamKeluar.TabIndex = 16
        Me.labelGenerateJamKeluar.Text = "Generate Jam Keluar"
        '
        'labelBiaya
        '
        Me.labelBiaya.AutoSize = True
        Me.labelBiaya.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelBiaya.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBiaya.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelBiaya.Location = New System.Drawing.Point(656, 86)
        Me.labelBiaya.Name = "labelBiaya"
        Me.labelBiaya.Size = New System.Drawing.Size(85, 28)
        Me.labelBiaya.TabIndex = 17
        Me.labelBiaya.Text = "Biaya:"
        '
        'labelDurasiParkir
        '
        Me.labelDurasiParkir.AutoSize = True
        Me.labelDurasiParkir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelDurasiParkir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDurasiParkir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelDurasiParkir.Location = New System.Drawing.Point(656, 251)
        Me.labelDurasiParkir.Name = "labelDurasiParkir"
        Me.labelDurasiParkir.Size = New System.Drawing.Size(176, 28)
        Me.labelDurasiParkir.TabIndex = 18
        Me.labelDurasiParkir.Text = "Durasi Parkir:"
        '
        'labelGenerateTarif
        '
        Me.labelGenerateTarif.AutoSize = True
        Me.labelGenerateTarif.BackColor = System.Drawing.Color.Black
        Me.labelGenerateTarif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGenerateTarif.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelGenerateTarif.Location = New System.Drawing.Point(654, 114)
        Me.labelGenerateTarif.Name = "labelGenerateTarif"
        Me.labelGenerateTarif.Size = New System.Drawing.Size(273, 42)
        Me.labelGenerateTarif.TabIndex = 19
        Me.labelGenerateTarif.Text = "Generate Tarif"
        '
        'labelGenerateDurasiParkir
        '
        Me.labelGenerateDurasiParkir.AutoSize = True
        Me.labelGenerateDurasiParkir.BackColor = System.Drawing.Color.Black
        Me.labelGenerateDurasiParkir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGenerateDurasiParkir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelGenerateDurasiParkir.Location = New System.Drawing.Point(654, 279)
        Me.labelGenerateDurasiParkir.Name = "labelGenerateDurasiParkir"
        Me.labelGenerateDurasiParkir.Size = New System.Drawing.Size(424, 42)
        Me.labelGenerateDurasiParkir.TabIndex = 20
        Me.labelGenerateDurasiParkir.Text = "Generate Durasi Parkir"
        '
        'buttonKembali
        '
        Me.buttonKembali.BackColor = System.Drawing.Color.OrangeRed
        Me.buttonKembali.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonKembali.Location = New System.Drawing.Point(28, 408)
        Me.buttonKembali.Name = "buttonKembali"
        Me.buttonKembali.Size = New System.Drawing.Size(207, 91)
        Me.buttonKembali.TabIndex = 21
        Me.buttonKembali.Text = "Kembali"
        Me.buttonKembali.UseVisualStyleBackColor = False
        '
        'buttonCetakKarcisKeluar
        '
        Me.buttonCetakKarcisKeluar.BackColor = System.Drawing.Color.SpringGreen
        Me.buttonCetakKarcisKeluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCetakKarcisKeluar.Location = New System.Drawing.Point(287, 408)
        Me.buttonCetakKarcisKeluar.Name = "buttonCetakKarcisKeluar"
        Me.buttonCetakKarcisKeluar.Size = New System.Drawing.Size(207, 91)
        Me.buttonCetakKarcisKeluar.TabIndex = 22
        Me.buttonCetakKarcisKeluar.Text = "Cetak Karcis Keluar"
        Me.buttonCetakKarcisKeluar.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1107, 523)
        Me.Controls.Add(Me.buttonCetakKarcisKeluar)
        Me.Controls.Add(Me.buttonKembali)
        Me.Controls.Add(Me.labelGenerateDurasiParkir)
        Me.Controls.Add(Me.labelGenerateTarif)
        Me.Controls.Add(Me.labelDurasiParkir)
        Me.Controls.Add(Me.labelBiaya)
        Me.Controls.Add(Me.labelGenerateJamKeluar)
        Me.Controls.Add(Me.labelGenerateJenisKendaraan)
        Me.Controls.Add(Me.labelGenerateJamMasuk)
        Me.Controls.Add(Me.labelPlatNo)
        Me.Controls.Add(Me.labelTiketNo)
        Me.Controls.Add(Me.labelTanggalHari)
        Me.Controls.Add(Me.labelJamKeluar)
        Me.Controls.Add(Me.labelJenisKendaraan)
        Me.Controls.Add(Me.labelJamMasuk)
        Me.Controls.Add(Me.labelPlatNomor)
        Me.Controls.Add(Me.labelNomorTiket)
        Me.Controls.Add(Me.labelInfoKendaraan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Kendaraan Keluar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelInfoKendaraan As Label
    Friend WithEvents labelNomorTiket As Label
    Friend WithEvents labelPlatNomor As Label
    Friend WithEvents labelJamMasuk As Label
    Friend WithEvents labelJenisKendaraan As Label
    Friend WithEvents labelJamKeluar As Label
    Friend WithEvents labelTanggalHari As Label
    Friend WithEvents labelTiketNo As Label
    Friend WithEvents labelPlatNo As Label
    Friend WithEvents labelGenerateJamMasuk As Label
    Friend WithEvents labelGenerateJenisKendaraan As Label
    Friend WithEvents labelGenerateJamKeluar As Label
    Friend WithEvents labelBiaya As Label
    Friend WithEvents labelDurasiParkir As Label
    Friend WithEvents labelGenerateTarif As Label
    Friend WithEvents labelGenerateDurasiParkir As Label
    Friend WithEvents buttonKembali As Button
    Friend WithEvents buttonCetakKarcisKeluar As Button
End Class
