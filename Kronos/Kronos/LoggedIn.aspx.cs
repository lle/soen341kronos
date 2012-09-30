using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kronos
{
    public partial class LoggedIn : System.Web.UI.Page
    {
        public string Username_logged_in;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Username"] != null) { Username_logged_in = Request.QueryString["Username"]; }

        }
    }
}