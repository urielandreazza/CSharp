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
    public class Global
    {
        public struct user {

            public string fname { get; set; }
            public string lname { get; set; }
            public string email { get; set; }
            public string pw { get; set; }
            public string role { get; set; }
            public double general { get; set; }
            public int generalQnt { get; set; }
            public double seniorAndChildren { get; set; }
            public int seniorAndChildrenQnt { get; set; }
            public double discount { get; set; }
            public string movie { get; set; }
            public string day { get; set; }
            public string time { get; set; }
            public int generalPrice { get; set; }
            public int seniorAndChildrenPrice { get; set; }
        }

        public static user cUser = new user();
        
    }
    public partial class landingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Global.cUser.fname = "Human";
            Global.cUser.lname = "Being";
            Global.cUser.role = "NOTUSER";
            Global.cUser.pw = "";
            Global.cUser.email = "UNDEFINED";
            Global.cUser.general = 0;
            Global.cUser.seniorAndChildren = 0;
            Global.cUser.movie = "Captiain Marvel";

        }

        protected void hyperLink_PreLoad(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbEmail.Text == "" || tbPw.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "One or More fields are missing" + "');", true);
            }
            else
            {

                try
                {
                    SqlConnection conn = new SqlConnection
                    (ConfigurationManager.ConnectionStrings["MovieTeatherConnectionString"].ConnectionString);

                    conn.Open();

                    string queryString = "SELECT * FROM users WHERE email = @email AND pw=@pw ";

                    SqlCommand queryUser = new SqlCommand(queryString, conn);

                    queryUser.Parameters.AddWithValue("@pw", tbPw.Text);
                    queryUser.Parameters.AddWithValue("@email", tbEmail.Text);

                    SqlDataReader query = queryUser.ExecuteReader();


                    if (!query.HasRows)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(User Don't exist);", true);
                    }
                    else
                    {
                        while (query.Read())
                        {
                            Global.cUser.fname = query["fname"].ToString();
                            Global.cUser.lname = query["lname"].ToString();
                            Global.cUser.role = query["role"].ToString();
                            Global.cUser.pw = query["pw"].ToString();
                            Global.cUser.email = query["email"].ToString();
                        }
                        Response.Redirect("movies.aspx");
                    }
                }
                catch (Exception ex)
                {

                    
                }



            }
        }
    }
}