
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Server

Public Class FRegisterAcc
    Dim SqlConnect As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim sqlDataReader As SqlDataReader

    Private Sub Ketnoi()
        SqlConnect = New SqlConnection("Data Source=DESKTOP-0LFAVEB\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")

    End Sub
    Private Sub BtnRegisterAcc_Click(sender As Object, e As EventArgs) Handles BtnRegisterAcc.Click

        Try
            Ketnoi()
            SqlConnect.Open()
            sqlCommand = New SqlCommand()
            sqlCommand.CommandType = CommandType.StoredProcedure
            sqlCommand.CommandText = "dkAcc"
            sqlCommand.Parameters.Add("@email", SqlDbType.NChar).Value = TxtGmailAcc.Text
            sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = TxtNameAcc.Text
            sqlCommand.Parameters.Add("@pass", SqlDbType.NVarChar).Value = TxtPassAcc.Text
            sqlCommand.Connection = SqlConnect
            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If (sqlDataReader.GetInt32(0) = 1) Then
                MessageBox.Show("Gmail và tên đăng nhập đã tồn tại! Nhập lại", "Thông báo", MessageBoxButtons.OK)
                TxtGmailAcc.Text = ""
                TxtNameAcc.Text = ""
                TxtPassAcc.Text = ""
                TxtGmailAcc.Focus()
            End If
            If (sqlDataReader.GetInt32(0) = 2) Then
                MessageBox.Show("Gmail đã tồn tại! Nhập lại", "Thông báo", MessageBoxButtons.OK)
                TxtGmailAcc.Text = ""
                TxtGmailAcc.Focus()
            End If
            If (sqlDataReader.GetInt32(0) = 3) Then
                MessageBox.Show("Tên đăng nhập đã tồn tại! Nhập lại", "Thông báo", MessageBoxButtons.OK)
                TxtNameAcc.Text = ""
                TxtNameAcc.Focus()
            End If
            If (sqlDataReader.GetInt32(0) = 4) Then
                sqlDataReader.Close()
                sqlCommand.ExecuteNonQuery()
                Reset()
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK)
                FDisplay.ShowDialog()
                Me.Close()

            End If

            SqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try

    End Sub

    Private Sub BtnExit0_Click(sender As Object, e As EventArgs) Handles BtnExit0.Click
        Me.Close()
    End Sub

End Class