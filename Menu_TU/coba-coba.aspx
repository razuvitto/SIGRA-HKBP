<%@ Page Title="Coba - Coba" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="coba-coba.aspx.vb" Inherits="coba_coba" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="600px">
    <Series>
        <asp:Series Name="Series1" XValueMember="Tahun" YValueMembers="Total" IsValueShownAsLabel="true" ChartType="Bar"></asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
    </ChartAreas>
</asp:Chart>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" SelectCommand="SELECT * FROM [uang_masuk_per_tahun]"></asp:SqlDataSource>
</asp:Content>

