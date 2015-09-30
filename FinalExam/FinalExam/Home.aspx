<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalExam.Fate_of_the_World" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Contry" runat="server" />
            <br />
            <asp:TextBox runat="server" ID="nameText" />
            <br />
            <br />
            <asp:Label Text="Capital" runat="server" /><br />
            <asp:TextBox runat="server" ID="capitalText" /><br />
            <br />
            <asp:Label Text="Population" runat="server" /><br />
            <asp:TextBox runat="server" ID="populationText" /><br />
            <br />
            <asp:Button Text="Add" ID="addCountry" OnClick="addCountry_Click"  runat="server" />
            <asp:LinkButton Text="Search" runat="server" PostBackUrl="~/Search.aspx" />
        </div>
    </form>
</body>
</html>
