﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.pbSource = New System.Windows.Forms.PictureBox()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.txbOutput = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb8x8 = New System.Windows.Forms.RadioButton()
        Me.rb16x16 = New System.Windows.Forms.RadioButton()
        Me.rb32x32 = New System.Windows.Forms.RadioButton()
        Me.rb64x64 = New System.Windows.Forms.RadioButton()
        CType(Me.pbSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbSource
        '
        Me.pbSource.Location = New System.Drawing.Point(13, 29)
        Me.pbSource.Margin = New System.Windows.Forms.Padding(4)
        Me.pbSource.Name = "pbSource"
        Me.pbSource.Size = New System.Drawing.Size(128, 128)
        Me.pbSource.TabIndex = 0
        Me.pbSource.TabStop = False
        '
        'pbPreview
        '
        Me.pbPreview.Location = New System.Drawing.Point(149, 29)
        Me.pbPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(128, 128)
        Me.pbPreview.TabIndex = 1
        Me.pbPreview.TabStop = False
        '
        'txbOutput
        '
        Me.txbOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbOutput.Location = New System.Drawing.Point(13, 216)
        Me.txbOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.txbOutput.Multiline = True
        Me.txbOutput.Name = "txbOutput"
        Me.txbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbOutput.Size = New System.Drawing.Size(264, 156)
        Me.txbOutput.TabIndex = 2
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(13, 165)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(264, 43)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate SPR code"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Preview"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb64x64)
        Me.GroupBox1.Controls.Add(Me.rb32x32)
        Me.GroupBox1.Controls.Add(Me.rb16x16)
        Me.GroupBox1.Controls.Add(Me.rb8x8)
        Me.GroupBox1.Location = New System.Drawing.Point(284, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 131)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sprite Size"
        '
        'rb8x8
        '
        Me.rb8x8.AutoSize = True
        Me.rb8x8.Checked = True
        Me.rb8x8.Location = New System.Drawing.Point(6, 22)
        Me.rb8x8.Name = "rb8x8"
        Me.rb8x8.Size = New System.Drawing.Size(48, 20)
        Me.rb8x8.TabIndex = 0
        Me.rb8x8.TabStop = True
        Me.rb8x8.Text = "8×8"
        Me.rb8x8.UseVisualStyleBackColor = True
        '
        'rb16x16
        '
        Me.rb16x16.AutoSize = True
        Me.rb16x16.Location = New System.Drawing.Point(6, 48)
        Me.rb16x16.Name = "rb16x16"
        Me.rb16x16.Size = New System.Drawing.Size(62, 20)
        Me.rb16x16.TabIndex = 1
        Me.rb16x16.Text = "16×16"
        Me.rb16x16.UseVisualStyleBackColor = True
        '
        'rb32x32
        '
        Me.rb32x32.AutoSize = True
        Me.rb32x32.Location = New System.Drawing.Point(6, 74)
        Me.rb32x32.Name = "rb32x32"
        Me.rb32x32.Size = New System.Drawing.Size(62, 20)
        Me.rb32x32.TabIndex = 2
        Me.rb32x32.Text = "32×32"
        Me.rb32x32.UseVisualStyleBackColor = True
        '
        'rb64x64
        '
        Me.rb64x64.AutoSize = True
        Me.rb64x64.Location = New System.Drawing.Point(6, 100)
        Me.rb64x64.Name = "rb64x64"
        Me.rb64x64.Size = New System.Drawing.Size(62, 20)
        Me.rb64x64.TabIndex = 3
        Me.rb64x64.Text = "64×64"
        Me.rb64x64.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txbOutput)
        Me.Controls.Add(Me.pbPreview)
        Me.Controls.Add(Me.pbSource)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbSource As PictureBox
    Friend WithEvents pbPreview As PictureBox
    Friend WithEvents txbOutput As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb64x64 As RadioButton
    Friend WithEvents rb32x32 As RadioButton
    Friend WithEvents rb16x16 As RadioButton
    Friend WithEvents rb8x8 As RadioButton
End Class
