<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Circle_Avatar1 = New Kelompok_15___UTS_Sistem_Parkir.Circle_Avatar()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.textboxUsername = New System.Windows.Forms.TextBox()
        Me.textboxPassword = New System.Windows.Forms.TextBox()
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        CType(Me.Circle_Avatar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.Circle_Avatar1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(199, 458)
        Me.panel1.TabIndex = 0
        '
        'Circle_Avatar1
        '
        Me.Circle_Avatar1.BackColor = System.Drawing.Color.Transparent
        Me.Circle_Avatar1.Image = CType(resources.GetObject("Circle_Avatar1.Image"), System.Drawing.Image)
        Me.Circle_Avatar1.Location = New System.Drawing.Point(12, 128)
        Me.Circle_Avatar1.Name = "Circle_Avatar1"
        Me.Circle_Avatar1.Size = New System.Drawing.Size(173, 173)
        Me.Circle_Avatar1.TabIndex = 1
        Me.Circle_Avatar1.TabStop = False
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.BackColor = System.Drawing.Color.Transparent
        Me.labelUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsername.Location = New System.Drawing.Point(233, 128)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(234, 46)
        Me.labelUsername.TabIndex = 1
        Me.labelUsername.Text = "Username:"
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.BackColor = System.Drawing.Color.Transparent
        Me.labelPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPassword.Location = New System.Drawing.Point(233, 255)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(228, 46)
        Me.labelPassword.TabIndex = 2
        Me.labelPassword.Text = "Password:"
        '
        'textboxUsername
        '
        Me.textboxUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxUsername.Location = New System.Drawing.Point(473, 128)
        Me.textboxUsername.Name = "textboxUsername"
        Me.textboxUsername.Size = New System.Drawing.Size(265, 54)
        Me.textboxUsername.TabIndex = 3
        '
        'textboxPassword
        '
        Me.textboxPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxPassword.Location = New System.Drawing.Point(473, 252)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.Size = New System.Drawing.Size(265, 54)
        Me.textboxPassword.TabIndex = 4
        Me.textboxPassword.UseSystemPasswordChar = True
        '
        'buttonLogin
        '
        Me.buttonLogin.BackColor = System.Drawing.Color.SpringGreen
        Me.buttonLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLogin.Image = CType(resources.GetObject("buttonLogin.Image"), System.Drawing.Image)
        Me.buttonLogin.Location = New System.Drawing.Point(473, 327)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(265, 110)
        Me.buttonLogin.TabIndex = 5
        Me.buttonLogin.Text = "Login"
        Me.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buttonLogin.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(760, 458)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.textboxPassword)
        Me.Controls.Add(Me.textboxUsername)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.labelUsername)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Login Screen"
        Me.panel1.ResumeLayout(False)
        CType(Me.Circle_Avatar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PerformanceCounter1 As PerformanceCounter

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents panel1 As Panel
    Friend WithEvents Circle_Avatar1 As Circle_Avatar
    Friend WithEvents labelUsername As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents textboxUsername As TextBox
    Friend WithEvents textboxPassword As TextBox
    Friend WithEvents buttonLogin As Button

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        If textboxUsername.Text = "admin" And textboxPassword.Text = "admin" Then
            MessageBox.Show("Anda Berhasil Login!", "Berhasil Login!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Form2 As New Form2
            Form2.Show()
            Me.Close()

        Else
            MessageBox.Show("Silahkan Coba Lagi!", "Tidak Berhasil Login!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class