using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Notice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"select * from [dbo].[notice]
   ";
        SqlCommand cmd = new SqlCommand(querry, con);
        
        con.Open();
        SqlDataReader read = cmd.ExecuteReader();
        if (read.Read())
        {
            TextBox1.Text = read["details"].ToString();
        }
        // Close the reader
        read.Close();
        con.Close();
    }
}