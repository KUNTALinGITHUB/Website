<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeachersDetails.aspx.cs" Inherits="TeachersDetails" %>

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
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="#6600CC" Text="Teacher's  Details "></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="*" Font-Bold="True" Font-Italic="True" ForeColor="Red" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
&nbsp; <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                    <asp:Label ID="Label13" runat="server" Text="Image must be under 500 kb" Font-Bold="True" Font-Italic="True" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Submit" Height="31px" OnClick="Button1_Click" Width="75px" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="#660066" Text="Update Teacher's Details"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label15" runat="server" Text="*" ForeColor="#006600" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server" Height="23px" Width="230px" TextMode="Number"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Subject"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Image"></asp:Label>
&nbsp; <asp:FileUpload ID="FileUpload2" runat="server" />
                    <br />
                    <asp:Label ID="Label14" runat="server" Text="Image must be under 500 kb" Font-Bold="True" Font-Italic="True" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Update" Height="31px" OnClick="Button3_Click" Width="75px" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Panel ID="Panel1" runat="server" Height="217px" GroupingText="Teacher's Details" BackColor="#CCCCFF">
                        &nbsp;
                        <asp:GridView ID="GridView1" runat="server" Width="1260px" BackColor="#999966">
                        </asp:GridView>
                    </asp:Panel>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="View Details" Height="31px" Width="75px" OnClick="Button2_Click"/>
                    <br />
                    <br />
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
