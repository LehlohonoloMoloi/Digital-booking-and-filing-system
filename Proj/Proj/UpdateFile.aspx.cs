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
    public partial class UpdateFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlDataReader datareader;


        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BophelongDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                lblOutput.Text = "Patient ID  found";
                Panel1.Visible = true;
            }
            else
            {
                lblOutput.Text = "Patient ID not found";
            }
        }

        private void updatePatient()
        {
            try
            {
                string sortPatients = "Ascending";
                if (Session["SortPatients"] != null)
                {
                    sortPatients = Session["SortPatients"].ToString();
                }

                con.Open();
                adapter = new SqlDataAdapter();

                command = new SqlCommand($"UPDATE File SET Record = '{txtRecord.Text}' WHERE Patient_ID = {int.Parse(Session["PatientID"].ToString())}", con);
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();

                con.Close();

                Response.Redirect("PatientsAndFiles.aspx");
            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred '" + ex.Message + "'');", true);

            }
        }

        public bool validate()
        {
            try
            {
                int count = 0;
                con.Open();
                command = new SqlCommand($"SELECT COUNT(*) FROM File WHERE Username = {int.Parse(txtPatientID.Text)}", con);
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePatient();

            Response.Redirect("PatientsAndFiles.aspx");
        }
    }
}