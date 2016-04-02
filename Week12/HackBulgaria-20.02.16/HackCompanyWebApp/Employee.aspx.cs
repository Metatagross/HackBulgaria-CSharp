using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HackCompanyWebApp
{
    public partial class Employee1 : System.Web.UI.Page
    {
        public HackCompanyEntities dbHack;
        protected void Page_Load ( object sender , EventArgs e )
        {
             dbHack= new HackCompanyEntities();
        }
    }
}