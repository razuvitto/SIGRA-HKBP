Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Buat_pengeluaran
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
        End If
    End Sub
    Private Sub Insert()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_SP")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT_PENGELUARAN")
                cmd.Parameters.AddWithValue("@id_transaksi", "")
                cmd.Parameters.AddWithValue("@nama_transaksi", txtnama.Text)
                cmd.Parameters.AddWithValue("@jenis_transaksi", "Pengeluaran")
                cmd.Parameters.AddWithValue("@kode_transaksi", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", txttanggal.Text)
                cmd.Parameters.AddWithValue("@debit", 0)
                cmd.Parameters.AddWithValue("@kredit", txtjumlah.Text)
                cmd.Parameters.AddWithValue("@saldo", 0 - txtjumlah.Text)
                cmd.Parameters.AddWithValue("@waktu_input_data", Date.Now)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("~/Menu_Bendahara/Keuangan_pengeluaran.aspx")
    End Sub

End Class