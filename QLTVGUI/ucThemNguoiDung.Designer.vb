<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThemNguoiDung
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbNgayTao = New System.Windows.Forms.Label()
        Me.lbMaNguoiDung = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHoTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbSoDienThoai = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbCMND = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbDiaChi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.cbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.cbVaiTro = New System.Windows.Forms.ComboBox()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'lbNgayTao
        '
        Me.lbNgayTao.AutoSize = True
        Me.lbNgayTao.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgayTao.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbNgayTao.Location = New System.Drawing.Point(159, 119)
        Me.lbNgayTao.Name = "lbNgayTao"
        Me.lbNgayTao.Size = New System.Drawing.Size(83, 21)
        Me.lbNgayTao.TabIndex = 24
        Me.lbNgayTao.Text = "lbNgayTao"
        '
        'lbMaNguoiDung
        '
        Me.lbMaNguoiDung.AutoSize = True
        Me.lbMaNguoiDung.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaNguoiDung.ForeColor = System.Drawing.Color.Red
        Me.lbMaNguoiDung.Location = New System.Drawing.Point(159, 79)
        Me.lbMaNguoiDung.Name = "lbMaNguoiDung"
        Me.lbMaNguoiDung.Size = New System.Drawing.Size(126, 21)
        Me.lbMaNguoiDung.TabIndex = 23
        Me.lbMaNguoiDung.Text = "lbMaNguoiDung"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(33, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 21)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Ngày tạo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(33, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 21)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Vai trò:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(315, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Số điện thoại:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(315, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(316, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Số CMND:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(315, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Địa chỉ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(316, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Giới tính:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(316, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ngày sinh:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(316, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Họ tên:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(33, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 21)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Mã người dùng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(243, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "THÊM NGƯỜI DÙNG"
        '
        'tbHoTen
        '
        Me.tbHoTen.AutoSize = True
        Me.tbHoTen.BackColor = System.Drawing.Color.White
        Me.tbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbHoTen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbHoTen.ForeColor = System.Drawing.Color.Black
        Me.tbHoTen.HintForeColor = System.Drawing.Color.Empty
        Me.tbHoTen.HintText = ""
        Me.tbHoTen.isPassword = False
        Me.tbHoTen.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbHoTen.LineIdleColor = System.Drawing.Color.Silver
        Me.tbHoTen.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbHoTen.LineThickness = 2
        Me.tbHoTen.Location = New System.Drawing.Point(423, 64)
        Me.tbHoTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbHoTen.Name = "tbHoTen"
        Me.tbHoTen.Size = New System.Drawing.Size(250, 36)
        Me.tbHoTen.TabIndex = 25
        Me.tbHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbSoDienThoai
        '
        Me.tbSoDienThoai.AutoSize = True
        Me.tbSoDienThoai.BackColor = System.Drawing.Color.White
        Me.tbSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSoDienThoai.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbSoDienThoai.ForeColor = System.Drawing.Color.Black
        Me.tbSoDienThoai.HintForeColor = System.Drawing.Color.Empty
        Me.tbSoDienThoai.HintText = ""
        Me.tbSoDienThoai.isPassword = False
        Me.tbSoDienThoai.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbSoDienThoai.LineIdleColor = System.Drawing.Color.Silver
        Me.tbSoDienThoai.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbSoDienThoai.LineThickness = 2
        Me.tbSoDienThoai.Location = New System.Drawing.Point(423, 304)
        Me.tbSoDienThoai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSoDienThoai.Name = "tbSoDienThoai"
        Me.tbSoDienThoai.Size = New System.Drawing.Size(250, 36)
        Me.tbSoDienThoai.TabIndex = 25
        Me.tbSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbCMND
        '
        Me.tbCMND.AutoSize = True
        Me.tbCMND.BackColor = System.Drawing.Color.White
        Me.tbCMND.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCMND.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbCMND.ForeColor = System.Drawing.Color.Black
        Me.tbCMND.HintForeColor = System.Drawing.Color.Empty
        Me.tbCMND.HintText = ""
        Me.tbCMND.isPassword = False
        Me.tbCMND.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbCMND.LineIdleColor = System.Drawing.Color.Silver
        Me.tbCMND.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbCMND.LineThickness = 2
        Me.tbCMND.Location = New System.Drawing.Point(423, 184)
        Me.tbCMND.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCMND.Name = "tbCMND"
        Me.tbCMND.Size = New System.Drawing.Size(250, 36)
        Me.tbCMND.TabIndex = 25
        Me.tbCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbDiaChi
        '
        Me.tbDiaChi.AutoSize = True
        Me.tbDiaChi.BackColor = System.Drawing.Color.White
        Me.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbDiaChi.ForeColor = System.Drawing.Color.Black
        Me.tbDiaChi.HintForeColor = System.Drawing.Color.Empty
        Me.tbDiaChi.HintText = ""
        Me.tbDiaChi.isPassword = False
        Me.tbDiaChi.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineIdleColor = System.Drawing.Color.Silver
        Me.tbDiaChi.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineThickness = 2
        Me.tbDiaChi.Location = New System.Drawing.Point(423, 224)
        Me.tbDiaChi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(250, 36)
        Me.tbDiaChi.TabIndex = 25
        Me.tbDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbEmail
        '
        Me.tbEmail.AutoSize = True
        Me.tbEmail.BackColor = System.Drawing.Color.White
        Me.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbEmail.ForeColor = System.Drawing.Color.Black
        Me.tbEmail.HintForeColor = System.Drawing.Color.Empty
        Me.tbEmail.HintText = ""
        Me.tbEmail.isPassword = False
        Me.tbEmail.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbEmail.LineIdleColor = System.Drawing.Color.Silver
        Me.tbEmail.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbEmail.LineThickness = 2
        Me.tbEmail.Location = New System.Drawing.Point(423, 264)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(250, 36)
        Me.tbEmail.TabIndex = 25
        Me.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgaySinh.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgaySinh.CustomFormat = "ddddddddd, dd/MM/yyyy"
        Me.dtpNgaySinh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(423, 113)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(250, 29)
        Me.dtpNgaySinh.TabIndex = 26
        Me.dtpNgaySinh.Value = New Date(2018, 6, 28, 0, 0, 0, 0)
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbGioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGioiTinh.DropDownHeight = 100
        Me.cbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbGioiTinh.FormattingEnabled = True
        Me.cbGioiTinh.IntegralHeight = False
        Me.cbGioiTinh.Location = New System.Drawing.Point(423, 151)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Size = New System.Drawing.Size(76, 29)
        Me.cbGioiTinh.TabIndex = 27
        '
        'cbVaiTro
        '
        Me.cbVaiTro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbVaiTro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVaiTro.DropDownHeight = 100
        Me.cbVaiTro.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbVaiTro.FormattingEnabled = True
        Me.cbVaiTro.IntegralHeight = False
        Me.cbVaiTro.Location = New System.Drawing.Point(37, 191)
        Me.cbVaiTro.Name = "cbVaiTro"
        Me.cbVaiTro.Size = New System.Drawing.Size(248, 29)
        Me.cbVaiTro.TabIndex = 27
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
        Me.btnThoat.Location = New System.Drawing.Point(409, 450)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Salmon
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(117, 41)
        Me.btnThoat.TabIndex = 30
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
        Me.btnLuu.Location = New System.Drawing.Point(175, 450)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(117, 41)
        Me.btnLuu.TabIndex = 29
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'ucThemNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.cbVaiTro)
        Me.Controls.Add(Me.cbGioiTinh)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.tbSoDienThoai)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.tbCMND)
        Me.Controls.Add(Me.tbHoTen)
        Me.Controls.Add(Me.lbNgayTao)
        Me.Controls.Add(Me.lbMaNguoiDung)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucThemNguoiDung"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNgayTao As Label
    Friend WithEvents lbMaNguoiDung As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbHoTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbSoDienThoai As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbCMND As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbDiaChi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cbGioiTinh As ComboBox
    Friend WithEvents cbVaiTro As ComboBox
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
End Class
