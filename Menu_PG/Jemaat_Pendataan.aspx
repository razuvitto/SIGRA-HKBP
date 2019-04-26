<%@ Page Title="Tambah Data Jemaat Baru" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Jemaat_Pendataan.aspx.vb" Inherits="Jemaat_Pendataan" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
    function ShowHideDiv() {
        var chkYes = document.getElementById("<%=chkYes.ClientID %>");
        var chkYes1 = document.getElementById("<%=chkYes1.ClientID %>");
        var chkYes2 = document.getElementById("<%=chkYes2.ClientID %>");
        var dvPassport = document.getElementById("dvPassport");
        dvPassport.style.display = chkYes.checked ? "block" : "none";
        var dvPassport1 = document.getElementById("dvPassport1");
        dvPassport1.style.display = chkYes1.checked ? "block" : "none";
        var dvPassport2 = document.getElementById("dvPassport2");
        dvPassport2.style.display = chkYes2.checked ? "block" : "none";
    }
</script>
      <script src="Scripts/WebForms/calendar1.js" type="text/javascript"></script>
    <script src="Scripts/WebForms/calendar2.js" type="text/javascript"></script>
    <link href="Content/bootstrapCalendar.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txtDatePria]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDateWanita]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDatePerkawinan]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDateMeninggalPria]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDateMeninggalWanita]").datepicker({
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
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label5" runat="server" Text="Wijk" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:DropDownList ID="DDWijk" runat="server" Font-Size="Medium" DataSourceID="SqlDataSource1" DataTextField="nama_sektor" DataValueField="nama_sektor" CssClass="form-control">
                        </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" SelectCommand="SELECT [id_sektor], [nama_sektor] FROM [sektor]"></asp:SqlDataSource>
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
            </tr>
        </table >
<br />


<%----------------------------    SUAMI     ----------------------------%>
        <table style="border:none">
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="KEPALA KELUARGA" Width="300px" Font-Underline="true"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label8" runat="server" Text="Nama Lengkap" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtNamapria" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label9" runat="server" Text="Tanggal Lahir" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtDatePria" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label10" runat="server" Text="Tempat Lahir" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtTempatLahirPria" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label29" runat="server" Text="Jenis Kelamin" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:DropDownList ID="DDKelamin1" runat="server" Font-Size="Medium" Width="300px" CssClass="form-control">
                            <asp:ListItem>Perempuan</asp:ListItem>
                            <asp:ListItem>Laki-laki</asp:ListItem>                           
                        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="Label26" runat="server" Text="Nomor Telepon" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtTelpPria" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
            </tr>
                        <tr>
                <td>
                        <asp:Label ID="Label11" runat="server" Text="Pekerjaan" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:TextBox ID="txtPekerjaanPria" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                    <td>
                                <asp:Label ID="Label22" runat="server" Text="Alamat" Width="300px"></asp:Label>
                    </td>
                    <td>
                                <asp:TextBox ID="txtAlamatPria" runat="server" CssClass="form-control" Width="300px" height="80px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>  
            <tr>
                <td>
                </td>
                <td>
                        <asp:CheckBox ID="chkYes1" GroupName="Passport1" Text="Meninggal Dunia" runat="server" onclick="ShowHideDiv()" Font-Size="Small" Font-Italic="true" />  
                </td>
                
            </tr>
            <%--<tr>
                <td>         
                </td>
                <td>                      
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Meninggal Dunia" Font-Size="Small" /> 
                </td>
            </tr>--%>

            </table>
            <div  id="dvPassport1" style="display: none; border:none">
            <table  style="border:none">
                <tr>
                    <td>
                            <asp:Label ID="Label27" runat="server" Text="Tanggal Meninggal" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtDateMeninggalPria" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
        </div>


            <tr>
                <td>
                        <asp:CheckBox ID="chkYes" GroupName="Passport" Text="Jemaat Berkeluarga" runat="server" onclick="ShowHideDiv()" Font-Size="Medium" />  
                </td>
                <td>
                </td>
            </tr>
        </div>

<%------------------------------------------------------------------------------------------------------------------------------------------------------------%>

        <div  id="dvPassport" style="display: none; border:none">
        <hr style="width:100%"/>
            <table  style="border:none">
             <%--------------    ISTRI     --------------%>
                <tr>
                    <td>
                            <asp:Label ID="Label12" runat="server" Text="ISTRI" Font-Underline="true" Width="300px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label13" runat="server" Text="Nama Lengkap" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtNamaWanita" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label14" runat="server" Text="Tanggal Lahir" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtDateWanita" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label15" runat="server" Text="Tempat Lahir" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtTempatLahirWanita" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                <td>
                        <asp:Label ID="Label4" runat="server" Text="Jenis Kelamin" Width="300px"></asp:Label>
                </td>
                <td>
                        <asp:DropDownList ID="DDKelamin2" runat="server" Font-Size="Medium" Width="300px" CssClass="form-control">
                            <asp:ListItem>Laki-laki</asp:ListItem>
                            <asp:ListItem>Perempuan</asp:ListItem>
                        </asp:DropDownList>
                </td>
            </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label25" runat="server" Text="Nomor Telepon" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtTelpWanita" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label16" runat="server" Text="Pekerjaan" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtPekerjaanWanita" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                                <asp:Label ID="Label21" runat="server" Text="Alamat" Width="300px"></asp:Label>
                    </td>
                    <td>
                                <asp:TextBox ID="txtAlamatWanita" runat="server" CssClass="form-control" Width="300px" height="80px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr> 
                <tr>
                <td>
                </td>
                  
                <td>
                        <asp:CheckBox ID="chkYes2" GroupName="Passport1" Text="Meninggal Dunia" runat="server" onclick="ShowHideDiv()" Font-Size="Small" Font-Italic="true" />  
                </td>
                
            </tr>
               
            </table>
              <div  id="dvPassport2" style="display: none; border:none">
            <table  style="border:none">
                <tr>
                    <td>
                            <asp:Label ID="Label28" runat="server" Text="Tanggal Meninggal" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtDateMeninggalWanita" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
        </div>
            <br />

<%----------------------------    DATA PERKAWINAN     ----------------------------%>
            <table style="border:none">
             
                <tr>
                    <td>
                            <asp:Label ID="Label17" runat="server" Text="DATA PERKAWINAN" Font-Underline="true" Width="300px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label18" runat="server" Text="Tanggal Perkawinan" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtDatePerkawinan" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label19" runat="server" Text="Nama Gereja Pemberkatan" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtPemberkatan" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                            <asp:Label ID="Label20" runat="server" Text="Pendeta Yang Melayani" Width="300px"></asp:Label>
                    </td>
                    <td>
                            <asp:TextBox ID="txtPendeta" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />

<%----------------------------    TEMPAT TINGGAL     ----------------------------%>
           <%-- <table style="border:none">
                <tr>
                    <td>
                            <asp:Label ID="Label21" runat="server" Text="TEMPAT TINGGAL" Font-Underline="true" Width="300px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                                <asp:Label ID="Label22" runat="server" Text="Alamat" Width="300px"></asp:Label>
                    </td>
                    <td>
                                <asp:TextBox ID="txtAlamat" runat="server" CssClass="form-control" Width="300px" height="80px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>            
            </table>--%>
        </div>
        <br />
 <%-----------------------------------------------------------------------------------------------------------------------------------------------------------%>          
        <div style="align-content:center; align-items:center">
            <asp:Button ID="Btncancel" runat="server" CssClass="btn btn-primary" Text="Kembali" OnClick="Insert"/>   
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Simpan" OnClick="Insert"/>
        </div>
    </div>   
</div>
</asp:Content>
