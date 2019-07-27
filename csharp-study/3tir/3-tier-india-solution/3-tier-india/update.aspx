<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="Update" %>
<!doctype html>
<html>
    <head runat="server">
        <title>Update</title>
    </head>
    <body>
        <table style="width: 672px; border: 1px">
            <td><tr><a href="./Default.aspx">Home</a></tr></td>
        </table>
        <form id="form1" runat="server">
            <h1>Update record</h1>
            <div>
                <p>First Name: <asp:TextBox runat="server" ID="txtFirstName"/></p>
                <p>Last Name: <asp:TextBox runat="server" ID="txtLastName"/></p>
                <p>Age: <asp:TextBox runat="server" ID="txtAge"></asp:TextBox></p>
                <asp:Button runat="server" ID="btnSave" Text="Update" onclick="btnSave_Click"/>
            </div>
             <p><asp:Label ID="lblMessage" runat="server" EnableViewState="false" /></p>
        </form>
    </body>
</html>
