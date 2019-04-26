Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Tentang
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid1()
        End If
    End Sub

    Private Sub BindGrid1()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Konfigurasi")
                cmd.Parameters.AddWithValue("@Action", "SELECT")
                cmd.Parameters.AddWithValue("@id_gereja", "")
                cmd.Parameters.AddWithValue("@nama_gereja", "")
                cmd.Parameters.AddWithValue("@alamat_gereja", "")
                cmd.Parameters.AddWithValue("@distrik_gereja", "")
                cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
                cmd.Parameters.AddWithValue("@logo_gereja", "")
                cmd.Parameters.AddWithValue("@path ", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        tentang1.DataSource = dt
                        tentang1.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
