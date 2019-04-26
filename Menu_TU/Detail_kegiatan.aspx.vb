Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Detail_kegiatan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BindGrid()
        Me.BindGrid2()
        Me.BindGrid3()
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("kegiatan_CRUD")
        cmd.Parameters.AddWithValue("@Action", "JUDUL")
        cmd.Parameters.AddWithValue("@id_kegiatan", Session("select_kegiatan"))
        cmd.Parameters.AddWithValue("@judul", "")
        cmd.Parameters.AddWithValue("@deskripsi", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        Dim dt As New DataTable()
        sda.Fill(dt)
        gv.DataSource = dt
        gv.DataBind()
    End Sub
    Private Sub BindGrid2()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("kegiatan_CRUD")
        cmd.Parameters.AddWithValue("@Action", "ISI")
        cmd.Parameters.AddWithValue("@id_kegiatan", Session("select_kegiatan"))
        cmd.Parameters.AddWithValue("@judul", "")
        cmd.Parameters.AddWithValue("@deskripsi", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        Dim dt As New DataTable()
        sda.Fill(dt)
        gv_isi.DataSource = dt
        gv_isi.DataBind()
    End Sub
    Private Sub BindGrid3()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("kegiatan_CRUD")
        cmd.Parameters.AddWithValue("@Action", "WAKTU")
        cmd.Parameters.AddWithValue("@id_kegiatan", Session("select_kegiatan"))
        cmd.Parameters.AddWithValue("@judul", "")
        cmd.Parameters.AddWithValue("@deskripsi", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        Dim dt As New DataTable()
        sda.Fill(dt)
        gv_waktu.DataSource = dt
        gv_waktu.DataBind()
    End Sub
End Class




