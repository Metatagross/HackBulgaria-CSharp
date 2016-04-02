<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ClickCounter.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUser" runat="server" Font-Size="Small" Height="20px" Width="33px">User:</asp:Label>
            <asp:TextBox ID="txtBox" runat="server" Height="20px" Width="150px" CausesValidation="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="txtBox"
                ErrorMessage="Username should not be empty."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        <div style="margin-left: 130px">
            <asp:Button ID="btnSubmit" OnClick="btnSub_OnClick" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
