<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnTaskBar = New System.Windows.Forms.Panel()
        Me.lbTroVe = New System.Windows.Forms.Label()
        Me.lbTrangThai = New System.Windows.Forms.Label()
        Me.ibtnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ibtnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.fpnZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnLogo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tbName = New System.Windows.Forms.Label()
        Me.btnBaoCao = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnQuanLyDocGia = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnQuanLySach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTraCuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnQuyDinh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNguoiDung = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.pnTaskBar.SuspendLayout()
        CType(Me.ibtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ibtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btnLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnTaskBar
        Me.BunifuDragControl1.Vertical = True
        '
        'pnTaskBar
        '
        Me.pnTaskBar.BackColor = System.Drawing.Color.LightGray
        Me.pnTaskBar.Controls.Add(Me.lbTroVe)
        Me.pnTaskBar.Controls.Add(Me.lbTrangThai)
        Me.pnTaskBar.Controls.Add(Me.ibtnMinimize)
        Me.pnTaskBar.Controls.Add(Me.ibtnExit)
        Me.pnTaskBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTaskBar.Location = New System.Drawing.Point(0, 0)
        Me.pnTaskBar.Name = "pnTaskBar"
        Me.pnTaskBar.Size = New System.Drawing.Size(962, 29)
        Me.pnTaskBar.TabIndex = 2
        '
        'lbTroVe
        '
        Me.lbTroVe.AutoSize = True
        Me.lbTroVe.BackColor = System.Drawing.Color.Transparent
        Me.lbTroVe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroVe.ForeColor = System.Drawing.Color.Blue
        Me.lbTroVe.Location = New System.Drawing.Point(185, 6)
        Me.lbTroVe.Name = "lbTroVe"
        Me.lbTroVe.Size = New System.Drawing.Size(67, 17)
        Me.lbTroVe.TabIndex = 99
        Me.lbTroVe.Text = "Đăng xuất"
        '
        'lbTrangThai
        '
        Me.lbTrangThai.AutoSize = True
        Me.lbTrangThai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTrangThai.Location = New System.Drawing.Point(12, 6)
        Me.lbTrangThai.Name = "lbTrangThai"
        Me.lbTrangThai.Size = New System.Drawing.Size(76, 17)
        Me.lbTrangThai.TabIndex = 1
        Me.lbTrangThai.Text = "lbTrangThai"
        Me.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ibtnMinimize
        '
        Me.ibtnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.ibtnMinimize.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Minimize_Window_64
        Me.ibtnMinimize.ImageActive = Nothing
        Me.ibtnMinimize.Location = New System.Drawing.Point(909, 2)
        Me.ibtnMinimize.Name = "ibtnMinimize"
        Me.ibtnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.ibtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibtnMinimize.TabIndex = 0
        Me.ibtnMinimize.TabStop = False
        Me.ibtnMinimize.Zoom = 25
        '
        'ibtnExit
        '
        Me.ibtnExit.BackColor = System.Drawing.Color.Transparent
        Me.ibtnExit.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Close_Window_64
        Me.ibtnExit.ImageActive = Nothing
        Me.ibtnExit.Location = New System.Drawing.Point(934, 2)
        Me.ibtnExit.Name = "ibtnExit"
        Me.ibtnExit.Size = New System.Drawing.Size(25, 25)
        Me.ibtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibtnExit.TabIndex = 0
        Me.ibtnExit.TabStop = False
        Me.ibtnExit.Zoom = 25
        '
        'fpnZone
        '
        Me.fpnZone.AutoScroll = True
        Me.fpnZone.AutoSize = True
        Me.fpnZone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.fpnZone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fpnZone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.fpnZone.Location = New System.Drawing.Point(251, 29)
        Me.fpnZone.Name = "fpnZone"
        Me.fpnZone.Size = New System.Drawing.Size(0, 0)
        Me.fpnZone.TabIndex = 1
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.btnLogo)
        Me.BunifuGradientPanel1.Controls.Add(Me.tbName)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 29)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(245, 124)
        Me.BunifuGradientPanel1.TabIndex = 11
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.Transparent
        Me.btnLogo.Image = Global.QLTVGUI.My.Resources.Resources._36336054_798363663702632_2571347381962407936_n1
        Me.btnLogo.ImageActive = Nothing
        Me.btnLogo.Location = New System.Drawing.Point(83, 9)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(71, 71)
        Me.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogo.TabIndex = 11
        Me.btnLogo.TabStop = False
        Me.btnLogo.Zoom = 10
        '
        'tbName
        '
        Me.tbName.AutoSize = True
        Me.tbName.BackColor = System.Drawing.Color.Transparent
        Me.tbName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbName.Location = New System.Drawing.Point(21, 85)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(202, 30)
        Me.tbName.TabIndex = 10
        Me.tbName.Text = "QUẢN LÝ THƯ VIỆN"
        '
        'btnBaoCao
        '
        Me.btnBaoCao.Activecolor = System.Drawing.Color.DimGray
        Me.btnBaoCao.BackColor = System.Drawing.Color.LightGray
        Me.btnBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBaoCao.BorderRadius = 7
        Me.btnBaoCao.ButtonText = "  Báo cáo - Thống kê"
        Me.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaoCao.DisabledColor = System.Drawing.Color.LightGray
        Me.btnBaoCao.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaoCao.ForeColor = System.Drawing.Color.White
        Me.btnBaoCao.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBaoCao.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Combo_Chart_64
        Me.btnBaoCao.Iconimage_right = Nothing
        Me.btnBaoCao.Iconimage_right_Selected = Nothing
        Me.btnBaoCao.Iconimage_Selected = Nothing
        Me.btnBaoCao.IconMarginLeft = 0
        Me.btnBaoCao.IconMarginRight = 0
        Me.btnBaoCao.IconRightVisible = True
        Me.btnBaoCao.IconRightZoom = 0R
        Me.btnBaoCao.IconVisible = True
        Me.btnBaoCao.IconZoom = 70.0R
        Me.btnBaoCao.IsTab = True
        Me.btnBaoCao.Location = New System.Drawing.Point(3, 389)
        Me.btnBaoCao.Name = "btnBaoCao"
        Me.btnBaoCao.Normalcolor = System.Drawing.Color.LightGray
        Me.btnBaoCao.OnHovercolor = System.Drawing.Color.Gray
        Me.btnBaoCao.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBaoCao.selected = False
        Me.btnBaoCao.Size = New System.Drawing.Size(220, 48)
        Me.btnBaoCao.TabIndex = 6
        Me.btnBaoCao.Text = "  Báo cáo - Thống kê"
        Me.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaoCao.Textcolor = System.Drawing.Color.Black
        Me.btnBaoCao.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnQuanLyDocGia
        '
        Me.btnQuanLyDocGia.Activecolor = System.Drawing.Color.DimGray
        Me.btnQuanLyDocGia.BackColor = System.Drawing.Color.LightGray
        Me.btnQuanLyDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuanLyDocGia.BorderRadius = 7
        Me.btnQuanLyDocGia.ButtonText = "  Quản lý độc giả"
        Me.btnQuanLyDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuanLyDocGia.DisabledColor = System.Drawing.Color.LightGray
        Me.btnQuanLyDocGia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuanLyDocGia.ForeColor = System.Drawing.Color.White
        Me.btnQuanLyDocGia.Iconcolor = System.Drawing.Color.Transparent
        Me.btnQuanLyDocGia.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_person_48
        Me.btnQuanLyDocGia.Iconimage_right = Nothing
        Me.btnQuanLyDocGia.Iconimage_right_Selected = Nothing
        Me.btnQuanLyDocGia.Iconimage_Selected = Nothing
        Me.btnQuanLyDocGia.IconMarginLeft = 0
        Me.btnQuanLyDocGia.IconMarginRight = 0
        Me.btnQuanLyDocGia.IconRightVisible = True
        Me.btnQuanLyDocGia.IconRightZoom = 0R
        Me.btnQuanLyDocGia.IconVisible = True
        Me.btnQuanLyDocGia.IconZoom = 70.0R
        Me.btnQuanLyDocGia.IsTab = True
        Me.btnQuanLyDocGia.Location = New System.Drawing.Point(3, 335)
        Me.btnQuanLyDocGia.Name = "btnQuanLyDocGia"
        Me.btnQuanLyDocGia.Normalcolor = System.Drawing.Color.LightGray
        Me.btnQuanLyDocGia.OnHovercolor = System.Drawing.Color.Gray
        Me.btnQuanLyDocGia.OnHoverTextColor = System.Drawing.Color.White
        Me.btnQuanLyDocGia.selected = False
        Me.btnQuanLyDocGia.Size = New System.Drawing.Size(220, 48)
        Me.btnQuanLyDocGia.TabIndex = 4
        Me.btnQuanLyDocGia.Text = "  Quản lý độc giả"
        Me.btnQuanLyDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuanLyDocGia.Textcolor = System.Drawing.Color.Black
        Me.btnQuanLyDocGia.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnQuanLySach
        '
        Me.btnQuanLySach.Activecolor = System.Drawing.Color.DimGray
        Me.btnQuanLySach.BackColor = System.Drawing.Color.LightGray
        Me.btnQuanLySach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuanLySach.BorderRadius = 7
        Me.btnQuanLySach.ButtonText = "  Quản lý sách"
        Me.btnQuanLySach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuanLySach.DisabledColor = System.Drawing.Color.LightGray
        Me.btnQuanLySach.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuanLySach.ForeColor = System.Drawing.Color.White
        Me.btnQuanLySach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnQuanLySach.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Course
        Me.btnQuanLySach.Iconimage_right = Nothing
        Me.btnQuanLySach.Iconimage_right_Selected = Nothing
        Me.btnQuanLySach.Iconimage_Selected = Nothing
        Me.btnQuanLySach.IconMarginLeft = 0
        Me.btnQuanLySach.IconMarginRight = 0
        Me.btnQuanLySach.IconRightVisible = True
        Me.btnQuanLySach.IconRightZoom = 0R
        Me.btnQuanLySach.IconVisible = True
        Me.btnQuanLySach.IconZoom = 70.0R
        Me.btnQuanLySach.IsTab = True
        Me.btnQuanLySach.Location = New System.Drawing.Point(3, 279)
        Me.btnQuanLySach.Name = "btnQuanLySach"
        Me.btnQuanLySach.Normalcolor = System.Drawing.Color.LightGray
        Me.btnQuanLySach.OnHovercolor = System.Drawing.Color.Gray
        Me.btnQuanLySach.OnHoverTextColor = System.Drawing.Color.White
        Me.btnQuanLySach.selected = False
        Me.btnQuanLySach.Size = New System.Drawing.Size(220, 48)
        Me.btnQuanLySach.TabIndex = 3
        Me.btnQuanLySach.Text = "  Quản lý sách"
        Me.btnQuanLySach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuanLySach.Textcolor = System.Drawing.Color.Black
        Me.btnQuanLySach.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Activecolor = System.Drawing.Color.DimGray
        Me.btnTraCuu.BackColor = System.Drawing.Color.LightGray
        Me.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTraCuu.BorderRadius = 7
        Me.btnTraCuu.ButtonText = "  Tra cứu"
        Me.btnTraCuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTraCuu.DisabledColor = System.Drawing.Color.LightGray
        Me.btnTraCuu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraCuu.ForeColor = System.Drawing.Color.White
        Me.btnTraCuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTraCuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Search_64
        Me.btnTraCuu.Iconimage_right = Nothing
        Me.btnTraCuu.Iconimage_right_Selected = Nothing
        Me.btnTraCuu.Iconimage_Selected = Nothing
        Me.btnTraCuu.IconMarginLeft = 0
        Me.btnTraCuu.IconMarginRight = 0
        Me.btnTraCuu.IconRightVisible = True
        Me.btnTraCuu.IconRightZoom = 0R
        Me.btnTraCuu.IconVisible = True
        Me.btnTraCuu.IconZoom = 70.0R
        Me.btnTraCuu.IsTab = True
        Me.btnTraCuu.Location = New System.Drawing.Point(3, 227)
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnTraCuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnTraCuu.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTraCuu.selected = False
        Me.btnTraCuu.Size = New System.Drawing.Size(220, 48)
        Me.btnTraCuu.TabIndex = 3
        Me.btnTraCuu.Text = "  Tra cứu"
        Me.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTraCuu.Textcolor = System.Drawing.Color.Black
        Me.btnTraCuu.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnQuyDinh
        '
        Me.btnQuyDinh.Activecolor = System.Drawing.Color.DimGray
        Me.btnQuyDinh.BackColor = System.Drawing.Color.LightGray
        Me.btnQuyDinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuyDinh.BorderRadius = 7
        Me.btnQuyDinh.ButtonText = "  Quy định"
        Me.btnQuyDinh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuyDinh.DisabledColor = System.Drawing.Color.LightGray
        Me.btnQuyDinh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuyDinh.ForeColor = System.Drawing.Color.White
        Me.btnQuyDinh.Iconcolor = System.Drawing.Color.Transparent
        Me.btnQuyDinh.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Term_64
        Me.btnQuyDinh.Iconimage_right = Nothing
        Me.btnQuyDinh.Iconimage_right_Selected = Nothing
        Me.btnQuyDinh.Iconimage_Selected = Nothing
        Me.btnQuyDinh.IconMarginLeft = 0
        Me.btnQuyDinh.IconMarginRight = 0
        Me.btnQuyDinh.IconRightVisible = True
        Me.btnQuyDinh.IconRightZoom = 0R
        Me.btnQuyDinh.IconVisible = True
        Me.btnQuyDinh.IconZoom = 70.0R
        Me.btnQuyDinh.IsTab = True
        Me.btnQuyDinh.Location = New System.Drawing.Point(3, 443)
        Me.btnQuyDinh.Name = "btnQuyDinh"
        Me.btnQuyDinh.Normalcolor = System.Drawing.Color.LightGray
        Me.btnQuyDinh.OnHovercolor = System.Drawing.Color.Gray
        Me.btnQuyDinh.OnHoverTextColor = System.Drawing.Color.White
        Me.btnQuyDinh.selected = False
        Me.btnQuyDinh.Size = New System.Drawing.Size(220, 48)
        Me.btnQuyDinh.TabIndex = 7
        Me.btnQuyDinh.Text = "  Quy định"
        Me.btnQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuyDinh.Textcolor = System.Drawing.Color.Black
        Me.btnQuyDinh.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNguoiDung
        '
        Me.btnNguoiDung.Activecolor = System.Drawing.Color.DimGray
        Me.btnNguoiDung.BackColor = System.Drawing.Color.LightGray
        Me.btnNguoiDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNguoiDung.BorderRadius = 7
        Me.btnNguoiDung.ButtonText = "  Người dùng"
        Me.btnNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNguoiDung.DisabledColor = System.Drawing.Color.LightGray
        Me.btnNguoiDung.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNguoiDung.ForeColor = System.Drawing.Color.White
        Me.btnNguoiDung.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNguoiDung.Iconimage = Global.QLTVGUI.My.Resources.Resources.Account_card
        Me.btnNguoiDung.Iconimage_right = Nothing
        Me.btnNguoiDung.Iconimage_right_Selected = Nothing
        Me.btnNguoiDung.Iconimage_Selected = Nothing
        Me.btnNguoiDung.IconMarginLeft = 0
        Me.btnNguoiDung.IconMarginRight = 0
        Me.btnNguoiDung.IconRightVisible = True
        Me.btnNguoiDung.IconRightZoom = 0R
        Me.btnNguoiDung.IconVisible = True
        Me.btnNguoiDung.IconZoom = 70.0R
        Me.btnNguoiDung.IsTab = True
        Me.btnNguoiDung.Location = New System.Drawing.Point(3, 173)
        Me.btnNguoiDung.Name = "btnNguoiDung"
        Me.btnNguoiDung.Normalcolor = System.Drawing.Color.LightGray
        Me.btnNguoiDung.OnHovercolor = System.Drawing.Color.Gray
        Me.btnNguoiDung.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNguoiDung.selected = False
        Me.btnNguoiDung.Size = New System.Drawing.Size(220, 48)
        Me.btnNguoiDung.TabIndex = 1
        Me.btnNguoiDung.Text = "  Người dùng"
        Me.btnNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNguoiDung.Textcolor = System.Drawing.Color.Black
        Me.btnNguoiDung.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pbMenu
        '
        Me.pbMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbMenu.Image = Global.QLTVGUI.My.Resources.Resources.blankpage1
        Me.pbMenu.Location = New System.Drawing.Point(0, 29)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(250, 521)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMenu.TabIndex = 0
        Me.pbMenu.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(962, 550)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.btnBaoCao)
        Me.Controls.Add(Me.btnQuanLyDocGia)
        Me.Controls.Add(Me.btnQuanLySach)
        Me.Controls.Add(Me.btnTraCuu)
        Me.Controls.Add(Me.btnQuyDinh)
        Me.Controls.Add(Me.btnNguoiDung)
        Me.Controls.Add(Me.fpnZone)
        Me.Controls.Add(Me.pbMenu)
        Me.Controls.Add(Me.pnTaskBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ THƯ VIỆN"
        Me.pnTaskBar.ResumeLayout(False)
        Me.pnTaskBar.PerformLayout()
        CType(Me.ibtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ibtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.btnLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbMenu As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents fpnZone As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnTaskBar As System.Windows.Forms.Panel
    Friend WithEvents ibtnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ibtnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnNguoiDung As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTraCuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnQuanLyDocGia As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBaoCao As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbTrangThai As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnLogo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tbName As Label
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnThongTinDocGia As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnQuanLySach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnQuyDinh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbTroVe As Label
End Class
