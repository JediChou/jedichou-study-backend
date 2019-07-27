<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>
<!DOCTYPE html>
<html>
    <head id="Head1" runat="server">
        <title>List Records</title>
    </head>
    <body>
        <table style="width: 672px; border: 1px">
            <td>
                <tr>
                    <a href="./insert.aspx">Insert</a> |
                </tr>
            </td>
        </table>
        <form id="form1" runat="server">
            <asp:Label runat="server" ID="lblMessage" EnableViewState="False" />

            <asp:GridView runat="server" ID="GridView1" EnableViewState="False">
                <Columns>
                    <asp:TemplateField HeaderText="Details">
                        <ItemTemplate>
                            <a href="details.aspx?autoid=<%# Eval("AutoId") %>">Details</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href="update.aspx?autoid=<%# Eval("AutoId") %>">Update</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </form>
    </body>
</html>
