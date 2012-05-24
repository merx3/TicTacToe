<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Select.aspx.cs" Inherits="TicTacToe.Select" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Select your side: 
    <asp:DropDownList ID="side" runat="server">
    <asp:ListItem>X</asp:ListItem>
    <asp:ListItem>O</asp:ListItem>
    </asp:DropDownList>
    <br />
    Select your turn: 
    <asp:DropDownList ID="turn" runat="server">
    <asp:ListItem>First</asp:ListItem>
    <asp:ListItem>Second</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="submit" Text="Start game" runat="server" OnClick="StartGame"/>
    </form>
</body>
</html>
