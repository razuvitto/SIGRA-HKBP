Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.DataVisualization.Charting
Partial Public Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            GetEmployeeChartInfo()
        End If
    End Sub

    Private Sub GetEmployeeChartInfo()
        Dim dt As DataTable = New DataTable()

        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-12VHOFI;Integrated Security=true;Initial Catalog=Sigra_DB")
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT bulan as Name, total AS Total  FROM keuangan_per_bulan", con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(dt)
            con.Close()
        End Using

        Dim x As String() = New String(dt.Rows.Count - 1) {}
        Dim y As Integer() = New Integer(dt.Rows.Count - 1) {}

        For i As Integer = 0 To dt.Rows.Count - 1
            x(i) = dt.Rows(i)(0).ToString()
            y(i) = Convert.ToInt32(dt.Rows(i)(1))
        Next

        EmployeeChartInfo.Series(0).Points.DataBindXY(x, y)
        EmployeeChartInfo.Series(0).ChartType = SeriesChartType.Pie
        EmployeeChartInfo.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        EmployeeChartInfo.Legends(0).Enabled = True
    End Sub
End Class
