using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label33.Text = "Library,Online Exam, Result, Pay Fees section under maintainces...";
        Label33.Visible = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"SELECT [address]
      ,[phone]
      ,[email]
  FROM [dbo].[Contact]";
        SqlCommand cmd = new SqlCommand(querry,con);
        con.Open();
        SqlDataReader read = cmd.ExecuteReader();
        if (read.Read())
        {
            Label30.Text = read["address"].ToString();
            Label31.Text = read["phone"].ToString();
            Label32.Text = read["email"].ToString();
        }

        // Close the reader
        read.Close();
        con.Close();

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        string selectedValue = Convert.ToString( DropDownList1.SelectedValue);



        switch (selectedValue)
        {
            case "1":
                 SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                 string querry1 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 1
                ";
                SqlCommand cmd1 = new SqlCommand(querry1, con1);
                con1.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                cmd1.ExecuteNonQuery();
                con1.Close();
                break;

                
            case "2":
                SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                 string querry2 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 2
                ";
                SqlCommand cmd2 = new SqlCommand(querry2, con2);
                con2.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                GridView1.DataSource = dt2;
                GridView1.DataBind();
                cmd2.ExecuteNonQuery();
                con2.Close();
                break;


            case "3":
                SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                 string querry3 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 3
                ";
                SqlCommand cmd3 = new SqlCommand(querry3, con3);
                con3.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                GridView1.DataSource = dt3;
                GridView1.DataBind();
                cmd3.ExecuteNonQuery();
                con3.Close();
                break;


            case "4":
                 SqlConnection con4 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                 string querry4 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 4
                ";
                SqlCommand cmd4 = new SqlCommand(querry4, con4);
                con4.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                GridView1.DataSource = dt4;
                GridView1.DataBind();
                cmd4.ExecuteNonQuery();
                con4.Close();
                break;

            case "5":
                 SqlConnection con5 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                 string querry5 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 5
                ";
                SqlCommand cmd5 = new SqlCommand(querry5, con5);
                con5.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                DataTable dt5 = new DataTable();
                da5.Fill(dt5);
                GridView1.DataSource = dt5;
                GridView1.DataBind();
                cmd5.ExecuteNonQuery();
                con5.Close();
                break;


            case "6":
                SqlConnection con6 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry6 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 6
                ";
                SqlCommand cmd6 = new SqlCommand(querry6, con6);
                con6.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);
                GridView1.DataSource = dt6;
                GridView1.DataBind();
                cmd6.ExecuteNonQuery();
                con6.Close();
                break;

            case "7":
                SqlConnection con7 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry7 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 7
                ";
                SqlCommand cmd7 = new SqlCommand(querry7, con7);
                con7.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
                DataTable dt7 = new DataTable();
                da7.Fill(dt7);
                GridView1.DataSource = dt7;
                GridView1.DataBind();
                cmd7.ExecuteNonQuery();
                con7.Close();
                break;

            case "8":
                SqlConnection con8 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry8 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 8
                ";
                SqlCommand cmd8 = new SqlCommand(querry8, con8);
                con8.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
                DataTable dt8 = new DataTable();
                da8.Fill(dt8);
                GridView1.DataSource = dt8;
                GridView1.DataBind();
                cmd8.ExecuteNonQuery();
                con8.Close();
                break;

            case "9":
                SqlConnection con9 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry9 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 9
                ";
                SqlCommand cmd9 = new SqlCommand(querry9, con9);
                con9.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
                DataTable dt9 = new DataTable();
                da9.Fill(dt9);
                GridView1.DataSource = dt9;
                GridView1.DataBind();
                cmd9.ExecuteNonQuery();
                con9.Close();
                break;

            case "10":
                SqlConnection con10 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry10 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 10
                ";
                SqlCommand cmd10 = new SqlCommand(querry10, con10);
                con10.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da10 = new SqlDataAdapter(cmd10);
                DataTable dt10 = new DataTable();
                da10.Fill(dt10);
                GridView1.DataSource = dt10;
                GridView1.DataBind();
                cmd10.ExecuteNonQuery();
                con10.Close();
                break;

            case "11":
                SqlConnection con11 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry11 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 11
                ";
                SqlCommand cmd11 = new SqlCommand(querry11, con11);
                con11.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
                DataTable dt11 = new DataTable();
                da11.Fill(dt11);
                GridView1.DataSource = dt11;
                GridView1.DataBind();
                cmd11.ExecuteNonQuery();
                con11.Close();
                break;

            case "12":
                SqlConnection con12 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry12 = @"select * from [dbo].[Fees]
                    WHERE [Class] = 12
                ";
                SqlCommand cmd12 = new SqlCommand(querry12, con12);
                con12.Open();
                GridView1.Visible = true;
                GridView1.Controls.Clear(); // This will clear the GridView1
                SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
                DataTable dt12 = new DataTable();
                da12.Fill(dt12);
                GridView1.DataSource = dt12;
                GridView1.DataBind();
                cmd12.ExecuteNonQuery();
                con12.Close();
                break;

            default:
              GridView1.Controls.Clear();// This will clear the GridView1
              GridView1.Visible = false;
             Label34.Visible = true;
             Label34.Text = "no data found...";
                break;
        }
    }




    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedValue = DropDownList2.SelectedValue;
        switch (selectedValue)
        {
            case "1":
                Response.Redirect("~/OnlineFeesPage.aspx");
                break;
            case "2":
                Response.Redirect("~/OflineFeesPage.aspx");
                break;
            default:
                Response.Redirect("#");
                break;
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedValue = DropDownList3.SelectedValue;



        switch (selectedValue)
        {
            case "1":
                Response.Redirect("~/RoutineOne.aspx");
                break;
            case "2":
                Response.Redirect("~/RoutineTwo.aspx");
                break;
            case "3":
                Response.Redirect("~/RoutineThree.aspx");
                break;
            case "4":
                Response.Redirect("~/RoutineFour.aspx");
                break;
            case "5":
                Response.Redirect("~/RoutineFive.aspx");
                break;
            case "6":
                Response.Redirect("~/RoutineSix.aspx");
                break;
            case "7":
                Response.Redirect("~/RoutineSeven.aspx");
                break;
            case "8":
                Response.Redirect("~/RoutineEight.aspx");
                break;
            case "9":
                Response.Redirect("~/RoutineNine.aspx");
                break;
            case "10":
                Response.Redirect("~/RoutineTen.aspx");
                break;
            case "11":
                Response.Redirect("~/RoutineEleven.aspx");
                break;
            case "12":
                Response.Redirect("~/RoutineTwelve.aspx");
                break;
            default:
                Response.Redirect("#");
                break;
        }
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedValue = DropDownList4.SelectedValue;



        switch (selectedValue)
        {
            case "1":
                Response.Redirect("~/ResultOne.aspx");
                break;
            case "2":
                Response.Redirect("~/ResultTwo.aspx");
                break;
            case "3":
                Response.Redirect("~/ResultThree.aspx");
                break;
            case "4":
                Response.Redirect("~/ResultFour.aspx");
                break;
            case "5":
                Response.Redirect("~/ResultFive.aspx");
                break;
            case "6":
                Response.Redirect("~/ResultSix.aspx");
                break;
            case "7":
                Response.Redirect("~/ResultSeven.aspx");
                break;
            case "8":
                Response.Redirect("~/ResultEight.aspx");
                break;
            case "9":
                Response.Redirect("~/ResultNine.aspx");
                break;
            case "10":
                Response.Redirect("~/ResultTen.aspx");
                break;
            case "11":
                Response.Redirect("~/ResultEleven.aspx");
                break;
            case "12":
                Response.Redirect("~/ResultTwelve.aspx");
                break;
            default:
                Response.Redirect("#");
                break;
        }
    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedValue =Convert.ToString( DropDownList5.SelectedValue);



        switch (selectedValue)
        {
        case "1":
                SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry1 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 1;
                ";
                SqlCommand cmd1 = new SqlCommand(querry1, con1);
                con1.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read1 = cmd1.ExecuteReader();
                if (read1.Read())
                {
                    TextBox15.Text = read1["dates"].ToString();
                }
                read1.Close();
                con1.Close();
                break;

            case "2":
                SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry2 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 2;
                ";
                SqlCommand cmd2 = new SqlCommand(querry2, con2);
                con2.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read2 = cmd2.ExecuteReader();
                if (read2.Read())
                {
                    TextBox15.Text = read2["dates"].ToString();
                }
                read2.Close();
                con2.Close();
                break;

            case "3":
                SqlConnection con3 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry3 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 3;
                ";
                SqlCommand cmd3 = new SqlCommand(querry3, con3);
                con3.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read3 = cmd3.ExecuteReader();
                if (read3.Read())
                {
                    TextBox15.Text = read3["dates"].ToString();
                }
                read3.Close();
                con3.Close();
                break;

            case "4":
                SqlConnection con4 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry4 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 4;
                ";
                SqlCommand cmd4 = new SqlCommand(querry4, con4);
                con4.Open();
                TextBox15.Visible = true;
               TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read4 = cmd4.ExecuteReader();
                if (read4.Read())
                {
                    TextBox15.Text = read4["dates"].ToString();
                }
                read4.Close();
                con4.Close();
                break;

            case "5":
                SqlConnection con5 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry5 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 5;
                ";
                SqlCommand cmd5 = new SqlCommand(querry5, con5);
                con5.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read5 = cmd5.ExecuteReader();
                if (read5.Read())
                {
                    TextBox15.Text = read5["dates"].ToString();
                }
                read5.Close();
                con5.Close();
                break;

            case "6":
                SqlConnection con6 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry6 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 6;
                ";
                SqlCommand cmd6 = new SqlCommand(querry6, con6);
                con6.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read6 = cmd6.ExecuteReader();
                if (read6.Read())
                {
                    TextBox15.Text = read6["dates"].ToString();
                }
                read6.Close();
                con6.Close();
                break;

            case "7":
                SqlConnection con7 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry7 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 7;
                ";
                SqlCommand cmd7 = new SqlCommand(querry7, con7);
                con7.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read7 = cmd7.ExecuteReader();
                if (read7.Read())
                {
                    TextBox15.Text = read7["dates"].ToString();
                }
                read7.Close();
                con7.Close();
                break;

            case "8":
                SqlConnection con8 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry8 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 8;
                ";
                SqlCommand cmd8 = new SqlCommand(querry8, con8);
                con8.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
                SqlDataReader read8 = cmd8.ExecuteReader();
                if (read8.Read())
                {
                    TextBox15.Text = read8["dates"].ToString();
                }
                read8.Close();
                con8.Close();
                break;

            case "9":
                SqlConnection con9 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
                string querry9 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 9;
                ";
                SqlCommand cmd9 = new SqlCommand(querry9,con9);
                con9.Open();
                TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
            SqlDataReader read9 = cmd9.ExecuteReader();
            if (read9.Read())
            {
                TextBox15.Text = read9["dates"].ToString();
            }
            read9.Close();
                con9.Close();
             break;

            case "10":
             SqlConnection con10 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
             string querry10 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 10;
                ";
             SqlCommand cmd10 = new SqlCommand(querry10, con10);
             con10.Open();
             TextBox15.Visible = true;
             TextBox15.Text = ""; // This will clear the TextBox
             SqlDataReader read10 = cmd10.ExecuteReader();
             if (read10.Read())
             {
                 TextBox15.Text = read10["dates"].ToString();
             }
             read10.Close();
                con10.Close();
             break;

            case "11":
             SqlConnection con11 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
             string querry11 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 11;
                ";
             SqlCommand cmd11 = new SqlCommand(querry11, con11);
             con11.Open();
             TextBox15.Visible = true;
             TextBox15.Text = ""; // This will clear the TextBox
             SqlDataReader read11 = cmd11.ExecuteReader();
             if (read11.Read())
             {
                 TextBox15.Text = read11["dates"].ToString();
             }
             read11.Close();
                con11.Close();
             break;

            case "12":
             SqlConnection con12 = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
             string querry12 = @"SELECT [dates]
                FROM [dbo].[holiday]
                where MONTH(dates) = 12;
                ";
             SqlCommand cmd12 = new SqlCommand(querry12, con12);
             con12.Open();
             TextBox15.Visible = true;
                TextBox15.Text = ""; // This will clear the TextBox
             SqlDataReader read12 = cmd12.ExecuteReader();
             if (read12.Read())
             {
                 TextBox15.Text = read12["dates"].ToString();
             }
             read12.Close();
             con12.Close();
             break;

            default:
            TextBox15.Text = ""; // This will clear the TextBox
             Label34.Visible = true;
             Label34.Text = "no data found...";
             break;
        }
        
    }
    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedValue = DropDownList6.SelectedValue;



        switch (selectedValue)
        {
            case "1":
                Response.Redirect("~/ExamOne.aspx");
                break;
            case "2":
                Response.Redirect("~/ExamTwo.aspx");
                break;
            case "3":
                Response.Redirect("~/ExamThree.aspx");
                break;
            case "4":
                Response.Redirect("~/ExamFour.aspx");
                break;
            case "5":
                Response.Redirect("~/ExamFive.aspx");
                break;
            case "6":
                Response.Redirect("~/ExamSix.aspx");
                break;
            case "7":
                Response.Redirect("~/ExamSeven.aspx");
                break;
            case "8":
                Response.Redirect("~/ExamEight.aspx");
                break;
            case "9":
                Response.Redirect("~/ExamNine.aspx");
                break;
            case "10":
                Response.Redirect("~/ExamTen.aspx");
                break;
            case "11":
                Response.Redirect("~/ExamEleven.aspx");
                break;
            case "12":
                Response.Redirect("~/ExamTwelve.aspx");
                break;
            default:
                Response.Redirect("#");
                break;
        }
    }
    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {
         string selectedValue = DropDownList7.SelectedValue;



         switch (selectedValue)
         {
             case "1":
                 Response.Redirect("~/MathLIB.aspx");
                 break;
             case "2":
                 Response.Redirect("~/BengaliLIB.aspx");
                 break;
             case "3":
                 Response.Redirect("~/HistoryLIB.aspx");
                 break;
             case "4":
                 Response.Redirect("~/GeographyLIB.aspx");
                 break;
             case "5":
                 Response.Redirect("~/EnglishLIB.aspx");
                 break;
             case "6":
                 Response.Redirect("~/PhysicsLIB.aspx");
                 break;
             case "7":
                 Response.Redirect("~/BiologyLIB.aspx");
                 break;
             case "8":
                 Response.Redirect("~/ChemistryLIB.aspx");
                 break;
             case "9":
                 Response.Redirect("~/ComputerLIB.aspx");
                 break;
             case "10":
                 Response.Redirect("~/SportsLIB.aspx");
                 break;
             case "11":
                 Response.Redirect("~/SanskritLIB.aspx");
                 break;
             default:
                 Response.Redirect("#");
                 break;
         }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");
        string querry = @"INSERT INTO [dbo].[Admission]
           ([Name]
           ,[Age]
           ,[Father's Name]
           ,[D.O.B]
           ,[Class]
           ,[Gender]
           ,[Contuct No]
           ,[Email id])
     VALUES
           (@Name
           ,@Age
           ,@FatherName
           ,@DOB
           ,@Class
           ,@Gender
           ,@ContuctNo
           ,@Email)";
        SqlCommand cmd = new SqlCommand(querry,con);
        con.Open();
        cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Age",Convert.ToInt32( TextBox2.Text));
        cmd.Parameters.AddWithValue("@FatherName", TextBox3.Text);
        cmd.Parameters.AddWithValue("@DOB",Convert.ToDateTime( TextBox4.Text));
        cmd.Parameters.AddWithValue("@Class",Convert.ToInt32( TextBox5.Text));
        cmd.Parameters.AddWithValue("@Gender",Convert.ToString( DropDownList8.SelectedItem));
        cmd.Parameters.AddWithValue("@ContuctNo", Convert.ToInt64 (TextBox6.Text));
        cmd.Parameters.AddWithValue("@Email", Convert.ToString (TextBox7.Text));
        cmd.ExecuteNonQuery();
        Label35.Visible = true;
        Label35.Text = "Submited Successfully....";
        con.Close();
    }
}