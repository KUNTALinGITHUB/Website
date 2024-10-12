using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class StudentsDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"INSERT INTO [dbo].[student]
           ([S_Name]
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
           ,[S_IMG])
     VALUES
           (@S_Name
           ,@S_class
           ,@S_Subject1
           ,@S_Subject2
           ,@S_Subject3
           ,@S_Subject4
           ,@S_Subject5
           ,@S_Subject6
           ,@S_Subject7
           ,@S_Subject8
           ,@S_Subject9
           ,@S_Subject10
           ,@S_Password
           ,@S_IMG);SELECT SCOPE_IDENTITY()";
        SqlCommand cmd = new SqlCommand(querry, con);
        cmd.Parameters.AddWithValue("@S_Name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@S_class", TextBox26.Text);
        cmd.Parameters.AddWithValue("@S_Subject1", TextBox5.Text);
        cmd.Parameters.AddWithValue("@S_Subject2", TextBox6.Text);
        cmd.Parameters.AddWithValue("@S_Subject3", TextBox7.Text);
        cmd.Parameters.AddWithValue("@S_Subject4", TextBox8.Text);
        cmd.Parameters.AddWithValue("@S_Subject5", TextBox9.Text);
        cmd.Parameters.AddWithValue("@S_Subject6", TextBox10.Text);
        cmd.Parameters.AddWithValue("@S_Subject7", TextBox11.Text);
        cmd.Parameters.AddWithValue("@S_Subject8", TextBox12.Text);
        cmd.Parameters.AddWithValue("@S_Subject9", TextBox4.Text);
        cmd.Parameters.AddWithValue("@S_Subject10", TextBox2.Text);
        cmd.Parameters.AddWithValue("@S_Password", TextBox3.Text);

        if (FileUpload1.HasFile)
            {
                // Read the uploaded file into a byte array
                byte[] imgData = FileUpload1.FileBytes;
                cmd.Parameters.AddWithValue("@S_IMG", imgData);
            }
            else
            {
                string defaultImagePath = Server.MapPath("~/Img/default.jpg");

                // Read the default image from the file system
                byte[] defaultImgData = File.ReadAllBytes(defaultImagePath);

                // Set the default image as the parameter value
                cmd.Parameters.AddWithValue("@S_IMG", defaultImgData);
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
        string querry = @"SELECT [S_ID]
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
order by [S_class] asc";
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
    protected void Button3_Click(object sender, EventArgs e)
    {
         SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
         string querry = @"UPDATE [dbo].[student]
   SET [S_Name] = @S_Name
      ,[S_class] = @S_class
      ,[S_Subject1] = @S_Subject1
      ,[S_Subject2] = @S_Subject2
      ,[S_Subject3] = @S_Subject3
      ,[S_Subject4] = @S_Subject4
      ,[S_Subject5] = @S_Subject5
      ,[S_Subject6] = @S_Subject6
      ,[S_Subject7] = @S_Subject7
      ,[S_Subject8] = @S_Subject8
      ,[S_Subject9] = @S_Subject9
      ,[S_Subject10] = @S_Subject10
      ,[S_Password] = @S_Password
      ,[S_IMG] = @S_IMG
 WHERE [S_ID]=@S_ID";
         SqlCommand cmd = new SqlCommand(querry, con);
         cmd.Parameters.AddWithValue("@S_ID", TextBox13.Text);
         cmd.Parameters.AddWithValue("@S_Name", TextBox14.Text);
         cmd.Parameters.AddWithValue("@S_class", TextBox27.Text);
         cmd.Parameters.AddWithValue("@S_Subject1", TextBox15.Text);
         cmd.Parameters.AddWithValue("@S_Subject2", TextBox17.Text);
         cmd.Parameters.AddWithValue("@S_Subject3", TextBox18.Text);
         cmd.Parameters.AddWithValue("@S_Subject4", TextBox19.Text);
         cmd.Parameters.AddWithValue("@S_Subject5", TextBox20.Text);
         cmd.Parameters.AddWithValue("@S_Subject6", TextBox21.Text);
         cmd.Parameters.AddWithValue("@S_Subject7", TextBox22.Text);
         cmd.Parameters.AddWithValue("@S_Subject8", TextBox23.Text);
         cmd.Parameters.AddWithValue("@S_Subject9", TextBox24.Text);
         cmd.Parameters.AddWithValue("@S_Subject10", TextBox25.Text);
         cmd.Parameters.AddWithValue("@S_Password", TextBox16.Text);

         if (FileUpload2.HasFile)
         {
             // Read the uploaded file into a byte array
             byte[] imgData = FileUpload2.FileBytes;
             cmd.Parameters.AddWithValue("@S_IMG", imgData);
         }
         else
         {
             string defaultImagePath = Server.MapPath("~/Img/default.jpg");

             // Read the default image from the file system
             byte[] defaultImgData = File.ReadAllBytes(defaultImagePath);

             // Set the default image as the parameter value
             cmd.Parameters.AddWithValue("@S_IMG", defaultImgData);
         }
         con.Open();
         cmd.ExecuteNonQuery();
         Label23.Text = " successfully Updated... ";
         Label23.Visible = true;
         con.Close();
    }
}