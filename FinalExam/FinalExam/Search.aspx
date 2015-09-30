<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="FinalExam.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="Back to add country" PostBackUrl="~/Home.aspx" runat="server" /><br /> <br />
            Search by country<br />
            <asp:TextBox runat="server" ID="nameSearch" /><br />
            <br />
            Search by capital<br />
            <asp:TextBox runat="server" ID="capitalSearch" />
            <br />
            <br />
            Search by population<br />
            From:
            <asp:TextBox runat="server" ID="minPop" />
            <br />
            To:
            <asp:TextBox runat="server" ID="maxPop" /><br /> <br />
            <asp:Button Text="Search" ID="searchBtn" OnClick="searchBtn_Click" runat="server" />
                        <asp:Repeater runat="server" ID="booksRepeater">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("country[0]") %>' />
                    <br />
                    <asp:Label Text='<%# Eval("country[1]") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("country[2]") %>' runat="server" />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:Repeater>
            

        </div>
    </form>
</body>
</html>
