<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="DisplayCommercial.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Display array values randomly on a gridview</h1>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Press to get random data" />
            <br />
            <br />
            <asp:GridView ID="GridView1" ShowHeader="false" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
