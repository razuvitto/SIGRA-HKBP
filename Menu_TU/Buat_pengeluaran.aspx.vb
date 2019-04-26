Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Buat_pengeluaran
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
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
    Private Sub Insert()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Transaksi_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT_PENGELUARAN")
                cmd.Parameters.AddWithValue("@id_transaksi", "")
                cmd.Parameters.AddWithValue("@nama_transaksi", txtnama.Text)
                cmd.Parameters.AddWithValue("@jenis_transaksi", "Pengeluaran")
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Text)
                cmd.Parameters.AddWithValue("@tanggal_transaksi", txttanggal.text)
                cmd.Parameters.AddWithValue("@waktu_input_data", Date.Now)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("Keuangan_pengeluaran.aspx")
    End Sub

End Class







'Imports System.IO
'Imports System.Data
'Imports System.Configuration
'Imports System.Data.SqlClient
'Partial Class Buat_pemasukan
'    Inherits System.Web.UI.Page

'    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
'        If Not Me.IsPostBack Then
'            Me.BindGrid()
'        End If
'    End Sub

'    Private Sub BindGrid()
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Transaksi_CRUD")
'                cmd.Parameters.AddWithValue("@Action", "SELECT")
'                cmd.Parameters.AddWithValue("@id_transaksi", "")
'                cmd.Parameters.AddWithValue("@tipe_transaksi", "")
'                cmd.Parameters.AddWithValue("@jenis_transaksi", "")
'                cmd.Parameters.AddWithValue("@jumlah_pemasukan", "")
'                cmd.Parameters.AddWithValue("@jumlah_pengeluaran", "")
'                cmd.Parameters.AddWithValue("@total_pemasukan", "")
'                cmd.Parameters.AddWithValue("@total_pengeluaran", "")
'                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
'                Using sda As New SqlDataAdapter()
'                    cmd.CommandType = CommandType.StoredProcedure
'                    cmd.Connection = con
'                    sda.SelectCommand = cmd
'                    Using dt As New DataTable()
'                        sda.Fill(dt)
'                        pemasukan.DataSource = dt
'                        pemasukan.DataBind()
'                    End Using
'                End Using
'            End Using
'        End Using
'    End Sub


'    Private Sub Insert()
'        Dim judul As String = txtjudul.Text
'        Dim jumlah As String = txtjumlah.Text
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Transaksi_CRUD")
'                cmd.CommandType = CommandType.StoredProcedure
'                cmd.Parameters.AddWithValue("@Action", "INSERT_PEMASUKAN")
'                cmd.Parameters.AddWithValue("@id_transaksi", "")
'                cmd.Parameters.AddWithValue("@tipe_transaksi", judul)
'                cmd.Parameters.AddWithValue("@jenis_transaksi", "Pemasukan")
'                cmd.Parameters.AddWithValue("@jumlah_pemasukan", jumlah)
'                cmd.Parameters.AddWithValue("@jumlah_pengeluaran", "")
'                cmd.Parameters.AddWithValue("@total_pemasukan", "")
'                cmd.Parameters.AddWithValue("@total_pengeluaran", "")
'                cmd.Parameters.AddWithValue("@tanggal_transaksi", "")
'                cmd.Connection = con
'                con.Open()
'                cmd.ExecuteNonQuery()
'                con.Close()
'            End Using
'        End Using
'        Me.BindGrid()
'    End Sub
'    Protected Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
'        Insert()
'        Response.Redirect("keuangan_penerimaan.aspx")
'    End Sub

'End Class