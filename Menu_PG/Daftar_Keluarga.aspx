<%@ Page Title="Pendaftaran Keluarga" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Daftar_Keluarga.aspx.vb" Inherits="Daftar_Keluarga" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
    function ShowHideDiv() {
        <%--var chkYes = document.getElementById("<%=chkYes.ClientID %>");--%>
<%--        var chkYes1 = document.getElementById("<%=chkYes1.ClientID %>");--%>
        //var dvPassport = document.getElementById("dvPassport");
        //dvPassport.style.display = chkYes.checked ? "block" : "none";
        //var dvPassport1 = document.getElementById("dvPassport1");
        //dvPassport1.style.display = chkYes1.checked ? "block" : "none";
    }
</script>
      <script src="../Scripts/WebForms/calendar1.js" type="text/javascript"></script>
    <script src="../Scripts/WebForms/calendar2.js" type="text/javascript"></script>
    <link href="../Content/bootstrapCalendar.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txtDate]").datepicker({
                showOn: "focus"
            });
        });
    </script>
    <br />
    <h2><%: Title %></h2>
    <asp:GridView ID="pendataan_jemaat" runat="server" AutoGenerateColumns="false" DataKeyNames="id_jemaat">
    </asp:GridView>

<div Class="row">
    <div Class="jumbotron">
        <div>
        <table style="border:none">
            <tr>
                <td>
                        <asp:Label ID="Label3" runat="server" Text="INFORMASI REGISTRASI" Width="300px" Font-Underline="true"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label2" runat="server" Text="Nomor Registrasi" Width="300px"></asp:Label>
                    </td>
                <td>
                        <asp:TextBox ID="txtnoreg" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                 <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnoreg"
                                CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" />
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label5" runat="server" Text="Wijk" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:DropDownList ID="DDWijk" runat="server" Font-Size="Medium" DataSourceID="SqlDataSource1" DataTextField="nama_sektor" DataValueField="id_sektor" CssClass="form-control">
                        </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" SelectCommand="SELECT * FROM [sektor]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label6" runat="server" Text="Jenis Registrasi" Width="300px"></asp:Label>
                </td>
                <td>
                    
                        <asp:DropDownList ID="DDJenis_Registrasi" runat="server" Font-Size="Medium" Width="300px" CssClass="form-control">
                            <asp:ListItem>Jemaat Gereja HKBP (Sejak Awal)</asp:ListItem>
                            <asp:ListItem>Pindahan dari Gereja HKBP Lain</asp:ListItem>
                            <asp:ListItem>Pindahan dari Gereja Lain</asp:ListItem>
                            <asp:ListItem>Pindahan dari Non Gereja Lain</asp:ListItem>
                        </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label1" runat="server" Text="Asal" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox  ID="txtAsal" runat="server" CssClass="form-control" Width="300px" ></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtasal"
                                CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" />
                </td>
            </tr>
            <%--<tr>
                <td>
                </td>
                <td>
                        <asp:CheckBox ID="chkYes" GroupName="Passport" Text=" Jemaat dari Gereja HKBP Lain/ Gereja Lain/ Non-Gereja Lain" runat="server" onclick="ShowHideDiv()" Font-Size="Medium" />  
                </td>
                
            </tr>--%>
            </table>
            
            
            
            <div  id="dvPassport" style="display: none; border:none">
                <table style="border:none">
  
            
            <%--<tr>
                <td>
                        <asp:Label ID="Label6" runat="server" Text="Jenis Registrasi" Width="300px"></asp:Label>
                </td>
                <td>
                    
                        <asp:DropDownList ID="DDJenis_Registrasi" runat="server" Font-Size="Medium" Width="300px" CssClass="form-control">
                            <asp:ListItem>Jemaat Gereja HKBP (Sejak Awal)</asp:ListItem>
                            <asp:ListItem>Pindahan dari Gereja HKBP Lain</asp:ListItem>
                            <asp:ListItem>Pindahan dari Gereja Lain</asp:ListItem>
                            <asp:ListItem>Pindahan dari Non Gereja Lain</asp:ListItem>
                        </asp:DropDownList>

                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label1" runat="server" Text="Asal" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox  ID="txtAsal" runat="server" CssClass="form-control" Width="300px" ></asp:TextBox>
                </td>
            </tr>--%>
        </table>
            </div>
<br />


<%----------------------------    DATA DIRI     ----------------------------%>
        <table style="border:none">
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="INFORMASI DATA DIRI" Width="300px" Font-Underline="true"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label8" runat="server" Text="Nama Lengkap" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtNama" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnama"
                                CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" />
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label9" runat="server" Text="Tanggal Lahir" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdate"
                                CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" />
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label10" runat="server" Text="Tempat Lahir" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtTempatLahir" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txttempatlahir"
                                CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" />
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label29" runat="server" Text="Jenis Kelamin" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:DropDownList ID="DDKelamin" runat="server" Font-Size="Medium" Width="300px" CssClass="form-control">                           
                            <asp:ListItem>Laki-laki</asp:ListItem>  
                            <asp:ListItem>Perempuan</asp:ListItem>                         
                        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label26" runat="server" Text="Nomor Telepon" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtTelp" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
            </tr>
                        <tr>
                <td>
                        <asp:Label ID="Label11" runat="server" Text="Pekerjaan" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtPekerjaan" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                    <td>
                                <asp:Label ID="Label22" runat="server" Text="Alamat" Width="300px"></asp:Label>
                    </td>
                    <td>
                                <asp:TextBox ID="txtAlamat" runat="server" CssClass="form-control" Width="300px" height="80px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtalamat"
                                CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" />
                </td>
                </tr>  
            </table>



            
        </div>

<%------------------------------------------------------------------------------------------------------------------------------------------------------------%>

        
        <br />
 <%-----------------------------------------------------------------------------------------------------------------------------------------------------------%>          
        <div style="align-content:center; align-items:center"> 
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Simpan" OnClick="Insert"/>
        </div>
    </div>   
</div>
</asp:Content>
