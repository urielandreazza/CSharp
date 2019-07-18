using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrielAndreazzaAssignment2
{
    public partial class recepit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbMovie.Text = Global.cUser.movie;
            lbDay.Text = Global.cUser.time;
            lbTime.Text = Global.cUser.day;

            lbGADesc.Text += "(" + Global.cUser.generalQnt + "x)";
            lbGA.Text = string.Format("$ {0:F2}", (Global.cUser.generalQnt * Global.cUser.generalPrice));

            lbSCDesc.Text += "(" + Global.cUser.seniorAndChildrenQnt + "x)";
            lbSC.Text = string.Format("$ {0:F2}", (Global.cUser.seniorAndChildrenQnt * Global.cUser.seniorAndChildrenPrice));


            lbCost.Text = string.Format("$ {0:F2}", (Global.cUser.seniorAndChildrenQnt * Global.cUser.seniorAndChildrenPrice) + (Global.cUser.generalQnt * Global.cUser.generalPrice));
            lbDisc.Text = string.Format("$ {0:F2}", Global.cUser.discount);
            lbTotal.Text = string.Format("$ {0:F2}", (Global.cUser.seniorAndChildrenQnt * Global.cUser.seniorAndChildrenPrice) + (Global.cUser.generalQnt * Global.cUser.generalPrice) - Global.cUser.discount);

        }
    }
}