Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class DauSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaDauSach(ByRef value As String) As Result
        value = String.Empty
        value = "DS"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [madausach] "
        query &= "FROM [tblDauSach] "
        query &= "ORDER BY [madausach] DESC "

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
                            msOnDB = reader("madausach")
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

    Public Function selectALL(ByRef list As List(Of DauSachDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblDauSach]"


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
                            list.Add(New DauSachDTO(reader("madausach"), reader("tendausach"), reader("tomtat"), reader("nhaxuatban"), reader("namxuatban"), reader("trigia")))
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

    Public Function getByMaDauSach(madausach As String, ByRef value As DauSachDTO) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblDauSach] "
        query &= "WHERE [madausach] = @madausach"


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
                            value = New DauSachDTO(reader("madausach"), reader("tendausach"), reader("tomtat"), reader("nhaxuatban"), reader("namxuatban"), reader("trigia"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        If value.MaDauSach Is Nothing Then
            Return New Result(False)
        End If
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(value As DauSachDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblDauSach]"
        query &= " VALUES (@madausach, @tendausach, @tomtat, @nhaxuatban, @namxuatban, @trigia)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@madausach", value.MaDauSach)
                    .Parameters.AddWithValue("@tendausach", value.TenDauSach)
                    .Parameters.AddWithValue("@tomtat", value.TomTat)
                    .Parameters.AddWithValue("@nhaxuatban", value.NhaXuatBan)
                    .Parameters.AddWithValue("@namxuatban", value.NamXuatBan)
                    .Parameters.AddWithValue("@trigia", value.TriGia)
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

    Public Function update(value As DauSachDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDauSach] SET"
        query &= " [tendausach] = @tendausach "
        query &= " ,[tomtat] = @tomtat "
        query &= " ,[nhaxuatban] = @nhaxuatban "
        query &= " ,[namxuatban] = @namxuatban "
        query &= " ,[trigia] = @trigia "
        query &= " WHERE "
        query &= " [madausach] = @madausach"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tendausach", value.TenDauSach)
                    .Parameters.AddWithValue("@tomtat", value.TomTat)
                    .Parameters.AddWithValue("@nhaxuatban", value.NhaXuatBan)
                    .Parameters.AddWithValue("@namxuatban", value.NamXuatBan)
                    .Parameters.AddWithValue("@trigia", value.TriGia)
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

    Public Function selectAll_MaDauSach(madausach As String, ByRef listDauSach As List(Of String)) As Result

        Dim query As String = String.Empty
        query &= "select [madausach] "
        query &= "from [tblDauSach] "
        query &= "where [madausach] like @madausach"

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
                        listDauSach.Clear()
                        While reader.Read()
                            listDauSach.Add(reader("madausach"))
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

    Public Function filter_MaSach(madausach As String, ByRef listSach As List(Of String)) As Result

        Dim query As String = String.Empty
        query &= "select [madausach] "
        query &= "from [tblDauSach] "
        query &= "where [madausach] like @madausach"

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
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(reader("madausach"))
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

    Public Function filter_TenSach(tendausach As String, ByRef listSach As List(Of String)) As Result

        Dim query As String = String.Empty
        query &= "select [madausach] "
        query &= "from [tblDauSach] "
        query &= "where [tendausach] like @tendausach"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tendausach", tendausach)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listSach.Clear()
                        While reader.Read()
                            listSach.Add(reader("madausach"))
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
End Class
