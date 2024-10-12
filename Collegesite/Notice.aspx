<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Notice.aspx.cs" Inherits="Notice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Notice</title>
    <style>
        p {
            text-align:center;
            height: 43px;
        }
        .auto-style1 {
            width: 100%;
            height: 356px;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
    
        <asp:Label ID="Label1" runat="server" Text="Notices" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="#660033"></asp:Label>
    
        </p>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="259px" TextMode="MultiLine" Width="684px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
