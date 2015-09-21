<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registraion.aspx.cs" Inherits="Task.Registraion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Username" runat="server" />
            <br />
            <asp:TextBox Text="" runat="server" ID="nameBox" />
            <br />
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="nameBox"
                ErrorMessage="Enter username"
                ForeColor="Red">
            </asp:RequiredFieldValidator>--%>

            <asp:Label Text="Password" runat="server" />
            <br />
            <asp:TextBox Text="" runat="server" ID="passBox" TextMode="Password" />
            <br />
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="passBox"
                ErrorMessage="Enter password"
                ForeColor="Red">
            </asp:RequiredFieldValidator>--%>

            <asp:Label Text="Repeat password" runat="server" />
            <br />
            <asp:TextBox Text="" runat="server" ID="passBox2" TextMode="Password" />
            <br />
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="Reenter password"
                ErrorMessage="Last name is a required field."
                ForeColor="Red">
            </asp:RequiredFieldValidator>--%>

            <asp:Label Text="Age" runat="server" />
            <br />
            <asp:TextBox Text="" runat="server" ID="ageBox" TextMode="Number" />
            <br />
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                ControlToValidate="ageBox"
                ErrorMessage="Enter your age"
                ForeColor="Red">
            </asp:RequiredFieldValidator>--%>

            <asp:Label Text="E-mail" runat="server" />
            <br />
            <asp:TextBox Text="" runat="server" ID="emailBox" TextMode="Email" />
            <br />
<%--            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                ControlToValidate="emailBox"
                ErrorMessage="Enter E-mail"
                ForeColor="Red">
            </asp:RequiredFieldValidator>--%>
            <asp:Button Text="Register" OnClick="Register_Click" runat="server" ValidateRequestMode="Disabled   " />

        </div>
    </form>
</body>
</html>
