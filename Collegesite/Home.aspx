<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 81px;
            background-color:gray;
            
        }
        .auto-style2 {
            height: 23px;
            background-color:chocolate;
            
            
        }
        .auto-style3 {
            height: 23px;
            width: 484px;
            background-color:chocolate;
            text-align:center
        }
        .auto-style4 {
            height: 23px;
            width: 65px;
            background-color:chocolate;
        }
        .auto-style5 {
            width: 63px;
            height: 47px;
            
        }
        .auto-style6 {
            width: 100%;
            height: 370px;
        }
        .auto-style7 {
            height: 323px;
            text-align:center;
            background-color:lightgrey;
            
        }
        #Select1 {
            width: 108px;
        }
        .auto-style8 {
            width: 100%;
            text-align:center;
        }
        .auto-style10 {
            width: 671px;
            background-color:lightgrey;
        }
        .auto-style11 {
            width: 67px;
            background-color:GrayText;
        }
        .auto-style12 {
            width: 100%;
            text-align:center;
            height: 4px;
            background-color:saddlebrown;
        }
        .auto-style13 {
            width: 100%;
        }
        .auto-style14 {
            width: 318px;
            height: 249px;
            text-align:center;
            background-color:lightslategrey;
        }
        .auto-style15 {
           width: 21px;
            
        }
        .auto-style16 {
            width: 21px;
            height: 249px;
            background-color:gainsboro;
        }
        .auto-style17 {
            width: 1061px;
            background-color:whitesmoke;
        }
        .auto-style18 {
            width: 110px;
        }
        
        </style>
