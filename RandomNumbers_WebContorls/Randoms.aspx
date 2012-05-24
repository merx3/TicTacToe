<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Randoms.aspx.cs" Inherits="RandomNumbers_WebContorls.Randoms" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Random number</h3>
        <p>From: <asp:TextBox ID="From" runat="server"></asp:TextBox>
        To: <asp:TextBox ID="To" runat="server"></asp:TextBox><br /></p>
        <asp:Button  runat="server" ID="ExecButton" Text="Submit" OnClick="ButtonClicked"/>
        <br />
        Random number: <asp:TextBox ID="Result" runat="server"></asp:TextBox>
    </form>
</body>
</html>
