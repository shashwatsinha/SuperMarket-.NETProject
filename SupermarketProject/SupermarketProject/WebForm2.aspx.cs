using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SupermarketProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SalesMenu.aspx");

          
        }
    }
}