﻿<%@ Page Title="Tambah Data Jemaat Baru" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_TU/Site_TU.master" AutoEventWireup="true" CodeFile="~/Menu_TU/Jemaat_Tambah_data.aspx.vb" Inherits="Jemaat_Tambah_data" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <script src="../Scripts/WebForms/calendar1.js" type="text/javascript"></script>
    <script src="../Scripts/WebForms/calendar2.js" type="text/javascript"></script>
    <link href="../Content/bootstrapCalendar.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
         function ShowHideDiv() {
        var chkYes = document.getElementById("<%=chkYes.ClientID %>");
        var chkYes1 = document.getElementById("<%=chkYes1.ClientID %>");
        var dvPassport = document.getElementById("dvPassport");
        dvPassport.style.display = chkYes.checked ? "block" : "none";
        var dvPassport1 = document.getElementById("dvPassport1");
        dvPassport1.style.display = chkYes1.checked ? "block" : "none";
    }
        $(function () {
            $("[id$=txtDatelahir]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDatebaptis]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDatesidi]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDatePerkawinan]").datepicker({
                showOn: "focus"
            });
        });
    </script>
    <br />
    <h2><%: Title %></h2>
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
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnoreg" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
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
                        <asp:Label ID="Label1" runat="server" Text="Gereja Asal" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtAsal" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtasal" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
        </table >
<br />


<%----------------------------    DATA DIRI     ----------------------------%>
        <table style="border:none">
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="DATA DIRI" Width="300px" Font-Underline="true"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label8" runat="server" Text="Nama Lengkap" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtNama" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnama" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label9" runat="server" Text="Tanggal Lahir" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtDatelahir" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdatelahir" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label10" runat="server" Text="Tempat Lahir" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtTempatLahir" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txttempatlahir" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label19" runat="server" Text="Status di Keluarga" Width="300px"></asp:Label>
                </td>
             <td>  
                        <asp:DropDownList ID="DDStatus" runat="server" Font-Size="Medium" Width="300px" CssClass="form-control">
                            <asp:ListItem>Kepala Keluarga</asp:ListItem>
                            <asp:ListItem>Istri</asp:ListItem>
                            <asp:ListItem>Anak</asp:ListItem>                   
                        </asp:DropDownList>

                </td>
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="DDStatus" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
                </tr>
            <tr>
                <td>
                        <asp:Label ID="Label29" runat="server" Text="Jenis Kelamin" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:DropDownList ID="DDKelamin1" runat="server" Font-Size="Medium" Width="300px" CssClass="form-control">
                            <asp:ListItem>Laki-laki</asp:ListItem>  
                            <asp:ListItem>Perempuan</asp:ListItem>                       
                        </asp:DropDownList>
                </td>
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="DDkelamin1" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
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
                            <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtpekerjaan" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
            <tr>
                    <td>
                                <asp:Label ID="Label22" runat="server" Text="Alamat" Width="300px"></asp:Label>
                    </td>
                    <td>
                                <asp:TextBox ID="txtAlamat" runat="server" CssClass="form-control" Width="300px" height="80px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtalamat" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
                </tr>  

            </table>
        </div>

        <br />
        <table style="border:none">
        <tr>
            <td>
                <asp:Label ID="Label17" runat="server" Visible="true" Text="" Width="300px"></asp:Label>
            </td>
            <td>
        <asp:CheckBox ID="chkYes" GroupName="Passport" Text="Sudah Baptis" runat="server" onclick="ShowHideDiv()" Font-Size="Medium" /> 
            </td>
        </tr>
            </table>


        <%----------------------------    DATA BAPTIS     ----------------------------%>

        <div  id="dvPassport" style="display: none; border:none">
        <table style="border:none">
             
                <tr>
                    <td>
                            <asp:Label ID="Label4" runat="server" Text="DATA BAPTIS" Font-Underline="true" Width="300px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label12" runat="server" Text="Tanggal Baptis" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtDatebaptis" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label13" runat="server" Text="Nama Gereja Pemberkatan" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txt_namagerejabaptis" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label14" runat="server" Text="Pendeta Yang Melayani" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txt_pendetabaptis" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            </div>
         <br />
        <table style="border:none">
        <tr>
            <td>
                <asp:Label ID="Label18" runat="server" Visible="true" Text="" Width="300px"></asp:Label>
            </td>
            <td>
                        <asp:CheckBox ID="chkyes1" GroupName="Passport" Text="Sudah Sidi" runat="server" onclick="ShowHideDiv()" Font-Size="Medium" />  

            </td>
        </tr>
            </table>
         <%----------------------------    DATA SIDI     ----------------------------%>

        <div  id="dvPassport1" style="display: none; border:none">
        <table style="border:none">
             
                <tr>
                    <td>
                            <asp:Label ID="Label15" runat="server" Text="DATA SIDI" Font-Underline="true" Width="300px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label16" runat="server" Text="Tanggal Sidi" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtDatesidi" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label21" runat="server" Text="Nama Gereja Pemberkatan" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txt_namagerejasidi" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label23" runat="server" Text="Pendeta Yang Melayani" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txt_pendetasidi" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            </div>
        <br />
 <%-----------------------------------------------------------------------------------------------------------------------------------------------------------%>          
        <div style="align-content:center; align-items:center"> 
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Simpan"/>
        </div>
    </div>   
</div>
</asp:Content>
