<%@ Page Title="Pengumuman" Language="VB" MasterPageFile="~/Menu_Bendahara/Site_Bendahara.master" AutoEventWireup="true" CodeFile="~/Menu_Bendahara/Pengumuman.aspx.vb" Inherits="Pengumuman" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h2 style = "font-size:20px" >PENGUMUMAN</h2>
    <br /> 
    <asp:Button ID="Buat_pengumuman" runat="server" Text="Buat Pengumuman" PostBackUrl="~/Menu_Bendahara/Buat_pengumuman.aspx" class="btn btn-primary"/>
    <div class="jumbotron" style="font-size:medium">
        <br /> 
    <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Pengumuman" CssClass="form-prime"></asp:TextBox>
    <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
    <br />
        <asp:GridView ID="all_pengumuman" runat="server" AutoGenerateColumns="false" DataKeyNames="id_pengumuman" BorderColor="Transparent" EmptyDataText="Data Belum Ditambahkan">
                <Columns>       
                        <asp:HyperLinkField DataTextField="Judul_pengumuman" DataNavigateUrlFields="Id_pengumuman" DataNavigateUrlFormatString="~/Menu_Bendahara/Detail_pengumuman.aspx?Id{0}" HeaderText="Judul" ItemStyle-Width = "650" HeaderStyle-BackColor="Transparent"/>            
                    <asp:BoundField DataField="waktu_unggah" HeaderText="Waktu Publish" ItemStyle-Width = "200" HeaderStyle-BackColor="Transparent"/>
                </Columns>
            <PagerStyle BorderStyle="None" />
        </asp:GridView>
        </div>  
    <br />
</asp:Content>
