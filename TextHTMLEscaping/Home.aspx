<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TextHTMLEscaping.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:TextBox runat="server" ID="input" Text="Enter text here"></asp:TextBox>
            <asp:Button runat="server" ID="submit" OnClick="Submit" Text="Submit"/><br />     
        </p>   
        <asp:TextBox runat="server" ID="resultTxt" Text="Result" ReadOnly="true"></asp:TextBox><br />
        <asp:Label runat="server" ID="resultLbl" Text="Second result"></asp:Label>
    </form>
</body>
</html>
