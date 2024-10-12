<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentHomePage.aspx.cs" Inherits="StudentHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
         text-align:center;
               width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Book Antiqua" Font-Size="XX-Large" ForeColor="#993300" Text="Student's  Home Page"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="118px" Width="138px" BorderColor="#996600"/>
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" Text="User ID"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Name"></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="Class"></asp:Label>
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" Width="1292px">
                    </asp:GridView>
                    <br />
                    </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
