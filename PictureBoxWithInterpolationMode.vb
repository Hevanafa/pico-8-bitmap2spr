Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

' Goal: make a picture box with nearest neighbor sampling
' Ref: https://stackoverflow.com/questions/29157/how-do-i-make-a-picturebox-use-nearest-neighbor-resampling
Public Class PictureBoxWithInterpolationMode
    Inherits PictureBox

    Public Property InterpolationMode As InterpolationMode

    Protected Overrides Sub OnPaint(paintEventArgs As PaintEventArgs)
        paintEventArgs.Graphics.InterpolationMode = InterpolationMode
        paintEventArgs.Graphics.PixelOffsetMode = PixelOffsetMode.Half
        MyBase.OnPaint(paintEventArgs)
    End Sub
End Class
