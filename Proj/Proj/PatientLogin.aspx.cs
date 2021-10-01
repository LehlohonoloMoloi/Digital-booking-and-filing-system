using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Proj
{
    public partial class PatientLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BophelongDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                
                Response.Redirect("ReserveBooking.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred ');", true);
            }


        }

        public bool validate()
        {
            try
            {
                int count = 0;
                con.Open();
                command = new SqlCommand($"SELECT COUNT(*) FROM PatientCredentials WHERE Username = '{txtPatientUsername.Text}' AND Password = '{txtPatientPassword.Text}'", con);
                count = (int)command.ExecuteScalar();
                con.Close();

                if(count == 0)
                {
                    return false;
                }
                else
                {
                    Session["PatientSurname"] = txtPatientUsername.Text;
                    return true;
                }
            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred '" + ex.Message + "'');", true);
                
            }

            return false;
        }
    }
}