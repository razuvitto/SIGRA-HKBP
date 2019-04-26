<%@ Page Title="Kegiatan" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Kegiatan.aspx.vb" Inherits="Kegiatan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h2 style = "font-size:20px" >KEGIATAN</h2>
    <div class="jumbotron" style="font-size:medium">  
        <br /> 
    <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Kegiatan" CssClass="form-prime"></asp:TextBox>
    <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
    <br />
        <asp:GridView ID="all_kegiatan" runat="server" AutoGenerateColumns="false" DataKeyNames="id_Kegiatan" BorderColor="Transparent"  EmptyDataText="Data Belum Ditambahkan">
                <Columns>       
                    <%--<asp:BoundField DataField="id_pengumuman" HeaderText="ID" ItemStyle-Width = "60" />--%>
                        <asp:HyperLinkField DataTextField="Judul" DataNavigateUrlFields="Id_kegiatan" DataNavigateUrlFormatString="~/Menu_PG/Detail_kegiatan.aspx?Id{0}" HeaderText="Judul" ItemStyle-Width = "650" HeaderStyle-BackColor="Transparent"/>            
                    <asp:BoundField DataField="waktu_unggah" HeaderText="Waktu Publish" ItemStyle-Width = "200" HeaderStyle-BackColor="Transparent" />
                </Columns>
            <PagerStyle BorderStyle="None" />
        </asp:GridView>
        </div>
</asp:Content>
