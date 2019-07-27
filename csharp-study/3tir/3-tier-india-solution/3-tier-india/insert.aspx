<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert.aspx.cs" Inherits="Insert" %>
<!DOCTYPE html>
<html>
    <head id="Head1" runat="server">
        <title>Insert Page</title>
    </head>
    <body>
        <table style="width: 672px; border: 1px">
            <td><tr><a href="./Default.aspx">Home</a></tr></td>
        </table>
        <form id="form1" runat="server">
            <h1>Insert Record</h1>
            <div>
                <p>First Name: <asp:TextBox runat="server" ID="txtFirstName"/></p>
                <p>Last Name: <asp:TextBox runat="server" ID="txtLastName"/></p>
                <p>Age: <asp:TextBox runat="server" ID="txtAge"/></p>
                <asp:Button runat="server" ID="btnSave" Text="Save" onclick="btnSave_Click"/>
            </div>
            <p><asp:Label runat="server" ID="lblMessage" EnableViewState="False"/></p>
        </form>
    </body>
</html>
