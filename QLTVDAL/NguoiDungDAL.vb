Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class NguoiDungDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function build_manguoidung(ByRef value As String) As Result

        value = String.Empty
        value = "ND"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [manguoidung] "
        query &= "FROM [tblNguoiDung] "
        query &= "ORDER BY [manguoidung] DESC "

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
                            msOnDB = reader("manguoidung")
                        End While
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

    Public Function insert(nd As NguoiDungDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblNguoiDung] "
        query &= "VALUES (@manguoidung, @hoten,@CMND, @gioitinh, @ngaysinh, @diachi, @email, @sodienthoai, @vaitro, @ngaytao)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manguoidung", nd.MaNguoiDung)
                    .Parameters.AddWithValue("@hoten", nd.HoTen)
                    .Parameters.AddWithValue("@CMND", nd.CMND)
                    .Parameters.AddWithValue("@gioitinh", nd.GioiTinh)
                    .Parameters.AddWithValue("@ngaysinh", nd.NgaySinh)
                    .Parameters.AddWithValue("@diachi", nd.DiaChi)
                    .Parameters.AddWithValue("@email", nd.Email)
                    .Parameters.AddWithValue("@sodienthoai", nd.SoDienThoai)
                    .Parameters.AddWithValue("@vaitro", nd.VaiTro)
                    .Parameters.AddWithValue("@ngaytao", nd.NgayTao)
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

    Public Function selectALL(ByRef listDocGia As List(Of NguoiDungDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblNguoiDung]"


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
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add(New NguoiDungDTO(reader("manguoidung"), reader("hoten"), reader("CMND"), reader("gioitinh"), reader("ngaysinh"),
                                                         reader("diachi"), reader("email"), reader("sodienthoai"), reader("vaitro"), reader("ngaytao")))
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

    Public Function selectALLDocGia(ByRef listDocGia As List(Of NguoiDungDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblNguoiDung] "
        query &= "WHERE [vaitro] = 'VT000006'"


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
                        listDocGia.Clear()
                        While reader.Read()
                            listDocGia.Add(New NguoiDungDTO(reader("manguoidung"), reader("hoten"), reader("CMND"), reader("gioitinh"), reader("ngaysinh"),
                                                         reader("diachi"), reader("email"), reader("sodienthoai"), reader("vaitro"), reader("ngaytao")))
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

    Public Function selectALL_ByFilters(manguoidung As String, hoten As String, diachi As String,
                                        tuoithapnhat As Integer, tuoicaonhat As Integer,
                                        vaitro As String,
                                        ngaytaothapnhat As Date, ngaytaocaonhat As Date,
                                        ByRef list As List(Of NguoiDungDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT * "
        query &= "FROM [tblNguoiDung] "
        query &= "WHERE [manguoidung] like @manguoidung "
        query &= "  AND [hoten] like @hoten "
        query &= "  AND [diachi] like @diachi "
        query &= "  AND DATEDIFF(year, [ngaysinh], GETDATE()) >= @tuoithapnhat "
        query &= "  AND DATEDIFF(year, [ngaysinh], GETDATE()) <= @tuoicaonhat "
        query &= "  AND [vaitro] like @vaitro "
        query &= "  AND [ngaytao] >= @ngaytaothapnhat "
        query &= "  AND [ngaytao] <= @ngaytaocaonhat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manguoidung", manguoidung)
                    .Parameters.AddWithValue("@hoten", hoten)
                    .Parameters.AddWithValue("@diachi", diachi)
                    .Parameters.AddWithValue("@tuoithapnhat", tuoithapnhat)
                    .Parameters.AddWithValue("@tuoicaonhat", tuoicaonhat)
                    .Parameters.AddWithValue("@vaitro", vaitro)
                    .Parameters.AddWithValue("@ngaytaothapnhat", ngaytaothapnhat)
                    .Parameters.AddWithValue("@ngaytaocaonhat", ngaytaocaonhat)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New NguoiDungDTO(reader("manguoidung"), reader("hoten"), reader("CMND"), reader("gioitinh"), reader("ngaysinh"),
                                                         reader("diachi"), reader("email"), reader("sodienthoai"), reader("vaitro"), reader("ngaytao")))
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

    Public Function selectALL_ByMaNguoiDung(manguoidung As String, ByRef list As List(Of String)) As Result

        Dim query As String = String.Empty
        query &= "select [manguoidung] "
        query &= "from [tblNguoiDung] "
        query &= "where [manguoidung] like @manguoidung"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manguoidung", manguoidung)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(reader("manguoidung"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function getByMaNguoiDung(manguoidung As String, ByRef value As NguoiDungDTO) As Result

        Dim query As String = String.Empty
        query &= "select * "
        query &= "from [tblNguoiDung] "
        query &= "where [manguoidung] = @manguoidung"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manguoidung", manguoidung)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            value = New NguoiDungDTO(reader("manguoidung"), reader("hoten"), reader("CMND"), reader("gioitinh"), reader("ngaysinh"), reader("diachi"), reader("email"), reader("sodienthoai"), reader("vaitro"), reader("ngaytao"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll_ByHoTen(hoten As String, ByRef list As List(Of String)) As Result
        Dim query As String = String.Empty
        query &= "select [manguoidung] "
        query &= "from [tblNguoiDung] "
        query &= "where [hoten] like @hoten"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hoten", hoten)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(reader("manguoidung"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectALL_ByEmail(email As String, ByRef list As List(Of String)) As Result

        Dim query As String = String.Empty
        query &= "select [manguoidung] "
        query &= "from [tblNguoiDung] "
        query &= "where [email] like @email"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@email", email)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(reader("manguoidung"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function update(nd As NguoiDungDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblNguoiDung] SET"
        query &= " [diachi] = @diachi "
        query &= " ,[email] = @email "
        query &= " ,[sodienthoai] = @sodienthoai "
        query &= " ,[vaitro] = @vaitro "
        query &= " WHERE "
        query &= " [manguoidung] = @manguoidung "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@diachi", nd.DiaChi)
                    .Parameters.AddWithValue("@email", nd.Email)
                    .Parameters.AddWithValue("@sodienthoai", nd.SoDienThoai)
                    .Parameters.AddWithValue("@vaitro", nd.VaiTro)
                    .Parameters.AddWithValue("@manguoidung", nd.MaNguoiDung)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function getNgayTao_ByMaNguoiDung(manguoidung As String, ByRef ngaytao As DateTime) As Result
        Dim query As String = String.Empty
        query &= " SELECT [ngaytao]"
        query &= " FROM [tblNguoiDung]"
        query &= " WHERE"
        query &= " [manguoidung] = @manguoidung"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manguoidung", manguoidung)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            ngaytao = reader("ngaytao")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Nạp thông tin độc giả không thành công", ex.StackTrace)
                End Try

            End Using
        End Using
        Return New Result(True)
    End Function
End Class
