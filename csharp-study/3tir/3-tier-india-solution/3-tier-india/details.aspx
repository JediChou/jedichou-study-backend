<%@ Page Language="C#" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="Details" %>
<!DOCTYPE html>
<html>
    <head runat="server">
        <title>Details</title>
    </head>
    <body>
        <table style="width: 672px; border: 1px">
            <td><tr><a href="./Default.aspx">Home</a></tr></td>
        </table>
        <form id="form1" runat="server">
            <asp:Label runat="server" ID="lblMessage"/>
            <asp:DetailsView runat="server" ID="DetailView1"></asp:DetailsView>
            <p>
                <span onclick="return confirm('Are you sure to delete?')"></span>
                <asp:Button runat="server" ID="btnDelete" Text="Delete" onclick="btnDelete_Click"/>
            </p>
        </form>
    </body>
</html>
