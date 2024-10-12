using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class NoticeDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"UPDATE [dbo].[notice]
   SET [details] = @details";
        SqlCommand cmd = new SqlCommand(querry,con);
        cmd.Parameters.AddWithValue("@details",TextBox1.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        Response.Write("Update successfully....");
        con.Close();

    }
}