Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class DangNhapDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function update(value As DangNhapDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDangNhap] "
        query &= " SET [tendangnhap] = @tendangnhap, [matkhau] = @matkhau "
        query &= " WHERE [madangnhap] = @madangnhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madangnhap", value.MaDangNhap)
                    .Parameters.AddWithValue("@tendangnhap", value.TenDangNhap)
                    .Parameters.AddWithValue("@matkhau", value.MatKhau)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function kiemTra(tendangnhap As String, matkhau As String, ByRef value As DangNhapDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT * "
        query &= " FROM [tblDangNhap] "
        query &= " WHERE [tendangnhap] = @tendangnhap AND [matkhau] = @matkhau"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tendangnhap", tendangnhap)
                    .Parameters.AddWithValue("@matkhau", matkhau)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            value = New DangNhapDTO(reader("madangnhap"), reader("nguoidung"), reader("tendangnhap"), reader("matkhau"), reader("dangnhaplandau"))
                        End While
                    Else
                        Return New Result(True, "invalid", "invalid")
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

    Public Function buildMaDangNhap(ByRef value As String) As Result
        value = String.Empty
        value = "DN"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [madangnhap] "
        query &= "FROM [tblDangNhap] "
        query &= "ORDER BY [madangnhap] DESC "

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
                            msOnDB = reader("madangnhap")
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

    Public Function insert(value As DangNhapDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblDangNhap]"
        query &= " VALUES (@madangnhap, @nguoidung, @tendangnhap, @matkhau, @dangnhaplandau)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madangnhap", value.MaDangNhap)
                    .Parameters.AddWithValue("@nguoidung", value.NguoiDung)
                    .Parameters.AddWithValue("@tendangnhap", value.TenDangNhap)
                    .Parameters.AddWithValue("@matkhau", value.MatKhau)
                    .Parameters.AddWithValue("@dangnhaplandau", value.DangNhapLanDau)
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
        Return New Result(True)
    End Function

End Class
