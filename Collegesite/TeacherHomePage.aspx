<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeacherHomePage.aspx.cs" Inherits="TeacherHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            text-align:center;
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
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Book Antiqua" Font-Size="XX-Large" ForeColor="#993300" Text="Teacher's  Home Page"></asp:Label>
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
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Subject"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Ofline Exam" ForeColor="#660033" Font-Underline="True"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Height="27px" TextMode="Number" Width="211px" placeholder="add exam rooms"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Height="27px" Width="211px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Height="27px" Width="211px" TextMode="Date"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" Height="27px" Width="211px"></asp:TextBox>
                    <br />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Add" Height="27px" Width="75px" Font-Bold="True" OnClick="Button1_Click"/>
                    &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Remove" Height="27px" Width="75px" Font-Bold="True" OnClick="Button2_Click" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Large" Text="Show all rooms"></asp:Label>
                    <br />
                    <asp:Button ID="Button3" runat="server" Font-Bold="True" OnClick="Button3_Click" Text="View" />
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" style="margin-left: 520px">
                    </asp:GridView>
                    <br />
                    <br />
                    </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
