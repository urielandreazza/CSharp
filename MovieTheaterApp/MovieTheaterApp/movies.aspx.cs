using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrielAndreazzaAssignment2
{
    public partial class movies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){ 
            welcomeLabel.Text = "Hello! " + Global.cUser.fname;

            if (Global.cUser.role != "admin") {

                adminLink.Text = "";
                adminLink.NavigateUrl = "#";
            }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("recepit.aspx");
        }

        protected void HyperLink1_PreRender(object sender, EventArgs e)
        {

        }

        protected void ddSC_SelectedIndexChanged(object sender, EventArgs e)
        {


            Global.cUser.seniorAndChildrenQnt = Convert.ToInt32(ddSC.Text);
            Global.cUser.seniorAndChildrenPrice = 5;

            Global.cUser.seniorAndChildren = Global.cUser.seniorAndChildrenPrice * Global.cUser.seniorAndChildrenQnt;

            double total = (Global.cUser.general + Global.cUser.seniorAndChildren);
            double discount;
            if (Global.cUser.role == "admin" || Global.cUser.role == "user")
            {
                discount = (total * 0.20f);
            }
            else
            {
                discount = 0.00f;
            }

            Global.cUser.time = tbDate.Text;
            Global.cUser.day = timePicker.Text;

            Global.cUser.discount = discount;

            string.Format("$ {0:F2}", total - discount);

            lbTotal.Text = string.Format("$ {0:F2}", total - discount);
            lbTotalDiscount.Text = string.Format("$ {0:F2}", discount);
        }

        protected void ddGA_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTime sessionDay = Convert.ToDateTime(tbDate.Text);

            Global.cUser.generalQnt = Convert.ToInt32(ddGA.Text);

            if (sessionDay.DayOfWeek.ToString() == "Tuesday")
            {
                Global.cUser.generalPrice = 5;
            } else
            {
                Global.cUser.generalPrice = 15;
            }


            Global.cUser.general = Global.cUser.generalPrice * Global.cUser.generalQnt;

            double total = (Global.cUser.general + Global.cUser.seniorAndChildren);
            double discount;
            if (Global.cUser.role == "admin" || Global.cUser.role == "user")
            {
                discount = (total * 0.20f);
            }
            else
            {
                discount = 0.00f;
            }

            Global.cUser.time = tbDate.Text;
            Global.cUser.day = timePicker.Text;

            Global.cUser.discount = discount;

            lbTotal.Text = string.Format("$ {0:F2}", total - discount);
            lbTotalDiscount.Text = string.Format("$ {0:F2}", discount);
        }

        
    }
}