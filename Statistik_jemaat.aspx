<%@ Page Title="Statistik Jemaat" Language="VB" MasterPageFile="Site_Unregist.master" AutoEventWireup="true" CodeFile="Statistik_jemaat.aspx.vb" Inherits="Statistik_jemaat" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div Class="jumbotron" style="width:auto">
           <asp:Label runat="server" Text="Grafik Tahun Lahir Jemaat" Font-Size="X-Large"></asp:Label>
          <br />
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="1050px">
            <Series>
                <asp:Series Name="Series1" ChartType="Bar" XValueMember="Tahun" YValueMembers="Total" IsXValueIndexed="true" IsValueShownAsLabel="true"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" SelectCommand="SELECT * FROM [jemaat_per_tahun]"></asp:SqlDataSource>
      <br />
        <br />
         </div>
      
    <div Class="jumbotron" style="width:auto">
        <table style="border:none">
            <tr>
                <td>
                    <asp:Label ID="lbl1" runat="server" Text="Jumlah Jemaat"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text=":"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                         <asp:GridView ID="gvtotal" runat="server" AutoGenerateColumns="true" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Jumlah Jemaat Laki-laki"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text=":"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                         <asp:GridView ID="gvlaki" runat="server" AutoGenerateColumns="true" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Jumlah Jemaat Perempuan"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text=":"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                         <asp:GridView ID="gvperempuan" runat="server" AutoGenerateColumns="true" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Jumlah Jemaat Pindahan dari Gereja Lain"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text=":"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                         <asp:GridView ID="PDGL" runat="server" AutoGenerateColumns="true" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Jumlah Jemaat Pindahan dari Gereja HKBP Lain"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text=":"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                         <asp:GridView ID="PDGHL" runat="server" AutoGenerateColumns="true" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Jumlah Jemaat Gereja HKBP (Sejak Awal)"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label11" runat="server" Text=":"  Font-Size="Medium"></asp:Label>
                </td>
                <td>
                         <asp:GridView ID="JGHSA" runat="server" AutoGenerateColumns="true" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
