<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="TicTacToe.TicTacToe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">    
    <title>Tic-Tac-Toe</title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
    <tr>
        <td><asp:ImageButton ID="cell_11" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
        <td><asp:ImageButton ID="cell_12" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
        <td><asp:ImageButton ID="cell_13" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
    </tr>                                                                                
    <tr>                                                                                 
        <td><asp:ImageButton ID="cell_21" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
        <td><asp:ImageButton ID="cell_22" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
        <td><asp:ImageButton ID="cell_23" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
    </tr>                                                                                
    <tr>                                                                                 
        <td><asp:ImageButton ID="cell_31" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
        <td><asp:ImageButton ID="cell_32" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
        <td><asp:ImageButton ID="cell_33" ImageUrl="~/empty.jpg" runat="server" OnClick="PlayerMove"/></td>
    </tr>
    </table>
    <asp:Label ID="finish" runat="server"></asp:Label>
    </form>
</body>
</html>
