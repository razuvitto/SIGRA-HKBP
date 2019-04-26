<%@ Page Title="Data Pemasukan" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_Bendahara/Site_Bendahara.master" AutoEventWireup="true" CodeFile="~/Menu_Bendahara/Keuangan_pemasukan.aspx.vb" Inherits="Keuangan_pemasukan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
    <br />
    <asp:Button ID="btnbuat" runat="server" Text="Tambah Pemasukan" CssClass="btn btn-primary" PostBackUrl="~/Menu_Bendahara/Buat_pemasukan.aspx"/>
    <div class="jumbotron" style="font-size:medium">
        
        <br />
         <%--   <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Transaksi" CssClass="form-prime"></asp:TextBox>
            <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>--%>
   <asp:GridView ID="pemasukan" runat="server" AutoGenerateColumns="false" DataKeyNames="id_transaksi" BorderColor="Transparent"
                OnRowDataBound="OnRowDataBound" OnRowDeleting="OnRowDeleting" EmptyDataText="Data Belum Ditambahkan" HeaderStyle-BackColor="Transparent">
        <Columns>
            <asp:TemplateField HeaderText="Tanggal Transaksi" ItemStyle-Width="450">
                <ItemTemplate>
                    <asp:Label ID="lbljudul" runat="server" Text='<%# Eval("tanggal_transaksi") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nama Transaksi" ItemStyle-Width="450">
                <ItemTemplate>
                    <asp:Label ID="lbljudul" runat="server" Text='<%# Eval("nama_transaksi") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Jumlah" ItemStyle-Width="450">
                <ItemTemplate>
                    <asp:Label ID="lbljudul" runat="server" Text='<%# Eval("debit") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>        
            <asp:CommandField ButtonType="Link" ShowDeleteButton="true" HeaderText="Aksi" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
        </div>
</div>
        <br />
        
</asp:Content>
