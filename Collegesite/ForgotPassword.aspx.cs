using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string p1 = TextBox2.Text;
        string p2 = TextBox1.Text;
        if(p1 == p2)
         {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-NEJ6CPH\\SQLEXPRESS;Initial Catalog=SchoolManagementSys;User ID=sa;Password=12345678");

                    string query = @"UPDATE [dbo].[admins]
                                     SET [password] = @password, [c_password] = @c_password
                                     WHERE [userid] = @userid and [name] = @name";

                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@userid",Convert.ToInt64(TextBox3.Text));
                    cmd.Parameters.AddWithValue("@name", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@password", p2); 
                    cmd.Parameters.AddWithValue("@c_password",p1); 

                    
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("Successfully Updated...");
            }
            else
            {
                
                Response.Write("Passwords do not match...");
            }
        }
        
    }
