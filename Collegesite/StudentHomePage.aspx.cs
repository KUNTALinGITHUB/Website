using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class StudentHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string userId = Request.QueryString["S_ID"];
            if (!string.IsNullOrEmpty(userId))
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;Persist Security Info=True;User ID=sa;Password=12345678");
                string querry1 = @"SELECT [S_ID]
      ,[S_Name]
      ,[S_class]
      ,[S_Subject1]
      ,[S_Subject2]
      ,[S_Subject3]
      ,[S_Subject4]
      ,[S_Subject5]
      ,[S_Subject6]
      ,[S_Subject7]
      ,[S_Subject8]
      ,[S_Subject9]
      ,[S_Subject10]
      ,[S_Password]
      ,[S_IMG]
  FROM [dbo].[student]
 where [S_ID]=@S_ID";

                string querry2 = @"SELECT 
      [S_Subject1]
      ,[S_Subject2]
      ,[S_Subject3]
      ,[S_Subject4]
      ,[S_Subject5]
      ,[S_Subject6]
      ,[S_Subject7]
      ,[S_Subject8]
      ,[S_Subject9]
      ,[S_Subject10]
      
  FROM [dbo].[student]
 where [S_ID]=@S_ID";
                SqlCommand cmd1 = new SqlCommand(querry1, con);
                SqlCommand cmd2 = new SqlCommand(querry2, con);
                cmd1.Parameters.AddWithValue("@S_ID", userId);
                cmd2.Parameters.AddWithValue("@S_ID", userId);

                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Read image data and set the image control
                        byte[] imgData = (byte[])reader["S_IMG"];
                        string base64Image = Convert.ToBase64String(imgData);
                        Image1.ImageUrl = "data:image/jpeg;base64," + base64Image;

                        // Set text for the labels
                        Label5.Text = reader["S_ID"].ToString();
                        Label2.Text = reader["S_Name"].ToString();
                        Label4.Text = reader["S_class"].ToString();
                    }
                }

                reader.Close();

                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();
            }
        }
    }
}