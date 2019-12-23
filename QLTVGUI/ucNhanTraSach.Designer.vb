<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucNhanTraSach
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbMaDocGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTinhTrang = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbNgayLap = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.dgDSSachMuon = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThoiGianMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbMaPTS = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.cbMaSach = New System.Windows.Forms.ComboBox()
        Me.dgDanhSachSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLuuVaThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbNgayTra = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDSSachMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(351, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 37)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "PHIẾU TRẢ SÁCH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(181, 86)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 28)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Ngày trả:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(181, 135)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 28)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Mã độc giả:"
        '
        'tbMaDocGia
        '
        Me.tbMaDocGia.AutoSize = True
        Me.tbMaDocGia.BackColor = System.Drawing.Color.White
        Me.tbMaDocGia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbMaDocGia.ForeColor = System.Drawing.Color.Silver
        Me.tbMaDocGia.HintForeColor = System.Drawing.Color.Empty
        Me.tbMaDocGia.HintText = ""
        Me.tbMaDocGia.isPassword = False
        Me.tbMaDocGia.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbMaDocGia.LineIdleColor = System.Drawing.Color.Silver
        Me.tbMaDocGia.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbMaDocGia.LineThickness = 2
        Me.tbMaDocGia.Location = New System.Drawing.Point(327, 127)
        Me.tbMaDocGia.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tbMaDocGia.Name = "tbMaDocGia"
        Me.tbMaDocGia.Size = New System.Drawing.Size(149, 44)
        Me.tbMaDocGia.TabIndex = 1
        Me.tbMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbTinhTrang)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbNgayLap)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbHoTen)
        Me.GroupBox1.Controls.Add(Me.dgDSSachMuon)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 181)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(853, 326)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin độc giả"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(432, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tình trạng thẻ: "
        '
        'lbTinhTrang
        '
        Me.lbTinhTrang.AutoSize = True
        Me.lbTinhTrang.BackColor = System.Drawing.Color.Gainsboro
        Me.lbTinhTrang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTinhTrang.ForeColor = System.Drawing.Color.Black
        Me.lbTinhTrang.Location = New System.Drawing.Point(568, 63)
        Me.lbTinhTrang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTinhTrang.Name = "lbTinhTrang"
        Me.lbTinhTrang.Size = New System.Drawing.Size(109, 23)
        Me.lbTinhTrang.TabIndex = 31
        Me.lbTinhTrang.Text = "Còn/Hết hạn"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(96, 94)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sách đang mượn:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(96, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ngày lập thẻ:"
        '
        'lbNgayLap
        '
        Me.lbNgayLap.AutoSize = True
        Me.lbNgayLap.BackColor = System.Drawing.Color.Gainsboro
        Me.lbNgayLap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgayLap.ForeColor = System.Drawing.Color.Black
        Me.lbNgayLap.Location = New System.Drawing.Point(235, 63)
        Me.lbNgayLap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayLap.Name = "lbNgayLap"
        Me.lbNgayLap.Size = New System.Drawing.Size(78, 23)
        Me.lbNgayLap.TabIndex = 31
        Me.lbNgayLap.Text = "Ngày lập"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(96, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Họ tên độc giả:"
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.BackColor = System.Drawing.Color.Gainsboro
        Me.lbHoTen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoTen.ForeColor = System.Drawing.Color.Black
        Me.lbHoTen.Location = New System.Drawing.Point(235, 34)
        Me.lbHoTen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(62, 23)
        Me.lbHoTen.TabIndex = 31
        Me.lbHoTen.Text = "Họ tên"
        '
        'dgDSSachMuon
        '
        Me.dgDSSachMuon.AllowUserToAddRows = False
        Me.dgDSSachMuon.AllowUserToDeleteRows = False
        Me.dgDSSachMuon.AllowUserToResizeColumns = False
        Me.dgDSSachMuon.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dgDSSachMuon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDSSachMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDSSachMuon.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgDSSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDSSachMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSSachMuon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDSSachMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ThoiGianMuon, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDSSachMuon.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDSSachMuon.DoubleBuffered = True
        Me.dgDSSachMuon.EnableHeadersVisualStyles = False
        Me.dgDSSachMuon.GridColor = System.Drawing.Color.Gray
        Me.dgDSSachMuon.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDSSachMuon.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDSSachMuon.Location = New System.Drawing.Point(8, 122)
        Me.dgDSSachMuon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgDSSachMuon.Name = "dgDSSachMuon"
        Me.dgDSSachMuon.ReadOnly = True
        Me.dgDSSachMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgDSSachMuon.Size = New System.Drawing.Size(835, 197)
        Me.dgDSSachMuon.TabIndex = 71
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã Sách"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 96
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 172.2419!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tên Sách"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 214
        '
        'ThoiGianMuon
        '
        Me.ThoiGianMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ThoiGianMuon.HeaderText = "Thời gian mượn"
        Me.ThoiGianMuon.Name = "ThoiGianMuon"
        Me.ThoiGianMuon.ReadOnly = True
        Me.ThoiGianMuon.Width = 145
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "Tình Trạng"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 130
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbMaPTS)
        Me.GroupBox2.Controls.Add(Me.label)
        Me.GroupBox2.Controls.Add(Me.cbMaSach)
        Me.GroupBox2.Controls.Add(Me.dgDanhSachSach)
        Me.GroupBox2.Controls.Add(Me.BunifuImageButton1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 534)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(853, 326)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin phiếu trả"
        '
        'lbMaPTS
        '
        Me.lbMaPTS.AutoSize = True
        Me.lbMaPTS.BackColor = System.Drawing.Color.Gainsboro
        Me.lbMaPTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbMaPTS.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbMaPTS.ForeColor = System.Drawing.Color.Red
        Me.lbMaPTS.Location = New System.Drawing.Point(672, 31)
        Me.lbMaPTS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaPTS.Name = "lbMaPTS"
        Me.lbMaPTS.Size = New System.Drawing.Size(89, 23)
        Me.lbMaPTS.TabIndex = 76
        Me.lbMaPTS.Text = "PMS00000"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Transparent
        Me.label.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.label.ForeColor = System.Drawing.Color.Red
        Me.label.Location = New System.Drawing.Point(524, 31)
        Me.label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(112, 23)
        Me.label.TabIndex = 75
        Me.label.Text = "Mã phiếu trả:"
        '
        'cbMaSach
        '
        Me.cbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaSach.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbMaSach.FormattingEnabled = True
        Me.cbMaSach.Location = New System.Drawing.Point(268, 64)
        Me.cbMaSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMaSach.Name = "cbMaSach"
        Me.cbMaSach.Size = New System.Drawing.Size(279, 36)
        Me.cbMaSach.TabIndex = 2
        '
        'dgDanhSachSach
        '
        Me.dgDanhSachSach.AllowUserToAddRows = False
        Me.dgDanhSachSach.AllowUserToOrderColumns = True
        Me.dgDanhSachSach.AllowUserToResizeColumns = False
        Me.dgDanhSachSach.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgDanhSachSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDanhSachSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSachSach.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgDanhSachSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSachSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSachSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSachSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.TenSach, Me.TheLoai, Me.TacGia})
        Me.dgDanhSachSach.DoubleBuffered = True
        Me.dgDanhSachSach.EnableHeadersVisualStyles = False
        Me.dgDanhSachSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSachSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSachSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSachSach.Location = New System.Drawing.Point(8, 117)
        Me.dgDanhSachSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgDanhSachSach.Name = "dgDanhSachSach"
        Me.dgDanhSachSach.ReadOnly = True
        Me.dgDanhSachSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgDanhSachSach.Size = New System.Drawing.Size(835, 197)
        Me.dgDanhSachSach.TabIndex = 3
        '
        'MaSach
        '
        Me.MaSach.FillWeight = 68.438!
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.ReadOnly = True
        Me.MaSach.Width = 96
        '
        'TenSach
        '
        Me.TenSach.FillWeight = 172.2419!
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.ReadOnly = True
        Me.TenSach.Width = 214
        '
        'TheLoai
        '
        Me.TheLoai.FillWeight = 90.76328!
        Me.TheLoai.HeaderText = "Thể Loại"
        Me.TheLoai.Name = "TheLoai"
        Me.TheLoai.ReadOnly = True
        Me.TheLoai.Width = 95
        '
        'TacGia
        '
        Me.TacGia.FillWeight = 93.9663!
        Me.TacGia.HeaderText = "Tác Giả"
        Me.TacGia.Name = "TacGia"
        Me.TacGia.ReadOnly = True
        Me.TacGia.Width = 180
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.QLTVGUI.My.Resources.Resources.minus_sign_inside_a_black_circle
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(556, 68)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(33, 31)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 31
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(164, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 28)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Tên sách:"
        '
        'btnLuuVaThoat
        '
        Me.btnLuuVaThoat.Activecolor = System.Drawing.Color.Silver
        Me.btnLuuVaThoat.BackColor = System.Drawing.Color.LightGray
        Me.btnLuuVaThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuuVaThoat.BorderRadius = 7
        Me.btnLuuVaThoat.ButtonText = "Lưu và Thoát"
        Me.btnLuuVaThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuuVaThoat.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuuVaThoat.ForeColor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuuVaThoat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Ok_64
        Me.btnLuuVaThoat.Iconimage_right = Nothing
        Me.btnLuuVaThoat.Iconimage_right_Selected = Nothing
        Me.btnLuuVaThoat.Iconimage_Selected = Nothing
        Me.btnLuuVaThoat.IconMarginLeft = 0
        Me.btnLuuVaThoat.IconMarginRight = 0
        Me.btnLuuVaThoat.IconRightVisible = True
        Me.btnLuuVaThoat.IconRightZoom = 0R
        Me.btnLuuVaThoat.IconVisible = True
        Me.btnLuuVaThoat.IconZoom = 60.0R
        Me.btnLuuVaThoat.IsTab = False
        Me.btnLuuVaThoat.Location = New System.Drawing.Point(367, 875)
        Me.btnLuuVaThoat.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnLuuVaThoat.Name = "btnLuuVaThoat"
        Me.btnLuuVaThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuuVaThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuuVaThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.selected = False
        Me.btnLuuVaThoat.Size = New System.Drawing.Size(201, 50)
        Me.btnLuuVaThoat.TabIndex = 5
        Me.btnLuuVaThoat.Text = "Lưu và Thoát"
        Me.btnLuuVaThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuuVaThoat.Textcolor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnThoat
        '
        Me.btnThoat.Activecolor = System.Drawing.Color.Silver
        Me.btnThoat.BackColor = System.Drawing.Color.LightGray
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThoat.BorderRadius = 7
        Me.btnThoat.ButtonText = "Thoát"
        Me.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThoat.DisabledColor = System.Drawing.Color.Silver
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThoat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Enter_64
        Me.btnThoat.Iconimage_right = Nothing
        Me.btnThoat.Iconimage_right_Selected = Nothing
        Me.btnThoat.Iconimage_Selected = Nothing
        Me.btnThoat.IconMarginLeft = 0
        Me.btnThoat.IconMarginRight = 0
        Me.btnThoat.IconRightVisible = True
        Me.btnThoat.IconRightZoom = 0R
        Me.btnThoat.IconVisible = True
        Me.btnThoat.IconZoom = 60.0R
        Me.btnThoat.IsTab = False
        Me.btnThoat.Location = New System.Drawing.Point(657, 875)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(201, 50)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoat.Textcolor = System.Drawing.Color.Black
        Me.btnThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnLuu
        '
        Me.btnLuu.Activecolor = System.Drawing.Color.Silver
        Me.btnLuu.BackColor = System.Drawing.Color.LightGray
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.BorderRadius = 7
        Me.btnLuu.ButtonText = "Lưu và Xuất"
        Me.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuu.ForeColor = System.Drawing.Color.Black
        Me.btnLuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
        Me.btnLuu.Iconimage_right = Nothing
        Me.btnLuu.Iconimage_right_Selected = Nothing
        Me.btnLuu.Iconimage_Selected = Nothing
        Me.btnLuu.IconMarginLeft = 0
        Me.btnLuu.IconMarginRight = 0
        Me.btnLuu.IconRightVisible = True
        Me.btnLuu.IconRightZoom = 0R
        Me.btnLuu.IconVisible = True
        Me.btnLuu.IconZoom = 60.0R
        Me.btnLuu.IsTab = False
        Me.btnLuu.Location = New System.Drawing.Point(76, 875)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(201, 50)
        Me.btnLuu.TabIndex = 4
        Me.btnLuu.Text = "Lưu và Xuất"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'lbNgayTra
        '
        Me.lbNgayTra.AutoSize = True
        Me.lbNgayTra.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgayTra.Location = New System.Drawing.Point(321, 86)
        Me.lbNgayTra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayTra.Name = "lbNgayTra"
        Me.lbNgayTra.Size = New System.Drawing.Size(69, 28)
        Me.lbNgayTra.TabIndex = 85
        Me.lbNgayTra.Text = "Label4"
        '
        'ucNhanTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbNgayTra)
        Me.Controls.Add(Me.btnLuuVaThoat)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbMaDocGia)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucNhanTraSach"
        Me.Size = New System.Drawing.Size(933, 942)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDSSachMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbMaDocGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbTinhTrang As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbNgayLap As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbHoTen As System.Windows.Forms.Label
    Friend WithEvents dgDSSachMuon As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDanhSachSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMaSach As System.Windows.Forms.ComboBox
    Friend WithEvents btnLuuVaThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbMaPTS As Label
    Friend WithEvents label As Label
    Friend WithEvents lbNgayTra As Label
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents TacGia As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ThoiGianMuon As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
