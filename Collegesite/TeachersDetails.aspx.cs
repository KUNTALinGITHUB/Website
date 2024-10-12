using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class TeachersDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"INSERT INTO [dbo].[teachers]
           ([T_Name]
           ,[T_Subject]
           ,[T_Password]
           ,[T_Image])
     VALUES
           (@T_Name
           ,@T_Subject
           ,@T_Password
           ,@T_Image);
            SELECT SCOPE_IDENTITY()";
        SqlCommand cmd = new SqlCommand(querry,con);
        cmd.Parameters.AddWithValue("@T_Name",TextBox1.Text);
        cmd.Parameters.AddWithValue("@T_Subject", TextBox2.Text);
        cmd.Parameters.AddWithValue("@T_Password",TextBox3.Text);
        if (FileUpload1.HasFile)
            {
                // Read the uploaded file into a byte array
                byte[] imgData = FileUpload1.FileBytes;
                cmd.Parameters.AddWithValue("@T_Image", imgData);
            }
            else
            {
                string defaultImagePath = Server.MapPath("~/Img/default.jpg");

                // Read the default image from the file system
                byte[] defaultImgData = File.ReadAllBytes(defaultImagePath);

                // Set the default image as the parameter value
                cmd.Parameters.AddWithValue("@T_Image", defaultImgData);
            }
        con.Open();
        
        Label12.Text=" successfully submitted ";
        Label12.Visible=true;
        object userid = cmd.ExecuteScalar();
        string userId = userid.ToString();
        Response.Write("User ID: " + userId); 
        con.Close();
    }
protected void Button2_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry =@"SELECT [T_ID]
      ,[T_Name]
      ,[T_Subject]
      ,[T_Password]
      ,[T_Image]
  FROM [dbo].[teachers]" ;
    SqlCommand cmd = new SqlCommand(querry,con);
    con.Open();
    SqlDataAdapter da = new SqlDataAdapter (cmd);
    DataTable dt = new DataTable();
    da.Fill(dt);
    GridView1.DataSource=dt;
    GridView1.DataBind();
    cmd.ExecuteNonQuery();
    con.Close();
}
protected void Button3_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry =@"UPDATE [dbo].[teachers]
   SET [T_Name] = @T_Name
      ,[T_Subject] = @T_Subject
      ,[T_Password] = @T_Password
      ,[T_Image] = @T_Image
 WHERE [T_ID] = @T_ID";
    SqlCommand cmd = new SqlCommand(querry,con);
    cmd.Parameters.AddWithValue("@T_ID", TextBox7.Text);
        cmd.Parameters.AddWithValue("@T_Name",TextBox4.Text);
        cmd.Parameters.AddWithValue("@T_Subject", TextBox5.Text);
        cmd.Parameters.AddWithValue("@T_Password",TextBox6.Text);
    if (FileUpload2.HasFile)
            {
                // Read the uploaded file into a byte array
                byte[] imgData = FileUpload2.FileBytes;
                cmd.Parameters.AddWithValue("@T_Image", imgData);
            }
            else
            {
                string defaultImagePath = Server.MapPath("~/Img/default.jpg");

                // Read the default image from the file system
                byte[] defaultImgData = File.ReadAllBytes(defaultImagePath);

                // Set the default image as the parameter value
                cmd.Parameters.AddWithValue("@T_Image", defaultImgData);
            }
        con.Open();
        cmd.ExecuteNonQuery();
    Label15.Text=" successfully Updated... ";
        Label15.Visible=true;
    con.Close();
}
}