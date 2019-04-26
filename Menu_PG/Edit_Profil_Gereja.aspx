<%@ Page Title="Edit Profil Gereja" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Edit_Profil_Gereja.aspx.vb" Inherits="Edit_Profil_Gereja" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2 style = "font-size:20px" >EDIT PROFIL GEREJA</h2> 
        <br />

    <asp:GridView ID="profil_gereja" runat="server" AutoGenerateColumns="false" DataKeyNames="id_gereja" BorderColor="Transparent"  RowStyle-BackColor="#C3C3C3" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
                OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="Data Belum Ditambahkan">
        <Columns>
            <asp:TemplateField HeaderText="Nama Gereja" ItemStyle-Width="450">
                <ItemTemplate>
                    <asp:Label ID="lblNama" runat="server" Text='<%# Eval("nama_gereja") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtNama" runat="server" Text='<%# Eval("nama_gereja") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Alamat" ItemStyle-Width="600">
                <ItemTemplate>
                    <asp:Label ID="lblAlamat" runat="server" Text='<%# Eval("alamat_gereja") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtAlamat" runat="server" Text='<%# Eval("alamat_gereja") %>'></asp:TextBox>
                </EditItemTemplate>            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Distrik" ItemStyle-Width="600">
                <ItemTemplate>
                    <asp:Label ID="lblDistrik" runat="server" Text='<%# Eval("distrik_gereja") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDistrik" runat="server" Text='<%# Eval("distrik_gereja") %>'></asp:TextBox>
                </EditItemTemplate>            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="No Telepon" ItemStyle-Width="600">
                <ItemTemplate>
                    <asp:Label ID="lblTelepon" runat="server" Text='<%# Eval("no_telepon_gereja") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtTelepon" runat="server" Text='<%# Eval("no_telepon_gereja") %>'></asp:TextBox>
                </EditItemTemplate>            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Deskripsi Gereja" ItemStyle-Width="600">
                <ItemTemplate>
                    <asp:Label ID="lbldeskripsi" runat="server" Text='<%# Eval("deskripsi") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtdeskripsi" runat="server" Text='<%# Eval("deskripsi") %>'></asp:TextBox>
                </EditItemTemplate>            
            </asp:TemplateField>  
            <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" HeaderText="Aksi" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="kembali" runat="server" Text="Kembali" PostBackUrl="~/Menu_PG/tentang.aspx" class="btn btn-primary"/>
    <asp:Button ID="btneditlogo" runat="server" CssClass="btn btn-primary" Text="Edit Logo Gereja" PostBackUrl="~/Menu_PG/Edit_Logo.aspx"/> 
</div>
        <br />
    
</asp:Content>