<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DisplayCommercial.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="ScriptCommercial.js"></script>
    <style>
        .myitem{
            display:flex; 
            justify-content:center;
            font-size:15px;
            font-weight:bold;
            
        }
        .shadow{
            box-shadow:20px 20px 50px grey;
            width:20%;
            height:30%;

        }

        .mytable{
            background-color :green;
            border-bottom-style:groove;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelTitle" runat="server" Text="Commercial information"></asp:Label>
            <br />
            <br />
            <asp:Xml ID="XmlCommercial" runat="server" DocumentSource="~/Commercial.xml" TransformSource="~/CommercialToHTML.xslt"></asp:Xml>
            <br />
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>

                    <table class="mytable"> 
                        
                </HeaderTemplate>

                <ItemTemplate> 
                    <tr class="shadow">
                       <td class="myitem"><%# Eval("CompanyName") %></td>
                       <td class="myitem"><%# Eval("Website") %></td>
                       <td class="myitem"><%# Eval("Address") %></td>
                        <td class="myitem"><%# Eval("Telephone") %></td>
                        <td class="myitem"><img src="logo/<%# Eval("Companylogo") %>" alt="logo" /></td>

                    </tr>

                   <%--<div class="col-sm-8" style="background-color:aqua">
      <h4> <strong>Company Name: </strong> <img src="logo/<%# Eval("Companylogo") %>" alt="logo" /> </h4>
      <h4><strong>MISSION:</strong><%# Eval("CompanyName") %> Our mission lorem ipsum..</h4> 
      <h4><strong>MISSION:</strong><%# Eval("Website") %> Our mission lorem ipsum..</h4> 
      <h4><strong>MISSION:</strong><%# Eval("Address") %> Our mission lorem ipsum..</h4> 
      <p><strong>VISION:</strong> Our vision Lorem ipsum..</p>
    </div>--%>
                </ItemTemplate>
                
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                 
    <%--            <div class="row">
    <div class="container-fluid bg-grey">
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-globe logo"></span>
    </div>
    <div class="col-sm-8">
      <h4> <strong>Company Name: </strong> </h4>
      <h4><strong>MISSION:</strong> Our mission lorem ipsum..</h4>      
      <p><strong>VISION:</strong> Our vision Lorem ipsum..</p>
    </div>
  </div>
</div>--%>

            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MovieDBConnectionString %>" SelectCommand="SELECT TOP (1) ID, CompanyName, Website, Address, Telephone, CompanyLogo FROM Commercial ORDER BY NEWID()"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2">
                <%--<Columns>--%>

                    




                <%--    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                    <asp:BoundField DataField="Website" HeaderText="Website" SortExpression="Website" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="Telephone" HeaderText="Telephone" SortExpression="Telephone" />
                    <asp:BoundField DataField="CompanyLogo" HeaderText="CompanyLogo" SortExpression="CompanyLogo" />
                </Columns>--%>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MovieDBConnectionString2 %>" SelectCommand="SELECT TOP (1) ID, CompanyName, Website, Address, Telephone, CompanyLogo FROM Commercial ORDER BY NEWID()"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Test" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
