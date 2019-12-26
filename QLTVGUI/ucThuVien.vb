Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Diagnostics

Public Class ucThuVien
    Dim ctpmBus As ChiTietPhieuMuonBUS
    Dim sachBus As DauSachBUS
    Dim ngBus As NguoiDungBUS

    Private Sub ucThuVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As Result
        ctpmBus = New ChiTietPhieuMuonBUS()
        sachBus = New DauSachBUS()
        ngBus = New NguoiDungBUS()

        ' Hien thi so dau sach
        Dim listSach As New List(Of DauSachDTO)
        result = sachBus.selectALL(listSach)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đầu sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbSoDauSach.Text = listSach.Count.ToString()

        ' Hien thi so doc gia
        Dim listDocGia As New List(Of NguoiDungDTO)
        result = ngBus.selectAllDocGia(listDocGia)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách độc giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbSoDocGia.Text = listDocGia.Count.ToString()

        ' Hien thi so luot muon
        Dim listctpm As List(Of ChiTietPhieuMuonDTO)
        listctpm = New List(Of ChiTietPhieuMuonDTO)
        result = ctpmBus.selectALL(listctpm)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu mượn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lbSoLuotMuon.Text = listctpm.Count.ToString()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("https://github.com/PhuongDuyHoang/QuanLyThuVien")
    End Sub
End Class
