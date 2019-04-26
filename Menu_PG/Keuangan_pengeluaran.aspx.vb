Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Keuangan_pengeluaran
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
            Me.SearchKegiatan()
        End If
    End Sub

    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT_PENGELUARAN")
                cmd.Parameters.AddWithValue("@id_transaksi", "")
                cmd.Parameters.AddWithValue("@nama_transaksi", "")
                cmd.Parameters.AddWithValue("@jenis_transaksi", "")
                cmd.Parameters.AddWithValue("@jumlah", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
                cmd.Parameters.AddWithValue("@waktu_input_data", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        pengeluaran.DataSource = dt
                        pengeluaran.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> pengeluaran.EditIndex Then
            TryCast(e.Row.Cells(3).Controls(0), LinkButton).Attributes("onclick") = "return confirm('Apakah Anda yakin ingin menghapus data ini?');"
        End If
    End Sub
    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_transaksi As Integer = Convert.ToInt32(pengeluaran.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("transaksi_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE")
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi)
                cmd.Parameters.AddWithValue("@nama_transaksi", "")
                cmd.Parameters.AddWithValue("@jenis_transaksi", "")
                cmd.Parameters.AddWithValue("@jumlah", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
                cmd.Parameters.AddWithValue("@waktu_input_data", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
    Private Sub SearchKegiatan()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "SELECT * FROM transaksi"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE nama_transaksi LIKE @nama_transaksi+ '%'"
                    cmd.Parameters.AddWithValue("@nama_transaksi", txtSearch.Text.Trim())
                End If
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    pengeluaran.DataSource = dt
                    pengeluaran.DataBind()
                End Using
            End Using
        End Using
    End Sub
    Protected Sub Search(sender As Object, e As EventArgs)
        Me.SearchKegiatan()
    End Sub

    Protected Sub OnPaging(sender As Object, e As GridViewPageEventArgs)
        pengeluaran.PageIndex = e.NewPageIndex
        Me.SearchKegiatan()
    End Sub
End Class
