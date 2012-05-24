<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="StudentRegistration.RegistrationForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
    <label for="fName">First name: </label><asp:TextBox ID="fName" runat="server"></asp:TextBox>
    </p>
    <p>
    <label for="lName">Last name: </label><asp:TextBox ID="lName" runat="server"></asp:TextBox>
    </p>
    <p>
    <label for="facNum">Faculty number: </label><asp:TextBox ID="facNum" runat="server"></asp:TextBox>
    </p>
    <p runat="server" ID="pin">
    <label for="university">Select university:</label> <br />
    <asp:DropDownList runat="server" ID="university">
    <asp:ListItem>Sofia University</asp:ListItem>    
    <asp:ListItem>Technical Univerity</asp:ListItem>
    <asp:ListItem>UNSS</asp:ListItem>    
    <asp:ListItem>MGU</asp:ListItem>    
    <asp:ListItem>VIAS</asp:ListItem>
    <asp:ListItem>Military University</asp:ListItem>    
    </asp:DropDownList>
    </p>
    <p>
    <label for="specialty">Select speciality:</label><br />
    <asp:DropDownList runat="server" ID="specialty">
    <asp:ListItem>Specialty1</asp:ListItem>   
    <asp:ListItem>Specialty2</asp:ListItem>   
    <asp:ListItem>Specialty3</asp:ListItem>       
    <asp:ListItem>Specialty4</asp:ListItem>   
    </asp:DropDownList>
    </p>
    <p>
    <label for="courses">Select attending courses:</label><br />
    <asp:ListBox SelectionMode="Multiple" runat="server" ID="courses" Height="150px">
    <asp:ListItem>Cooking</asp:ListItem>
    <asp:ListItem>Manadgement</asp:ListItem>
    <asp:ListItem>Law and Order</asp:ListItem>
    <asp:ListItem>Aviation</asp:ListItem>
    <asp:ListItem>Programing</asp:ListItem>
    <asp:ListItem>Iconomics</asp:ListItem>
    <asp:ListItem>Journalism</asp:ListItem>
    </asp:ListBox>
    </p>
    <br />
    <asp:Button runat="server" ID="submit" Text="Submit" OnClick="GetData"/>
    <div id="results" runat="server"></div>
    </form>
</body>
</html>
