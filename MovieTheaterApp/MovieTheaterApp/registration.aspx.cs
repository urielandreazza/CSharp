using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace UrielAndreazzaAssignment2
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {




            Global.user user = new Global.user();

            user.fname = Request.Form["fname"];
            user.lname = Request.Form["lname"];
            user.role = "user";
            user.pw = Request.Form["pw"];
            user.email = Request.Form["email"];

            Global.cUser.fname = user.fname;


            if (user.fname == "" || user.lname == "" || user.role == "" || user.pw == "" || user.email == "") {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "One or More fields are missing" + "');", true);
            } else
            {
                try
                {
                        SqlConnection conn = new SqlConnection
                        (ConfigurationManager.ConnectionStrings["MovieTeatherConnectionString"].ConnectionString);

                        conn.Open();

                        string insertString = "INSERT INTO users (fname, lname, role, pw, email) " +
                                            "VALUES (@fname, @lname, @role, @pw, @email)";

                        SqlCommand insertUser = new SqlCommand(insertString, conn);
                        insertUser.Parameters.AddWithValue("@fname", user.fname);
                        insertUser.Parameters.AddWithValue("@lname", user.lname);
                        insertUser.Parameters.AddWithValue("@role", user.role);
                        insertUser.Parameters.AddWithValue("@pw", user.pw);
                        insertUser.Parameters.AddWithValue("@email", user.email);

                        insertUser.ExecuteNonQuery();

                        Response.Redirect("landingPage.aspx");

                }
                catch (Exception ex)
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Email Already Registered" + "');", true);
                }

            }

        }
    }
}