<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTinhTrang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbMaTinhTrang = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgDanhSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.lbTroVe = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MaNguoiDung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbTen)
        Me.GroupBox1.Controls.Add(Me.lbMaTinhTrang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 180)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'tbTen
        '
        Me.tbTen.AutoSize = True
        Me.tbTen.BackColor = System.Drawing.Color.White
        Me.tbTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tbTen.ForeColor = System.Drawing.Color.Black
        Me.tbTen.HintForeColor = System.Drawing.Color.Empty
        Me.tbTen.HintText = ""
        Me.tbTen.isPassword = False
        Me.tbTen.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbTen.LineIdleColor = System.Drawing.Color.Silver
        Me.tbTen.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbTen.LineThickness = 2
        Me.tbTen.Location = New System.Drawing.Point(7, 129)
        Me.tbTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(204, 36)
        Me.tbTen.TabIndex = 84
        Me.tbTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbMaTinhTrang
        '
        Me.lbMaTinhTrang.BackColor = System.Drawing.Color.Transparent
        Me.lbMaTinhTrang.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaTinhTrang.ForeColor = System.Drawing.Color.Red
        Me.lbMaTinhTrang.Location = New System.Drawing.Point(6, 56)
        Me.lbMaTinhTrang.Name = "lbMaTinhTrang"
        Me.lbMaTinhTrang.Size = New System.Drawing.Size(205, 25)
        Me.lbMaTinhTrang.TabIndex = 30
        Me.lbMaTinhTrang.Text = "lbMaTinhTrang"
        Me.lbMaTinhTrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Tên tình trạng *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Mã tình trạng:"
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
        Me.dgDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNguoiDung, Me.Ten})
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
        Me.dgDanhSach.Location = New System.Drawing.Point(411, 93)
        Me.dgDanhSach.Name = "dgDanhSach"
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
        Me.dgDanhSach.Size = New System.Drawing.Size(267, 417)
        Me.dgDanhSach.TabIndex = 101
        '
        'lbTroVe
        '
        Me.lbTroVe.AutoSize = True
        Me.lbTroVe.BackColor = System.Drawing.Color.Transparent
        Me.lbTroVe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroVe.ForeColor = System.Drawing.Color.Blue
        Me.lbTroVe.Location = New System.Drawing.Point(11, 23)
        Me.lbTroVe.Name = "lbTroVe"
        Me.lbTroVe.Size = New System.Drawing.Size(66, 17)
        Me.lbTroVe.TabIndex = 98
        Me.lbTroVe.Text = "<< Trở về"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(242, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 30)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "TÌNH TRẠNG SÁCH"
        '
        'btnLuu
        '
        Me.btnLuu.Activecolor = System.Drawing.Color.Silver
        Me.btnLuu.BackColor = System.Drawing.Color.LightGray
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.BorderRadius = 7
        Me.btnLuu.ButtonText = "Thêm"
        Me.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuu.ForeColor = System.Drawing.Color.Black
        Me.btnLuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Plus_64
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
        Me.btnLuu.Location = New System.Drawing.Point(278, 133)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(117, 41)
        Me.btnLuu.TabIndex = 97
        Me.btnLuu.Text = "Thêm"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'MaNguoiDung
        '
        Me.MaNguoiDung.HeaderText = "Mã"
        Me.MaNguoiDung.Name = "MaNguoiDung"
        Me.MaNguoiDung.ReadOnly = True
        Me.MaNguoiDung.Width = 75
        '
        'Ten
        '
        Me.Ten.HeaderText = "Tên"
        Me.Ten.Name = "Ten"
        Me.Ten.Width = 150
        '
        'ucTinhTrang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.dgDanhSach)
        Me.Controls.Add(Me.lbTroVe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucTinhTrang"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbMaTinhTrang As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgDanhSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lbTroVe As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaNguoiDung As DataGridViewTextBoxColumn
    Friend WithEvents Ten As DataGridViewTextBoxColumn
End Class
