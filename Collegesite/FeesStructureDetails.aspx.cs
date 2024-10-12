using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class FeesStructureDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string query = @"UPDATE [dbo].[Fees]
   SET [School Fees] = @SchoolFees
      ,[Library Fees] = @LibraryFees
      ,[Sport Fees] = @SportFees
      ,[Music Club Fees] = @MusicClubFees
      ,[Extra Activitirs Fees] = @ExtraActivitirsFees
 WHERE [Class] = @Class";

        float schoolFees, libraryFees, sportFees, musicClubFees, extraActivitiesFees;
        int classValue;

        if (!int.TryParse(TextBox1.Text, out classValue))
        {
            Label8.Visible = true;
            Label8.Text = "Class must be a valid integer value.";
            Label8.ForeColor = System.Drawing.Color.Red;
            return;
        }

        if (!float.TryParse(TextBox2.Text, out schoolFees) ||
            !float.TryParse(TextBox3.Text, out libraryFees) ||
            !float.TryParse(TextBox4.Text, out sportFees) ||
            !float.TryParse(TextBox5.Text, out musicClubFees) ||
            !float.TryParse(TextBox6.Text, out extraActivitiesFees))
        {
            Label14.Visible = true;
            Label14.Text = "Fees must be valid floating-point values.";
            Label14.ForeColor = System.Drawing.Color.Red;
            return;
        }
        schoolFees = (float)Math.Round(schoolFees, 2);
        libraryFees = (float)Math.Round(libraryFees, 2);
        sportFees = (float)Math.Round(sportFees, 2);
        musicClubFees = (float)Math.Round(musicClubFees, 2);
        extraActivitiesFees = (float)Math.Round(extraActivitiesFees, 2);

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Class", classValue);
        cmd.Parameters.AddWithValue("@SchoolFees", schoolFees);
        cmd.Parameters.AddWithValue("@LibraryFees", libraryFees);
        cmd.Parameters.AddWithValue("@SportFees", sportFees);
        cmd.Parameters.AddWithValue("@MusicClubFees", musicClubFees);
        cmd.Parameters.AddWithValue("@ExtraActivitirsFees", extraActivitiesFees);

        try
        {
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Label15.Visible = true;
                Label15.Text = "Fees updated successfully.";
                Label15.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label14.Visible = true;
                Label14.Text = "No record found for the given class.";
                Label14.ForeColor = System.Drawing.Color.Red;
            }
        }
        catch (Exception ex)
        {
            Label16.Visible = true;
            Label16.Text = "Error: " + ex.Message;
            Label16.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            con.Close();
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"select * from [dbo].[Fees]";
        SqlCommand cmd = new SqlCommand(querry, con);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();
    }
}