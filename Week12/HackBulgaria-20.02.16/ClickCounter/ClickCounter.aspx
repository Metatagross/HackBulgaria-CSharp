<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClickCounter.aspx.cs" Inherits="ClickCounter.ClickCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Welcome <%: Session["Username"] %></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnClick" OnClick="btnClick_OnClick" runat="server" Text="Click me!" />
            <asp:Label ID="lblClicks" runat="server">Clicks: <%: Application[String.Format($"{Session["Username"]}Clicks")] %></asp:Label>
            <br/>
            <asp:Label ID="lblTotal" runat="server">TotalClicks: <%: Application["TotalClicks"] %></asp:Label>
        </div>
    </form>
    <table style="width: 50%;">
        <%
            Response.Write("<tr>");
                    Response.Write($"<td>Name</td>");
                    Response.Write($"<td>Clicks</td>");
                    Response.Write("</tr>");

            foreach(string user in Application.AllKeys)
            {
                if(user != "TotalClicks")
                {
                    Response.Write("<tr>");
                    Response.Write($"<td>{user}</td>");
                    Response.Write($"<td>{Application[user]}</td>");
                    Response.Write("</tr>");
                }
            }
             %>
    </table>
</body>
</html>
