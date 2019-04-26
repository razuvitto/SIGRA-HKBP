Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Buat_pemasukan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
        End If
        'txtjudul.Text = ""
        'txtisi.Text = ""
    End Sub
    Private Sub Insert()
        Dim judul As String = txtnama.Text
        Dim jumlah As String = txtjumlah.Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_SP")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT_PEMASUKAN")
                cmd.Parameters.AddWithValue("@id_transaksi", "")
                cmd.Parameters.AddWithValue("@nama_transaksi", judul)
                cmd.Parameters.AddWithValue("@jenis_transaksi", "Pemasukan")
                cmd.Parameters.AddWithValue("@kode_transaksi", "")
                cmd.Parameters.AddWithValue("@tanggal_transaksi", txttanggal.Text)
                cmd.Parameters.AddWithValue("@debit", jumlah)
                cmd.Parameters.AddWithValue("@kredit", 0)
                cmd.Parameters.AddWithValue("@saldo", jumlah - 0)
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
        Response.Redirect("~/Menu_bendahara/Keuangan_pemasukan.aspx")
    End Sub

End Class