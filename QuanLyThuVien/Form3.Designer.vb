<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fqlsach
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fqlsach))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DtpDateadd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNamebook = New System.Windows.Forms.TextBox()
        Me.TxtNxb = New System.Windows.Forms.TextBox()
        Me.TxtCount = New System.Windows.Forms.TextBox()
        Me.TxtAuthorbook = New System.Windows.Forms.TextBox()
        Me.TxtCategorybook = New System.Windows.Forms.TextBox()
        Me.TxtGroupbook = New System.Windows.Forms.TextBox()
        Me.TxtIDbook = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAddbook = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DtpNgaynhapUpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNamebookupdate = New System.Windows.Forms.TextBox()
        Me.TxtNxbupdate = New System.Windows.Forms.TextBox()
        Me.TxtCountupdate = New System.Windows.Forms.TextBox()
        Me.TxtAuthorbookupdate = New System.Windows.Forms.TextBox()
        Me.TxtThloaiUpdate = New System.Windows.Forms.TextBox()
        Me.TxtGroupbookupdate = New System.Windows.Forms.TextBox()
        Me.TxtIDbookupdate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnEditbook = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvFindbook = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnFindbook = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtNamebookS = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnDeletebook = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtIDbookdelete = New System.Windows.Forms.TextBox()
        Me.BtnReturnpage2 = New System.Windows.Forms.Button()
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvFindbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.BtnReturnpage2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 613)
        Me.Panel1.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Script MT Bold", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(142, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(504, 72)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "TEEN LIBRARY"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(17, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(802, 487)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.BtnAddbook)
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(794, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thêm thông tin sách"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.DtpDateadd)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TxtNamebook)
        Me.Panel2.Controls.Add(Me.TxtNxb)
        Me.Panel2.Controls.Add(Me.TxtCount)
        Me.Panel2.Controls.Add(Me.TxtAuthorbook)
        Me.Panel2.Controls.Add(Me.TxtCategorybook)
        Me.Panel2.Controls.Add(Me.TxtGroupbook)
        Me.Panel2.Controls.Add(Me.TxtIDbook)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(33, 28)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(627, 302)
        Me.Panel2.TabIndex = 1
        '
        'DtpDateadd
        '
        Me.DtpDateadd.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue
        Me.DtpDateadd.Location = New System.Drawing.Point(143, 244)
        Me.DtpDateadd.Name = "DtpDateadd"
        Me.DtpDateadd.Size = New System.Drawing.Size(352, 29)
        Me.DtpDateadd.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ngày nhập"
        '
        'TxtNamebook
        '
        Me.TxtNamebook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TxtNamebook.Location = New System.Drawing.Point(143, 45)
        Me.TxtNamebook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamebook.Name = "TxtNamebook"
        Me.TxtNamebook.Size = New System.Drawing.Size(467, 29)
        Me.TxtNamebook.TabIndex = 13
        '
        'TxtNxb
        '
        Me.TxtNxb.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TxtNxb.Location = New System.Drawing.Point(143, 177)
        Me.TxtNxb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNxb.Name = "TxtNxb"
        Me.TxtNxb.Size = New System.Drawing.Size(352, 29)
        Me.TxtNxb.TabIndex = 11
        '
        'TxtCount
        '
        Me.TxtCount.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TxtCount.Location = New System.Drawing.Point(143, 210)
        Me.TxtCount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCount.Name = "TxtCount"
        Me.TxtCount.Size = New System.Drawing.Size(145, 29)
        Me.TxtCount.TabIndex = 12
        '
        'TxtAuthorbook
        '
        Me.TxtAuthorbook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TxtAuthorbook.Location = New System.Drawing.Point(143, 144)
        Me.TxtAuthorbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAuthorbook.Name = "TxtAuthorbook"
        Me.TxtAuthorbook.Size = New System.Drawing.Size(352, 29)
        Me.TxtAuthorbook.TabIndex = 10
        '
        'TxtCategorybook
        '
        Me.TxtCategorybook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TxtCategorybook.Location = New System.Drawing.Point(143, 78)
        Me.TxtCategorybook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCategorybook.Name = "TxtCategorybook"
        Me.TxtCategorybook.Size = New System.Drawing.Size(281, 29)
        Me.TxtCategorybook.TabIndex = 9
        '
        'TxtGroupbook
        '
        Me.TxtGroupbook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TxtGroupbook.Location = New System.Drawing.Point(143, 111)
        Me.TxtGroupbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGroupbook.Name = "TxtGroupbook"
        Me.TxtGroupbook.Size = New System.Drawing.Size(185, 29)
        Me.TxtGroupbook.TabIndex = 8
        '
        'TxtIDbook
        '
        Me.TxtIDbook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TxtIDbook.Location = New System.Drawing.Point(143, 12)
        Me.TxtIDbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtIDbook.Name = "TxtIDbook"
        Me.TxtIDbook.Size = New System.Drawing.Size(281, 29)
        Me.TxtIDbook.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Số lượng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Thể loại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tác giả"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nhà xuất bản"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nhóm sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên sách"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID sách"
        '
        'BtnAddbook
        '
        Me.BtnAddbook.BackgroundImage = CType(resources.GetObject("BtnAddbook.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddbook.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddbook.Location = New System.Drawing.Point(491, 334)
        Me.BtnAddbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddbook.Name = "BtnAddbook"
        Me.BtnAddbook.Size = New System.Drawing.Size(169, 37)
        Me.BtnAddbook.TabIndex = 0
        Me.BtnAddbook.Text = "Thêm"
        Me.BtnAddbook.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.BtnEditbook)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(794, 453)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cập nhật thông tin sách theo ID"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.DtpNgaynhapUpdate)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.TxtNamebookupdate)
        Me.Panel4.Controls.Add(Me.TxtNxbupdate)
        Me.Panel4.Controls.Add(Me.TxtCountupdate)
        Me.Panel4.Controls.Add(Me.TxtAuthorbookupdate)
        Me.Panel4.Controls.Add(Me.TxtThloaiUpdate)
        Me.Panel4.Controls.Add(Me.TxtGroupbookupdate)
        Me.Panel4.Controls.Add(Me.TxtIDbookupdate)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(23, 17)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(627, 308)
        Me.Panel4.TabIndex = 2
        '
        'DtpNgaynhapUpdate
        '
        Me.DtpNgaynhapUpdate.CalendarMonthBackground = System.Drawing.SystemColors.Desktop
        Me.DtpNgaynhapUpdate.Location = New System.Drawing.Point(143, 271)
        Me.DtpNgaynhapUpdate.Name = "DtpNgaynhapUpdate"
        Me.DtpNgaynhapUpdate.Size = New System.Drawing.Size(352, 28)
        Me.DtpNgaynhapUpdate.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(17, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Ngày nhập"
        '
        'TxtNamebookupdate
        '
        Me.TxtNamebookupdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtNamebookupdate.Location = New System.Drawing.Point(143, 76)
        Me.TxtNamebookupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamebookupdate.Name = "TxtNamebookupdate"
        Me.TxtNamebookupdate.Size = New System.Drawing.Size(467, 28)
        Me.TxtNamebookupdate.TabIndex = 13
        '
        'TxtNxbupdate
        '
        Me.TxtNxbupdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtNxbupdate.Location = New System.Drawing.Point(143, 204)
        Me.TxtNxbupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNxbupdate.Name = "TxtNxbupdate"
        Me.TxtNxbupdate.Size = New System.Drawing.Size(352, 28)
        Me.TxtNxbupdate.TabIndex = 11
        '
        'TxtCountupdate
        '
        Me.TxtCountupdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtCountupdate.Location = New System.Drawing.Point(143, 237)
        Me.TxtCountupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCountupdate.Name = "TxtCountupdate"
        Me.TxtCountupdate.Size = New System.Drawing.Size(145, 28)
        Me.TxtCountupdate.TabIndex = 12
        '
        'TxtAuthorbookupdate
        '
        Me.TxtAuthorbookupdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtAuthorbookupdate.Location = New System.Drawing.Point(143, 172)
        Me.TxtAuthorbookupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAuthorbookupdate.Name = "TxtAuthorbookupdate"
        Me.TxtAuthorbookupdate.Size = New System.Drawing.Size(352, 28)
        Me.TxtAuthorbookupdate.TabIndex = 10
        '
        'TxtThloaiUpdate
        '
        Me.TxtThloaiUpdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtThloaiUpdate.Location = New System.Drawing.Point(143, 108)
        Me.TxtThloaiUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtThloaiUpdate.Name = "TxtThloaiUpdate"
        Me.TxtThloaiUpdate.Size = New System.Drawing.Size(281, 28)
        Me.TxtThloaiUpdate.TabIndex = 9
        '
        'TxtGroupbookupdate
        '
        Me.TxtGroupbookupdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtGroupbookupdate.Location = New System.Drawing.Point(143, 140)
        Me.TxtGroupbookupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGroupbookupdate.Name = "TxtGroupbookupdate"
        Me.TxtGroupbookupdate.Size = New System.Drawing.Size(185, 28)
        Me.TxtGroupbookupdate.TabIndex = 8
        '
        'TxtIDbookupdate
        '
        Me.TxtIDbookupdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtIDbookupdate.Location = New System.Drawing.Point(143, 44)
        Me.TxtIDbookupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtIDbookupdate.Name = "TxtIDbookupdate"
        Me.TxtIDbookupdate.Size = New System.Drawing.Size(281, 28)
        Me.TxtIDbookupdate.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(17, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 24)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Số lượng"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(26, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 24)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Thể loại"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(25, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 24)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Tác giả"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(17, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 24)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Nhà xuất bản"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(25, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 24)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Nhóm sách"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(26, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 24)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Tên sách"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(33, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 24)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "ID sách"
        '
        'BtnEditbook
        '
        Me.BtnEditbook.BackgroundImage = CType(resources.GetObject("BtnEditbook.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditbook.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditbook.Location = New System.Drawing.Point(481, 329)
        Me.BtnEditbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditbook.Name = "BtnEditbook"
        Me.BtnEditbook.Size = New System.Drawing.Size(169, 37)
        Me.BtnEditbook.TabIndex = 1
        Me.BtnEditbook.Text = "Sửa"
        Me.BtnEditbook.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.DgvFindbook)
        Me.TabPage3.Controls.Add(Me.Panel5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(794, 453)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tìm kiếm sách theo tên"
        '
        'DgvFindbook
        '
        Me.DgvFindbook.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DgvFindbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFindbook.Location = New System.Drawing.Point(10, 164)
        Me.DgvFindbook.Name = "DgvFindbook"
        Me.DgvFindbook.RowHeadersWidth = 51
        Me.DgvFindbook.RowTemplate.Height = 24
        Me.DgvFindbook.Size = New System.Drawing.Size(767, 273)
        Me.DgvFindbook.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.BtnFindbook)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.TxtNamebookS)
        Me.Panel5.Location = New System.Drawing.Point(20, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(700, 122)
        Me.Panel5.TabIndex = 16
        '
        'BtnFindbook
        '
        Me.BtnFindbook.BackgroundImage = CType(resources.GetObject("BtnFindbook.BackgroundImage"), System.Drawing.Image)
        Me.BtnFindbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFindbook.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFindbook.Location = New System.Drawing.Point(484, 70)
        Me.BtnFindbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFindbook.Name = "BtnFindbook"
        Me.BtnFindbook.Size = New System.Drawing.Size(169, 37)
        Me.BtnFindbook.TabIndex = 3
        Me.BtnFindbook.Text = "Tìm kiếm"
        Me.BtnFindbook.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(44, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 24)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Tên sách"
        '
        'TxtNamebookS
        '
        Me.TxtNamebookS.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TxtNamebookS.Location = New System.Drawing.Point(186, 23)
        Me.TxtNamebookS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamebookS.Name = "TxtNamebookS"
        Me.TxtNamebookS.Size = New System.Drawing.Size(467, 28)
        Me.TxtNamebookS.TabIndex = 15
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.Panel6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(794, 453)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Xóa sách theo ID"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnDeletebook)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.TxtIDbookdelete)
        Me.Panel6.Location = New System.Drawing.Point(42, 27)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(658, 154)
        Me.Panel6.TabIndex = 17
        '
        'BtnDeletebook
        '
        Me.BtnDeletebook.BackgroundImage = CType(resources.GetObject("BtnDeletebook.BackgroundImage"), System.Drawing.Image)
        Me.BtnDeletebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeletebook.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeletebook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDeletebook.Location = New System.Drawing.Point(484, 92)
        Me.BtnDeletebook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDeletebook.Name = "BtnDeletebook"
        Me.BtnDeletebook.Size = New System.Drawing.Size(169, 37)
        Me.BtnDeletebook.TabIndex = 2
        Me.BtnDeletebook.Text = "Xóa"
        Me.BtnDeletebook.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(33, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 28)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "ID sách"
        '
        'TxtIDbookdelete
        '
        Me.TxtIDbookdelete.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtIDbookdelete.Location = New System.Drawing.Point(130, 23)
        Me.TxtIDbookdelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtIDbookdelete.Name = "TxtIDbookdelete"
        Me.TxtIDbookdelete.Size = New System.Drawing.Size(467, 28)
        Me.TxtIDbookdelete.TabIndex = 15
        '
        'BtnReturnpage2
        '
        Me.BtnReturnpage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnReturnpage2.Location = New System.Drawing.Point(794, 2)
        Me.BtnReturnpage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnReturnpage2.Name = "BtnReturnpage2"
        Me.BtnReturnpage2.Size = New System.Drawing.Size(40, 28)
        Me.BtnReturnpage2.TabIndex = 4
        Me.BtnReturnpage2.Text = "<<"
        Me.BtnReturnpage2.UseVisualStyleBackColor = False
        '
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        '
        'Fqlsach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Fqlsach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý sách"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvFindbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAddbook As Button
    Friend WithEvents TxtNamebook As TextBox
    Friend WithEvents TxtNxb As TextBox
    Friend WithEvents TxtCount As TextBox
    Friend WithEvents TxtAuthorbook As TextBox
    Friend WithEvents TxtCategorybook As TextBox
    Friend WithEvents TxtGroupbook As TextBox
    Friend WithEvents TxtIDbook As TextBox
    Friend WithEvents BtnDeletebook As Button
    Friend WithEvents BtnEditbook As Button

    Friend WithEvents BOOKBindingSource As BindingSource

    Friend WithEvents BtnFindbook As Button
    Friend WithEvents MaSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TgiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NXBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnReturnpage2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpDateadd As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DtpNgaynhapUpdate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNamebookupdate As TextBox
    Friend WithEvents TxtNxbupdate As TextBox
    Friend WithEvents TxtCountupdate As TextBox
    Friend WithEvents TxtAuthorbookupdate As TextBox
    Friend WithEvents TxtThloaiUpdate As TextBox
    Friend WithEvents TxtGroupbookupdate As TextBox
    Friend WithEvents TxtIDbookupdate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtNamebookS As TextBox
    Friend WithEvents DgvFindbook As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtIDbookdelete As TextBox
    Friend WithEvents Label19 As Label
End Class
