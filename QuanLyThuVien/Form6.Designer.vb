<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRegisterAcc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRegisterAcc))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtGmailAcc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtNameAcc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtPassAcc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnExit0 = New System.Windows.Forms.Button()
        Me.BtnRegisterAcc = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TxtGmailAcc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 132)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 52)
        Me.Panel1.TabIndex = 0
        '
        'TxtGmailAcc
        '
        Me.TxtGmailAcc.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtGmailAcc.Location = New System.Drawing.Point(197, 15)
        Me.TxtGmailAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGmailAcc.Name = "TxtGmailAcc"
        Me.TxtGmailAcc.Size = New System.Drawing.Size(455, 22)
        Me.TxtGmailAcc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gmail"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TxtNameAcc)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(13, 190)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 52)
        Me.Panel2.TabIndex = 1
        '
        'TxtNameAcc
        '
        Me.TxtNameAcc.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtNameAcc.Location = New System.Drawing.Point(197, 15)
        Me.TxtNameAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNameAcc.Name = "TxtNameAcc"
        Me.TxtNameAcc.Size = New System.Drawing.Size(455, 22)
        Me.TxtNameAcc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên đăng nhập"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.TxtPassAcc)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(13, 249)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(709, 52)
        Me.Panel3.TabIndex = 2
        '
        'TxtPassAcc
        '
        Me.TxtPassAcc.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtPassAcc.Location = New System.Drawing.Point(197, 15)
        Me.TxtPassAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPassAcc.Name = "TxtPassAcc"
        Me.TxtPassAcc.Size = New System.Drawing.Size(455, 22)
        Me.TxtPassAcc.TabIndex = 3
        Me.TxtPassAcc.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mật khẩu"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.BtnExit0)
        Me.Panel4.Controls.Add(Me.BtnRegisterAcc)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Location = New System.Drawing.Point(12, 12)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(753, 428)
        Me.Panel4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bernard MT Condensed", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label4.Location = New System.Drawing.Point(375, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 55)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "LIBRARY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label3.Location = New System.Drawing.Point(186, 13)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 85)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TEEN "
        '
        'BtnExit0
        '
        Me.BtnExit0.BackColor = System.Drawing.Color.MediumPurple
        Me.BtnExit0.BackgroundImage = CType(resources.GetObject("BtnExit0.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit0.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnExit0.Location = New System.Drawing.Point(588, 353)
        Me.BtnExit0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnExit0.Name = "BtnExit0"
        Me.BtnExit0.Size = New System.Drawing.Size(121, 42)
        Me.BtnExit0.TabIndex = 5
        Me.BtnExit0.Text = "Thoát"
        Me.BtnExit0.UseVisualStyleBackColor = False
        '
        'BtnRegisterAcc
        '
        Me.BtnRegisterAcc.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BtnRegisterAcc.BackgroundImage = CType(resources.GetObject("BtnRegisterAcc.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegisterAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegisterAcc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnRegisterAcc.Location = New System.Drawing.Point(440, 353)
        Me.BtnRegisterAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegisterAcc.Name = "BtnRegisterAcc"
        Me.BtnRegisterAcc.Size = New System.Drawing.Size(124, 42)
        Me.BtnRegisterAcc.TabIndex = 4
        Me.BtnRegisterAcc.Text = "Đăng ký"
        Me.BtnRegisterAcc.UseVisualStyleBackColor = False
        '
        'FRegisterAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FRegisterAcc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng ký tài khoản quản lý thư viện"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtGmailAcc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtNameAcc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtPassAcc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnExit0 As Button
    Friend WithEvents BtnRegisterAcc As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
