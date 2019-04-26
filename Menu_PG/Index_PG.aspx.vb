Imports System.Data
Imports System.Data.SqlClient
Partial Class Index_PG
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.BindGrid2()
            'Me.BindGrid3()
            Me.BindGrid4()
            Me.BindGrid5()
            getCustRecords("", "")
            getCustRecords2("", "")
        End If
    End Sub
    'Private Sub BindGrid()
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("Pengumuman_CRUD")
    '            cmd.Parameters.AddWithValue("@Action", "SELECT")
    '            cmd.Parameters.AddWithValue("@id_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@judul_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@isi_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@waktu_unggah", "")
    '            cmd.Parameters.AddWithValue("@file_pengumuman", "")
    '            Using sda As New SqlDataAdapter()
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dt As New DataTable()
    '                    sda.Fill(dt)
    '                    all_pengumuman.DataSource = dt
    '                    all_pengumuman.DataBind()
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    'Private Sub BindGrid1()
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("Pengumuman_CRUD")
    '            cmd.Parameters.AddWithValue("@Action", "SELECT_TOP")
    '            cmd.Parameters.AddWithValue("@id_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@judul_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@isi_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@waktu_unggah", "")
    '            cmd.Parameters.AddWithValue("@file_pengumuman", "")
    '            Using sda As New SqlDataAdapter()
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dt As New DataTable()
    '                    sda.Fill(dt)
    '                    all_pengumuman.DataSource = dt
    '                    all_pengumuman.DataBind()
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    Private Sub BindGrid2()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Jadwal_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT_JADWAL_TOP")
                cmd.Parameters.AddWithValue("@id_jadwal", "")
                cmd.Parameters.AddWithValue("@nama_ibadah", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        jadwal.DataSource = dt
                        jadwal.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    'Private Sub BindGrid3()
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("Kegiatan_CRUD")
    '            cmd.Parameters.AddWithValue("@Action", "SELECT_KEGIATAN_TOP")
    '            cmd.Parameters.AddWithValue("@id_kegiatan", "")
    '            cmd.Parameters.AddWithValue("@judul", "")
    '            cmd.Parameters.AddWithValue("@deskripsi", "")
    '            cmd.Parameters.AddWithValue("@waktu_unggah", "")
    '            Using sda As New SqlDataAdapter()
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dt As New DataTable()
    '                    sda.Fill(dt)
    '                    kegiatan.DataSource = dt
    '                    kegiatan.DataBind()
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    Private Sub BindGrid4()
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
                cmd.Parameters.AddWithValue("@path", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        gvwelcome.DataSource = dt
                        gvwelcome.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid5()
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
                cmd.Parameters.AddWithValue("@path", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        gvimgbrand.DataSource = dt
                        gvimgbrand.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub


    Private Sub getCustRecords(searchBy As String, searchVal As String)
        Dim constring As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim constr As New SqlConnection(constring)
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand()
        Dim sda As New SqlDataAdapter()
        cmd = New SqlCommand("Pengumuman_CRUD", constr)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Action", "SELECT_TOP")
        cmd.Parameters.AddWithValue("@id_pengumuman", "")
        cmd.Parameters.AddWithValue("@judul_pengumuman", "")
        cmd.Parameters.AddWithValue("@isi_pengumuman", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        cmd.Parameters.AddWithValue("@file_pengumuman", "")
        sda.SelectCommand = cmd
        sda.Fill(dt)
        If dt.Rows.Count > 0 Then
            Session("data") = dt
            CustGrid.DataSource = dt
            CustGrid.DataBind()
        Else
            CustGrid.DataSource = dt
            CustGrid.DataBind()
        End If
    End Sub
    Private Sub getCustRecords2(searchBy As String, searchVal As String)
        Dim constring As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim constr As New SqlConnection(constring)
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand()
        Dim sda As New SqlDataAdapter()
        cmd = New SqlCommand("kegiatan_CRUD", constr)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Action", "SELECT_KEGIATAN_TOP")
        cmd.Parameters.AddWithValue("@id_kegiatan", "")
        cmd.Parameters.AddWithValue("@judul", "")
        cmd.Parameters.AddWithValue("@deskripsi", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        sda.SelectCommand = cmd
        sda.Fill(dt)
        If dt.Rows.Count > 0 Then
            Session("data") = dt
            Custgrid2.DataSource = dt
            Custgrid2.DataBind()
        Else
            Custgrid2.DataSource = dt
            Custgrid2.DataBind()
        End If
    End Sub
    Protected Sub OnRowDataBound(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(CustGrid, "Select$" & e.Row.RowIndex)
            e.Row.Attributes("style") = "cursor:pointer"
            'CustGrid.Columns(0).Visible = False
        End If
    End Sub
    Protected Sub OnRowDataBound2(sender As Object, e As System.Web.UI.WebControls.GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(Custgrid2, "Select$" & e.Row.RowIndex)
            e.Row.Attributes("style") = "cursor:pointer"
            'CustGrid.Columns(0).Visible = False
        End If
    End Sub
    Protected Sub OnSelectedIndexChanged(sender As Object, e As EventArgs)
        Session("select_pengumuman") = Int(CustGrid.SelectedRow.Cells(0).Text)
        Response.Redirect("Detail_pengumuman.aspx")

    End Sub
    Protected Sub OnSelectedIndexChanged2(sender As Object, e As EventArgs)
        Session("select_kegiatan") = Int(Custgrid2.SelectedRow.Cells(0).Text)
        Response.Redirect("Detail_kegiatan.aspx")

    End Sub
End Class