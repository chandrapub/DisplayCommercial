<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DisplayCommercial.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelTitle" runat="server" Text="Commercial information"></asp:Label>
            <br />
            <br />
            <asp:Xml ID="XmlCommercial" runat="server" DocumentSource="~/Commercial.xml" TransformSource="~/Commercial.xslt"></asp:Xml>
        </div>
    </form>
</body>
</html>
