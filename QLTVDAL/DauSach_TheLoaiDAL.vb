Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class DauSach_TheLoaiDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of DauSach_TheLoaiDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblDauSach_TheLoai]"


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
                            list.Add(New DauSach_TheLoaiDTO(reader("madausach"), reader("matheloai")))
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

    Public Function getListTheLoaiAsString_ByMaDauSach(madausach As String, ByRef value As String) As Result
        Dim query As String = String.Empty
        query &= " SELECT [tentheloai]"
        query &= " FROM [tblDauSach_TheLoai] dstl, [tblTheLoai] tl"
        query &= " WHERE [madausach] = @madausach and dstl.[matheloai] = tl.[matheloai]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madausach", madausach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            value = value + reader("tentheloai") + ","
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

    Public Function selectALL_ByMaTheLoai(matheloai As String, ByRef list As List(Of DauSach_TheLoaiDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblDauSach_TheLoai]"
        query &= " WHERE [matheloai] like @matheloai"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matheloai", matheloai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New DauSach_TheLoaiDTO(reader("madausach"), reader("matheloai")))
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

    Public Function selectALL_ByMaDauSach(madausach As String, ByRef list As List(Of DauSach_TheLoaiDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [tblDauSach_TheLoai]"
        query &= " WHERE [madausach] = @madausach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madausach", madausach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New DauSach_TheLoaiDTO(reader("madausach"), reader("matheloai")))
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

    Public Function insert(value As DauSach_TheLoaiDTO) As Result
        Dim query As String = String.Empty
        query &= "insert into [tblDauSach_TheLoai] "
        query &= "values (@madausach, @matheloai) "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madausach", value.MaDauSach)
                    .Parameters.AddWithValue("@matheloai", value.MaTheLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
