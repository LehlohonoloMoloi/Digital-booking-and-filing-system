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
    public partial class DeletePatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BophelongDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                lblOutput.Text = "Patient ID found";
                Panel1.Visible = true;

            }
            else
            {
                lblOutput.Text = "Patient ID NOT found";
            }
        }

        public bool validate()
        {
            try
            {
                int patientID = int.Parse(txtPatientID.Text);
                int count = 0;
                con.Open();
                command = new SqlCommand($"SELECT COUNT(*) FROM File WHERE Username = {patientID}", con);
                count = (int)command.ExecuteScalar();
                con.Close();

                if (count == 0)
                {
                    return false;
                }
                else
                {
                    Session["PatientID"] = txtPatientID.Text;
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