Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class PhieuNhapDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function build_maphieunhap(ByRef value As String) As Result
        value = String.Empty
        value = "PN"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [maphieunhap] "
        query &= "FROM [tblPhieuNhap] "
        query &= "ORDER BY [maphieunhap] DESC "

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
                            msOnDB = reader("maphieunhap")
                        End While
                    Else
                        value = value + "000001"
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

    Public Function insert(value As PhieuNhapDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPhieuNhap] "
        query &= "VALUES (@maphieunhap,@ngaynhap,@nhacungcap,@tongtien,@nguoinhap)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", value.MaPhieuNhap)
                    .Parameters.AddWithValue("@ngaynhap", value.NgayNhap)
                    .Parameters.AddWithValue("@nhacungcap", value.NhaCungCap)
                    .Parameters.AddWithValue("@tongtien", value.TongTien)
                    .Parameters.AddWithValue("@nguoinhap", value.NguoiNhap)
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

    Public Function selectALL(ByRef list As List(Of PhieuNhapDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblPhieuNhap]"


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
                            list.Add(New PhieuNhapDTO(reader("maphieunhap"), reader("ngaynhap"), reader("nhacungcap"), reader("tongtien"), reader("nguoinhap")))
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

    Public Function getByMaPhieuNhap(maphieunhap As String, ByRef value As PhieuNhapDTO) As Result

        Dim query As String = String.Empty
        query &= "select * "
        query &= "from [tblPhieuNhap] "
        query &= "where [maphieunhap] = @maphieunhap"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", maphieunhap)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            value = New PhieuNhapDTO(reader("maphieunhap"), reader("ngaynhap"), reader("nhacungcap"), reader("tongtien"), reader("nguoinhap"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False)
                End Try
            End Using
        End Using
        If value.MaPhieuNhap Is Nothing Then
            Return New Result(False)
        End If
        Return New Result(True)
    End Function

    Public Function update(value As PhieuNhapDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblPhieuNhap] SET"
        query &= " [ngaynhap] = @ngaynhap "
        query &= " ,[nhacungcap] = @nhacungcap "
        query &= " ,[tongtien] = @tongtien "
        query &= " ,[nguoinhap] = @nguoinhap "
        query &= " WHERE "
        query &= " [maphieunhap] = @maphieunhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngaynhap", value.NgayNhap)
                    .Parameters.AddWithValue("@nhacungcap", value.NhaCungCap)
                    .Parameters.AddWithValue("@tongtien", value.TongTien)
                    .Parameters.AddWithValue("@nguoinhap", value.NguoiNhap)
                    .Parameters.AddWithValue("@maphieunhap", value.MaPhieuNhap)
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
End Class
