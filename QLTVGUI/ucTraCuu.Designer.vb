<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTraCuu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTraCuu))
        Me.btnTimKiemNguoiDung = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThemNguoiDung = New Bunifu.Framework.UI.BunifuTileButton()
        Me.dot1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.SuspendLayout()
        '
        'btnTimKiemNguoiDung
        '
        Me.btnTimKiemNguoiDung.BackColor = System.Drawing.Color.LightGray
        Me.btnTimKiemNguoiDung.color = System.Drawing.Color.LightGray
        Me.btnTimKiemNguoiDung.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnTimKiemNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimKiemNguoiDung.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiemNguoiDung.ForeColor = System.Drawing.Color.Black
        Me.btnTimKiemNguoiDung.Image = Global.QLTVGUI.My.Resources.Resources.icons8_find_user_male_48
        Me.btnTimKiemNguoiDung.ImagePosition = 5
        Me.btnTimKiemNguoiDung.ImageZoom = 20
        Me.btnTimKiemNguoiDung.LabelPosition = 34
        Me.btnTimKiemNguoiDung.LabelText = "Tìm kiếm người dùng"
        Me.btnTimKiemNguoiDung.Location = New System.Drawing.Point(67, 165)
        Me.btnTimKiemNguoiDung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimKiemNguoiDung.Name = "btnTimKiemNguoiDung"
        Me.btnTimKiemNguoiDung.Size = New System.Drawing.Size(203, 85)
        Me.btnTimKiemNguoiDung.TabIndex = 17
        '
        'btnThemNguoiDung
        '
        Me.btnThemNguoiDung.BackColor = System.Drawing.Color.LightGray
        Me.btnThemNguoiDung.color = System.Drawing.Color.LightGray
        Me.btnThemNguoiDung.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnThemNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThemNguoiDung.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemNguoiDung.ForeColor = System.Drawing.Color.Black
        Me.btnThemNguoiDung.Image = Global.QLTVGUI.My.Resources.Resources.icons8_search_property_64
        Me.btnThemNguoiDung.ImagePosition = 5
        Me.btnThemNguoiDung.ImageZoom = 20
        Me.btnThemNguoiDung.LabelPosition = 34
        Me.btnThemNguoiDung.LabelText = "Tìm kiếm sách"
        Me.btnThemNguoiDung.Location = New System.Drawing.Point(67, 70)
        Me.btnThemNguoiDung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThemNguoiDung.Name = "btnThemNguoiDung"
        Me.btnThemNguoiDung.Size = New System.Drawing.Size(203, 85)
        Me.btnThemNguoiDung.TabIndex = 18
        '
        'dot1
        '
        Me.dot1.BackgroundImage = CType(resources.GetObject("dot1.BackgroundImage"), System.Drawing.Image)
        Me.dot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dot1.GradientBottomLeft = System.Drawing.Color.Silver
        Me.dot1.GradientBottomRight = System.Drawing.Color.Silver
        Me.dot1.GradientTopLeft = System.Drawing.Color.Silver
        Me.dot1.GradientTopRight = System.Drawing.Color.Silver
        Me.dot1.Location = New System.Drawing.Point(55, 70)
        Me.dot1.Name = "dot1"
        Me.dot1.Quality = 10
        Me.dot1.Size = New System.Drawing.Size(5, 387)
        Me.dot1.TabIndex = 15
        '
        'ucTraCuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.btnTimKiemNguoiDung)
        Me.Controls.Add(Me.btnThemNguoiDung)
        Me.Controls.Add(Me.dot1)
        Me.Name = "ucTraCuu"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnTimKiemNguoiDung As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnThemNguoiDung As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents dot1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
