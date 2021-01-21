<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Name_Application.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Name Application</title>
    <style type="text/css">
        #form1 {
            width: 1222px;
            height: 467px;
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <h2 style="margin-left: 350px">Name Application</h2>
    <form id="form1" runat="server">
        <div style="height: 296px; width: 1219px">
            <asp:Button ID="getJson" runat="server" Text="Get Json" style="margin: 20px 0px 0px 100px"  OnClick="getJson_Click"/>
            <asp:Button ID="orderByAmount" runat="server" Text="Order By Amount" style="margin-left: 10px" OnClick="orderByAmount_Click"/>
            <asp:Button ID="alphabeticalOrder" runat="server" Text="Alphabetical Order" style="margin-left: 10px" OnClick="alphabeticalOrder_Click"/>
            <asp:Button ID="totalAmount" runat="server" Text="Total Amount" style="margin-left: 10px" OnClick="totalAmount_Click"/>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 10px"></asp:TextBox>
            
            <asp:Button ID="search" runat="server" Text="Search" style="margin-left: 10px" OnClick="search_Click"/>
            <br />
            <asp:Label ID="Label1" runat="server" style="margin-left: 510px"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" style="margin: 10px 0px 0px 100px">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
