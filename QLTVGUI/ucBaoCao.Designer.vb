<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBaoCao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBaoCao))
        Me.btnThongKeTraTre = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThongKeTheLoai = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.SuspendLayout()
        '
        'btnThongKeTraTre
        '
        Me.btnThongKeTraTre.BackColor = System.Drawing.Color.LightGray
        Me.btnThongKeTraTre.color = System.Drawing.Color.LightGray
        Me.btnThongKeTraTre.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnThongKeTraTre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThongKeTraTre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThongKeTraTre.ForeColor = System.Drawing.Color.Black
        Me.btnThongKeTraTre.Image = Nothing
        Me.btnThongKeTraTre.ImagePosition = 5
        Me.btnThongKeTraTre.ImageZoom = 20
        Me.btnThongKeTraTre.LabelPosition = 34
        Me.btnThongKeTraTre.LabelText = "Thống kê sách trả trễ theo ngày"
        Me.btnThongKeTraTre.Location = New System.Drawing.Point(67, 124)
        Me.btnThongKeTraTre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThongKeTraTre.Name = "btnThongKeTraTre"
        Me.btnThongKeTraTre.Size = New System.Drawing.Size(355, 41)
        Me.btnThongKeTraTre.TabIndex = 21
        '
        'btnThongKeTheLoai
        '
        Me.btnThongKeTheLoai.BackColor = System.Drawing.Color.LightGray
        Me.btnThongKeTheLoai.color = System.Drawing.Color.LightGray
        Me.btnThongKeTheLoai.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnThongKeTheLoai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThongKeTheLoai.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThongKeTheLoai.ForeColor = System.Drawing.Color.Black
        Me.btnThongKeTheLoai.Image = Nothing
        Me.btnThongKeTheLoai.ImagePosition = 5
        Me.btnThongKeTheLoai.ImageZoom = 20
        Me.btnThongKeTheLoai.LabelPosition = 34
        Me.btnThongKeTheLoai.LabelText = "Thống kê tình hình mượn sách theo thể loại"
        Me.btnThongKeTheLoai.Location = New System.Drawing.Point(67, 70)
        Me.btnThongKeTheLoai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThongKeTheLoai.Name = "btnThongKeTheLoai"
        Me.btnThongKeTheLoai.Size = New System.Drawing.Size(355, 41)
        Me.btnThongKeTheLoai.TabIndex = 22
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Silver
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(55, 70)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(5, 387)
        Me.BunifuGradientPanel1.TabIndex = 20
        '
        'ucBaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.btnThongKeTraTre)
        Me.Controls.Add(Me.btnThongKeTheLoai)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "ucBaoCao"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnThongKeTraTre As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnThongKeTheLoai As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
