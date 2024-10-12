using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class TeacherHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string userId = Request.QueryString["T_ID"];
            if (!string.IsNullOrEmpty(userId))
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;Persist Security Info=True;User ID=sa;Password=12345678");
                string querry = @"SELECT [T_ID]
      ,[T_Name]
      ,[T_Subject]
      ,[T_Password]
      ,[T_Image]
  FROM [dbo].[teachers]
 where [T_ID]=@T_ID";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@T_ID", userId);


                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Read image data and set the image control
                        byte[] imgData = (byte[])reader["T_Image"];
                        string base64Image = Convert.ToBase64String(imgData);
                        Image1.ImageUrl = "data:image/jpeg;base64," + base64Image;

                        // Set text for the labels
                        Label5.Text = reader["T_ID"].ToString();
                        Label2.Text = reader["T_Name"].ToString();
                        Label3.Text = reader["T_Subject"].ToString();
                    }
                }

                reader.Close();

            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;Persist Security Info=True;User ID=sa;Password=12345678");
        string querry = @"INSERT INTO [dbo].[room]
           ([roomNo],[subject]
           ,[examDate],[invigilator])
     VALUES
           (@roomNo,@subject,@examDate,@invigilator)";
        SqlCommand cmd = new SqlCommand(querry, con);
        cmd.Parameters.AddWithValue("@roomNo", TextBox1.Text);
        cmd.Parameters.AddWithValue("@subject", TextBox2.Text);
        cmd.Parameters.AddWithValue("@examDate", TextBox3.Text);
        cmd.Parameters.AddWithValue("@invigilator", TextBox4.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;Persist Security Info=True;User ID=sa;Password=12345678");
        string querry = @"truncate table [dbo].[room]";
        SqlCommand cmd = new SqlCommand(querry, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;Persist Security Info=True;User ID=sa;Password=12345678");
        string querry = @"
        SELECT [roomNo],[subject]
           ,[examDate] ,[invigilator]
  FROM [dbo].[room]";
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