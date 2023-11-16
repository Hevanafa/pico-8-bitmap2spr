Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colours = colours_raw.Select(Function(c) Color.FromArgb(c)).ToArray
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

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim files$() = e.Data.GetData(DataFormats.FileDrop)
        Dim first = files(0)

        Try
            Dim img = Image.FromFile(first)

            If img.Width > 64 OrElse img.Height > 64 Then
                Throw New FormatException("The size can't be more than 64x64.")
            End If

            pbSource.Image = img

            ' Todo: redraw



        Catch ex As Exception
            MessageBox.Show("An exception occurred: " + ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
