<%@ Page Title="Jadwal Ibadah" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="jadwal_ibadah.aspx.vb" Inherits="jadwal_ibadah" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2 style = "font-size:20px" >JADWAL IBADAH</h2> 
        <br />
     <asp:Button ID="tambah_jadwal" runat="server" Text="Tambah Jadwal" PostBackUrl="~/Buat_jadwal_ibadah.aspx" class="btn btn-primary"/>
    <br />
    <br />
    <div class="jumbotron" style="font-size:medium">
    <asp:GridView ID="jadwal" runat="server" AutoGenerateColumns="false" DataKeyNames="id_jadwal" BorderColor="Transparent"
                OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="Data Belum Ditambahkan">
        <Columns>
            <asp:TemplateField HeaderText="Nama Ibadah" ItemStyle-Width="450" HeaderStyle-BackColor="transparent">
                <ItemTemplate>
                    <asp:Label ID="lblNama" runat="server" Text='<%# Eval("nama_ibadah") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtNama" runat="server" Text='<%# Eval("nama_ibadah") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Deskripsi" ItemStyle-Width="600" HeaderStyle-BackColor="transparent">
                <ItemTemplate>
                    <asp:Label ID="lblDeskripsi" runat="server" Text='<%# Eval("deskripsi") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDeskripsi" runat="server" Text='<%# Eval("deskripsi") %>'></asp:TextBox>
                </EditItemTemplate>            
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" HeaderStyle-BackColor="transparent" ShowEditButton="true" ShowDeleteButton="true" HeaderText="Aksi" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
        </div>
</div>
         <br />
       
    
</asp:Content>



