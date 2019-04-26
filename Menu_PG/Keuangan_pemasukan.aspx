<%@ Page Title="Data Pemasukan" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Keuangan_pemasukan.aspx.vb" Inherits="Keuangan_pemasukan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
        <br />
    <br />
        <br />
    <asp:GridView Width="1100px" ID="pemasukan" runat="server" DataKeyNames="id_transaksi" BorderColor="Tan" EmptyDataText="Data Belum Ditambahkan" BackColor="LightGoldenrodYellow" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    
</div>
        <br />
        
</asp:Content>
