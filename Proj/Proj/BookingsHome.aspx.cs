using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj
{
    public partial class BookingsHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReserveBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientLogin.aspx");
        }
    }
}