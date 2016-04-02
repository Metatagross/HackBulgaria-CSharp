using System;


namespace ClickCounter
{
    public partial class ClickCounter : System.Web.UI.Page
    {
        protected void Page_Load ( object sender , EventArgs e )
        {

        }

        protected void btnClick_OnClick ( object sender , EventArgs e )
        {
            Application[String.Format($"{Session["Username"]}Clicks")] = (int)Application[String.Format($"{Session["Username"]}Clicks")] + 1;
            Application["TotalClicks"] = (int)Application["TotalClicks"] + 1;
        }
    }
}