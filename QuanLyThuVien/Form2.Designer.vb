<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDisplay))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvBook = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýTàiKhoảnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngKýSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DgvBook)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 511)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(137, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(596, 77)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TEEN LIBRARY"
        '
        'DgvBook
        '
        Me.DgvBook.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBook.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DgvBook.Location = New System.Drawing.Point(5, 166)
        Me.DgvBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvBook.Name = "DgvBook"
        Me.DgvBook.RowHeadersWidth = 51
        Me.DgvBook.RowTemplate.Height = 24
        Me.DgvBook.Size = New System.Drawing.Size(917, 330)
        Me.DgvBook.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýSáchToolStripMenuItem, Me.QuảnLýTàiKhoảnToolStripMenuItem, Me.ĐăngKýSáchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(927, 31)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýSáchToolStripMenuItem
        '
        Me.QuảnLýSáchToolStripMenuItem.BackgroundImage = CType(resources.GetObject("QuảnLýSáchToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.QuảnLýSáchToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.QuảnLýSáchToolStripMenuItem.Name = "QuảnLýSáchToolStripMenuItem"
        Me.QuảnLýSáchToolStripMenuItem.Size = New System.Drawing.Size(123, 27)
        Me.QuảnLýSáchToolStripMenuItem.Text = "Quản lý sách"
        '
        'QuảnLýTàiKhoảnToolStripMenuItem
        '
        Me.QuảnLýTàiKhoảnToolStripMenuItem.BackgroundImage = CType(resources.GetObject("QuảnLýTàiKhoảnToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.QuảnLýTàiKhoảnToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Name = "QuảnLýTàiKhoảnToolStripMenuItem"
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Size = New System.Drawing.Size(161, 27)
        Me.QuảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản"
        '
        'ĐăngKýSáchToolStripMenuItem
        '
        Me.ĐăngKýSáchToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ĐăngKýSáchToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ĐăngKýSáchToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ĐăngKýSáchToolStripMenuItem.Name = "ĐăngKýSáchToolStripMenuItem"
        Me.ĐăngKýSáchToolStripMenuItem.Size = New System.Drawing.Size(125, 27)
        Me.ĐăngKýSáchToolStripMenuItem.Text = "Đăng ký sách"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'FDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giao diện chính của thư viện"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvBook As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QuảnLýSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýTàiKhoảnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐăngKýSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
End Class
