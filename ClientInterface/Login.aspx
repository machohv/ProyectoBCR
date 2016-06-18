<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClientInterface.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Banco de Costa Rica</title>
    <link href="Content/login.css" rel="stylesheet" />
</head>
<body>    
    <div class="login-page">
        <div class="form">
            <form class="login-form" id="form1" runat="server">
             <img src="img/logo-bcr.png"/><br />
             &nbsp;      
                <br />
            <asp:TextBox ID="txtCedula" runat="server" placeholder="Cédula"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCedula" Display="Dynamic" ErrorMessage="Debe digitar una cédula" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="La cédula no corresponde a un cliente" ForeColor="Red" OnServerValidate="CedulaValidate" ControlToValidate="txtCedula" Display="Dynamic" ></asp:CustomValidator>
                <br />
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Contraseña" type="password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Debe digitar una contraseña" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="La contraseña es incorrecta" ForeColor="Red" OnServerValidate="PasswordValidate" ControlToValidate="txtPassword" Display="Dynamic"></asp:CustomValidator>
                <br />
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" />
                <br />
            </form>
  </div>
</div>
</body>
</html>
