Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Partial Public Class Edit_Logo
    Inherits System.Web.UI.Page

    Private con As SqlConnection
    Private da As SqlDataAdapter
    Private ds As DataSet
    Private cmd As SqlCommand
    Private connStr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            ImageData()
        End If
    End Sub

    Protected Sub ImageData()
        con = New SqlConnection(connStr)
        con.Open()
        da = New SqlDataAdapter("select top 1 * from gereja ORDER BY waktu_konfigurasi DESC", con)
        ds = New DataSet()
        da.Fill(ds)
        gvProfil.DataSource = ds
        gvProfil.DataBind()
    End Sub

    Protected Sub gvImage_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs)
        gvProfil.EditIndex = e.NewEditIndex
        ImageData()
    End Sub

    Protected Sub gvImage_RowUpdating(ByVal sender As Object, ByVal e As GridViewUpdateEventArgs)
        Dim imageId As String = gvProfil.DataKeys(e.RowIndex).Value.ToString()
        Dim name As TextBox = CType(gvProfil.Rows(e.RowIndex).FindControl("txt_Nama_gereja"), TextBox)
        Dim FileUpload1 As FileUpload = CType(gvProfil.Rows(e.RowIndex).FindControl("FileUpload1"), FileUpload)
        con = New SqlConnection(connStr)
        Dim path As String = "~/Images/"

        If FileUpload1.HasFile Then
            path += FileUpload1.FileName
            FileUpload1.SaveAs(MapPath(path))
        Else
            Dim img As Image = CType(gvProfil.Rows(e.RowIndex).FindControl("img_logo"), Image)
            path = img.ImageUrl
        End If

        Dim cmd As SqlCommand = New SqlCommand("update gereja set logo_gereja='" & name.Text & "',path='" & path & "'  where id_gereja=" & imageId & "", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        gvProfil.EditIndex = -1
        ImageData()
    End Sub

    Protected Sub gvImage_RowCancelingEdit(ByVal sender As Object, ByVal e As GridViewCancelEditEventArgs)
        gvProfil.EditIndex = -1
        ImageData()
    End Sub

    Protected Sub gvImage_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs)
        Dim row As GridViewRow = CType(gvProfil.Rows(e.RowIndex), GridViewRow)
        Dim lbldeleteid As Label = CType(row.FindControl("lblImgId"), Label)
        Dim lblDeleteImageName As Label = CType(row.FindControl("lblnama_gereja"), Label)
        con = New SqlConnection(connStr)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("delete FROM gereja where id_gereja='" & Convert.ToInt32(gvProfil.DataKeys(e.RowIndex).Value.ToString()) & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
        ImageDeleteFromFolder(lblDeleteImageName.Text)
        ImageData()
    End Sub

    Protected Sub ImageDeleteFromFolder(ByVal imagename As String)
        Dim file_name As String = imagename
        Dim path As String = Server.MapPath("~/Images/" & imagename)
        Dim file As FileInfo = New FileInfo(path)

        If file.Exists Then
            file.Delete()
            lblResult.Text = file_name & " file deleted successfully"
            lblResult.ForeColor = System.Drawing.Color.Green
        Else
            lblResult.Text = file_name & " This file does not exists "
            lblResult.ForeColor = System.Drawing.Color.Red
        End If
    End Sub
End Class

































'Imports System.IO
'Imports System.Data
'Imports System.Configuration
'Imports System.Data.SqlClient

'Partial Class Edit_Profil_Gereja
'    Inherits System.Web.UI.Page

'    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
'        If Not Me.IsPostBack Then
'            Me.BindGrid()
'            'Me.BindGrid2()
'        End If
'    End Sub

'    Private Sub BindGrid()
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Konfigurasi")
'                cmd.Parameters.AddWithValue("@Action", "SELECT")
'                cmd.Parameters.AddWithValue("@id_gereja", "")
'                cmd.Parameters.AddWithValue("@nama_gereja", "")
'                cmd.Parameters.AddWithValue("@alamat_gereja", "")
'                cmd.Parameters.AddWithValue("@distrik_gereja", "")
'                cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
'                cmd.Parameters.AddWithValue("@logo_gereja", "")
'                cmd.Parameters.AddWithValue("@path", "")
'                cmd.Parameters.AddWithValue("@wallpaper_gereja", "")
'                cmd.Parameters.AddWithValue("@path_wallpaper", "")
'                cmd.Parameters.AddWithValue("@deskripsi", "")
'                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
'                Using sda As New SqlDataAdapter()
'                    cmd.CommandType = CommandType.StoredProcedure
'                    cmd.Connection = con
'                    sda.SelectCommand = cmd
'                    Using dt As New DataTable()
'                        sda.Fill(dt)
'                        profil_gereja.DataSource = dt
'                        profil_gereja.DataBind()
'                    End Using
'                End Using
'            End Using
'        End Using
'    End Sub
'    'Private Sub BindGrid2()
'    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'    '    Using con As New SqlConnection(constr)
'    '        Using cmd As New SqlCommand("Konfigurasi")
'    '            cmd.Parameters.AddWithValue("@Action", "SELECT")
'    '            cmd.Parameters.AddWithValue("@id_gereja", "")
'    '            cmd.Parameters.AddWithValue("@nama_gereja", "")
'    '            cmd.Parameters.AddWithValue("@alamat_gereja", "")
'    '            cmd.Parameters.AddWithValue("@distrik_gereja", "")
'    '            cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
'    '            cmd.Parameters.AddWithValue("@logo_gereja", "")
'    '            cmd.Parameters.AddWithValue("@path", "")
'    '            cmd.Parameters.AddWithValue("@wallpaper_gereja", "")
'    '            cmd.Parameters.AddWithValue("@path_wallpaper", "")
'    '            cmd.Parameters.AddWithValue("@deskripsi", "")
'    '            cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
'    '            Using sda As New SqlDataAdapter()
'    '                cmd.CommandType = CommandType.StoredProcedure
'    '                cmd.Connection = con
'    '                sda.SelectCommand = cmd
'    '                Using dt As New DataTable()
'    '                    sda.Fill(dt)
'    '                    gvImages.DataSource = dt
'    '                    gvImages.DataBind()
'    '                End Using
'    '            End Using
'    '        End Using
'    '    End Using
'    'End Sub

'    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
'        profil_gereja.EditIndex = e.NewEditIndex
'        Me.BindGrid()
'    End Sub

'    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
'        profil_gereja.EditIndex = -1
'        Me.BindGrid()
'    End Sub

'    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
'        Dim row As GridViewRow = profil_gereja.Rows(e.RowIndex)
'        Dim id_gereja As Integer = Convert.ToInt32(profil_gereja.DataKeys(e.RowIndex).Values(0))
'        Dim nama_gereja As String = TryCast(row.FindControl("txtNama"), TextBox).Text
'        Dim alamat_gereja As String = TryCast(row.FindControl("txtAlamat"), TextBox).Text
'        Dim distrik_gereja As String = TryCast(row.FindControl("txtDistrik"), TextBox).Text
'        Dim no_telepon_gereja As String = TryCast(row.FindControl("txtTelepon"), TextBox).Text
'        Dim deskripsi As String = TryCast(row.FindControl("txtdeskripsi"), TextBox).Text
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Konfigurasi")
'                cmd.CommandType = CommandType.StoredProcedure
'                cmd.Parameters.AddWithValue("@Action", "UPDATE")
'                cmd.Parameters.AddWithValue("@id_gereja", id_gereja)
'                cmd.Parameters.AddWithValue("@nama_gereja", nama_gereja)
'                cmd.Parameters.AddWithValue("@alamat_gereja", alamat_gereja)
'                cmd.Parameters.AddWithValue("@distrik_gereja", distrik_gereja)
'                cmd.Parameters.AddWithValue("@no_telepon_gereja", no_telepon_gereja)
'                cmd.Parameters.AddWithValue("@logo_gereja", "")
'                cmd.Parameters.AddWithValue("@path ", "")
'                cmd.Parameters.AddWithValue("@wallpaper_gereja", "")
'                cmd.Parameters.AddWithValue("@path_wallpaper", "")
'                cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
'                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
'                cmd.Connection = con
'                con.Open()
'                cmd.ExecuteNonQuery()
'                con.Close()
'            End Using
'        End Using
'        profil_gereja.EditIndex = -1
'        Me.BindGrid()
'    End Sub

'    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
'        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> profil_gereja.EditIndex Then
'            TryCast(e.Row.Cells(6).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Do you want to delete this row?');"
'        End If
'    End Sub

'    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
'        Dim id_gereja As Integer = Convert.ToInt32(profil_gereja.DataKeys(e.RowIndex).Values(0))
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Konfigurasi")
'                cmd.CommandType = CommandType.StoredProcedure
'                cmd.Parameters.AddWithValue("@Action", "DELETE")
'                cmd.Parameters.AddWithValue("@id_gereja", id_gereja)
'                cmd.Parameters.AddWithValue("@nama_gereja", "")
'                cmd.Parameters.AddWithValue("@alamat_gereja", "")
'                cmd.Parameters.AddWithValue("@distrik_gereja", "")
'                cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
'                cmd.Parameters.AddWithValue("@logo_gereja", "")
'                cmd.Parameters.AddWithValue("@path ", "")
'                cmd.Parameters.AddWithValue("@wallpaper_gereja", "")
'                cmd.Parameters.AddWithValue("@path_wallpaper", "")
'                cmd.Parameters.AddWithValue("@deskripsi", "")
'                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
'                cmd.Connection = con
'                con.Open()
'                cmd.ExecuteNonQuery()
'                con.Close()
'            End Using
'        End Using
'        Me.BindGrid()
'    End Sub
'End Class
