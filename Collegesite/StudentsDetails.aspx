<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentsDetails.aspx.cs" Inherits="StudentsDetails" %>

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
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="#6600CC" Text="Student's  Details "></asp:Label>
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
                    <asp:Label ID="Label34" runat="server" Text="Class"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox26" runat="server" Height="23px" Width="230px" TextMode="Number"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label15" runat="server" Text="Subject 1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label16" runat="server" Text="Subject 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label17" runat="server" Text="Subject 3"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label18" runat="server" Text="Subject 4"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox8" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label19" runat="server" Text="Subject 5"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox9" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label20" runat="server" Text="Subject 6"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox10" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label21" runat="server" Text="Subject 7"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox11" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label22" runat="server" Text="Subject 8"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox12" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label14" runat="server" Text="Subject 9"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Subject 10"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
&nbsp;&nbsp;&nbsp;
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
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="#660066" Text="Update Student's Details"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label23" runat="server" Text="*" ForeColor="#006600" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TextBox13" runat="server" Height="23px" Width="230px" TextMode="Number"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TextBox14" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label35" runat="server" Text="Class"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TextBox27" runat="server" Height="23px" Width="230px" TextMode="Number"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Subject 1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox15" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label25" runat="server" Text="Subject 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox17" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label26" runat="server" Text="Subject 3"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox18" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label27" runat="server" Text="Subject 4"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox19" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label28" runat="server" Text="Subject 5"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox20" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label29" runat="server" Text="Subject 6"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox21" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label30" runat="server" Text="Subject 7"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox22" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label31" runat="server" Text="Subject 8"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox23" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label32" runat="server" Text="Subject 9"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox24" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label33" runat="server" Text="Subject 10"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox25" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox16" runat="server" Height="23px" Width="230px"></asp:TextBox>
                    <br />
                    <br />
&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Text="Image"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; <asp:FileUpload ID="FileUpload2" runat="server" />
                    <br />
                    <asp:Label ID="Label24" runat="server" Text="Image must be under 500 kb" Font-Bold="True" Font-Italic="True" Font-Size="Smaller" ForeColor="Red"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Update" Height="31px" OnClick="Button3_Click" Width="75px" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="View Details" Height="31px" Width="75px" OnClick="Button2_Click"/>
                    <br />
                    <asp:Panel ID="Panel1" runat="server" Height="217px" GroupingText="Student's Details" BackColor="#CCCCFF">
                        &nbsp;
                        <asp:GridView ID="GridView1" runat="server" BackColor="#999966" Width="1260px">
                        </asp:GridView>
                    </asp:Panel>
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
