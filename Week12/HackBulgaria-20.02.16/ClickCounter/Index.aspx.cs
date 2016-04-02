using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickCounter
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load ( object sender , EventArgs e )
        {

        }
        protected void btnSub_OnClick(object sender, EventArgs e)
        {
            Session["Username"] = txtBox.Text;
            Application[String.Format($"{txtBox.Text}Clicks")] = 0;
            Response.Redirect("ClickCounter.aspx");
        }

        protected void txtBox_TextChanged ( object sender , EventArgs e )
        {

        }
    }
}