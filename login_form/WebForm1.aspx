<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="login_form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> User Login Form</h1>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            
        </div>
        <p>
            
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
            </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
