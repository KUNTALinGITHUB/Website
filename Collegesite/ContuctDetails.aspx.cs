using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ContuctDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"UPDATE [dbo].[Contact]
   SET [address] = @address
      ,[phone] = @phone
      ,[email] = @email
 ";
        SqlCommand cmd = new SqlCommand(querry,con);
        cmd.Parameters.AddWithValue("@address",TextBox1.Text);
        cmd.Parameters.AddWithValue("@phone", TextBox2.Text);
        cmd.Parameters.AddWithValue("@email", TextBox3.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        Label5.Text = "successfully updated...";
            Label5.Visible=true;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"select * from [dbo].[Contact]";
        SqlCommand cmd = new SqlCommand(querry, con);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}