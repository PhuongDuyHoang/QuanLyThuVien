Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class PhieuMuonDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function build_maphieumuon(ByRef value As String) As Result
        value = String.Empty
        value = "PM"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieumuon] "
        query &= "FROM [tblPhieuMuon] "
        query &= "ORDER BY [maphieumuon] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("maphieumuon")
                        End While
                    Else
                        value = value + "000001"
                        conn.Close()
                        Return New Result(True)
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        value = value + tmp
                        System.Console.WriteLine(value)
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(value As PhieuMuonDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuMuon] "
        query &= "VALUES (@maphieumuon,@docgia,@thuthu,@ngaymuon)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieumuon", value.MaPhieuMuon)
                    .Parameters.AddWithValue("@docgia", value.DocGia)
                    .Parameters.AddWithValue("@thuthu", value.ThuThu)
                    .Parameters.AddWithValue("@ngaymuon", value.NgayMuon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef list As List(Of PhieuMuonDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblPhieuMuon]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New PhieuMuonDTO(reader("maphieumuon"), reader("docgia"), reader("thuthu"), reader("ngaymuon")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getAll_SachDangMuon_ByMaDocGia(madocgia As String, ByRef listMaSach As List(Of String), ByRef listTenSach As List(Of String), ByRef listNgayMuon As List(Of Date)) As Result

        Dim query As String = String.Empty
        query &= "SELECT DISTINCT cs.[macuonsach], s.[tendausach], pm.[ngaymuon] "
        query &= "FROM [tblCuonSach] cs, [tblChiTietPhieuMuon] ctpm, [tblPhieuMuon] pm, [tblNguoiDung] dg, [tblDauSach] s "
        query &= "WHERE cs.[tinhtrang] = 'TT000004' and cs.[macuonsach] = ctpm.[macuonsach] and ctpm.[maphieumuon] = pm.[maphieumuon] and cs.[dausach] = s.[madausach] and pm.[docgia] = @madocgia "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madocgia", madocgia)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listMaSach.Clear()
                        listTenSach.Clear()
                        listNgayMuon.Clear()
                        While reader.Read()
                            listMaSach.Add(reader("macuonsach"))
                            listTenSach.Add(reader("tendausach"))
                            listNgayMuon.Add(reader("ngaymuon"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
