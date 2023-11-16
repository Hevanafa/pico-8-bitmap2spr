Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colours = colours_raw.Select(Function(c) Color.FromArgb(255, Color.FromArgb(c))).ToArray
    End Sub

    Dim colours_raw%() = New Integer() {
        &H20408,
        &H1D2B53,
        &H7E2553,
        &H8751,
        &HAB5236,
        &H5F574F,
        &HC2C3C7,
        &HFFF1E8,
        &HFF004D,
        &HFFA300,
        &HFFEC27,
        &HE436,
        &H29ADFF,
        &H83769C,
        &HFF77A8,
        &HFFCCAA
    }

    Dim colours As Color()

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Function GetNearest(colour As Color) As Color
        Dim diff% = 1000
        Dim last_c As Color

        Try
            For Each c In colours
                last_c = c
                Dim temp_diff% = {Int(c.R) - colour.R, Int(c.G) - colour.G, Int(c.B) - colour.B}.Sum(Function(x) Math.Abs(x))

                If diff > temp_diff Then
                    diff = temp_diff
                    GetNearest = c
                End If
            Next
        Catch oex As OverflowException
            Debug.Print(colour.ToString)
            Debug.Print(last_c.ToString)
            GetNearest = Color.Black
        Catch ex As Exception
            Debug.Print(colour.ToString)
            GetNearest = Color.Black
        End Try
    End Function


    Dim edited As Bitmap

    Private Async Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim files$() = e.Data.GetData(DataFormats.FileDrop)
        Dim first = files(0)

        Try
            Dim img As Bitmap = Image.FromFile(first)

            If img.Width > 64 OrElse img.Height > 64 Then
                Throw New FormatException("The size can't be more than 64x64.")
            End If

            pbSource.Image = img

            ' Redraw
            If edited IsNot Nothing Then _
                edited.Dispose()

            edited = New Bitmap(img)
            Dim colour As Color

            For y = 0 To img.Height - 1
                For x = 0 To img.Width - 1
                    colour = img.GetPixel(x, y)
                    edited.SetPixel(x, y, GetNearest(colour))
            Next x, y

            'edited.Save("temp.png", Imaging.ImageFormat.Png)

            RedrawPreview()

        Catch ex As Exception
            MessageBox.Show("An exception occurred: " + ex.Message)
        End Try

    End Sub


    Sub RedrawPreview()
        If edited Is Nothing Then Return

        Dim size% = GetConversionSize()
        Dim cropped As New Bitmap(size, size)
        Using g = Graphics.FromImage(cropped)
            g.DrawImage(edited, 0, 0)
        End Using
        pbPreview.Image = cropped
    End Sub


    Function GetConversionSize%()
        GetConversionSize = IIf(rb8x8.Checked, 8,
                        IIf(rb16x16.Checked, 16,
                            IIf(rb32x32.Checked, 32,
                                IIf(rb64x64.Checked, 64, 1))))
    End Function

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim img As Bitmap = pbSource.Image

        Dim size% = GetConversionSize()

        Dim padding% = IIf(size = 8, 2,
                           IIf(size = 16, 8,
                               IIf(size = 32, 32,
                                   IIf(size = 64, 128, 1))))

        ' last padding:
        ' 8x8: 2
        ' 16x16: 8
        ' 32x32: 32
        ' 64x64: 128
        txbOutput.Text = String.Join("", Enumerable.Range(0, size).Select(
            Function(y)
                Return String.Join("", Enumerable.Range(0, size).Select(
                Function(x)
                    Try
                        Return Array.IndexOf(colours, GetNearest(img.GetPixel(x, y))).ToString("x")
                    Catch ex As Exception
                        Return 0
                    End Try
                End Function))
            End Function)) + StrDup(padding, "0"c)

    End Sub

    Private Sub rb8x8_CheckedChanged(sender As Object, e As EventArgs) Handles rb8x8.CheckedChanged
        RedrawPreview()
    End Sub

    Private Sub rb16x16_CheckedChanged(sender As Object, e As EventArgs) Handles rb16x16.CheckedChanged
        RedrawPreview()
    End Sub

    Private Sub rb32x32_CheckedChanged(sender As Object, e As EventArgs) Handles rb32x32.CheckedChanged
        RedrawPreview()
    End Sub

    Private Sub rb64x64_CheckedChanged(sender As Object, e As EventArgs) Handles rb64x64.CheckedChanged
        RedrawPreview()
    End Sub
End Class
