Imports System.Data.SqlClient
Imports System.Net
Imports Microsoft.Identity.Client.TelemetryCore.Internal

Public Class Fqlsach
    Dim SqlConnect As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim sqlDataReader As SqlDataReader


    Private Sub Ketnoi()
        SqlConnect = New SqlConnection("Data Source=DESKTOP-0LFAVEB\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
        sqlCommand = New SqlCommand()
        sqlCommand.CommandType = CommandType.StoredProcedure
        sqlCommand.Connection = SqlConnect

    End Sub

    Private Sub BtnAddbook_Click(sender As Object, e As EventArgs) Handles BtnAddbook.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            If (TxtIDbook.Text = "" Or TxtCategorybook.Text = "" Or TxtCount.Text = "" Or TxtGroupbook.Text = "" Or TxtAuthorbook.Text = "" Or TxtNamebook.Text = "" Or TxtNxb.Text = "") Then
                MessageBox.Show("Thông tin sách chưa được nhập đủ. Nhập lại!", "Thông báo", MessageBoxButtons.OK)
                TxtIDbook.Text = ""
                TxtNamebook.Text = ""
                TxtAuthorbook.Text = ""
                TxtCategorybook.Text = ""
                TxtGroupbook.Text = ""
                TxtCount.Text = ""
                TxtNxb.Text = ""
                TxtIDbook.Focus()
            End If
            sqlCommand.CommandText = "addBook"
            sqlCommand.Parameters.Add("@MaSach", SqlDbType.NChar).Value = TxtIDbook.Text
            sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = TxtNamebook.Text
            sqlCommand.Parameters.Add("@ThLoai", SqlDbType.NVarChar).Value = TxtCategorybook.Text
            sqlCommand.Parameters.Add("@Nhom", SqlDbType.NVarChar).Value = TxtGroupbook.Text
            sqlCommand.Parameters.Add("@Tgia", SqlDbType.NVarChar).Value = TxtAuthorbook.Text
            sqlCommand.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = TxtNxb.Text
            sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = TxtCount.Text
            sqlCommand.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = DtpDateadd.Value
            sqlCommand.ExecuteNonQuery()
            Reset()
            MessageBox.Show("Đã thêm thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK)
            TxtIDbook.Text = ""
            TxtNamebook.Text = ""
            TxtCategorybook.Text = ""
            TxtGroupbook.Text = ""
            TxtAuthorbook.Text = ""
            TxtNxb.Text = ""
            TxtCount.Text = ""
            TxtIDbook.Focus()

            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try

    End Sub

    Private Sub BtnReturnpage2_Click(sender As Object, e As EventArgs) Handles BtnReturnpage2.Click

        Me.Close()

    End Sub

    Private Sub BtnEditbook_Click(sender As Object, e As EventArgs) Handles BtnEditbook.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "updateBook"
            sqlCommand.Parameters.Add("@MaSach", SqlDbType.NChar).Value = TxtIDbookupdate.Text
            sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = TxtNamebookupdate.Text
            sqlCommand.Parameters.Add("@ThLoai", SqlDbType.NVarChar).Value = TxtThloaiUpdate.Text
            sqlCommand.Parameters.Add("@Nhom", SqlDbType.NVarChar).Value = TxtGroupbookupdate.Text
            sqlCommand.Parameters.Add("@Tgia", SqlDbType.NVarChar).Value = TxtAuthorbookupdate.Text
            sqlCommand.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = TxtNxbupdate.Text
            sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = TxtCountupdate.Text
            sqlCommand.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = DtpNgaynhapUpdate.Value

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Reset()
                MessageBox.Show("Chỉnh sửa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK)
                TxtIDbookupdate.Text = ""
                TxtNamebookupdate.Text = ""
                TxtThloaiUpdate.Text = ""
                TxtGroupbookupdate.Text = ""
                TxtAuthorbookupdate.Text = ""
                TxtNxbupdate.Text = ""
                TxtCountupdate.Text = ""
                TxtIDbookupdate.Focus()
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy ID sách đã nhập! Nhập lại hoặc thêm thông tin sách mới", "Thông báo", MessageBoxButtons.OK)
            End If

            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub BtnDeletebook_Click(sender As Object, e As EventArgs) Handles BtnDeletebook.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "deleteBook"
            sqlCommand.Parameters.Add("@MaSach", SqlDbType.NChar).Value = TxtIDbookdelete.Text
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Reset()
                MessageBox.Show("Xóa thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK)
                TxtIDbookdelete.Text = ""
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy mã sách vừa nhập! Nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If


            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub LayDl()
        Dim SqlDataAdapter As New SqlDataAdapter("select * from BOOK where TenSach ='" + TxtNamebookS.Text + "'", SqlConnect)
        Dim dataTable As New DataTable
        SqlDataAdapter.Fill(dataTable)
        DgvFindbook.DataSource = dataTable

    End Sub
    Private Sub BtnFindbook_Click(sender As Object, e As EventArgs) Handles BtnFindbook.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "findBook"
            sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = TxtNamebookS.Text
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                LayDl()
                'Reset()
                TxtNamebookS.Text = ""
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy tên sách vừa nhập! Nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If
            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub
End Class