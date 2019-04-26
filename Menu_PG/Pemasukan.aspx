<%@ Page Title="Pemasukan" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Pemasukan.aspx.vb" Inherits="Pemasukan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
    <asp:Button ID="buat_kegiatan" runat="server" Text="Tambah Data Pemasukan" PostBackUrl="~/Buat_kegiatan.aspx" class="btn btn-primary"/>
    <div class="jumbotron" style="font-size:medium">
        <br />
            <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Data Pemasukan" CssClass="form-prime"></asp:TextBox>
            <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
        <br />
        <br />
    <asp:GridView ID="pemasukan" runat="server" AutoGenerateColumns="false" DataKeyNames="id_transaksi" BorderColor="Transparent"
                OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="Data Belum Ditambahkan">
        <Columns>
            <asp:TemplateField HeaderText="Nama Pemasukan" ItemStyle-Width="450"  HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lblnama" runat="server" Text='<%# Eval("nama_transaksi") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtnama" runat="server" Text='<%# Eval("nama_transaksi") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Jumlah" ItemStyle-Width="600"  HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lbljumlah" runat="server" Text='<%# Eval("jumlah") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtjumlah" runat="server" Text='<%# Eval("jumlah") %>'></asp:TextBox>
                </EditItemTemplate>            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Waktu Transaksi" ItemStyle-Width="600"  HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lblwaktu" runat="server" Text='<%# Eval("tanggal_transaksi") %>'></asp:Label>
                </ItemTemplate>            
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" HeaderText="Aksi" ItemStyle-Width="150"  HeaderStyle-BackColor="Transparent"/>
        </Columns>
    </asp:GridView>
        </div>
</div>
</asp:Content>
