<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTraCuuNguoiDung
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTraCuuNguoiDung))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbDiaChi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbHoTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbMaNguoiDung = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtpNgayTaoCaoNhat = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayTaoThapNhat = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudTuoiCaoNhat = New System.Windows.Forms.NumericUpDown()
        Me.nudTuoiThapNhat = New System.Windows.Forms.NumericUpDown()
        Me.cbVaiTro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDanhSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MaNguoiDung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaiTro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTraCuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbNgayTao = New System.Windows.Forms.Label()
        Me.lbVaiTro = New System.Windows.Forms.Label()
        Me.lbSoDienThoai = New System.Windows.Forms.Label()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbCMND = New System.Windows.Forms.Label()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.lbMaNguoiDung = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dot1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudTuoiCaoNhat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTuoiThapNhat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(229, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 30)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "TRA CỨU NGƯỜI DÙNG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbDiaChi)
        Me.GroupBox1.Controls.Add(Me.tbHoTen)
        Me.GroupBox1.Controls.Add(Me.tbMaNguoiDung)
        Me.GroupBox1.Controls.Add(Me.dtpNgayTaoCaoNhat)
        Me.GroupBox1.Controls.Add(Me.dtpNgayTaoThapNhat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.nudTuoiCaoNhat)
        Me.GroupBox1.Controls.Add(Me.nudTuoiThapNhat)
        Me.GroupBox1.Controls.Add(Me.cbVaiTro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 171)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'tbDiaChi
        '
        Me.tbDiaChi.AutoSize = True
        Me.tbDiaChi.BackColor = System.Drawing.Color.White
        Me.tbDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbDiaChi.ForeColor = System.Drawing.Color.Silver
        Me.tbDiaChi.HintForeColor = System.Drawing.Color.Empty
        Me.tbDiaChi.HintText = ""
        Me.tbDiaChi.isPassword = False
        Me.tbDiaChi.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineIdleColor = System.Drawing.Color.Silver
        Me.tbDiaChi.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbDiaChi.LineThickness = 2
        Me.tbDiaChi.Location = New System.Drawing.Point(133, 110)
        Me.tbDiaChi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(201, 36)
        Me.tbDiaChi.TabIndex = 78
        Me.tbDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbHoTen
        '
        Me.tbHoTen.AutoSize = True
        Me.tbHoTen.BackColor = System.Drawing.Color.White
        Me.tbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbHoTen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbHoTen.ForeColor = System.Drawing.Color.Silver
        Me.tbHoTen.HintForeColor = System.Drawing.Color.Empty
        Me.tbHoTen.HintText = ""
        Me.tbHoTen.isPassword = False
        Me.tbHoTen.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbHoTen.LineIdleColor = System.Drawing.Color.Silver
        Me.tbHoTen.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbHoTen.LineThickness = 2
        Me.tbHoTen.Location = New System.Drawing.Point(133, 67)
        Me.tbHoTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbHoTen.Name = "tbHoTen"
        Me.tbHoTen.Size = New System.Drawing.Size(201, 36)
        Me.tbHoTen.TabIndex = 78
        Me.tbHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbMaNguoiDung
        '
        Me.tbMaNguoiDung.AutoSize = True
        Me.tbMaNguoiDung.BackColor = System.Drawing.Color.White
        Me.tbMaNguoiDung.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaNguoiDung.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbMaNguoiDung.ForeColor = System.Drawing.Color.Silver
        Me.tbMaNguoiDung.HintForeColor = System.Drawing.Color.Empty
        Me.tbMaNguoiDung.HintText = ""
        Me.tbMaNguoiDung.isPassword = False
        Me.tbMaNguoiDung.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbMaNguoiDung.LineIdleColor = System.Drawing.Color.Silver
        Me.tbMaNguoiDung.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbMaNguoiDung.LineThickness = 2
        Me.tbMaNguoiDung.Location = New System.Drawing.Point(133, 21)
        Me.tbMaNguoiDung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMaNguoiDung.Name = "tbMaNguoiDung"
        Me.tbMaNguoiDung.Size = New System.Drawing.Size(201, 36)
        Me.tbMaNguoiDung.TabIndex = 78
        Me.tbMaNguoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dtpNgayTaoCaoNhat
        '
        Me.dtpNgayTaoCaoNhat.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTaoCaoNhat.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgayTaoCaoNhat.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgayTaoCaoNhat.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgayTaoCaoNhat.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayTaoCaoNhat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgayTaoCaoNhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayTaoCaoNhat.Location = New System.Drawing.Point(545, 117)
        Me.dtpNgayTaoCaoNhat.Name = "dtpNgayTaoCaoNhat"
        Me.dtpNgayTaoCaoNhat.Size = New System.Drawing.Size(108, 29)
        Me.dtpNgayTaoCaoNhat.TabIndex = 76
        Me.dtpNgayTaoCaoNhat.Value = New Date(2018, 6, 28, 0, 0, 0, 0)
        '
        'dtpNgayTaoThapNhat
        '
        Me.dtpNgayTaoThapNhat.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTaoThapNhat.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgayTaoThapNhat.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgayTaoThapNhat.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgayTaoThapNhat.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayTaoThapNhat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgayTaoThapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayTaoThapNhat.Location = New System.Drawing.Point(429, 117)
        Me.dtpNgayTaoThapNhat.Name = "dtpNgayTaoThapNhat"
        Me.dtpNgayTaoThapNhat.Size = New System.Drawing.Size(108, 29)
        Me.dtpNgayTaoThapNhat.TabIndex = 77
        Me.dtpNgayTaoThapNhat.Value = New Date(2018, 6, 28, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(350, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 21)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Ngày tạo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(534, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 21)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "-"
        '
        'nudTuoiCaoNhat
        '
        Me.nudTuoiCaoNhat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTuoiCaoNhat.Location = New System.Drawing.Point(520, 29)
        Me.nudTuoiCaoNhat.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudTuoiCaoNhat.Name = "nudTuoiCaoNhat"
        Me.nudTuoiCaoNhat.Size = New System.Drawing.Size(63, 29)
        Me.nudTuoiCaoNhat.TabIndex = 73
        Me.nudTuoiCaoNhat.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudTuoiThapNhat
        '
        Me.nudTuoiThapNhat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTuoiThapNhat.Location = New System.Drawing.Point(429, 28)
        Me.nudTuoiThapNhat.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudTuoiThapNhat.Name = "nudTuoiThapNhat"
        Me.nudTuoiThapNhat.Size = New System.Drawing.Size(63, 29)
        Me.nudTuoiThapNhat.TabIndex = 73
        Me.nudTuoiThapNhat.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'cbVaiTro
        '
        Me.cbVaiTro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbVaiTro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVaiTro.DropDownHeight = 100
        Me.cbVaiTro.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbVaiTro.FormattingEnabled = True
        Me.cbVaiTro.IntegralHeight = False
        Me.cbVaiTro.Location = New System.Drawing.Point(429, 69)
        Me.cbVaiTro.Name = "cbVaiTro"
        Me.cbVaiTro.Size = New System.Drawing.Size(154, 29)
        Me.cbVaiTro.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(350, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 21)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Vai trò:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(498, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 21)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(350, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Độ tuổi: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Họ tên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Mã người dùng:"
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
        Me.dgDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNguoiDung, Me.HoTen, Me.DiaChi, Me.NgaySinh, Me.VaiTro, Me.NgayTao})
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
        Me.dgDanhSach.Location = New System.Drawing.Point(21, 267)
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
        Me.dgDanhSach.Size = New System.Drawing.Size(659, 245)
        Me.dgDanhSach.TabIndex = 73
        '
        'MaNguoiDung
        '
        Me.MaNguoiDung.HeaderText = "Mã"
        Me.MaNguoiDung.Name = "MaNguoiDung"
        Me.MaNguoiDung.ReadOnly = True
        Me.MaNguoiDung.Width = 80
        '
        'HoTen
        '
        Me.HoTen.HeaderText = "Họ tên"
        Me.HoTen.Name = "HoTen"
        Me.HoTen.ReadOnly = True
        Me.HoTen.Width = 150
        '
        'DiaChi
        '
        Me.DiaChi.HeaderText = "Địa chỉ"
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        '
        'NgaySinh
        '
        Me.NgaySinh.HeaderText = "Ngày sinh"
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.ReadOnly = True
        Me.NgaySinh.Width = 95
        '
        'VaiTro
        '
        Me.VaiTro.HeaderText = "Vai trò"
        Me.VaiTro.Name = "VaiTro"
        Me.VaiTro.ReadOnly = True
        '
        'NgayTao
        '
        Me.NgayTao.HeaderText = "Ngày tạo"
        Me.NgayTao.Name = "NgayTao"
        Me.NgayTao.ReadOnly = True
        Me.NgayTao.Width = 90
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Activecolor = System.Drawing.Color.Silver
        Me.btnTraCuu.BackColor = System.Drawing.Color.LightGray
        Me.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTraCuu.BorderRadius = 7
        Me.btnTraCuu.ButtonText = "Tra cứu"
        Me.btnTraCuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTraCuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnTraCuu.ForeColor = System.Drawing.Color.Black
        Me.btnTraCuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTraCuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Search1_64
        Me.btnTraCuu.Iconimage_right = Nothing
        Me.btnTraCuu.Iconimage_right_Selected = Nothing
        Me.btnTraCuu.Iconimage_Selected = Nothing
        Me.btnTraCuu.IconMarginLeft = 0
        Me.btnTraCuu.IconMarginRight = 0
        Me.btnTraCuu.IconRightVisible = True
        Me.btnTraCuu.IconRightZoom = 0R
        Me.btnTraCuu.IconVisible = True
        Me.btnTraCuu.IconZoom = 60.0R
        Me.btnTraCuu.IsTab = False
        Me.btnTraCuu.Location = New System.Drawing.Point(21, 220)
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnTraCuu.OnHovercolor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTraCuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnTraCuu.selected = False
        Me.btnTraCuu.Size = New System.Drawing.Size(116, 41)
        Me.btnTraCuu.TabIndex = 71
        Me.btnTraCuu.Text = "Tra cứu"
        Me.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTraCuu.Textcolor = System.Drawing.Color.Black
        Me.btnTraCuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
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
        Me.btnThoat.Location = New System.Drawing.Point(154, 220)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Salmon
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(117, 41)
        Me.btnThoat.TabIndex = 74
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoat.Textcolor = System.Drawing.Color.Black
        Me.btnThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'lbNgayTao
        '
        Me.lbNgayTao.AutoSize = True
        Me.lbNgayTao.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgayTao.Location = New System.Drawing.Point(169, 646)
        Me.lbNgayTao.Name = "lbNgayTao"
        Me.lbNgayTao.Size = New System.Drawing.Size(83, 21)
        Me.lbNgayTao.TabIndex = 95
        Me.lbNgayTao.Text = "lbNgayTao"
        '
        'lbVaiTro
        '
        Me.lbVaiTro.AutoSize = True
        Me.lbVaiTro.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbVaiTro.Location = New System.Drawing.Point(151, 616)
        Me.lbVaiTro.Name = "lbVaiTro"
        Me.lbVaiTro.Size = New System.Drawing.Size(66, 21)
        Me.lbVaiTro.TabIndex = 93
        Me.lbVaiTro.Text = "lbVaiTro"
        '
        'lbSoDienThoai
        '
        Me.lbSoDienThoai.AutoSize = True
        Me.lbSoDienThoai.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbSoDienThoai.Location = New System.Drawing.Point(493, 646)
        Me.lbSoDienThoai.Name = "lbSoDienThoai"
        Me.lbSoDienThoai.Size = New System.Drawing.Size(111, 21)
        Me.lbSoDienThoai.TabIndex = 92
        Me.lbSoDienThoai.Text = "lbSoDienThoai"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbEmail.Location = New System.Drawing.Point(440, 616)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(61, 21)
        Me.lbEmail.TabIndex = 91
        Me.lbEmail.Text = "lbEmail"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbDiaChi.Location = New System.Drawing.Point(449, 586)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(69, 21)
        Me.lbDiaChi.TabIndex = 90
        Me.lbDiaChi.Text = "lbDiaChi"
        '
        'lbCMND
        '
        Me.lbCMND.AutoSize = True
        Me.lbCMND.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbCMND.Location = New System.Drawing.Point(174, 586)
        Me.lbCMND.Name = "lbCMND"
        Me.lbCMND.Size = New System.Drawing.Size(70, 21)
        Me.lbCMND.TabIndex = 89
        Me.lbCMND.Text = "lbCMND"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbGioiTinh.Location = New System.Drawing.Point(462, 556)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(81, 21)
        Me.lbGioiTinh.TabIndex = 88
        Me.lbGioiTinh.Text = "lbGioiTinh"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbNgaySinh.Location = New System.Drawing.Point(472, 526)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(91, 21)
        Me.lbNgaySinh.TabIndex = 87
        Me.lbNgaySinh.Text = "lbNgaySinh"
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbHoTen.Location = New System.Drawing.Point(151, 556)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(66, 21)
        Me.lbHoTen.TabIndex = 86
        Me.lbHoTen.Text = "lbHoTen"
        '
        'lbMaNguoiDung
        '
        Me.lbMaNguoiDung.AutoSize = True
        Me.lbMaNguoiDung.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaNguoiDung.Location = New System.Drawing.Point(211, 526)
        Me.lbMaNguoiDung.Name = "lbMaNguoiDung"
        Me.lbMaNguoiDung.Size = New System.Drawing.Size(126, 21)
        Me.lbMaNguoiDung.TabIndex = 94
        Me.lbMaNguoiDung.Text = "lbMaNguoiDung"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(87, 646)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 21)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Ngày tạo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(87, 616)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 21)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Vai trò:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(383, 646)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 21)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Số điện thoại:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(383, 616)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 21)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Email:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(86, 586)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 21)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Số CMND:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(383, 586)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 21)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "Địa chỉ:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(383, 556)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 21)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Giới tính:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(383, 526)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 21)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "Ngày sinh:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(86, 556)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 21)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "Họ tên:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(85, 526)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 21)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Mã người dùng:"
        '
        'dot1
        '
        Me.dot1.BackgroundImage = CType(resources.GetObject("dot1.BackgroundImage"), System.Drawing.Image)
        Me.dot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dot1.GradientBottomLeft = System.Drawing.Color.Silver
        Me.dot1.GradientBottomRight = System.Drawing.Color.Silver
        Me.dot1.GradientTopLeft = System.Drawing.Color.Silver
        Me.dot1.GradientTopRight = System.Drawing.Color.Silver
        Me.dot1.Location = New System.Drawing.Point(104, 518)
        Me.dot1.Name = "dot1"
        Me.dot1.Quality = 10
        Me.dot1.Size = New System.Drawing.Size(500, 5)
        Me.dot1.TabIndex = 96
        '
        'ucTraCuuNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dot1)
        Me.Controls.Add(Me.lbNgayTao)
        Me.Controls.Add(Me.lbVaiTro)
        Me.Controls.Add(Me.lbSoDienThoai)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbCMND)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.lbNgaySinh)
        Me.Controls.Add(Me.lbHoTen)
        Me.Controls.Add(Me.lbMaNguoiDung)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.dgDanhSach)
        Me.Controls.Add(Me.btnTraCuu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucTraCuuNguoiDung"
        Me.Size = New System.Drawing.Size(700, 690)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudTuoiCaoNhat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTuoiThapNhat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbVaiTro As ComboBox
    Friend WithEvents dtpNgayTaoCaoNhat As DateTimePicker
    Friend WithEvents dtpNgayTaoThapNhat As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nudTuoiCaoNhat As NumericUpDown
    Friend WithEvents nudTuoiThapNhat As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents dgDanhSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnTraCuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tbDiaChi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbHoTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbMaNguoiDung As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbNgayTao As Label
    Friend WithEvents lbVaiTro As Label
    Friend WithEvents lbSoDienThoai As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbCMND As Label
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbHoTen As Label
    Friend WithEvents lbMaNguoiDung As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dot1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents MaNguoiDung As DataGridViewTextBoxColumn
    Friend WithEvents HoTen As DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinh As DataGridViewTextBoxColumn
    Friend WithEvents VaiTro As DataGridViewTextBoxColumn
    Friend WithEvents NgayTao As DataGridViewTextBoxColumn
End Class
