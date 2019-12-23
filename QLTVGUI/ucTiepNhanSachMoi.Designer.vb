<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTiepNhanSachMoi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tbGhiChu = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nudViTriKe = New System.Windows.Forms.NumericUpDown()
        Me.nudSoLuong = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbThanhTien = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHuy = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.btAddTheLoai = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbTacGia = New System.Windows.Forms.ComboBox()
        Me.btnAddTacGia = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbNgonNgu = New System.Windows.Forms.ComboBox()
        Me.btnAddNgonNgu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudNamXuatBan = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbNhaXuatBan = New System.Windows.Forms.ComboBox()
        Me.tbTriGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbMaDauSach = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTenDauSach = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbTomTat = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbDSTheLoai = New System.Windows.Forms.Label()
        Me.lbXoaTheLoai = New System.Windows.Forms.Label()
        Me.lbDSTacGia = New System.Windows.Forms.Label()
        Me.lbXoaTacGia = New System.Windows.Forms.Label()
        Me.lbDSNgonNgu = New System.Windows.Forms.Label()
        Me.lbXoaNgonNgu = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudViTriKe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.btnAddTacGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.btnAddNgonNgu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNamXuatBan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(217, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TIẾP NHẬN ĐẦU SÁCH MỚI"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tbGhiChu)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.cbTinhTrang)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.nudViTriKe)
        Me.GroupBox5.Controls.Add(Me.nudSoLuong)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Location = New System.Drawing.Point(428, 41)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(254, 224)
        Me.GroupBox5.TabIndex = 48
        Me.GroupBox5.TabStop = False
        '
        'tbGhiChu
        '
        Me.tbGhiChu.AutoSize = True
        Me.tbGhiChu.BackColor = System.Drawing.Color.White
        Me.tbGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbGhiChu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbGhiChu.ForeColor = System.Drawing.Color.Black
        Me.tbGhiChu.HintForeColor = System.Drawing.Color.Empty
        Me.tbGhiChu.HintText = ""
        Me.tbGhiChu.isPassword = False
        Me.tbGhiChu.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbGhiChu.LineIdleColor = System.Drawing.Color.Silver
        Me.tbGhiChu.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbGhiChu.LineThickness = 2
        Me.tbGhiChu.Location = New System.Drawing.Point(12, 178)
        Me.tbGhiChu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbGhiChu.Name = "tbGhiChu"
        Me.tbGhiChu.Size = New System.Drawing.Size(229, 36)
        Me.tbGhiChu.TabIndex = 60
        Me.tbGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 150)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 21)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "Ghi chú:"
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTinhTrang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTinhTrang.DropDownHeight = 100
        Me.cbTinhTrang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.IntegralHeight = False
        Me.cbTinhTrang.Location = New System.Drawing.Point(98, 62)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(143, 29)
        Me.cbTinhTrang.TabIndex = 59
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(7, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 21)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Vị trí (kệ) *"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(5, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 21)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Tình trạng *"
        '
        'nudViTriKe
        '
        Me.nudViTriKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudViTriKe.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nudViTriKe.Location = New System.Drawing.Point(98, 106)
        Me.nudViTriKe.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudViTriKe.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudViTriKe.Name = "nudViTriKe"
        Me.nudViTriKe.Size = New System.Drawing.Size(87, 29)
        Me.nudViTriKe.TabIndex = 55
        Me.nudViTriKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudViTriKe.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSoLuong
        '
        Me.nudSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudSoLuong.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nudSoLuong.Location = New System.Drawing.Point(98, 20)
        Me.nudSoLuong.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudSoLuong.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSoLuong.Name = "nudSoLuong"
        Me.nudSoLuong.Size = New System.Drawing.Size(87, 29)
        Me.nudSoLuong.TabIndex = 55
        Me.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSoLuong.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 21)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Số lượng *"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(621, 320)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 21)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "VND"
        '
        'lbThanhTien
        '
        Me.lbThanhTien.BackColor = System.Drawing.Color.Gainsboro
        Me.lbThanhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbThanhTien.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbThanhTien.ForeColor = System.Drawing.Color.Red
        Me.lbThanhTien.Location = New System.Drawing.Point(441, 316)
        Me.lbThanhTien.Name = "lbThanhTien"
        Me.lbThanhTien.Size = New System.Drawing.Size(174, 29)
        Me.lbThanhTien.TabIndex = 60
        Me.lbThanhTien.Text = "0"
        Me.lbThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbThanhTien.UseWaitCursor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(436, 284)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 21)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Thành tiền:"
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
        Me.btnLuu.Location = New System.Drawing.Point(438, 369)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(117, 41)
        Me.btnLuu.TabIndex = 62
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnHuy
        '
        Me.btnHuy.Activecolor = System.Drawing.Color.Silver
        Me.btnHuy.BackColor = System.Drawing.Color.LightGray
        Me.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHuy.BorderRadius = 7
        Me.btnHuy.ButtonText = "Huỷ"
        Me.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHuy.DisabledColor = System.Drawing.Color.Silver
        Me.btnHuy.ForeColor = System.Drawing.Color.Black
        Me.btnHuy.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHuy.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Enter_64
        Me.btnHuy.Iconimage_right = Nothing
        Me.btnHuy.Iconimage_right_Selected = Nothing
        Me.btnHuy.Iconimage_Selected = Nothing
        Me.btnHuy.IconMarginLeft = 0
        Me.btnHuy.IconMarginRight = 0
        Me.btnHuy.IconRightVisible = True
        Me.btnHuy.IconRightZoom = 0R
        Me.btnHuy.IconVisible = True
        Me.btnHuy.IconZoom = 60.0R
        Me.btnHuy.IsTab = False
        Me.btnHuy.Location = New System.Drawing.Point(565, 369)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Normalcolor = System.Drawing.Color.LightGray
        Me.btnHuy.OnHovercolor = System.Drawing.Color.Salmon
        Me.btnHuy.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnHuy.selected = False
        Me.btnHuy.Size = New System.Drawing.Size(117, 41)
        Me.btnHuy.TabIndex = 63
        Me.btnHuy.Text = "Huỷ"
        Me.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHuy.Textcolor = System.Drawing.Color.Black
        Me.btnHuy.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btAddTheLoai)
        Me.GroupBox2.Controls.Add(Me.cbTheLoai)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lbDSTheLoai)
        Me.GroupBox2.Controls.Add(Me.lbXoaTheLoai)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 140)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thể loại  *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(34, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Danh sách:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 19)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Thêm thể loại:"
        '
        'cbTheLoai
        '
        Me.cbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTheLoai.DropDownHeight = 100
        Me.cbTheLoai.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.IntegralHeight = False
        Me.cbTheLoai.Location = New System.Drawing.Point(128, 33)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(196, 25)
        Me.cbTheLoai.TabIndex = 1
        '
        'btAddTheLoai
        '
        Me.btAddTheLoai.BackColor = System.Drawing.Color.Transparent
        Me.btAddTheLoai.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btAddTheLoai.ImageActive = Nothing
        Me.btAddTheLoai.Location = New System.Drawing.Point(330, 28)
        Me.btAddTheLoai.Name = "btAddTheLoai"
        Me.btAddTheLoai.Size = New System.Drawing.Size(30, 33)
        Me.btAddTheLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btAddTheLoai.TabIndex = 45
        Me.btAddTheLoai.TabStop = False
        Me.btAddTheLoai.Zoom = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.lbDSTacGia)
        Me.GroupBox3.Controls.Add(Me.lbXoaTacGia)
        Me.GroupBox3.Controls.Add(Me.btnAddTacGia)
        Me.GroupBox3.Controls.Add(Me.cbTacGia)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 459)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 140)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tác giả *"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(33, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 19)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Danh sách:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(19, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 19)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Thêm tác giả:"
        '
        'cbTacGia
        '
        Me.cbTacGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbTacGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTacGia.DropDownHeight = 100
        Me.cbTacGia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTacGia.FormattingEnabled = True
        Me.cbTacGia.IntegralHeight = False
        Me.cbTacGia.Location = New System.Drawing.Point(129, 33)
        Me.cbTacGia.Name = "cbTacGia"
        Me.cbTacGia.Size = New System.Drawing.Size(196, 25)
        Me.cbTacGia.TabIndex = 1
        '
        'btnAddTacGia
        '
        Me.btnAddTacGia.BackColor = System.Drawing.Color.Transparent
        Me.btnAddTacGia.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btnAddTacGia.ImageActive = Nothing
        Me.btnAddTacGia.Location = New System.Drawing.Point(331, 28)
        Me.btnAddTacGia.Name = "btnAddTacGia"
        Me.btnAddTacGia.Size = New System.Drawing.Size(30, 33)
        Me.btnAddTacGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddTacGia.TabIndex = 45
        Me.btnAddTacGia.TabStop = False
        Me.btnAddTacGia.Zoom = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.lbDSNgonNgu)
        Me.GroupBox4.Controls.Add(Me.lbXoaNgonNgu)
        Me.GroupBox4.Controls.Add(Me.btnAddNgonNgu)
        Me.GroupBox4.Controls.Add(Me.cbNgonNgu)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 605)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 140)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ngôn ngữ *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(34, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Danh sách:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(20, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Thêm tác giả:"
        '
        'cbNgonNgu
        '
        Me.cbNgonNgu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNgonNgu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNgonNgu.DropDownHeight = 100
        Me.cbNgonNgu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbNgonNgu.FormattingEnabled = True
        Me.cbNgonNgu.IntegralHeight = False
        Me.cbNgonNgu.Location = New System.Drawing.Point(130, 35)
        Me.cbNgonNgu.Name = "cbNgonNgu"
        Me.cbNgonNgu.Size = New System.Drawing.Size(196, 25)
        Me.cbNgonNgu.TabIndex = 47
        '
        'btnAddNgonNgu
        '
        Me.btnAddNgonNgu.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNgonNgu.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btnAddNgonNgu.ImageActive = Nothing
        Me.btnAddNgonNgu.Location = New System.Drawing.Point(332, 30)
        Me.btnAddNgonNgu.Name = "btnAddNgonNgu"
        Me.btnAddNgonNgu.Size = New System.Drawing.Size(30, 33)
        Me.btnAddNgonNgu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddNgonNgu.TabIndex = 50
        Me.btnAddNgonNgu.TabStop = False
        Me.btnAddNgonNgu.Zoom = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 21)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Trị giá *"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 231)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 21)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Tóm tắt:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(260, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 21)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "VND"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Năm xuất bản *"
        '
        'nudNamXuatBan
        '
        Me.nudNamXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudNamXuatBan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nudNamXuatBan.Location = New System.Drawing.Point(135, 140)
        Me.nudNamXuatBan.Maximum = New Decimal(New Integer() {2499, 0, 0, 0})
        Me.nudNamXuatBan.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudNamXuatBan.Name = "nudNamXuatBan"
        Me.nudNamXuatBan.Size = New System.Drawing.Size(113, 29)
        Me.nudNamXuatBan.TabIndex = 44
        Me.nudNamXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNamXuatBan.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 21)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Nhà xuất bản *"
        '
        'cbNhaXuatBan
        '
        Me.cbNhaXuatBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNhaXuatBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNhaXuatBan.DropDownHeight = 100
        Me.cbNhaXuatBan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNhaXuatBan.FormattingEnabled = True
        Me.cbNhaXuatBan.IntegralHeight = False
        Me.cbNhaXuatBan.Location = New System.Drawing.Point(135, 99)
        Me.cbNhaXuatBan.Name = "cbNhaXuatBan"
        Me.cbNhaXuatBan.Size = New System.Drawing.Size(256, 29)
        Me.cbNhaXuatBan.TabIndex = 48
        '
        'tbTriGia
        '
        Me.tbTriGia.AutoSize = True
        Me.tbTriGia.BackColor = System.Drawing.Color.White
        Me.tbTriGia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTriGia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbTriGia.ForeColor = System.Drawing.Color.Black
        Me.tbTriGia.HintForeColor = System.Drawing.Color.Empty
        Me.tbTriGia.HintText = ""
        Me.tbTriGia.isPassword = False
        Me.tbTriGia.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbTriGia.LineIdleColor = System.Drawing.Color.Silver
        Me.tbTriGia.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbTriGia.LineThickness = 2
        Me.tbTriGia.Location = New System.Drawing.Point(136, 179)
        Me.tbTriGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTriGia.Name = "tbTriGia"
        Me.tbTriGia.Size = New System.Drawing.Size(113, 36)
        Me.tbTriGia.TabIndex = 50
        Me.tbTriGia.Text = "0"
        Me.tbTriGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbMaDauSach
        '
        Me.lbMaDauSach.AutoSize = True
        Me.lbMaDauSach.BackColor = System.Drawing.Color.Gainsboro
        Me.lbMaDauSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbMaDauSach.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaDauSach.ForeColor = System.Drawing.Color.Red
        Me.lbMaDauSach.Location = New System.Drawing.Point(133, 26)
        Me.lbMaDauSach.Name = "lbMaDauSach"
        Me.lbMaDauSach.Size = New System.Drawing.Size(106, 21)
        Me.lbMaDauSach.TabIndex = 52
        Me.lbMaDauSach.Text = "lbMaDauSach"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 21)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Tên đầu sách *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Mã đầu sách:"
        '
        'tbTenDauSach
        '
        Me.tbTenDauSach.AutoSize = True
        Me.tbTenDauSach.BackColor = System.Drawing.Color.White
        Me.tbTenDauSach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTenDauSach.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbTenDauSach.ForeColor = System.Drawing.Color.Black
        Me.tbTenDauSach.HintForeColor = System.Drawing.Color.Empty
        Me.tbTenDauSach.HintText = ""
        Me.tbTenDauSach.isPassword = False
        Me.tbTenDauSach.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbTenDauSach.LineIdleColor = System.Drawing.Color.Silver
        Me.tbTenDauSach.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbTenDauSach.LineThickness = 2
        Me.tbTenDauSach.Location = New System.Drawing.Point(135, 56)
        Me.tbTenDauSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTenDauSach.Name = "tbTenDauSach"
        Me.tbTenDauSach.Size = New System.Drawing.Size(256, 36)
        Me.tbTenDauSach.TabIndex = 51
        Me.tbTenDauSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbTomTat
        '
        Me.tbTomTat.Location = New System.Drawing.Point(135, 223)
        Me.tbTomTat.Name = "tbTomTat"
        Me.tbTomTat.Size = New System.Drawing.Size(256, 84)
        Me.tbTomTat.TabIndex = 55
        Me.tbTomTat.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.tbTomTat)
        Me.GroupBox1.Controls.Add(Me.tbTenDauSach)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbMaDauSach)
        Me.GroupBox1.Controls.Add(Me.tbTriGia)
        Me.GroupBox1.Controls.Add(Me.cbNhaXuatBan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nudNamXuatBan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(14, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 761)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'lbDSTheLoai
        '
        Me.lbDSTheLoai.BackColor = System.Drawing.Color.Transparent
        Me.lbDSTheLoai.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbDSTheLoai.ForeColor = System.Drawing.Color.Black
        Me.lbDSTheLoai.Location = New System.Drawing.Point(126, 66)
        Me.lbDSTheLoai.Name = "lbDSTheLoai"
        Me.lbDSTheLoai.Size = New System.Drawing.Size(200, 71)
        Me.lbDSTheLoai.TabIndex = 40
        Me.lbDSTheLoai.Text = "lbDSTheLoai"
        '
        'lbXoaTheLoai
        '
        Me.lbXoaTheLoai.AutoSize = True
        Me.lbXoaTheLoai.BackColor = System.Drawing.Color.Transparent
        Me.lbXoaTheLoai.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Underline)
        Me.lbXoaTheLoai.ForeColor = System.Drawing.Color.Blue
        Me.lbXoaTheLoai.Location = New System.Drawing.Point(330, 66)
        Me.lbXoaTheLoai.Name = "lbXoaTheLoai"
        Me.lbXoaTheLoai.Size = New System.Drawing.Size(32, 19)
        Me.lbXoaTheLoai.TabIndex = 40
        Me.lbXoaTheLoai.Text = "Xoá"
        '
        'lbDSTacGia
        '
        Me.lbDSTacGia.BackColor = System.Drawing.Color.Transparent
        Me.lbDSTacGia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbDSTacGia.ForeColor = System.Drawing.Color.Black
        Me.lbDSTacGia.Location = New System.Drawing.Point(126, 60)
        Me.lbDSTacGia.Name = "lbDSTacGia"
        Me.lbDSTacGia.Size = New System.Drawing.Size(198, 73)
        Me.lbDSTacGia.TabIndex = 46
        Me.lbDSTacGia.Text = "lbDSTacGia"
        '
        'lbXoaTacGia
        '
        Me.lbXoaTacGia.AutoSize = True
        Me.lbXoaTacGia.BackColor = System.Drawing.Color.Transparent
        Me.lbXoaTacGia.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Underline)
        Me.lbXoaTacGia.ForeColor = System.Drawing.Color.Blue
        Me.lbXoaTacGia.Location = New System.Drawing.Point(331, 60)
        Me.lbXoaTacGia.Name = "lbXoaTacGia"
        Me.lbXoaTacGia.Size = New System.Drawing.Size(32, 19)
        Me.lbXoaTacGia.TabIndex = 47
        Me.lbXoaTacGia.Text = "Xoá"
        '
        'lbDSNgonNgu
        '
        Me.lbDSNgonNgu.BackColor = System.Drawing.Color.Transparent
        Me.lbDSNgonNgu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbDSNgonNgu.ForeColor = System.Drawing.Color.Black
        Me.lbDSNgonNgu.Location = New System.Drawing.Point(125, 62)
        Me.lbDSNgonNgu.Name = "lbDSNgonNgu"
        Me.lbDSNgonNgu.Size = New System.Drawing.Size(201, 70)
        Me.lbDSNgonNgu.TabIndex = 51
        Me.lbDSNgonNgu.Text = "lbDSNgonNgu"
        '
        'lbXoaNgonNgu
        '
        Me.lbXoaNgonNgu.AutoSize = True
        Me.lbXoaNgonNgu.BackColor = System.Drawing.Color.Transparent
        Me.lbXoaNgonNgu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Underline)
        Me.lbXoaNgonNgu.ForeColor = System.Drawing.Color.Blue
        Me.lbXoaNgonNgu.Location = New System.Drawing.Point(331, 61)
        Me.lbXoaNgonNgu.Name = "lbXoaNgonNgu"
        Me.lbXoaNgonNgu.Size = New System.Drawing.Size(32, 19)
        Me.lbXoaNgonNgu.TabIndex = 52
        Me.lbXoaNgonNgu.Text = "Xoá"
        '
        'ucTiepNhanSachMoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbThanhTien)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ucTiepNhanSachMoi"
        Me.Size = New System.Drawing.Size(700, 800)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudViTriKe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSoLuong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.btnAddTacGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.btnAddNgonNgu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNamXuatBan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tbGhiChu As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label21 As Label
    Friend WithEvents cbTinhTrang As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents nudViTriKe As NumericUpDown
    Friend WithEvents nudSoLuong As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbThanhTien As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnHuy As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btAddTheLoai As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAddTacGia As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cbTacGia As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnAddNgonNgu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cbNgonNgu As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nudNamXuatBan As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents cbNhaXuatBan As ComboBox
    Friend WithEvents tbTriGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbMaDauSach As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTenDauSach As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbTomTat As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbDSTheLoai As Label
    Friend WithEvents lbXoaTheLoai As Label
    Friend WithEvents lbDSTacGia As Label
    Friend WithEvents lbXoaTacGia As Label
    Friend WithEvents lbDSNgonNgu As Label
    Friend WithEvents lbXoaNgonNgu As Label
End Class
