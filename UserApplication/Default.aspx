<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Users and Roles Sample</h1>
            <asp:Login ID="ctlLogin" runat="server" OnAuthenticate="ctlLogin_Authenticate" />
        </div>
    </form>
</body>
</html>
