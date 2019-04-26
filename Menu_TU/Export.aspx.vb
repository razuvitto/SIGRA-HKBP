Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Partial Class Export
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.BindGrid()
        End If
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("Sigra_DB").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("view_allpengumuman", con)
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@param1", "view_pengumuman")
                    sda.Fill(dt)
                    all_pengumuman.DataSource = dt
                    all_pengumuman.DataBind()
                End Using
            End Using
        End Using
    End Sub
    Protected Sub OnPageIndexChanging(sender As Object, e As GridViewPageEventArgs)
        all_pengumuman.PageIndex = e.NewPageIndex
        Me.BindGrid()
    End Sub
    Protected Sub ExportToPDF(sender As Object, e As EventArgs)
        Using sw As New StringWriter()
            Using hw As New HtmlTextWriter(sw)
                'To Export all pages
                all_pengumuman.AllowPaging = False
                Me.BindGrid()

                all_pengumuman.RenderControl(hw)
                Dim sr As New StringReader(sw.ToString())
                Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
                Dim htmlparser As New HTMLWorker(pdfDoc)
                PdfWriter.GetInstance(pdfDoc, Response.OutputStream)
                pdfDoc.Open()
                htmlparser.Parse(sr)
                pdfDoc.Close()

                Response.ContentType = "application/pdf"
                Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.pdf")
                Response.Cache.SetCacheability(HttpCacheability.NoCache)
                Response.Write(pdfDoc)
                Response.[End]()
            End Using
        End Using
    End Sub
    Public Overrides Sub VerifyRenderingInServerForm(control As Control)
        ' Verifies that the control is rendered 
    End Sub
End Class