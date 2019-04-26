<%@ Page Title="Pencarian Data Jemaat" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_Bendahara/Site_Bendahara.master" AutoEventWireup="true" CodeFile="~/Menu_Bendahara/Pencarian_data_jemaat.aspx.vb" Inherits="pencarian_data_jemaat" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2 style = "font-size:20px" >Pencarian Jemaat</h2> 
    <div class="jumbotron" style="font-size:medium">
        <br />   
    <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Nama Jemaat" CssClass="form-prime"></asp:TextBox>
    <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
    <br />
        <br />
    <asp:GridView ID="jemaat" runat="server" AutoGenerateColumns="true" BorderColor="Transparent" EmptyDataText="Data Belum Ditambahkan" Width="1050px">
    </asp:GridView>
        </div>
</div>
         <br />
       
    
</asp:Content>



