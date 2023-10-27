Imports System.Data.SqlClient

Public Class Fdksach
    Dim SqlConnect As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim sqlDataReader As SqlDataReader

    Private Sub Ketnoi()
        SqlConnect = New SqlConnection("Data Source=DESKTOP-0LFAVEB\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
        sqlCommand = New SqlCommand()
        sqlCommand.CommandType = CommandType.StoredProcedure
        sqlCommand.Connection = SqlConnect

    End Sub
    Private Sub BtnAddr_Click(sender As Object, e As EventArgs) Handles BtnAddr.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            If (TxtIDbookr.Text = "" Or TxtNamer.Text = "" Or TxtNamebookr.Text = "" Or TxtIDr.Text = "") Then
                MessageBox.Show("Thông tin chưa được nhập đủ. Nhập lại!", "Thông báo", MessageBoxButtons.OK)
                TxtIDr.Text = ""
                TxtNamer.Text = ""
                TxtChucvur.Text = ""
                TxtIDbookr.Text = ""
                TxtNamebookr.Focus()
            End If
            sqlCommand.CommandText = "addRead"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtIDr.Text
            sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = TxtNamer.Text
            sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NChar).Value = TxtChucvur.Text
            sqlCommand.Parameters.Add("@MaSach", SqlDbType.NChar).Value = TxtIDbookr.Text
            sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = TxtNamebookr.Text

            If (CkbYesr.Checked = True) Then
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Đã trả sách"
            Else
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Chưa trả sách"
            End If
            sqlCommand.ExecuteNonQuery()
            Reset()
            MessageBox.Show("Đã thêm thông tin phiếu đọc thành công!", "Thông báo", MessageBoxButtons.OK)
            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub BtnUpdater_Click(sender As Object, e As EventArgs) Handles BtnUpdater.Click

        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "editBookRead"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtIDr.Text
            sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = TxtNamer.Text
            sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NChar).Value = TxtChucvur.Text
            sqlCommand.Parameters.Add("@MaSach", SqlDbType.NChar).Value = TxtIDbookr.Text
            sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = TxtNamebookr.Text
            If (CkbYesr.Checked = True) Then
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Đã trả sách"
            Else
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Chưa trả sách"
            End If
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Reset()
                MessageBox.Show("Chỉnh sửa phiếu đọc thành công!", "Thông báo", MessageBoxButtons.OK)
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy ID cá nhân vừa nhập! Thêm Thông tin phiếu đọc hoặc nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If

            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub BtnDeleter_Click(sender As Object, e As EventArgs) Handles BtnDeleter.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "deleteRead"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtIDr.Text
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Reset()
                MessageBox.Show("Xóa phiếu đọc thành công!", "Thông báo", MessageBoxButtons.OK)
                TxtIDr.Text = ""
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy mã cá nhân vừa nhập! Nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If
            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub LayDl()
        Dim SqlDataAdapter As New SqlDataAdapter("select * from DocTcho where MaCN ='" + TxtIDr.Text + "'", SqlConnect)
        Dim dataTable As New DataTable
        SqlDataAdapter.Fill(dataTable)
        DgvShow.DataSource = dataTable
    End Sub

    Private Sub BtnFindr_Click(sender As Object, e As EventArgs) Handles BtnFindr.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "findRead"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtIDr.Text
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                LayDl()
                'Reset()
                TxtIDr.Text = ""
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy mã cá nhân vừa nhập! Nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If
            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub BtnReturnPage2_Click(sender As Object, e As EventArgs) Handles BtnReturnPage2.Click
        Me.Close()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            If (TxtIDbook.Text = "" Or TxtName.Text = "" Or TxtNamebook.Text = "" Or TxtID.Text = "") Then
                MessageBox.Show("Thông tin chưa được nhập đủ. Nhập lại!", "Thông báo", MessageBoxButtons.OK)
                TxtID.Text = ""
                TxtName.Text = ""
                TxtChucvu.Text = ""
                TxtIDbook.Text = ""
                TxtNamebook.Focus()
            End If
            sqlCommand.CommandText = "addBorrow"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtIDr.Text
            sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = TxtNamer.Text
            sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NChar).Value = TxtChucvur.Text
            sqlCommand.Parameters.Add("@MaSach", SqlDbType.NChar).Value = TxtIDbookr.Text
            sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = TxtNamebookr.Text
            sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.Date).Value = DtpBorrow.Value
            sqlCommand.Parameters.Add("@NgayTra", SqlDbType.Date).Value = DtpReturn.Value

            If (CkbYesr.Checked = True) Then
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Đã trả sách"
            Else
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Chưa trả sách"
            End If
            sqlCommand.ExecuteNonQuery()
            Reset()
            MessageBox.Show("Đã thêm thông tin phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK)
            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "editBookBorrow"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtIDr.Text
            sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = TxtNamer.Text
            sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NChar).Value = TxtChucvur.Text
            sqlCommand.Parameters.Add("@MaSach", SqlDbType.NChar).Value = TxtIDbookr.Text
            sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = TxtNamebookr.Text
            sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.Date).Value = DtpBorrow.Value
            sqlCommand.Parameters.Add("@NgayTra", SqlDbType.Date).Value = DtpReturn.Value

            If (CkbYesr.Checked = True) Then
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Đã trả sách"
            Else
                sqlCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = "Chưa trả sách"
            End If
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Reset()
                MessageBox.Show("Chỉnh sửa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK)
            End If
            If (sqlDataReader.GetInt32(0) = 1) Then
                MessageBox.Show("Không tìm thấy ID cá nhân vừa nhập! Thêm Thông tin phiếu mượn hoặc nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If

            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "deleteBorrow"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtID.Text
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Reset()
                MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK)
                TxtID.Text = ""
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy mã cá nhân vừa nhập! Nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If
            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand.CommandText = "findBorrow"
            sqlCommand.Parameters.Add("@MaCN", SqlDbType.NVarChar).Value = TxtID.Text
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()
            If (sqlDataReader.GetInt32(0) = 1) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Dim SqlDataAdapter As New SqlDataAdapter("select * from MuonSach where MaCN ='" + TxtID.Text + "'", SqlConnect)
                Dim dataTable As New DataTable
                SqlDataAdapter.Fill(dataTable)
                DgvShow.DataSource = dataTable
                'Reset()
                TxtID.Text = ""
            End If
            If (sqlDataReader.GetInt32(0) = 0) Then
                MessageBox.Show("Không tìm thấy mã cá nhân vừa nhập! Nhập lại!", "Thông báo", MessageBoxButtons.OK)
            End If
            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try
    End Sub
End Class