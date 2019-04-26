<%@ Page Title="Tambah Jadwal Ibadah" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_TU/Site_TU.master" AutoEventWireup="true" CodeFile="~/Menu_TU/Buat_jadwal_ibadah.aspx.vb" Inherits="Buat_jadwal_ibadah" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    

    <div Class="row">

        <div Class="jumbotron">
            <asp:GridView ID="jadwal_ibadah" runat="server" AutoGenerateColumns="false" DataKeyNames="id_jadwal">
        </asp:GridView>
            <p>
                <asp:Label ID="lblnama" runat="server" Text="Nama"></asp:Label>
            </p>     
            <p>
                <asp:TextBox ID="txtnama" runat="server" CssClass="form-control"></asp:TextBox>
            </p> 
            <p>
                <asp:Label ID="lblisi" runat="server" Text="Deskripsi"></asp:Label>
                
            </p>
            <p>                
                <CKEditor:CKEditorControl ID="txtisi" BasePath="/ckeditor/" runat="server">
                </CKEditor:CKEditorControl>   
            </p> 
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Publish"/>        
        </div>   
    </div>
</asp:Content>
