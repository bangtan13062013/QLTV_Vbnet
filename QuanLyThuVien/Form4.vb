Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Interop

Public Class Fqltk
    Dim SqlConnect As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim sqlDataReader As SqlDataReader
    Private Sub Ketnoi()
        SqlConnect = New SqlConnection("Data Source=DESKTOP-0LFAVEB\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")

    End Sub
    Private Function Ktra() As Boolean

        If (TxtAccountUsername.Text = "") Then
            MessageBox.Show("Nhập tên đăng nhập! ", "thông báo", MessageBoxButtons.OK)
            TxtAccountUsername.Focus()
            Return False
        ElseIf (TxtPassWord.Text = "") Then
            MessageBox.Show("NHập mật khẩu! ", "thông báo", MessageBoxButtons.OK)
            TxtPassWord.Focus()
            Return False
        ElseIf (TxtReturnPass.Text = "") Then
            MessageBox.Show("Xác nhận lại mật khẩu! ", "thông báo", MessageBoxButtons.OK)
            TxtReturnPass.Focus()
            Return False
        ElseIf (TxtReturnPass.Text <> TxtPassWord.Text) Then
            MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận ko trùng khớp!", "thông báo", MessageBoxButtons.OK)
            TxtReturnPass.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If (Ktra()) Then
            Try
                Ketnoi()
                SqlConnect.Open()
                sqlCommand = New SqlCommand()
                sqlCommand.CommandType = CommandType.StoredProcedure
                sqlCommand.CommandText = "updateAcc"
                sqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = TxtAccountUsername.Text
                sqlCommand.Parameters.Add("@pass", SqlDbType.NVarChar).Value = TxtPassWord.Text
                sqlCommand.Parameters.Add("@returnpass", SqlDbType.NVarChar).Value = TxtReturnPass.Text
                sqlCommand.Connection = SqlConnect
                sqlDataReader = sqlCommand.ExecuteReader
                sqlDataReader.Read()
                If (sqlDataReader.GetInt32(0) = 1) Then
                    MessageBox.Show("Đã cập nhật mật khẩu!", "Thông báo", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Nhập lại tên đăng nhập", "Thông báo", MessageBoxButtons.OK)
                    TxtAccountUsername.Text = ""
                    TxtPassWord.Text = ""
                    TxtReturnPass.Text = ""
                    TxtAccountUsername.Focus()

                End If
                sqlDataReader.Close()
                SqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erros")
            End Try
        End If

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Application.Exit()

    End Sub

    Private Sub LayDl()
        Dim SqlDataAdapter As New SqlDataAdapter("select * from LoginAcc", SqlConnect)
        Dim dataTable As New DataTable
        SqlDataAdapter.Fill(dataTable)
        DgvDisplayAcc.DataSource = dataTable

    End Sub
    Private Sub Fqltk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ketnoi()
        SqlConnect.Open()
        LayDl()
        SqlConnect.Close()
    End Sub

    Private Sub BtnReturnP2_Click(sender As Object, e As EventArgs) Handles BtnReturnP2.Click
        Me.Close()


    End Sub
End Class