<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fqltk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fqltk))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvDisplayAcc = New System.Windows.Forms.DataGridView()
        Me.BtnReturnP2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtReturnPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtPassWord = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtAccountUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDisplayAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.DgvDisplayAcc)
        Me.Panel1.Controls.Add(Me.BtnReturnP2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnUpdate)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(4, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 479)
        Me.Panel1.TabIndex = 0
        '
        'DgvDisplayAcc
        '
        Me.DgvDisplayAcc.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DgvDisplayAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDisplayAcc.Location = New System.Drawing.Point(234, 59)
        Me.DgvDisplayAcc.Name = "DgvDisplayAcc"
        Me.DgvDisplayAcc.RowHeadersWidth = 51
        Me.DgvDisplayAcc.RowTemplate.Height = 24
        Me.DgvDisplayAcc.Size = New System.Drawing.Size(341, 173)
        Me.DgvDisplayAcc.TabIndex = 10
        '
        'BtnReturnP2
        '
        Me.BtnReturnP2.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnReturnP2.Location = New System.Drawing.Point(942, 14)
        Me.BtnReturnP2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReturnP2.Name = "BtnReturnP2"
        Me.BtnReturnP2.Size = New System.Drawing.Size(33, 28)
        Me.BtnReturnP2.TabIndex = 9
        Me.BtnReturnP2.Text = "<<"
        Me.BtnReturnP2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Ravie", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 50)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Library"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Ravie", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 59)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TEEN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.MediumPurple
        Me.BtnLogout.BackgroundImage = CType(resources.GetObject("BtnLogout.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogout.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogout.Location = New System.Drawing.Point(492, 430)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(151, 33)
        Me.BtnLogout.TabIndex = 5
        Me.BtnLogout.Text = "Đăng xuất"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Plum
        Me.BtnUpdate.BackgroundImage = CType(resources.GetObject("BtnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUpdate.Location = New System.Drawing.Point(321, 430)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(151, 33)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Cập nhật"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.TxtReturnPass)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(14, 373)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(629, 55)
        Me.Panel4.TabIndex = 2
        '
        'TxtReturnPass
        '
        Me.TxtReturnPass.BackColor = System.Drawing.Color.SkyBlue
        Me.TxtReturnPass.Location = New System.Drawing.Point(201, 10)
        Me.TxtReturnPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtReturnPass.Name = "TxtReturnPass"
        Me.TxtReturnPass.Size = New System.Drawing.Size(424, 22)
        Me.TxtReturnPass.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(11, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nhập lại mật khẩu"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.TxtPassWord)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(14, 313)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(629, 55)
        Me.Panel3.TabIndex = 1
        '
        'TxtPassWord
        '
        Me.TxtPassWord.BackColor = System.Drawing.Color.SkyBlue
        Me.TxtPassWord.Location = New System.Drawing.Point(201, 10)
        Me.TxtPassWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPassWord.Name = "TxtPassWord"
        Me.TxtPassWord.Size = New System.Drawing.Size(424, 22)
        Me.TxtPassWord.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(11, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mật khẩu"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TxtAccountUsername)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(14, 253)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 55)
        Me.Panel2.TabIndex = 0
        '
        'TxtAccountUsername
        '
        Me.TxtAccountUsername.BackColor = System.Drawing.Color.SkyBlue
        Me.TxtAccountUsername.Location = New System.Drawing.Point(201, 10)
        Me.TxtAccountUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAccountUsername.Name = "TxtAccountUsername"
        Me.TxtAccountUsername.Size = New System.Drawing.Size(424, 22)
        Me.TxtAccountUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên đăng nhập"
        '
        'Fqltk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Fqltk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý tài khoản"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvDisplayAcc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtReturnPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtPassWord As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtAccountUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnReturnP2 As Button
    Friend WithEvents DgvDisplayAcc As DataGridView
End Class
