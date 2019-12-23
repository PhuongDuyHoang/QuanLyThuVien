<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucDocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDocGia))
        Me.btnThemDocGia = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnTimDocGia = New Bunifu.Framework.UI.BunifuTileButton()
        Me.dot1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.SuspendLayout()
        '
        'btnThemDocGia
        '
        Me.btnThemDocGia.BackColor = System.Drawing.Color.LightGray
        Me.btnThemDocGia.color = System.Drawing.Color.LightGray
        Me.btnThemDocGia.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnThemDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThemDocGia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemDocGia.ForeColor = System.Drawing.Color.Black
        Me.btnThemDocGia.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Add_User_Male_64
        Me.btnThemDocGia.ImagePosition = 5
        Me.btnThemDocGia.ImageZoom = 20
        Me.btnThemDocGia.LabelPosition = 34
        Me.btnThemDocGia.LabelText = "Lập thẻ độc giả"
        Me.btnThemDocGia.Location = New System.Drawing.Point(67, 70)
        Me.btnThemDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThemDocGia.Name = "btnThemDocGia"
        Me.btnThemDocGia.Size = New System.Drawing.Size(203, 85)
        Me.btnThemDocGia.TabIndex = 5
        '
        'btnTimDocGia
        '
        Me.btnTimDocGia.BackColor = System.Drawing.Color.LightGray
        Me.btnTimDocGia.color = System.Drawing.Color.LightGray
        Me.btnTimDocGia.colorActive = System.Drawing.SystemColors.ActiveBorder
        Me.btnTimDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimDocGia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimDocGia.ForeColor = System.Drawing.Color.Black
        Me.btnTimDocGia.Image = Global.QLTVGUI.My.Resources.Resources.icons8_find_user_male_48
        Me.btnTimDocGia.ImagePosition = 5
        Me.btnTimDocGia.ImageZoom = 20
        Me.btnTimDocGia.LabelPosition = 34
        Me.btnTimDocGia.LabelText = "Tìm kiếm độc giả"
        Me.btnTimDocGia.Location = New System.Drawing.Point(67, 165)
        Me.btnTimDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimDocGia.Name = "btnTimDocGia"
        Me.btnTimDocGia.Size = New System.Drawing.Size(203, 85)
        Me.btnTimDocGia.TabIndex = 6
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
        Me.dot1.TabIndex = 16
        '
        'ucDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dot1)
        Me.Controls.Add(Me.btnTimDocGia)
        Me.Controls.Add(Me.btnThemDocGia)
        Me.Name = "ucDocGia"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnThemDocGia As Bunifu.Framework.UI.BunifuTileButton
    Public WithEvents btnTimDocGia As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents dot1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
