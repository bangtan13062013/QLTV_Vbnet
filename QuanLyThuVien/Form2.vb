Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows
Imports Microsoft
Imports Microsoft.Data

Public Class FDisplay
    Dim SqlConnect As SqlConnection
    Private Sub LayDl()

        Dim SqlDataAdapter As New SqlDataAdapter("select * from BOOK", SqlConnect)
        Dim dataTable As New DataTable
        SqlDataAdapter.Fill(dataTable)
        DgvBook.DataSource = dataTable
    End Sub

    Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSáchToolStripMenuItem.Click
        Fqlsach.ShowDialog()

    End Sub

    Private Sub QuảnLýTàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýTàiKhoảnToolStripMenuItem.Click
        Fqltk.ShowDialog()

    End Sub

    Private Sub ĐăngKýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngKýSáchToolStripMenuItem.Click
        Fdksach.ShowDialog()

    End Sub

    Private Sub FDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnect = New SqlConnection("Data Source=DESKTOP-0LFAVEB\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True")
        SqlConnect.Open()
        LayDl()
        SqlConnect.Close()
    End Sub
End Class