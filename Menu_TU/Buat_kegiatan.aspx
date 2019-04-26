<%@ Page Title="Buat Kegiatan" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_TU/Site_TU.master" AutoEventWireup="true" CodeFile="~/Menu_TU/Buat_kegiatan.aspx.vb" Inherits="Buat_kegiatan" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <asp:GridView ID="kegiatan" runat="server" AutoGenerateColumns="false" DataKeyNames="id_kegiatan"
        OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting">
    </asp:GridView>

    <div Class="row">
        <div Class="jumbotron">
            <p>
                <asp:Label ID="lbljudul" runat="server" Text="Judul"></asp:Label>
            </p>     
            <p>
                <asp:TextBox ID="txtjudul" runat="server" CssClass="form-control"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lbldeskripsi" runat="server" Text="Deskripsi"></asp:Label>
                
            </p>
            <p>                
                <CKEditor:CKEditorControl ID="txtdeskripsi" BasePath="/ckeditor/" runat="server">
                </CKEditor:CKEditorControl>   
            </p> 
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Publish"/>        
        </div>   
    </div>
</asp:Content>
