<%@ Page Title="Tambah Data Pemasukan" EnableEventValidation="false" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Buat_pemasukan.aspx.vb" Inherits="Buat_pemasukan" %>
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
    <h2><%: Title %></h2>

    <asp:GridView ID="pemasukan" runat="server" AutoGenerateColumns="false" DataKeyNames="id_transaksi">
    </asp:GridView>

    <div Class="row">
        <div Class="jumbotron" style="width:600px">
            <table style="border:none">
                <tr>
            <td>
                <asp:Label ID="lblnama" runat="server" Text="Nama Transaksi"></asp:Label>
            </td>     
                    <td>
                        :
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
                <asp:Label ID="lbljumlah" runat="server" Text="Jumlah"></asp:Label>
                
            </td>
                    <td>
                        :
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
