Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Keuangan_pengeluaran
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
        End If
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_SP")
                cmd.Parameters.AddWithValue("@Action", "SELECT_PENGELUARAN")
                cmd.Parameters.AddWithValue("@id_transaksi", "")
                cmd.Parameters.AddWithValue("@nama_transaksi", "")
                cmd.Parameters.AddWithValue("@jenis_transaksi", "")
                cmd.Parameters.AddWithValue("@kode_transaksi", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
                cmd.Parameters.AddWithValue("@debit", "")
                cmd.Parameters.AddWithValue("@kredit", "")
                cmd.Parameters.AddWithValue("@saldo", "")
                cmd.Parameters.AddWithValue("@waktu_input_data", "")
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
    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> pemasukan.EditIndex Then
            TryCast(e.Row.Cells(3).Controls(0), LinkButton).Attributes("onclick") = "return confirm('Apakah Anda yakin ingin menghapus data ini?');"
        End If
    End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_transaksi As Integer = Convert.ToInt32(pemasukan.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_SP")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE_PENGELUARAN")
                cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi)
                cmd.Parameters.AddWithValue("@nama_transaksi", "")
                cmd.Parameters.AddWithValue("@jenis_transaksi", "")
                cmd.Parameters.AddWithValue("@kode_transaksi", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
                cmd.Parameters.AddWithValue("@debit", "")
                cmd.Parameters.AddWithValue("@kredit", "")
                cmd.Parameters.AddWithValue("@saldo", "")
                cmd.Parameters.AddWithValue("@waktu_input_data", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
End Class
