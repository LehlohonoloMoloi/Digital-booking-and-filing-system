using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBookings_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookingsHome.aspx");
        }

        protected void btnPatients_Click(object sender, EventArgs e)
        {
            Response.Redirect("Patients.aspx");
        }
    }
}