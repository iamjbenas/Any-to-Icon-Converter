Imports System.Drawing.Icon
Imports System.IO
Imports FreeImageAPI


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FadeInForm(Me, 500)
        txtOutputFolder.Text = My.Settings.path
        lbFiles.SelectionMode = SelectionMode.MultiExtended

        Panel1.AllowDrop = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Filter = "All Supported Image Files|*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.png;*.tif;*.tiff;*.ico;*.tga;*.pcx;*.wbmp;*.webp;*.jxr;*.hdp;*.wdp|BMP (*.bmp)|*.bmp|JPEG (*.jpg; *.jpeg; *.jpe; *.jfif)|*.jpg; *.jpeg; *.jpe; *.jfif|GIF (*.gif)|*.gif|PNG (*.png)|*.png|TIFF (*.tif; *.tiff)|*.tif; *.tiff|ICO (*.ico)|*.ico|TGA (*.tga)|*.tga|PCX (*.pcx)|*.pcx|WBMP (*.wbmp)|*.wbmp|WebP (*.webp)|*.webp|JXR (*.jxr; *.hdp; *.wdp)|*.jxr; *.hdp; *.wdp"
        open.Multiselect = True
        If open.ShowDialog() = DialogResult.OK Then
            For Each fileName As String In open.FileNames
                lbFiles.Items.Add(fileName)
            Next
        End If
    End Sub
    Private Sub FadeInForm(form As Form, duration As Integer)
        Dim fadeInTimer As New Timer()
        fadeInTimer.Interval = 10
        Dim targetOpacity As Double = 1.0
        form.Opacity = 0.0

        AddHandler fadeInTimer.Tick,
            Sub(sender As Object, e As EventArgs)
                form.Opacity += 1.0 / (duration / fadeInTimer.Interval)
                If form.Opacity >= targetOpacity Then
                    form.Opacity = targetOpacity
                    fadeInTimer.Stop()
                End If
            End Sub

        fadeInTimer.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub
    Private Function GetSelectedSize() As Integer
        If rb16x16.Checked Then
            Return 16
        ElseIf rb32x32.Checked Then
            Return 32
        ElseIf rb64x64.Checked Then
            Return 64
        ElseIf rb128x128.Checked Then
            Return 128
        ElseIf rb256x256.Checked Then
            Return 256
        Else
            Return 0
        End If
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtOutputFolder.Text = folderBrowserDialog.SelectedPath
            My.Settings.path = txtOutputFolder.Text
            My.Settings.Save()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim open As New OpenFileDialog
        With open
            .Filter = "PNG (*.png)|*.png"
            If open.ShowDialog = DialogResult.OK Then
                Dim pngImagePath As String = open.FileName
                Dim pngImage As FIBITMAP = FreeImage.Load(FREE_IMAGE_FORMAT.FIF_PNG, pngImagePath, FREE_IMAGE_LOAD_FLAGS.DEFAULT)
                Dim resizedImage As FIBITMAP = FreeImage.Rescale(pngImage, 200, 200, FREE_IMAGE_FILTER.FILTER_BILINEAR)
                Dim outputIcoPath As String = "C:\test2.ico"
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_ICO, resizedImage, outputIcoPath, FREE_IMAGE_SAVE_FLAGS.DEFAULT)
                MsgBox("done")
            End If
        End With

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        selected.Visible = True
        selected.BringToFront()
        bulk.Visible = True
        bulk.BringToFront()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub lbFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFiles.SelectedIndexChanged
        Try
            Panel1.BackgroundImage = Image.FromFile(lbFiles.SelectedItem)
            PictureBox1.Visible = False
            Label1.Visible = False

        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs)

    End Sub
    Private Function IsImageFile(filePath As String) As Boolean
        Dim validExtensions() As String = {".bmp", ".jpg", ".jpeg", ".jpe", ".jfif", ".gif", ".png", ".tif", ".tiff", ".ico", ".tga", ".pcx", ".wbmp", ".webp", ".jxr", ".hdp", ".wdp"}
        Dim extension As String = Path.GetExtension(filePath).ToLower()
        Return validExtensions.Contains(extension)
    End Function

    Private Sub lbFiles_DragEnter(sender As Object, e As DragEventArgs) Handles lbFiles.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub lbFiles_DragLeave(sender As Object, e As EventArgs) Handles lbFiles.DragLeave

    End Sub

    Private Sub lbFiles_DragDrop(sender As Object, e As DragEventArgs) Handles lbFiles.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If files IsNot Nothing Then
            For Each file As String In files
                If IsImageFile(file) Then
                    lbFiles.Items.Add(file)
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub LoadImageToPanel(imagePath As String)
        If File.Exists(imagePath) Then
            Panel1.BackgroundImage = Image.FromFile(imagePath)
        Else
            MessageBox.Show("File does not exist: " & imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            If files IsNot Nothing AndAlso files.Length > 0 Then
                Dim imageFilePath As String = files(0)
                If IsImageFile(imageFilePath) Then
                    LoadImageToPanel(imageFilePath)
                    lbFiles.Items.Add(imageFilePath)
                    PictureBox1.Visible = False
                    Label1.Visible = False

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.path = txtOutputFolder.Text
        My.Settings.Save()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        For i As Integer = lbFiles.SelectedIndices.Count - 1 To 0 Step -1
            lbFiles.Items.RemoveAt(lbFiles.SelectedIndices(i))
        Next
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click
        lbFiles.Items.Clear()

    End Sub

    Private Sub AddFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFilesToolStripMenuItem.Click
        Dim open As New OpenFileDialog
        open.Filter = "All Supported Image Files|*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.png;*.tif;*.tiff;*.ico;*.tga;*.pcx;*.wbmp;*.webp;*.jxr;*.hdp;*.wdp|BMP (*.bmp)|*.bmp|JPEG (*.jpg; *.jpeg; *.jpe; *.jfif)|*.jpg; *.jpeg; *.jpe; *.jfif|GIF (*.gif)|*.gif|PNG (*.png)|*.png|TIFF (*.tif; *.tiff)|*.tif; *.tiff|ICO (*.ico)|*.ico|TGA (*.tga)|*.tga|PCX (*.pcx)|*.pcx|WBMP (*.wbmp)|*.wbmp|WebP (*.webp)|*.webp|JXR (*.jxr; *.hdp; *.wdp)|*.jxr; *.hdp; *.wdp"
        open.Multiselect = True
        If open.ShowDialog() = DialogResult.OK Then
            For Each fileName As String In open.FileNames
                lbFiles.Items.Add(fileName)
            Next
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub selected_Click(sender As Object, e As EventArgs) Handles selected.Click
        If lbFiles.SelectedItems.Count <> 1 Then
            MessageBox.Show("Please select exactly one item for conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedItem As String = lbFiles.SelectedItem.ToString()

        Dim selectedSize As Integer = GetSelectedSize()
        If selectedSize = 0 Then
            MessageBox.Show("Please select an icon size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim outputFolder As String = txtOutputFolder.Text.Trim()
        If Not Directory.Exists(outputFolder) Then
            MessageBox.Show("Output folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If IsImageFile(selectedItem) Then
            selected.Visible = False
            bulk.Visible = False

            Dim pngImage As FIBITMAP = FreeImage.Load(FREE_IMAGE_FORMAT.FIF_PNG, selectedItem, FREE_IMAGE_LOAD_FLAGS.DEFAULT)
            Dim resizedImage As FIBITMAP = FreeImage.Rescale(pngImage, selectedSize, selectedSize, FREE_IMAGE_FILTER.FILTER_BILINEAR)

            Dim outputFilePath As String = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(selectedItem) & ".ico")
            FreeImage.Save(FREE_IMAGE_FORMAT.FIF_ICO, resizedImage, outputFilePath, FREE_IMAGE_SAVE_FLAGS.DEFAULT)

            FreeImage.Unload(resizedImage)
            FreeImage.Unload(pngImage)

            MessageBox.Show("Conversion completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Selected item is not an image file: " & selectedItem, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bulk_Click(sender As Object, e As EventArgs) Handles bulk.Click
        If lbFiles.Items.Count = 0 Then
            MessageBox.Show("No files selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedSize As Integer = GetSelectedSize()
        If selectedSize = 0 Then
            MessageBox.Show("Please select an icon size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim outputFolder As String = txtOutputFolder.Text.Trim()
        If Not Directory.Exists(outputFolder) Then
            MessageBox.Show("Output folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For Each fileName As String In lbFiles.Items
            selected.Visible = False
            bulk.Visible = False
            Dim imageFormat As FREE_IMAGE_FORMAT = FreeImage.GetFileType(fileName, 0)
            Dim pngImage As FIBITMAP = FreeImage.Load(imageFormat, fileName, FREE_IMAGE_LOAD_FLAGS.DEFAULT)
            Dim resizedImage As FIBITMAP = FreeImage.Rescale(pngImage, selectedSize, selectedSize, FREE_IMAGE_FILTER.FILTER_BILINEAR)

            Dim outputFilePath As String = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(fileName) & ".ico")
            FreeImage.Save(FREE_IMAGE_FORMAT.FIF_ICO, resizedImage, outputFilePath, FREE_IMAGE_SAVE_FLAGS.DEFAULT)

            FreeImage.Unload(resizedImage)
            FreeImage.Unload(pngImage)
        Next
        MessageBox.Show("Conversion completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
