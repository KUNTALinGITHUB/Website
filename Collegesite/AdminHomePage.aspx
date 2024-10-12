<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHomePage.aspx.cs" Inherits="AdminHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 725px;
        }
        .auto-style2 {
            width: 270px;
            height: 745px;
        }
        .auto-style3 {
            width: 714px;
            text-align:center;
            background-color:oldlace;
            height: 745px;
        }
        .auto-style4 {
            height: 745px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3">
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Book Antiqua" Font-Size="XX-Large" ForeColor="#993300" Text="Admin Home Page"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="118px" Width="138px" BorderColor="#996600"/>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Name"></asp:Label>
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="User ID"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Panel ID="Panel1" runat="server" BackColor="#999966" Height="246px">
                        <br />
                        <asp:Button ID="Button1" runat="server" Height="40px" Text="Teacher's  Details" Width="147px" OnClick="Button1_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Student's  Details"  Height="40px" Width="147px" OnClick="Button2_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button3" runat="server" Text=" Admission  Application  " Height="40px" Width="147px" OnClick="Button3_Click"  />
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button4" runat="server" Text="Class  Rutine" Height="40px" Width="147px" OnClick="Button4_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button5" runat="server" Text="Fees  Structure" Height="40px" Width="147px" OnClick="Button5_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button6" runat="server" Text="Holidays" Height="40px" Width="147px" OnClick="Button6_Click" />
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button7" runat="server" Text="Online Library" Height="40px" Width="147px" OnClick="Button7_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button8" runat="server" Text="Notice" Height="40px" Width="147px" OnClick="Button8_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button9" runat="server" Text="Contuct" Height="40px" Width="147px" OnClick="Button9_Click" />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="Button10" runat="server" Text="Log Out" Height="40px" Width="147px" OnClick="Button10_Click" />
                    </asp:Panel>
                    <br />
                    <br />
                    <br />
                </td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
