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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbFiles = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtOutputFolder = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb256x256 = New System.Windows.Forms.RadioButton()
        Me.rb128x128 = New System.Windows.Forms.RadioButton()
        Me.rb64x64 = New System.Windows.Forms.RadioButton()
        Me.rb32x32 = New System.Windows.Forms.RadioButton()
        Me.rb16x16 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.selected = New System.Windows.Forms.Button()
        Me.bulk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbFiles
        '
        Me.lbFiles.AllowDrop = True
        Me.lbFiles.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lbFiles.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.ItemHeight = 17
        Me.lbFiles.Location = New System.Drawing.Point(15, 19)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.ScrollAlwaysVisible = True
        Me.lbFiles.Size = New System.Drawing.Size(355, 89)
        Me.lbFiles.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Add Files"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Icon_Converter.My.MySettings.Default, "path", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtOutputFolder.Location = New System.Drawing.Point(170, 188)
        Me.txtOutputFolder.Name = "txtOutputFolder"
        Me.txtOutputFolder.Size = New System.Drawing.Size(173, 23)
        Me.txtOutputFolder.TabIndex = 4
        Me.txtOutputFolder.Text = Global.Icon_Converter.My.MySettings.Default.path
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(345, 187)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(256, 217)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 26)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "&Convert"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bulk)
        Me.GroupBox1.Controls.Add(Me.selected)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtOutputFolder)
        Me.GroupBox1.Controls.Add(Me.lbFiles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 259)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversion"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.CausesValidation = False
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(15, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 127)
        Me.Panel1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb256x256)
        Me.GroupBox2.Controls.Add(Me.rb128x128)
        Me.GroupBox2.Controls.Add(Me.rb64x64)
        Me.GroupBox2.Controls.Add(Me.rb32x32)
        Me.GroupBox2.Controls.Add(Me.rb16x16)
        Me.GroupBox2.Location = New System.Drawing.Point(145, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 69)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Size"
        '
        'rb256x256
        '
        Me.rb256x256.AutoSize = True
        Me.rb256x256.Location = New System.Drawing.Point(146, 20)
        Me.rb256x256.Name = "rb256x256"
        Me.rb256x256.Size = New System.Drawing.Size(73, 19)
        Me.rb256x256.TabIndex = 13
        Me.rb256x256.TabStop = True
        Me.rb256x256.Text = "256x256"
        Me.rb256x256.UseVisualStyleBackColor = True
        '
        'rb128x128
        '
        Me.rb128x128.AutoSize = True
        Me.rb128x128.Location = New System.Drawing.Point(77, 39)
        Me.rb128x128.Name = "rb128x128"
        Me.rb128x128.Size = New System.Drawing.Size(69, 19)
        Me.rb128x128.TabIndex = 12
        Me.rb128x128.TabStop = True
        Me.rb128x128.Text = "128x128"
        Me.rb128x128.UseVisualStyleBackColor = True
        '
        'rb64x64
        '
        Me.rb64x64.AutoSize = True
        Me.rb64x64.Location = New System.Drawing.Point(77, 20)
        Me.rb64x64.Name = "rb64x64"
        Me.rb64x64.Size = New System.Drawing.Size(59, 19)
        Me.rb64x64.TabIndex = 11
        Me.rb64x64.TabStop = True
        Me.rb64x64.Text = "64x64"
        Me.rb64x64.UseVisualStyleBackColor = True
        '
        'rb32x32
        '
        Me.rb32x32.AutoSize = True
        Me.rb32x32.Location = New System.Drawing.Point(15, 39)
        Me.rb32x32.Name = "rb32x32"
        Me.rb32x32.Size = New System.Drawing.Size(59, 19)
        Me.rb32x32.TabIndex = 10
        Me.rb32x32.TabStop = True
        Me.rb32x32.Text = "32x32"
        Me.rb32x32.UseVisualStyleBackColor = True
        '
        'rb16x16
        '
        Me.rb16x16.AutoSize = True
        Me.rb16x16.Location = New System.Drawing.Point(15, 20)
        Me.rb16x16.Name = "rb16x16"
        Me.rb16x16.Size = New System.Drawing.Size(55, 19)
        Me.rb16x16.TabIndex = 9
        Me.rb16x16.TabStop = True
        Me.rb16x16.Text = "16x16"
        Me.rb16x16.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, -56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(354, 226)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Drag Image Here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Developed by Joshua B. // Powered by FreeImage"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFilesToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem, Me.ClearListToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 104)
        '
        'AddFilesToolStripMenuItem
        '
        Me.AddFilesToolStripMenuItem.Image = CType(resources.GetObject("AddFilesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem"
        Me.AddFilesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AddFilesToolStripMenuItem.Text = "Add File(s)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete selected files"
        '
        'ClearListToolStripMenuItem
        '
        Me.ClearListToolStripMenuItem.Image = CType(resources.GetObject("ClearListToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        Me.ClearListToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ClearListToolStripMenuItem.Text = "Clear list"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(174, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(148, 189)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 21)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'selected
        '
        Me.selected.Location = New System.Drawing.Point(145, 217)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(109, 25)
        Me.selected.TabIndex = 9
        Me.selected.Text = "Selected Item"
        Me.selected.UseVisualStyleBackColor = True
        Me.selected.Visible = False
        '
        'bulk
        '
        Me.bulk.Location = New System.Drawing.Point(256, 217)
        Me.bulk.Name = "bulk"
        Me.bulk.Size = New System.Drawing.Size(114, 25)
        Me.bulk.TabIndex = 10
        Me.bulk.Text = "Bulk Convert"
        Me.bulk.UseVisualStyleBackColor = True
        Me.bulk.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Any to Icon - Any Image to Icon Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbFiles As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtOutputFolder As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb128x128 As RadioButton
    Friend WithEvents rb64x64 As RadioButton
    Friend WithEvents rb32x32 As RadioButton
    Friend WithEvents rb16x16 As RadioButton
    Friend WithEvents rb256x256 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bulk As Button
    Friend WithEvents selected As Button
End Class
