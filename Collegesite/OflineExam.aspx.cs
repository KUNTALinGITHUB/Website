using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class OflineExam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridViews();
        }
    }

    private void BindGridViews()
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string query = @"
            SELECT student.S_ID, student.S_Name, student.S_class, room.roomNo, room.subject, room.examDate, room.invigilator
            FROM student
            LEFT JOIN room ON student.S_ID = room.id   
            ORDER BY student.S_class ASC";
        // issue here
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();

        try
        {
            con.Open();
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            // Handle exceptions
            Response.Write("Error: " + ex.Message);
            return;
        }
        finally
        {
            con.Close();
        }

        if (dt.Rows.Count > 0)
        {
            // Split the DataTable into chunks of 15 rows, if available
            DataTable first15 = dt.AsEnumerable().Take(15).CopyToDataTable();
            GridView1.DataSource = first15;
            GridView1.DataBind();

            if (dt.Rows.Count > 15)
            {
                DataTable next15 = dt.AsEnumerable().Skip(15).Take(15).CopyToDataTable();
                GridView2.DataSource = next15;
                GridView2.DataBind();
            }
        }
    }
}
