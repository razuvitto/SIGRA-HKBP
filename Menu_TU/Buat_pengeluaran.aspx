<%@ Page Title="Tambah Data Pengeluaran" EnableEventValidation="false" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Buat_pengeluaran.aspx.vb" Inherits="Buat_pengeluaran" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/WebForms/calendar1.js" type="text/javascript"></script>
    <script src="Scripts/WebForms/calendar2.js" type="text/javascript"></script>
    <link href="Content/bootstrapCalendar.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txttanggal]").datepicker({
                showOn: "focus"
            });
        });
    </script>
    <asp:GridView ID="pengeluaran" runat="server" AutoGenerateColumns="false" DataKeyNames="id_transaksi">
    </asp:GridView>


    <h2><%: Title %></h2>
    <div Class="row">
        <div Class="jumbotron" style="width:700px">
            <table style="border:none">
                <tr>
            <td>
                <asp:Label ID="lblnama" runat="server" Text="Nama Transaksi" Width="220px"></asp:Label>
            </td>     
                    <td>
                        <asp:Label ID="Label1" runat="server" Text=":" Width="50px"></asp:Label>
                    </td>
            <td>
                <asp:TextBox ID="txtnama" runat="server" CssClass="form-control"  Width="700px"></asp:TextBox>
            </td>
                    </tr>
                     <tr>
            <td>
                <asp:Label ID="lbltanggal" runat="server" Text="Tanggal Transaksi" Width="220px"></asp:Label>
                
            </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text=":" Width="50px"></asp:Label>
                    </td>
            <td>
                <asp:TextBox ID="txttanggal" runat="server" CssClass="form-control" Width="700px"></asp:TextBox>
            </td>
                    </tr>
                <tr>
            <td>
                <asp:Label ID="lbljumlah" runat="server" Text="Jumlah" Width="220px"></asp:Label>
                
            </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text=":" Width="50px"></asp:Label>
                    </td>
            <td>
                <asp:TextBox ID="txtjumlah" runat="server" CssClass="form-control" Width="700px"></asp:TextBox>
            </td>
                    </tr>
             
                <tr>
                    
                    <td>
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Simpan"/>  
                        </td>
                    <td>

                    </td>
                    </tr>  
            </table>    
        </div>   
    </div>
</asp:Content>