</head>
<body style="height: 84px">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">
                    <img alt="School Logo" class="auto-style5" src="Img/logo.png" /></td>
                <td class="auto-style3">&nbsp;<asp:Label ID="Label1" runat="server" BackColor="#CCFF33" BorderColor="#FF9900" Font-Bold="True" Font-Size="Larger" Text="ABCD International School" Height="25px" Width="479px"></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/AdminLogin.aspx" Target="_blank" style="text-decoration:none;color: black;" >Admin</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/StudentLogin.aspx" Target="_blank" style="text-decoration:none;color: black;">Student Login</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/TeacherLogin.aspx" Target="_blank" style="text-decoration:none;color: black;">Teacher Login</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/About.aspx" style="text-decoration:none;color: black;">About</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="#Label18" style="text-decoration:none;color: black;">Contuct</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Notice.aspx" style="text-decoration:none;color: black;">Notice</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="#Label9" style="text-decoration:none;color: black;">Online Admission</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/OflineExam.aspx" Target="_blank"  style="text-decoration:none;color: black;" >Ofline Exam</asp:HyperLink>
                </td>
            </tr>
        </table>
    
        <table class="auto-style1">
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Text="Results"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label7" runat="server" Text="Online Exam"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label6" runat="server" Text="Pay Fees"></asp:Label>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Fees Structure"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Class Routine"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Holidays"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Text="Online Library"></asp:Label>
&nbsp;
                    <br />
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" Height="21px" Width="121px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                        <asp:ListItem> --Select Class--</asp:ListItem>
                        <asp:ListItem Value="1">Class 1</asp:ListItem>
                        <asp:ListItem Value ="2">Class 2</asp:ListItem>
                        <asp:ListItem Value ="3">Class 3</asp:ListItem>
                        <asp:ListItem Value ="4">Class 4</asp:ListItem>
                        <asp:ListItem Value ="5">Class 5</asp:ListItem>
                        <asp:ListItem Value ="6">Class 6</asp:ListItem>
                        <asp:ListItem Value="7">Class 7</asp:ListItem>
                        <asp:ListItem Value ="8">Class 8</asp:ListItem>
                        <asp:ListItem Value ="9">Class 9</asp:ListItem>
                        <asp:ListItem Value ="10">Class 10</asp:ListItem>
                        <asp:ListItem Value ="11">Class 11</asp:ListItem>
                        <asp:ListItem Value ="12">Class 12</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True" Height="21px" Width="121px" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged">
                        <asp:ListItem> --Select Class--</asp:ListItem>
                        <asp:ListItem Value="1">Class 1</asp:ListItem>
                        <asp:ListItem Value ="2">Class 2</asp:ListItem>
                        <asp:ListItem Value ="3">Class 3</asp:ListItem>
                        <asp:ListItem Value ="4">Class 4</asp:ListItem>
                        <asp:ListItem Value ="5">Class 5</asp:ListItem>
                        <asp:ListItem Value ="6">Class 6</asp:ListItem>
                        <asp:ListItem Value="7">Class 7</asp:ListItem>
                        <asp:ListItem Value ="8">Class 8</asp:ListItem>
                        <asp:ListItem Value ="9">Class 9</asp:ListItem>
                        <asp:ListItem Value ="10">Class 10</asp:ListItem>
                        <asp:ListItem Value ="11">Class 11</asp:ListItem>
                        <asp:ListItem Value ="12">Class 12</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="21px" Width="121px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>--Select Option--</asp:ListItem>
                        <asp:ListItem Value="1">Online</asp:ListItem>
                        <asp:ListItem Value="2">Ofline</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="21px" Width="121px">
                        <asp:ListItem>--Fees--</asp:ListItem>
                        <asp:ListItem Value="1">Class 1</asp:ListItem>
                        <asp:ListItem Value="2">Class 2</asp:ListItem>
                        <asp:ListItem Value="3">Class 3</asp:ListItem>
                        <asp:ListItem Value="4">Class 4</asp:ListItem>
                        <asp:ListItem Value="5">Class 5</asp:ListItem>
                        <asp:ListItem Value="6">Class 6</asp:ListItem>
                        <asp:ListItem Value="7">Class 7</asp:ListItem>
                        <asp:ListItem Value="8">Class 8</asp:ListItem>
                        <asp:ListItem Value="9">Class 9</asp:ListItem>
                        <asp:ListItem Value="10">Class 10</asp:ListItem>
                        <asp:ListItem Value="11">Class 11</asp:ListItem>
                        <asp:ListItem Value="12">Class 12</asp:ListItem>
                        
                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; 
                    <asp:DropDownList ID="DropDownList3" runat="server" Height="21px" Width="121px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>--Select Class--</asp:ListItem>
                        <asp:ListItem Value="1">Class 1</asp:ListItem>
                        <asp:ListItem Value="2">Class 2</asp:ListItem>
                        <asp:ListItem Value="3">Class 3</asp:ListItem>
                        <asp:ListItem Value ="4">Class 4</asp:ListItem>
                        <asp:ListItem Value ="5">Class 5</asp:ListItem>
                        <asp:ListItem Value ="6">Class 6</asp:ListItem>
                        <asp:ListItem Value ="7">Class 7</asp:ListItem>
                        <asp:ListItem Value="8">Class 8</asp:ListItem>
                        <asp:ListItem Value ="9">Class 9</asp:ListItem>
                        <asp:ListItem Value ="10">Class 10</asp:ListItem>
                        <asp:ListItem Value ="11">Class 11</asp:ListItem>
                        <asp:ListItem Value="12">Class 12</asp:ListItem>
                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" Height="21px" Width="121px" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                        <asp:ListItem>-- Select Month--</asp:ListItem>
                        <asp:ListItem Value="1">January</asp:ListItem>
                        <asp:ListItem Value="2" >February</asp:ListItem>
                        <asp:ListItem Value="3">March</asp:ListItem>
                        <asp:ListItem Value="4">April</asp:ListItem>
                        <asp:ListItem Value="5">May</asp:ListItem>
                        <asp:ListItem Value ="6">June</asp:ListItem>
                        <asp:ListItem Value ="7">July</asp:ListItem>
                        <asp:ListItem Value="8">August</asp:ListItem>
                        <asp:ListItem Value="9">September</asp:ListItem>
                        <asp:ListItem Value="10">October</asp:ListItem>
                        <asp:ListItem Value="11">November</asp:ListItem>
                        <asp:ListItem Value="12">December</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:DropDownList ID="DropDownList7" runat="server" Height="21px" Width="121px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged">
                        <asp:ListItem>--Subject--</asp:ListItem>
                        <asp:ListItem Value="1">Math</asp:ListItem>
                        <asp:ListItem Value="2">Bengali</asp:ListItem>
                        <asp:ListItem Value="3">History</asp:ListItem>
                        <asp:ListItem Value="4">Geography</asp:ListItem>
                        <asp:ListItem Value="5">English</asp:ListItem>
                        <asp:ListItem Value="6">Physics</asp:ListItem>
                        <asp:ListItem Value="7">Biology</asp:ListItem>
                        <asp:ListItem Value="8">Chemistry</asp:ListItem>
                        <asp:ListItem Value="9">Computer</asp:ListItem>
                        <asp:ListItem Value="10">sports</asp:ListItem>
                        <asp:ListItem Value="11">sanskrit</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                </td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style6">
            <tr>
                <td class="auto-style7">
                    <br />
                    <asp:Label ID="Label33" runat="server" Text="*" Font-Bold="True" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label34" runat="server" Text="*" Font-Bold="True" Font-Size="Large" ForeColor="Red" Visible="False"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox15" runat="server" BackColor="#9999FF" BorderColor="#9900CC" Font-Size="Large" Height="59px" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="1210px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" Height="194px" Visible="False" Width="1283px">
                    </asp:GridView>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <table class="auto-style12">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table class="auto-style8">
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">
                    <br />
                    <br />
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Bahnschrift SemiBold" Font-Size="XX-Large" ForeColor="#FFCC00" Text="Apply For Online Admission" Font-Underline="True"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label35" runat="server" Text="*" ForeColor="#006600" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
&nbsp;<asp:Label ID="Label10" runat="server" Text="Name "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <asp:Label ID="Label13" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" Height="16px" Width="97px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="Father's Name"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    &nbsp;
                    <asp:Label ID="Label14" runat="server" Text="D.O.B"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Date" Width="200px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="Class"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Number" Width="200px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label15" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList8" runat="server" Height="16px" Width="97px">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem Value="Male">Male</asp:ListItem>
                        <asp:ListItem Value="Female">Female</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label ID="Label16" runat="server" Text="Contuct No"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="Number" Width="200px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:Label ID="Label17" runat="server" Text="Email id"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server" TextMode="Email" Width="200px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Apply" Width="93px" BackColor="#993333" Font-Bold="True" Font-Names="Arial Black" Height="42px" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <br />
                </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style12">
            <tr>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style17">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label28" runat="server" Text="slid show 5 or 6 img of that school  galary"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style13">
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style14">
                    <asp:Label ID="Label27" runat="server" Text="Have A Question ?" Font-Bold="True" Font-Names="Bahnschrift SemiBold Condensed" ForeColor="#CC3399"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" ForeColor="#CC6699" Text="Contact Details"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label30" runat="server" Text="*"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label31" runat="server" Text="*"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label32" runat="server" Text="*"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                <td class="auto-style16">
                    <br />
                    <asp:Label ID="Label18" runat="server" Text=" Get In Touch With Us" Font-Bold="True" Font-Names="Bahnschrift SemiBold" Font-Overline="False" Font-Size="XX-Large" ForeColor="#003300" BorderColor="#999966" BorderStyle="Groove" Width="305px" Height="38px" style="margin-top: 0px"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label26" runat="server" Text="First Name :" Font-Bold="True" Font-Size="Large" Height="17px" Width="113px"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox14" runat="server" Height="22px" Width="198px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label25" runat="server" Text="Last Name :" Font-Bold="True" Font-Size="Large" Height="17px" Width="113px"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox13" runat="server" Height="22px" Width="198px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label21" runat="server" Text="Email ID :" Font-Bold="True" Font-Size="Large" Height="17px" Width="113px"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox10" runat="server" Height="22px" Width="198px" TextMode="Email"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label22" runat="server" Text="Class :" Font-Bold="True" Font-Size="Large" Height="17px" Width="113px"></asp:Label>
                    <br />
                    <asp:DropDownList ID="DropDownList9" runat="server" Height="22px" Width="198px">
                        <asp:ListItem>--Class--</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label ID="Label23" runat="server" Text="Subject :" Font-Bold="True" Font-Size="Large" Height="17px" Width="113px"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox11" runat="server" Height="22px" Width="439px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label24" runat="server" Text="Massage :" Font-Bold="True" Font-Size="Large" Height="17px" Width="113px"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox12" runat="server" Height="148px" Width="439px" TextMode="MultiLine" placeholder="Write here..."></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Submit" Height="38px" Width="92px" Font-Bold="True" Font-Names="Arial Black" />
                    <br />
                    <br />
                </td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
