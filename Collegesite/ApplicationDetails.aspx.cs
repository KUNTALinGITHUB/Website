using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class ApplicationDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"SELECT [Name]
      ,[Age]
      ,[Father's Name]
      ,[D.O.B]
      ,[Class]
      ,[Gender]
      ,[Contuct No]
      ,[Email id]
      ,[ID]
  FROM [dbo].[Admission]";
        SqlCommand cmd = new SqlCommand(querry,con);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource=dt;
        GridView1.DataBind();
        cmd.ExecuteNonQuery();
        con.Close();

    }
}