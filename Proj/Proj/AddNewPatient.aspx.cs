using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Proj\\And we are within Sire!!!!!!!!!!!!!!!!!!!!!!
{
    public partial class AddNewPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BophelongDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;

        protected void btnAddPatient_Click(object sender, EventArgs e)
        {
            addNewPatient();
        }

        private void addNewPatient()
        {
            try
            {

                con.Open();
                adapter = new SqlDataAdapter();

                command = new SqlCommand($"INSERT INTO Patient(First_name, Last_name, ID_number, Contact_number, Email_address, House_number, Street_name, Postal_code) VALUES('{txtPatientName.Text}', '{txtPatientSurname.Text}', '{txtPatientID.Text}', '{txtContactNumber.Text}', '{txtEmailAddress.Text}', '{txtPatientHouseNumber.Text}', '{txtPatientStreetName.Text}', '{txtPatientPostalCode.Text}')", con);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                con.Close();





                Response.Redirect("PatientsAndFiles.aspx");

            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred '" + ex.Message + "'');", true);

            }
        }
    }
}
