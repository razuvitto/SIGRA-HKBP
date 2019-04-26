Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Keuangan_pengeluaran
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.SearchKegiatan()
            Me.BindGrid()
        End If
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Keuangan_SP")
                cmd.Parameters.AddWithValue("@Action", "SELECT_PENGELUARAN")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        pemasukan.DataSource = dt
                        pemasukan.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub SearchKegiatan()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "SELECT * FROM Pengeluaran"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE deskripsi Like @deskripsi+ '%'"
                    cmd.Parameters.AddWithValue("@deskripsi", txtSearch.Text.Trim())
                End If
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    pemasukan.DataSource = dt
                    pemasukan.DataBind()
                End Using
            End Using
        End Using
    End Sub
    Protected Sub Search(sender As Object, e As EventArgs)
        Me.SearchKegiatan()
    End Sub

    Protected Sub OnPaging(sender As Object, e As GridViewPageEventArgs)
        pemasukan.PageIndex = e.NewPageIndex
        Me.SearchKegiatan()
    End Sub
End Class
