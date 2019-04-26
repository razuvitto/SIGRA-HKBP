<%@ Page Title="Jemaat Sidi" EnableEventValidation="false" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Jemaat_Sidi.aspx.vb" Inherits="Jemaat_Sidi" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
        <br />
            <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Kegiatan" CssClass="form-prime"></asp:TextBox>
            <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
        <br />
        <br />
    <asp:GridView ID="kegiatan" runat="server" AutoGenerateColumns="false" DataKeyNames="id_kegiatan" BorderColor="Transparent"  RowStyle-BackColor="#C3C3C3" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
                OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="Data Belum Ditambahkan">
        <Columns>
            <asp:TemplateField HeaderText="Nama Kegiatan" ItemStyle-Width="450">
                <ItemTemplate>
                    <asp:Label ID="lbljudul" runat="server" Text='<%# Eval("Judul") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtjudul" runat="server" Text='<%# Eval("Judul") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Deskripsi" ItemStyle-Width="600">
                <ItemTemplate>
                    <asp:Label ID="lbldeskripsi" runat="server" Text='<%# Eval("deskripsi") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtdeskripsi" runat="server" Text='<%# Eval("deskripsi") %>'></asp:TextBox>
                </EditItemTemplate>            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Waktu Unggah" ItemStyle-Width="600">
                <ItemTemplate>
                    <asp:Label ID="lblwaktu" runat="server" Text='<%# Eval("waktu_unggah") %>'></asp:Label>
                </ItemTemplate>            
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" HeaderText="Aksi" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
</div>
        <br />
        <asp:Button ID="buat_kegiatan" runat="server" Text="Tambah Jadwal" PostBackUrl="~/Buat_kegiatan.aspx" class="btn btn-primary"/>
</asp:Content>
