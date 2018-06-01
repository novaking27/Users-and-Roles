<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Portal.aspx.cs" Inherits="UserApplication.Portal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Portal Page </h2>
            Logged in user: <asp:Label ID="lblUser" runat="server" /><br />

            <h2>What roles does this user have </h2>
            <asp:GridView ID="gvRoles" runat="server" />

             <h2>Add  role to this user</h2>
             Available Roles <asp:DropDownList ID="ddlRoles" runat="server" /><br />
             User ID: <asp:TextBox ID="txtUserID" runat="server" />
             <asp:Button ID="btnAddroles" runat="server" Text="Add Role" OnClick="btnAddroles_Click" />
        </div>
    </form>
</body>
</html>
