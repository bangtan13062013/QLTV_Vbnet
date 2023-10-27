
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class FLogin
    Dim conn As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim username As String = " "
    Dim pass As String = ""
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        conn = New SqlConnection("Data Source=DESKTOP-0LFAVEB\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
        Try
            conn.Open()
            sqlCommand = New SqlCommand()
            sqlCommand.CommandType = CommandType.StoredProcedure
            sqlCommand.CommandText = "duyetLogin"
            sqlCommand.Parameters.AddWithValue("@UserName", txtUserName.Text)
            sqlCommand.Parameters.AddWithValue("@pass", txtPass.Text)
            sqlCommand.Connection = conn
            username = txtUserName.Text
            pass = txtPass.Text
            Dim kq As Object = sqlCommand.ExecuteScalar()
            Dim code As Int32 = Convert.ToInt32(kq)
            If (code = 1) Then
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK)

                FDisplay.ShowDialog()
                Me.Close()
            End If

            If (code = 2) Then
                MessageBox.Show("Tên đăng nhập, mật khẩu không đúng hoặc không tồn tại. Mời nhập lại!", "Thông báo", MessageBoxButtons.OK)
                txtPass.Text = ""
                txtUserName.Text = ""
                txtUserName.Focus()
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erros")
        End Try


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) <> System.Windows.Forms.DialogResult.OK) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LkblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LkblRegister.LinkClicked

        FRegisterAcc.ShowDialog()

    End Sub


End Class
