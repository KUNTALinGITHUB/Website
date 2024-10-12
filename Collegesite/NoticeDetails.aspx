<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NoticeDetails.aspx.cs" Inherits="NoticeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #div1 {
            text-align:center;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
    
        <asp:Label ID="Label1" runat="server" Text="Notices Details" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="#660033"></asp:Label>
    
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="294px" TextMode="MultiLine" Width="673px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Submit" Width="80px" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
