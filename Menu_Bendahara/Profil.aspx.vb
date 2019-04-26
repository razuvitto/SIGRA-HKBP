Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class profil
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
            Me.BindGrid2()
        End If
    End Sub

    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("akun_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT_Profil")
                cmd.Parameters.AddWithValue("@id_akun", Session("id_akun"))
                cmd.Parameters.AddWithValue("@username", "")
                cmd.Parameters.AddWithValue("@password", "")
                cmd.Parameters.AddWithValue("@email", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        akun.DataSource = dt
                        akun.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid2()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("akun_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT_Profil")
                cmd.Parameters.AddWithValue("@id_akun", Session("id_akun"))
                cmd.Parameters.AddWithValue("@username", "")
                cmd.Parameters.AddWithValue("@password", "")
                cmd.Parameters.AddWithValue("@email", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        gv_username.DataSource = dt
                        gv_username.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        akun.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        akun.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = akun.Rows(e.RowIndex)
        Dim id_akun As Integer = Convert.ToInt32(akun.DataKeys(e.RowIndex).Values(0))
        Dim email As String = TryCast(row.FindControl("txtemail"), TextBox).Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Akun_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "UPDATE_EMAIL_AKUN")
                cmd.Parameters.AddWithValue("@id_akun", id_akun)
                cmd.Parameters.AddWithValue("@username", "")
                cmd.Parameters.AddWithValue("@password", "")
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        akun.EditIndex = -1
        Me.BindGrid()
    End Sub
End Class
