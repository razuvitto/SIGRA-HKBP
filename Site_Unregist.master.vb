Imports System.Collections.Generic
Imports System.Security.Claims
Imports System.Security.Principal
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Public Class SiteMaster
    Inherits MasterPage
    Private Const AntiXsrfTokenKey As String = "__AntiXsrfToken"
    Private Const AntiXsrfUserNameKey As String = "__AntiXsrfUserName"
    Private _antiXsrfTokenValue As String
    Protected Sub Page_Init(sender As Object, e As EventArgs)
        ' The code below helps to protect against XSRF attacks
        Dim requestCookie = Request.Cookies(AntiXsrfTokenKey)
        Dim requestCookieGuidValue As Guid
        If requestCookie IsNot Nothing AndAlso Guid.TryParse(requestCookie.Value, requestCookieGuidValue) Then
            ' Use the Anti-XSRF token from the cookie
            _antiXsrfTokenValue = requestCookie.Value
            Page.ViewStateUserKey = _antiXsrfTokenValue
        Else
            ' Generate a new Anti-XSRF token and save to the cookie
            _antiXsrfTokenValue = Guid.NewGuid().ToString("N")
            Page.ViewStateUserKey = _antiXsrfTokenValue

            Dim responseCookie = New HttpCookie(AntiXsrfTokenKey) With {
                .HttpOnly = True,
                .Value = _antiXsrfTokenValue
            }
            If FormsAuthentication.RequireSSL AndAlso Request.IsSecureConnection Then
                responseCookie.Secure = True
            End If
            Response.Cookies.[Set](responseCookie)
        End If

        AddHandler Page.PreLoad, AddressOf master_Page_PreLoad
    End Sub

    Protected Sub master_Page_PreLoad(sender As Object, e As EventArgs)
        If Not Me.IsPostBack Then
            'Me.BindGrid1()
            Me.BindGrid2()
            Me.BindGrid3()
        End If
        If Not IsPostBack Then
            ' Set Anti-XSRF token
            ViewState(AntiXsrfTokenKey) = Page.ViewStateUserKey
            ViewState(AntiXsrfUserNameKey) = If(Context.User.Identity.Name, [String].Empty)
        Else
            ' Validate the Anti-XSRF token
            If DirectCast(ViewState(AntiXsrfTokenKey), String) <> _antiXsrfTokenValue OrElse DirectCast(ViewState(AntiXsrfUserNameKey), String) <> (If(Context.User.Identity.Name, [String].Empty)) Then
                Throw New InvalidOperationException("Validation of Anti-XSRF token failed.")
            End If
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Unnamed_LoggingOut(sender As Object, e As LoginCancelEventArgs)
        Context.GetOwinContext().Authentication.SignOut()
    End Sub
    '---------------------------- GridView Logo Gereja ----------------------------
    'Private Sub BindGrid1()
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("Konfigurasi")
    '            cmd.Parameters.AddWithValue("@Action", "SELECT")
    '            cmd.Parameters.AddWithValue("@id_gereja", "")
    '            cmd.Parameters.AddWithValue("@nama_gereja", "")
    '            cmd.Parameters.AddWithValue("@alamat_gereja", "")
    '            cmd.Parameters.AddWithValue("@distrik_gereja", "")
    '            cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
    '            cmd.Parameters.AddWithValue("@logo_gereja", "")
    '            cmd.Parameters.AddWithValue("@path", "")
    '            cmd.Parameters.AddWithValue("@wallpaper_gereja", "")
    '            cmd.Parameters.AddWithValue("@path_wallpaper", "")
    '            cmd.Parameters.AddWithValue("@deskripsi", "")
    '            cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
    '            Using sda As New SqlDataAdapter()
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dt As New DataTable()
    '                    sda.Fill(dt)
    '                    gv1.DataSource = dt
    '                    gv1.DataBind()
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    '---------------------------- GridView Nama Gereja ----------------------------
    Private Sub BindGrid2()
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
                        gvtentang.DataSource = dt
                        gvtentang.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid3()
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
                        gvbrand.DataSource = dt
                        gvbrand.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    '---------------------------- GridView Alamat Gereja ----------------------------
    'Private Sub BindGrid3()
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("Konfigurasi")
    '            cmd.Parameters.AddWithValue("@Action", "SELECT")
    '            cmd.Parameters.AddWithValue("@id_gereja", "")
    '            cmd.Parameters.AddWithValue("@nama_gereja", "")
    '            cmd.Parameters.AddWithValue("@alamat_gereja", "")
    '            cmd.Parameters.AddWithValue("@distrik_gereja", "")
    '            cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
    '            cmd.Parameters.AddWithValue("@logo_gereja", "")
    '            cmd.Parameters.AddWithValue("@path", "")
    '            Using sda As New SqlDataAdapter()
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dt As New DataTable()
    '                    sda.Fill(dt)
    '                    gv3.DataSource = dt
    '                    gv3.DataBind()
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Sub
End Class
