Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class Circle_Avatar
    Inherits PictureBox
    Public Sub New()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim brushImege As System.Drawing.Brush
        Try
            Dim Imagem As New Bitmap(Me.Image)
            Imagem = New Bitmap(Imagem, New Size(Me.Width - 1, Me.Height - 1))
            brushImege = New TextureBrush(Imagem)
        Catch
            Dim Imagem As New Bitmap(Me.Width - 1, Me.Height - 1, PixelFormat.Format24bppRgb)
            Using grp As Graphics = Graphics.FromImage(Imagem)
                grp.FillRectangle(Brushes.White, 0, 0, Me.Width - 1, Me.Height - 1)
                Imagem = New Bitmap(Me.Width - 1, Me.Height - 1, grp)
            End Using
            brushImege = New TextureBrush(Imagem)
        End Try
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.FillPath(brushImege, path)
        e.Graphics.DrawPath(Pens.Transparent, path)
    End Sub
End Class