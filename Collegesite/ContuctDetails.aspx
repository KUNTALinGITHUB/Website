<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContuctDetails.aspx.cs" Inherits="ContuctDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 310px;
        }
        .auto-style3 {
            width: 626px;
            text-align:center;

        }
        .auto-style4 {
            width: 241px;
        }
        .auto-style5 {
            width: 756px;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Contuct Details" Font-Bold="True" Font-Size="XX-Large" ForeColor="#333399" Font-Italic="True" Font-Underline="True"></asp:Label>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="*" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Address:"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Width="473px" Height="26px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Phone No:"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Width="473px" Height="26px" TextMode="Number"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Email ID:"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Width="473px" Height="26px" TextMode="Email"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Height="36px" Text="Update" Width="72px" OnClick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="36px" Text="View" Width="72px" OnClick="Button2_Click"/>
                    <br />
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:GridView ID="GridView1" runat="server" style="margin-left: 0px" Width="752px">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
