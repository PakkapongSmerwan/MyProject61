<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblGSky = New System.Windows.Forms.Label()
        Me.lblGBlack = New System.Windows.Forms.Label()
        Me.lblGWhite = New System.Windows.Forms.Label()
        Me.lblGViolet = New System.Windows.Forms.Label()
        Me.lblGBrown = New System.Windows.Forms.Label()
        Me.lblGGreen = New System.Windows.Forms.Label()
        Me.lblGYellow = New System.Windows.Forms.Label()
        Me.lblGBlue = New System.Windows.Forms.Label()
        Me.lblGOrange = New System.Windows.Forms.Label()
        Me.lblGRed = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(285, 59)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(237, 74)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = " "
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(519, 59)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(37, 41)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = " +"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(519, 95)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(37, 38)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = " -"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " กำหนดตัวเลข"
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cboSize.Location = New System.Drawing.Point(479, 163)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 21)
        Me.cboSize.TabIndex = 3
        Me.cboSize.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ขนาดฟอนด์"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 112)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ForeColor"
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFRed.Location = New System.Drawing.Point(28, 25)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(33, 30)
        Me.lblFRed.TabIndex = 0
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFBlue.Location = New System.Drawing.Point(67, 25)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(33, 30)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Lime
        Me.lblFGreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFGreen.Location = New System.Drawing.Point(106, 25)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(33, 30)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFViolet.Location = New System.Drawing.Point(145, 25)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(33, 30)
        Me.lblFViolet.TabIndex = 0
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFBlack.Location = New System.Drawing.Point(186, 25)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(33, 30)
        Me.lblFBlack.TabIndex = 0
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFOrange.Location = New System.Drawing.Point(28, 64)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(33, 30)
        Me.lblFOrange.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFYellow.Location = New System.Drawing.Point(67, 64)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(33, 30)
        Me.lblFYellow.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFBrown.Location = New System.Drawing.Point(106, 64)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(33, 30)
        Me.lblFBrown.TabIndex = 0
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFWhite.Location = New System.Drawing.Point(145, 64)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(33, 30)
        Me.lblFWhite.TabIndex = 0
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFSky.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFSky.Location = New System.Drawing.Point(186, 64)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(33, 30)
        Me.lblFSky.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox2.Controls.Add(Me.lblGSky)
        Me.GroupBox2.Controls.Add(Me.lblGBlack)
        Me.GroupBox2.Controls.Add(Me.lblGWhite)
        Me.GroupBox2.Controls.Add(Me.lblGViolet)
        Me.GroupBox2.Controls.Add(Me.lblGBrown)
        Me.GroupBox2.Controls.Add(Me.lblGGreen)
        Me.GroupBox2.Controls.Add(Me.lblGYellow)
        Me.GroupBox2.Controls.Add(Me.lblGBlue)
        Me.GroupBox2.Controls.Add(Me.lblGOrange)
        Me.GroupBox2.Controls.Add(Me.lblGRed)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 112)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblGSky
        '
        Me.lblGSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGSky.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGSky.Location = New System.Drawing.Point(186, 64)
        Me.lblGSky.Name = "lblGSky"
        Me.lblGSky.Size = New System.Drawing.Size(33, 30)
        Me.lblGSky.TabIndex = 0
        '
        'lblGBlack
        '
        Me.lblGBlack.BackColor = System.Drawing.Color.Black
        Me.lblGBlack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGBlack.Location = New System.Drawing.Point(186, 25)
        Me.lblGBlack.Name = "lblGBlack"
        Me.lblGBlack.Size = New System.Drawing.Size(33, 30)
        Me.lblGBlack.TabIndex = 0
        '
        'lblGWhite
        '
        Me.lblGWhite.BackColor = System.Drawing.Color.White
        Me.lblGWhite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGWhite.Location = New System.Drawing.Point(145, 64)
        Me.lblGWhite.Name = "lblGWhite"
        Me.lblGWhite.Size = New System.Drawing.Size(33, 30)
        Me.lblGWhite.TabIndex = 0
        '
        'lblGViolet
        '
        Me.lblGViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblGViolet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGViolet.Location = New System.Drawing.Point(145, 25)
        Me.lblGViolet.Name = "lblGViolet"
        Me.lblGViolet.Size = New System.Drawing.Size(33, 30)
        Me.lblGViolet.TabIndex = 0
        '
        'lblGBrown
        '
        Me.lblGBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGBrown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGBrown.Location = New System.Drawing.Point(106, 64)
        Me.lblGBrown.Name = "lblGBrown"
        Me.lblGBrown.Size = New System.Drawing.Size(33, 30)
        Me.lblGBrown.TabIndex = 0
        '
        'lblGGreen
        '
        Me.lblGGreen.BackColor = System.Drawing.Color.Lime
        Me.lblGGreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGGreen.Location = New System.Drawing.Point(106, 25)
        Me.lblGGreen.Name = "lblGGreen"
        Me.lblGGreen.Size = New System.Drawing.Size(33, 30)
        Me.lblGGreen.TabIndex = 0
        '
        'lblGYellow
        '
        Me.lblGYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblGYellow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGYellow.Location = New System.Drawing.Point(67, 64)
        Me.lblGYellow.Name = "lblGYellow"
        Me.lblGYellow.Size = New System.Drawing.Size(33, 30)
        Me.lblGYellow.TabIndex = 0
        '
        'lblGBlue
        '
        Me.lblGBlue.BackColor = System.Drawing.Color.Blue
        Me.lblGBlue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGBlue.Location = New System.Drawing.Point(67, 25)
        Me.lblGBlue.Name = "lblGBlue"
        Me.lblGBlue.Size = New System.Drawing.Size(33, 30)
        Me.lblGBlue.TabIndex = 0
        '
        'lblGOrange
        '
        Me.lblGOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGOrange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGOrange.Location = New System.Drawing.Point(28, 64)
        Me.lblGOrange.Name = "lblGOrange"
        Me.lblGOrange.Size = New System.Drawing.Size(33, 30)
        Me.lblGOrange.TabIndex = 0
        '
        'lblGRed
        '
        Me.lblGRed.BackColor = System.Drawing.Color.Red
        Me.lblGRed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGRed.Location = New System.Drawing.Point(28, 25)
        Me.lblGRed.Name = "lblGRed"
        Me.lblGRed.Size = New System.Drawing.Size(33, 30)
        Me.lblGRed.TabIndex = 0
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 455)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmColor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFSky As System.Windows.Forms.Label
    Friend WithEvents lblFBlack As System.Windows.Forms.Label
    Friend WithEvents lblFWhite As System.Windows.Forms.Label
    Friend WithEvents lblFViolet As System.Windows.Forms.Label
    Friend WithEvents lblFBrown As System.Windows.Forms.Label
    Friend WithEvents lblFGreen As System.Windows.Forms.Label
    Friend WithEvents lblFYellow As System.Windows.Forms.Label
    Friend WithEvents lblFBlue As System.Windows.Forms.Label
    Friend WithEvents lblFOrange As System.Windows.Forms.Label
    Friend WithEvents lblFRed As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGSky As System.Windows.Forms.Label
    Friend WithEvents lblGBlack As System.Windows.Forms.Label
    Friend WithEvents lblGWhite As System.Windows.Forms.Label
    Friend WithEvents lblGViolet As System.Windows.Forms.Label
    Friend WithEvents lblGBrown As System.Windows.Forms.Label
    Friend WithEvents lblGGreen As System.Windows.Forms.Label
    Friend WithEvents lblGYellow As System.Windows.Forms.Label
    Friend WithEvents lblGBlue As System.Windows.Forms.Label
    Friend WithEvents lblGOrange As System.Windows.Forms.Label
    Friend WithEvents lblGRed As System.Windows.Forms.Label
End Class
