<%@ Page Title="Jadwal Ibadah" Language="VB" MasterPageFile="Site_Unregist.master" AutoEventWireup="true" CodeFile="Jadwal_ibadah.aspx.vb" Inherits="jadwal_ibadah" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2 style = "font-size:20px" >JADWAL IBADAH</h2> 
    <div class="jumbotron" style="font-size:medium">
        <br />   
    <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Jadwal Ibadah" CssClass="form-prime"></asp:TextBox>
    <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
    <br />
        <br />
    <asp:GridView ID="jadwal" runat="server" AutoGenerateColumns="false" DataKeyNames="id_jadwal" BorderColor="Transparent" EmptyDataText="Data Belum Ditambahkan">
        <Columns>
            <asp:TemplateField HeaderText="Nama Ibadah" ItemStyle-Width="450" HeaderStyle-BackColor="transparent">
                <ItemTemplate>
                    <asp:Label ID="lblNama" runat="server" Text='<%# Eval("nama_ibadah") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Deskripsi" ItemStyle-Width="600" HeaderStyle-BackColor="transparent">
                <ItemTemplate>
                    <asp:Label ID="lblDeskripsi" runat="server" Text='<%# Eval("deskripsi") %>'></asp:Label>
                </ItemTemplate>        
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Waktu Unggah" ItemStyle-Width="600" HeaderStyle-BackColor="transparent">
                <ItemTemplate>
                    <asp:Label ID="lblwaktu" runat="server" Text='<%# Eval("waktu_unggah_jadwal") %>'></asp:Label>
                </ItemTemplate>        
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</div>
         <br />
       
    
</asp:Content>



