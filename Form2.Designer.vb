<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.labelParkingSystem = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.textboxDurasiParkir = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.textboxPlatNomor = New System.Windows.Forms.TextBox()
        Me.textboxNomorTiket = New System.Windows.Forms.TextBox()
        Me.labelDurasiParkir = New System.Windows.Forms.Label()
        Me.labelJamKeluar = New System.Windows.Forms.Label()
        Me.labelTarif = New System.Windows.Forms.Label()
        Me.labelJamMasuk = New System.Windows.Forms.Label()
        Me.labelJenisKendaraan = New System.Windows.Forms.Label()
        Me.labelPlatNomor = New System.Windows.Forms.Label()
        Me.labelNomorTiket = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.labelTanggal = New System.Windows.Forms.Label()
        Me.labelInformasi = New System.Windows.Forms.Label()
        Me.buttonKendaraanMasuk = New System.Windows.Forms.Button()
        Me.buttonKendaraanKeluar = New System.Windows.Forms.Button()
        Me.buttonLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelParkingSystem
        '
        Me.labelParkingSystem.AutoSize = True
        Me.labelParkingSystem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelParkingSystem.Location = New System.Drawing.Point(578, 24)
        Me.labelParkingSystem.Name = "labelParkingSystem"
        Me.labelParkingSystem.Size = New System.Drawing.Size(199, 18)
        Me.labelParkingSystem.TabIndex = 0
        Me.labelParkingSystem.Text = "Selamat Datang, Admin!"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.Controls.Add(Me.textboxDurasiParkir)
        Me.Panel1.Controls.Add(Me.DateTimePicker3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.textboxPlatNomor)
        Me.Panel1.Controls.Add(Me.textboxNomorTiket)
        Me.Panel1.Controls.Add(Me.labelDurasiParkir)
        Me.Panel1.Controls.Add(Me.labelJamKeluar)
        Me.Panel1.Controls.Add(Me.labelTarif)
        Me.Panel1.Controls.Add(Me.labelJamMasuk)
        Me.Panel1.Controls.Add(Me.labelJenisKendaraan)
        Me.Panel1.Controls.Add(Me.labelPlatNomor)
        Me.Panel1.Controls.Add(Me.labelNomorTiket)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.labelTanggal)
        Me.Panel1.Controls.Add(Me.labelInformasi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 450)
        Me.Panel1.TabIndex = 1
        '
        'textboxDurasiParkir
        '
        Me.textboxDurasiParkir.Location = New System.Drawing.Point(244, 413)
        Me.textboxDurasiParkir.Name = "textboxDurasiParkir"
        Me.textboxDurasiParkir.Size = New System.Drawing.Size(293, 26)
        Me.textboxDurasiParkir.TabIndex = 17
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(244, 368)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(293, 26)
        Me.DateTimePicker3.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Gratis (Dibawah 1 Jam)", "Rp. 3000", "Rp. 6000", "Rp. 9000", "Rp. 12000", "Rp. 15000", "Rp. 18000", "Rp. 21000", "Rp. 24000", "Rp. 27000", "Rp. 30000", "Terdaftar Member (Gratis)"})
        Me.ComboBox2.Location = New System.Drawing.Point(244, 319)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(293, 28)
        Me.ComboBox2.TabIndex = 15
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(244, 269)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(293, 26)
        Me.DateTimePicker2.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Motor", "Mobil"})
        Me.ComboBox1.Location = New System.Drawing.Point(244, 218)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(293, 28)
        Me.ComboBox1.TabIndex = 13
        '
        'textboxPlatNomor
        '
        Me.textboxPlatNomor.Location = New System.Drawing.Point(244, 166)
        Me.textboxPlatNomor.Name = "textboxPlatNomor"
        Me.textboxPlatNomor.Size = New System.Drawing.Size(293, 26)
        Me.textboxPlatNomor.TabIndex = 12
        '
        'textboxNomorTiket
        '
        Me.textboxNomorTiket.Location = New System.Drawing.Point(244, 116)
        Me.textboxNomorTiket.Name = "textboxNomorTiket"
        Me.textboxNomorTiket.Size = New System.Drawing.Size(293, 26)
        Me.textboxNomorTiket.TabIndex = 11
        '
        'labelDurasiParkir
        '
        Me.labelDurasiParkir.AutoSize = True
        Me.labelDurasiParkir.BackColor = System.Drawing.Color.SpringGreen
        Me.labelDurasiParkir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDurasiParkir.Location = New System.Drawing.Point(12, 413)
        Me.labelDurasiParkir.Name = "labelDurasiParkir"
        Me.labelDurasiParkir.Size = New System.Drawing.Size(176, 28)
        Me.labelDurasiParkir.TabIndex = 10
        Me.labelDurasiParkir.Text = "Durasi Parkir:"
        '
        'labelJamKeluar
        '
        Me.labelJamKeluar.AutoSize = True
        Me.labelJamKeluar.BackColor = System.Drawing.Color.SpringGreen
        Me.labelJamKeluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJamKeluar.Location = New System.Drawing.Point(14, 366)
        Me.labelJamKeluar.Name = "labelJamKeluar"
        Me.labelJamKeluar.Size = New System.Drawing.Size(153, 28)
        Me.labelJamKeluar.TabIndex = 9
        Me.labelJamKeluar.Text = "Jam Keluar:"
        '
        'labelTarif
        '
        Me.labelTarif.AutoSize = True
        Me.labelTarif.BackColor = System.Drawing.Color.SpringGreen
        Me.labelTarif.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTarif.Location = New System.Drawing.Point(14, 319)
        Me.labelTarif.Name = "labelTarif"
        Me.labelTarif.Size = New System.Drawing.Size(164, 28)
        Me.labelTarif.TabIndex = 8
        Me.labelTarif.Text = "Tarif Perjam:"
        '
        'labelJamMasuk
        '
        Me.labelJamMasuk.AutoSize = True
        Me.labelJamMasuk.BackColor = System.Drawing.Color.SpringGreen
        Me.labelJamMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJamMasuk.Location = New System.Drawing.Point(14, 269)
        Me.labelJamMasuk.Name = "labelJamMasuk"
        Me.labelJamMasuk.Size = New System.Drawing.Size(150, 28)
        Me.labelJamMasuk.TabIndex = 7
        Me.labelJamMasuk.Text = "Jam Masuk:"
        '
        'labelJenisKendaraan
        '
        Me.labelJenisKendaraan.AutoSize = True
        Me.labelJenisKendaraan.BackColor = System.Drawing.Color.SpringGreen
        Me.labelJenisKendaraan.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJenisKendaraan.Location = New System.Drawing.Point(14, 218)
        Me.labelJenisKendaraan.Name = "labelJenisKendaraan"
        Me.labelJenisKendaraan.Size = New System.Drawing.Size(216, 28)
        Me.labelJenisKendaraan.TabIndex = 6
        Me.labelJenisKendaraan.Text = "Jenis Kendaraan:"
        '
        'labelPlatNomor
        '
        Me.labelPlatNomor.AutoSize = True
        Me.labelPlatNomor.BackColor = System.Drawing.Color.SpringGreen
        Me.labelPlatNomor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlatNomor.Location = New System.Drawing.Point(12, 166)
        Me.labelPlatNomor.Name = "labelPlatNomor"
        Me.labelPlatNomor.Size = New System.Drawing.Size(149, 28)
        Me.labelPlatNomor.TabIndex = 5
        Me.labelPlatNomor.Text = "Plat Nomor:"
        '
        'labelNomorTiket
        '
        Me.labelNomorTiket.AutoSize = True
        Me.labelNomorTiket.BackColor = System.Drawing.Color.SpringGreen
        Me.labelNomorTiket.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNomorTiket.Location = New System.Drawing.Point(12, 116)
        Me.labelNomorTiket.Name = "labelNomorTiket"
        Me.labelNomorTiket.Size = New System.Drawing.Size(162, 28)
        Me.labelNomorTiket.TabIndex = 4
        Me.labelNomorTiket.Text = "Nomor Tiket:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(244, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(293, 26)
        Me.DateTimePicker1.TabIndex = 2
        '
        'labelTanggal
        '
        Me.labelTanggal.AutoSize = True
        Me.labelTanggal.BackColor = System.Drawing.Color.SpringGreen
        Me.labelTanggal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTanggal.Location = New System.Drawing.Point(12, 66)
        Me.labelTanggal.Name = "labelTanggal"
        Me.labelTanggal.Size = New System.Drawing.Size(114, 28)
        Me.labelTanggal.TabIndex = 3
        Me.labelTanggal.Text = "Tanggal:"
        '
        'labelInformasi
        '
        Me.labelInformasi.AutoSize = True
        Me.labelInformasi.BackColor = System.Drawing.Color.SpringGreen
        Me.labelInformasi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInformasi.Location = New System.Drawing.Point(12, 9)
        Me.labelInformasi.Name = "labelInformasi"
        Me.labelInformasi.Size = New System.Drawing.Size(163, 37)
        Me.labelInformasi.TabIndex = 2
        Me.labelInformasi.Text = "Informasi"
        '
        'buttonKendaraanMasuk
        '
        Me.buttonKendaraanMasuk.BackColor = System.Drawing.Color.SpringGreen
        Me.buttonKendaraanMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonKendaraanMasuk.Location = New System.Drawing.Point(570, 66)
        Me.buttonKendaraanMasuk.Name = "buttonKendaraanMasuk"
        Me.buttonKendaraanMasuk.Size = New System.Drawing.Size(207, 91)
        Me.buttonKendaraanMasuk.TabIndex = 2
        Me.buttonKendaraanMasuk.Text = "Kendaraan Masuk"
        Me.buttonKendaraanMasuk.UseVisualStyleBackColor = False
        '
        'buttonKendaraanKeluar
        '
        Me.buttonKendaraanKeluar.BackColor = System.Drawing.Color.SpringGreen
        Me.buttonKendaraanKeluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonKendaraanKeluar.Location = New System.Drawing.Point(570, 206)
        Me.buttonKendaraanKeluar.Name = "buttonKendaraanKeluar"
        Me.buttonKendaraanKeluar.Size = New System.Drawing.Size(207, 91)
        Me.buttonKendaraanKeluar.TabIndex = 3
        Me.buttonKendaraanKeluar.Text = "Kendaraan Keluar"
        Me.buttonKendaraanKeluar.UseVisualStyleBackColor = False
        '
        'buttonLogout
        '
        Me.buttonLogout.BackColor = System.Drawing.Color.OrangeRed
        Me.buttonLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLogout.Location = New System.Drawing.Point(570, 335)
        Me.buttonLogout.Name = "buttonLogout"
        Me.buttonLogout.Size = New System.Drawing.Size(207, 91)
        Me.buttonLogout.TabIndex = 4
        Me.buttonLogout.Text = "Logout"
        Me.buttonLogout.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonLogout)
        Me.Controls.Add(Me.buttonKendaraanKeluar)
        Me.Controls.Add(Me.buttonKendaraanMasuk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelParkingSystem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Parking System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelParkingSystem As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelInformasi As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents labelTanggal As Label
    Friend WithEvents labelJamMasuk As Label
    Friend WithEvents labelJenisKendaraan As Label
    Friend WithEvents labelPlatNomor As Label
    Friend WithEvents labelNomorTiket As Label
    Friend WithEvents labelDurasiParkir As Label
    Friend WithEvents labelJamKeluar As Label
    Friend WithEvents labelTarif As Label
    Friend WithEvents textboxNomorTiket As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents textboxPlatNomor As TextBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents textboxDurasiParkir As TextBox
    Friend WithEvents buttonKendaraanMasuk As Button
    Friend WithEvents buttonKendaraanKeluar As Button
    Friend WithEvents buttonLogout As Button

    Private Sub buttonLogout_Click(sender As Object, e As EventArgs) Handles buttonLogout.Click
        MessageBox.Show("Anda Berhasil Logout!", "Berhasil Logout!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub buttonKendaraanMasuk_Click(sender As Object, e As EventArgs) Handles buttonKendaraanMasuk.Click
        Dim selectedDate As String = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        Dim selectedTicketNo As String = textboxNomorTiket.Text
        Dim selectedPlatNo As String = textboxPlatNomor.Text
        Dim selectedJenisKendaraan As String = ComboBox1.SelectedItem.ToString()
        Dim selectedJamMasuk As String = DateTimePicker2.Value.ToString("HH:mm:s")

        Dim Form3 As New Form3

        Form3.TanggalHariText = selectedDate
        Form3.NomorTiketText = selectedTicketNo
        Form3.PlatNomorText = selectedPlatNo
        Form3.JenisKendaraanText = selectedJenisKendaraan
        Form3.JamMasukText = selectedJamMasuk

        Form3.Show()
        Me.Close()
    End Sub

    Private Sub buttonKendaraanKeluar_Click(sender As Object, e As EventArgs) Handles buttonKendaraanKeluar.Click
        Dim selectedDate As String = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        Dim selectedTicketNo As String = textboxNomorTiket.Text
        Dim selectedPlatNo As String = textboxPlatNomor.Text
        Dim selectedJenisKendaraan As String = ComboBox1.SelectedItem.ToString()
        Dim selectedJamMasuk As String = DateTimePicker2.Value.ToString("HH:mm:s")
        Dim selectedTarifPerJam As String = ComboBox2.SelectedItem.ToString()
        Dim selectedJamKeluar As String = DateTimePicker3.Value.ToString("HH:mm:s")
        Dim selectedDurasiParkir As String = textboxDurasiParkir.Text

        Dim Form4 As New Form4

        Form4.TanggalHariText = selectedDate
        Form4.NomorTiketText = selectedTicketNo
        Form4.PlatNomorText = selectedPlatNo
        Form4.JenisKendaraanText = selectedJenisKendaraan
        Form4.JamMasukText = selectedJamMasuk
        Form4.TarifPerJamText = selectedTarifPerJam
        Form4.JamKeluarText = selectedJamKeluar
        Form4.DurasiParkirText = selectedDurasiParkir

        Form4.Show()
        Me.Close()
    End Sub
End Class