<%@ Page Title="Data Pengeluaran" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Keuangan_pengeluaran.aspx.vb" Inherits="Keuangan_pengeluaran" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
        <br />
    <asp:Button ID="tambah_pengeluaran" runat="server" Text="Tambah Data Pengeluaran" PostBackUrl="~/buat_pengeluaran.aspx" class="btn btn-primary"/>
    <br />
    <div class="jumbotron" style="font-size:medium">
       <div>
            <div class="col-md-4">

            </div>
            <div class="col-md-4">

            </div>
        <div class="col-md-4">
           <center><table style="border:none">
                <tr>
                    <td>
                        <asp:TextBox ID="txtSearch" runat="server" placeholder="Cari Data Pengeluaran" CssClass="form-prime"></asp:TextBox>
                    </td>
                    <td>
                         <asp:Button Text="Cari" runat="server" OnClick="Search" CssClass="btn btn-prime"/>
                    </td>
                </tr>
            
           
                </table>
            </div>
            </div>
        <br />
    <asp:GridView ID="pengeluaran" runat="server" AutoGenerateColumns="false" DataKeyNames="id_transaksi" BorderColor="Transparent"
                OnRowDataBound="OnRowDataBound" OnRowDeleting="OnRowDeleting" EmptyDataText="Data Belum Ditambahkan">
        <Columns>
            <asp:TemplateField HeaderText="Nama Pengeluaran" ItemStyle-Width="600" HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lblnama" runat="server" Text='<%# Eval("nama_transaksi") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Jumlah" ItemStyle-Width="450" HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lbljumlah" runat="server" Text='<%# Eval("jumlah") %>'></asp:Label>
                </ItemTemplate>           
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tanggal Transaksi" ItemStyle-Width="600" HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lblwaktu" runat="server" Text='<%# Eval("tanggal_transaksi") %>'></asp:Label>
                </ItemTemplate>            
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" ShowEditButton="false" ShowDeleteButton="true" HeaderText="Aksi" ItemStyle-Width="150" HeaderStyle-BackColor="Transparent"/>
        </Columns>
    </asp:GridView>
        </div>
</div>
        <br />
        
</asp:Content>
