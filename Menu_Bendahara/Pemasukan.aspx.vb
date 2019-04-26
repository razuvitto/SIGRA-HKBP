Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Pemasukan
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
                cmd.Parameters.AddWithValue("@Action", "SELECT_PEMASUKAN")
                cmd.Parameters.AddWithValue("@id_transaksi", "")
                cmd.Parameters.AddWithValue("@nama_transaksi", "")
                cmd.Parameters.AddWithValue("@jenis_transaksi", "")
                cmd.Parameters.AddWithValue("@jumlah", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
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

    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        pemasukan.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        pemasukan.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = pemasukan.Rows(e.RowIndex)
        Dim id_transaksi As Integer = Convert.ToInt32(pemasukan.DataKeys(e.RowIndex).Values(0))
        Dim nama As String = TryCast(row.FindControl("txtnama"), TextBox).Text
        Dim jumlah As String = TryCast(row.FindControl("txtjumlah"), TextBox).Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "UPDATE_PEMASUKAN")
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi)
                cmd.Parameters.AddWithValue("@nama_transaksi", nama)
                cmd.Parameters.AddWithValue("@jenis_transaksi", "Pemasukan")
                cmd.Parameters.AddWithValue("@jumlah", jumlah)
                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        pemasukan.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> pemasukan.EditIndex Then
            TryCast(e.Row.Cells(3).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Apakah Anda yakin ingin menghapus data ini?');"
        End If
    End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_transaksi As Integer = Convert.ToInt32(pemasukan.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE")
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi)
                cmd.Parameters.AddWithValue("@nama_transaksi", "")
                cmd.Parameters.AddWithValue("@jenis_transaksi", "")
                cmd.Parameters.AddWithValue("@jumlah", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
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
                Dim sql As String = "SELECT id_transaksi, nama_transaksi, jumlah, tanggal_transaksi FROM transaksi"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE nama_transaksi LIKE @nama_transaksi + '%'"
                    cmd.Parameters.AddWithValue("@nama_transaksi", txtSearch.Text.Trim())
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
