using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class HolidayDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"INSERT INTO [dbo].[holiday]
           ([dates])
     VALUES
           (@dates)";
        SqlCommand cmd = new SqlCommand(querry,con);
        cmd.Parameters.AddWithValue("@dates",Calendar1.SelectedDate);
        con.Open();
        cmd.ExecuteNonQuery();
        Response.Write("Added successfully....");
        con.Close();

    }

}