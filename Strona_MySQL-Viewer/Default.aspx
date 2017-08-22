<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Strona_MySQL_Viewer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="style.css" media="all">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 144px;
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset class="FsLogin">
            <legend class="LgLogin" align="center" >Zaloguj się!</legend>
            <center>
                <span class="TxtLogin">Host:  </span><br/>
                <asp:TextBox runat="server" ID="FHost" type="text" /><br/>
                <span class="TxtLogin">Login:  </span><br/>
                <asp:TextBox runat="server" id="FLogin" type="text" /><br/>
                <span class="TxtLogin">Hasło:  </span><br/>
                <asp:TextBox runat="server" id="FPassword" type="password" /><br/>
                <span class="TxtLogin">Baza Danych:  </span><br/>
                <asp:TextBox runat="server" id="FDataBase" type="text" /><br />
                <br />
                <asp:Button ID="Button_Zaloguj" runat="server" Text="Zaloguj Się!" OnClick="Button_Zaloguj_Click" />
                <br />
                <br />
                <asp:Label ID="La_Status" runat="server" CssClass="LaStaus"></asp:Label>
                <br/>
            </center>
        </fieldset>
        
    </form>
</body>
</html>
