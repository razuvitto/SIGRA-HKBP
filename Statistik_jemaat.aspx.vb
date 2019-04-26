Imports System.Data
Imports System.Data.SqlClient
Partial Class Statistik_jemaat
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Me.BindGrid()
            Me.BindGrid2()
            Me.BindGrid3()
            Me.BindGrid4()
            Me.BindGrid5()
            Me.BindGrid6()
        End If
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jemaat_SP")
                cmd.Parameters.AddWithValue("@Action", "Jumlah_jemaat")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        gvtotal.DataSource = dt
                        gvtotal.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid2()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jemaat_SP")
                cmd.Parameters.AddWithValue("@Action", "Jumlah_jemaat_laki")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        gvlaki.DataSource = dt
                        gvlaki.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid3()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jemaat_SP")
                cmd.Parameters.AddWithValue("@Action", "Jumlah_jemaat_perempuan")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        gvperempuan.DataSource = dt
                        gvperempuan.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid4()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jemaat_SP")
                cmd.Parameters.AddWithValue("@Action", "Jumlah_jemaat_PDGL")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        PDGL.DataSource = dt
                        PDGL.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid5()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jemaat_SP")
                cmd.Parameters.AddWithValue("@Action", "Jumlah_jemaat_PDGHL")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        PDGHL.DataSource = dt
                        PDGHL.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub BindGrid6()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jemaat_SP")
                cmd.Parameters.AddWithValue("@Action", "Jumlah_jemaat_JGHSA")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        JGHSA.DataSource = dt
                        JGHSA.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class