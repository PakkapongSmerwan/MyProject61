﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLap1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.pmoney = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.lbltotaltotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ชื่อ-สกุล"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินเดือน"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ชื่อ-สกุล"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "เงินเดือน"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(143, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "เงินเดือนทั้งหมด"
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(328, 59)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(182, 20)
        Me.pname.TabIndex = 1
        '
        'pmoney
        '
        Me.pmoney.Location = New System.Drawing.Point(328, 113)
        Me.pmoney.Name = "pmoney"
        Me.pmoney.Size = New System.Drawing.Size(182, 20)
        Me.pmoney.TabIndex = 2
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblname.Location = New System.Drawing.Point(328, 219)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(182, 23)
        Me.lblname.TabIndex = 4
        '
        'lblsalary
        '
        Me.lblsalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsalary.Location = New System.Drawing.Point(328, 284)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(182, 23)
        Me.lblsalary.TabIndex = 4
        '
        'lbltotaltotal
        '
        Me.lbltotaltotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltotaltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotaltotal.Location = New System.Drawing.Point(328, 344)
        Me.lbltotaltotal.Name = "lbltotaltotal"
        Me.lbltotaltotal.Size = New System.Drawing.Size(182, 23)
        Me.lbltotaltotal.TabIndex = 4
        '
        'frmLap1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 454)
        Me.Controls.Add(Me.lbltotaltotal)
        Me.Controls.Add(Me.lblsalary)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.pmoney)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmLap1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pname As System.Windows.Forms.TextBox
    Friend WithEvents pmoney As System.Windows.Forms.TextBox
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblsalary As System.Windows.Forms.Label
    Friend WithEvents lbltotaltotal As System.Windows.Forms.Label

End Class
