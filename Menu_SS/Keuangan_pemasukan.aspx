﻿<%@ Page Title="Data Pemasukan" Language="VB" MasterPageFile="~/Menu_SS/Site_SS.master" AutoEventWireup="true" CodeFile="~/Menu_SS/Keuangan_pemasukan.aspx.vb" Inherits="Keuangan_pemasukan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
    <div class="jumbotron" style="font-size:medium">
        <br />
            <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Transaksi" CssClass="form-prime"></asp:TextBox>
            <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
        <br />
        <br />
    <asp:GridView ID="pemasukan" runat="server" AutoGenerateColumns="true" BorderColor="Transparent" EmptyDataText="Data Belum Ditambahkan" Width="1050px">
    </asp:GridView>
        </div>
</div>
        <br />
        
</asp:Content>
