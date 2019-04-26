Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Laporan_Pengeluaran
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
            'Me.BindGrid2()
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
                        pemasukan.DataSource = dt
                        pemasukan.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
