<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucChoMuonSach
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaDocGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuuVaxuat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbNgayMuon = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbMaPhieuMuon = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbThuThu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbHoTenDocGia = New System.Windows.Forms.Label()
        Me.dgDanhSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MaCuonSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenCuonSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbThongBao = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTong = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbThemMaSach = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btAddTheLoai = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dgDSCanMuon = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NhaXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbTroVe = New System.Windows.Forms.Label()
        Me.lbXoaDanhSach = New System.Windows.Forms.Label()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDSCanMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(332, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PHIẾU MƯỢN SÁCH"
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
        Me.tbMaDocGia.Location = New System.Drawing.Point(719, 146)
        Me.tbMaDocGia.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tbMaDocGia.Name = "tbMaDocGia"
        Me.tbMaDocGia.Size = New System.Drawing.Size(176, 44)
        Me.tbMaDocGia.TabIndex = 1
        Me.tbMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(589, 160)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 28)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Mã độc giả:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(81, 121)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 28)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Ngày mượn:"
        '
        'btnLuu
        '
        Me.btnLuu.Activecolor = System.Drawing.Color.Silver
        Me.btnLuu.BackColor = System.Drawing.Color.LightGray
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.BorderRadius = 7
        Me.btnLuu.ButtonText = "Lưu"
        Me.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuu.ForeColor = System.Drawing.Color.Black
        Me.btnLuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Ok_64
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
        Me.btnLuu.Location = New System.Drawing.Point(571, 769)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(137, 50)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnLuuVaxuat
        '
        Me.btnLuuVaxuat.Activecolor = System.Drawing.Color.Silver
        Me.btnLuuVaxuat.BackColor = System.Drawing.Color.LightGray
        Me.btnLuuVaxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuuVaxuat.BorderRadius = 7
        Me.btnLuuVaxuat.ButtonText = "Lưu và Xuất "
        Me.btnLuuVaxuat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuuVaxuat.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuuVaxuat.ForeColor = System.Drawing.Color.Black
        Me.btnLuuVaxuat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuuVaxuat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
        Me.btnLuuVaxuat.Iconimage_right = Nothing
        Me.btnLuuVaxuat.Iconimage_right_Selected = Nothing
        Me.btnLuuVaxuat.Iconimage_Selected = Nothing
        Me.btnLuuVaxuat.IconMarginLeft = 0
        Me.btnLuuVaxuat.IconMarginRight = 0
        Me.btnLuuVaxuat.IconRightVisible = True
        Me.btnLuuVaxuat.IconRightZoom = 0R
        Me.btnLuuVaxuat.IconVisible = True
        Me.btnLuuVaxuat.IconZoom = 60.0R
        Me.btnLuuVaxuat.IsTab = False
        Me.btnLuuVaxuat.Location = New System.Drawing.Point(223, 769)
        Me.btnLuuVaxuat.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnLuuVaxuat.Name = "btnLuuVaxuat"
        Me.btnLuuVaxuat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuuVaxuat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuuVaxuat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuuVaxuat.selected = False
        Me.btnLuuVaxuat.Size = New System.Drawing.Size(228, 50)
        Me.btnLuuVaxuat.TabIndex = 4
        Me.btnLuuVaxuat.Text = "Lưu và Xuất "
        Me.btnLuuVaxuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuuVaxuat.Textcolor = System.Drawing.Color.Black
        Me.btnLuuVaxuat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'lbNgayMuon
        '
        Me.lbNgayMuon.AutoSize = True
        Me.lbNgayMuon.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgayMuon.ForeColor = System.Drawing.Color.Blue
        Me.lbNgayMuon.Location = New System.Drawing.Point(217, 121)
        Me.lbNgayMuon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgayMuon.Name = "lbNgayMuon"
        Me.lbNgayMuon.Size = New System.Drawing.Size(128, 28)
        Me.lbNgayMuon.TabIndex = 86
        Me.lbNgayMuon.Text = "lbNgayMuon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(44, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 28)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Mã phiếu mượn:"
        '
        'lbMaPhieuMuon
        '
        Me.lbMaPhieuMuon.AutoSize = True
        Me.lbMaPhieuMuon.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaPhieuMuon.ForeColor = System.Drawing.Color.Red
        Me.lbMaPhieuMuon.Location = New System.Drawing.Point(217, 81)
        Me.lbMaPhieuMuon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaPhieuMuon.Name = "lbMaPhieuMuon"
        Me.lbMaPhieuMuon.Size = New System.Drawing.Size(157, 28)
        Me.lbMaPhieuMuon.TabIndex = 86
        Me.lbMaPhieuMuon.Text = "lbMaPhieuMuon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(43, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 28)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Người lập phiếu:"
        '
        'lbThuThu
        '
        Me.lbThuThu.AutoSize = True
        Me.lbThuThu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbThuThu.ForeColor = System.Drawing.Color.Blue
        Me.lbThuThu.Location = New System.Drawing.Point(217, 158)
        Me.lbThuThu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbThuThu.Name = "lbThuThu"
        Me.lbThuThu.Size = New System.Drawing.Size(93, 28)
        Me.lbThuThu.TabIndex = 86
        Me.lbThuThu.Text = "lbThuThu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(44, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 28)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "-THÔNG TIN MƯỢN SÁCH-"
        '
        'lbHoTenDocGia
        '
        Me.lbHoTenDocGia.AutoSize = True
        Me.lbHoTenDocGia.BackColor = System.Drawing.Color.Transparent
        Me.lbHoTenDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoTenDocGia.ForeColor = System.Drawing.Color.Black
        Me.lbHoTenDocGia.Location = New System.Drawing.Point(320, 218)
        Me.lbHoTenDocGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHoTenDocGia.Name = "lbHoTenDocGia"
        Me.lbHoTenDocGia.Size = New System.Drawing.Size(148, 28)
        Me.lbHoTenDocGia.TabIndex = 74
        Me.lbHoTenDocGia.Text = "lbHoTenDocGia"
        '
        'dgDanhSach
        '
        Me.dgDanhSach.AllowUserToAddRows = False
        Me.dgDanhSach.AllowUserToDeleteRows = False
        Me.dgDanhSach.AllowUserToResizeColumns = False
        Me.dgDanhSach.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaCuonSach, Me.TenCuonSach, Me.NgayMuon})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDanhSach.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDanhSach.DoubleBuffered = True
        Me.dgDanhSach.EnableHeadersVisualStyles = False
        Me.dgDanhSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.Location = New System.Drawing.Point(87, 260)
        Me.dgDanhSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgDanhSach.Name = "dgDanhSach"
        Me.dgDanhSach.ReadOnly = True
        Me.dgDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDanhSach.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDanhSach.Size = New System.Drawing.Size(777, 134)
        Me.dgDanhSach.TabIndex = 90
        '
        'MaCuonSach
        '
        Me.MaCuonSach.HeaderText = "Mã cuốn sách"
        Me.MaCuonSach.Name = "MaCuonSach"
        Me.MaCuonSach.ReadOnly = True
        Me.MaCuonSach.Width = 120
        '
        'TenCuonSach
        '
        Me.TenCuonSach.HeaderText = "Tên cuốn sách"
        Me.TenCuonSach.Name = "TenCuonSach"
        Me.TenCuonSach.ReadOnly = True
        Me.TenCuonSach.Width = 270
        '
        'NgayMuon
        '
        Me.NgayMuon.HeaderText = "Ngày mượn"
        Me.NgayMuon.Name = "NgayMuon"
        Me.NgayMuon.ReadOnly = True
        Me.NgayMuon.Width = 150
        '
        'lbThongBao
        '
        Me.lbThongBao.BackColor = System.Drawing.Color.Transparent
        Me.lbThongBao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThongBao.ForeColor = System.Drawing.Color.Red
        Me.lbThongBao.Location = New System.Drawing.Point(91, 405)
        Me.lbThongBao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbThongBao.Name = "lbThongBao"
        Me.lbThongBao.Size = New System.Drawing.Size(617, 26)
        Me.lbThongBao.TabIndex = 74
        Me.lbThongBao.Text = "lbThongBao"
        Me.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(715, 409)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 23)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Tổng số:"
        '
        'lbTong
        '
        Me.lbTong.AutoSize = True
        Me.lbTong.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTong.ForeColor = System.Drawing.Color.Blue
        Me.lbTong.Location = New System.Drawing.Point(801, 409)
        Me.lbTong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTong.Name = "lbTong"
        Me.lbTong.Size = New System.Drawing.Size(61, 23)
        Me.lbTong.TabIndex = 86
        Me.lbTong.Text = "lbTong"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(45, 452)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(280, 28)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "-CHI TIẾT PHIẾU MƯỢN SÁCH-"
        '
        'tbThemMaSach
        '
        Me.tbThemMaSach.AutoSize = True
        Me.tbThemMaSach.BackColor = System.Drawing.Color.White
        Me.tbThemMaSach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbThemMaSach.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbThemMaSach.ForeColor = System.Drawing.Color.Silver
        Me.tbThemMaSach.HintForeColor = System.Drawing.Color.Empty
        Me.tbThemMaSach.HintText = ""
        Me.tbThemMaSach.isPassword = False
        Me.tbThemMaSach.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbThemMaSach.LineIdleColor = System.Drawing.Color.Silver
        Me.tbThemMaSach.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbThemMaSach.LineThickness = 2
        Me.tbThemMaSach.Location = New System.Drawing.Point(247, 487)
        Me.tbThemMaSach.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tbThemMaSach.Name = "tbThemMaSach"
        Me.tbThemMaSach.Size = New System.Drawing.Size(176, 44)
        Me.tbThemMaSach.TabIndex = 1
        Me.tbThemMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(81, 501)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 28)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Mã cuốn sách:"
        '
        'btAddTheLoai
        '
        Me.btAddTheLoai.BackColor = System.Drawing.Color.Transparent
        Me.btAddTheLoai.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btAddTheLoai.ImageActive = Nothing
        Me.btAddTheLoai.Location = New System.Drawing.Point(439, 490)
        Me.btAddTheLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btAddTheLoai.Name = "btAddTheLoai"
        Me.btAddTheLoai.Size = New System.Drawing.Size(40, 41)
        Me.btAddTheLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btAddTheLoai.TabIndex = 91
        Me.btAddTheLoai.TabStop = False
        Me.btAddTheLoai.Zoom = 10
        '
        'dgDSCanMuon
        '
        Me.dgDSCanMuon.AllowUserToAddRows = False
        Me.dgDSCanMuon.AllowUserToResizeColumns = False
        Me.dgDSCanMuon.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDSCanMuon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgDSCanMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDSCanMuon.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDSCanMuon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDSCanMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSCanMuon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgDSCanMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDSCanMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.NhaXuatBan, Me.TacGia, Me.TheLoai, Me.TriGia})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDSCanMuon.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgDSCanMuon.DoubleBuffered = True
        Me.dgDSCanMuon.EnableHeadersVisualStyles = False
        Me.dgDSCanMuon.GridColor = System.Drawing.Color.Gray
        Me.dgDSCanMuon.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDSCanMuon.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDSCanMuon.Location = New System.Drawing.Point(87, 553)
        Me.dgDSCanMuon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgDSCanMuon.Name = "dgDSCanMuon"
        Me.dgDSCanMuon.ReadOnly = True
        Me.dgDSCanMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSCanMuon.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDSCanMuon.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgDSCanMuon.Size = New System.Drawing.Size(777, 178)
        Me.dgDSCanMuon.TabIndex = 90
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên sách"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'NhaXuatBan
        '
        Me.NhaXuatBan.HeaderText = "NXB"
        Me.NhaXuatBan.Name = "NhaXuatBan"
        Me.NhaXuatBan.ReadOnly = True
        '
        'TacGia
        '
        Me.TacGia.HeaderText = "Tác giả"
        Me.TacGia.Name = "TacGia"
        Me.TacGia.ReadOnly = True
        '
        'TheLoai
        '
        Me.TheLoai.HeaderText = "Thể loại"
        Me.TheLoai.Name = "TheLoai"
        Me.TheLoai.ReadOnly = True
        '
        'TriGia
        '
        Me.TriGia.HeaderText = "Trị giá"
        Me.TriGia.Name = "TriGia"
        Me.TriGia.ReadOnly = True
        '
        'lbTroVe
        '
        Me.lbTroVe.AutoSize = True
        Me.lbTroVe.BackColor = System.Drawing.Color.Transparent
        Me.lbTroVe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroVe.ForeColor = System.Drawing.Color.Blue
        Me.lbTroVe.Location = New System.Drawing.Point(15, 26)
        Me.lbTroVe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTroVe.Name = "lbTroVe"
        Me.lbTroVe.Size = New System.Drawing.Size(85, 23)
        Me.lbTroVe.TabIndex = 92
        Me.lbTroVe.Text = "<< Trở về"
        '
        'lbXoaDanhSach
        '
        Me.lbXoaDanhSach.AutoSize = True
        Me.lbXoaDanhSach.BackColor = System.Drawing.Color.Transparent
        Me.lbXoaDanhSach.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbXoaDanhSach.ForeColor = System.Drawing.Color.Blue
        Me.lbXoaDanhSach.Location = New System.Drawing.Point(719, 501)
        Me.lbXoaDanhSach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbXoaDanhSach.Name = "lbXoaDanhSach"
        Me.lbXoaDanhSach.Size = New System.Drawing.Size(138, 28)
        Me.lbXoaDanhSach.TabIndex = 92
        Me.lbXoaDanhSach.Text = "Xoá danh sách"
        '
        'ucChoMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbXoaDanhSach)
        Me.Controls.Add(Me.lbTroVe)
        Me.Controls.Add(Me.btAddTheLoai)
        Me.Controls.Add(Me.dgDSCanMuon)
        Me.Controls.Add(Me.dgDanhSach)
        Me.Controls.Add(Me.lbMaPhieuMuon)
        Me.Controls.Add(Me.lbTong)
        Me.Controls.Add(Me.lbThuThu)
        Me.Controls.Add(Me.lbNgayMuon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbThongBao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbHoTenDocGia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbThemMaSach)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbMaDocGia)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnLuuVaxuat)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucChoMuonSach"
        Me.Size = New System.Drawing.Size(933, 841)
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDSCanMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuuVaxuat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMaDocGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbNgayMuon As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbMaPhieuMuon As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbThuThu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbHoTenDocGia As Label
    Friend WithEvents dgDanhSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lbThongBao As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbTong As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbThemMaSach As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents btAddTheLoai As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgDSCanMuon As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NhaXuatBan As DataGridViewTextBoxColumn
    Friend WithEvents TacGia As DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents TriGia As DataGridViewTextBoxColumn
    Friend WithEvents lbTroVe As Label
    Friend WithEvents MaCuonSach As DataGridViewTextBoxColumn
    Friend WithEvents TenCuonSach As DataGridViewTextBoxColumn
    Friend WithEvents NgayMuon As DataGridViewTextBoxColumn
    Friend WithEvents lbXoaDanhSach As Label
End Class
