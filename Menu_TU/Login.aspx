<%@ Page Title="Login" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" Codefile="Login.aspx.vb" Inherits="Login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container, justify" style="margin-top: 30px;">
        <div class="col-sm-4 col-sm-offset-4">
            <div class="panel panel-default">
                <div class="panel-body">
                    <h3><center>Silahkan Login</h3><br />
                    <div>
                        <form>
                                <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
                                <asp:TextBox runat="server" ID="UserName" Placeholder="Username" CssClass="form-control" />
                                
                            </div>
                            <br />
                            <div class="input-group">
                                <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                 <asp:TextBox runat="server" ID="Password" Placeholder="Password" TextMode="Password" CssClass="form-control" />
                                
                            </div>
                            <br/>
                            <div class="form-group">
                                <center><asp:Button ID="buat_kegiatan" runat="server" Text="Masuk" class="btn btn-primary"/>
                            </div>
                            <asp:TextBox ID ="test" runat="server"></asp:TextBox>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
