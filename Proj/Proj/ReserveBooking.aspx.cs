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
    public partial class ReserveBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BophelongDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter;

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            book();
        }

        private void book()
        {
            try
            {
                con.Open();
                adapter = new SqlDataAdapter();

                command = new SqlCommand($"INSERT INTO Appointments(First_name, Last_name, Appointment_date, Appointment_time) VALUES('{txtName.Text}', '{Session["PatientSurname"]}', '{Calendar1.SelectedDate}', '{DropDownList1.SelectedItem}'", con);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                con.Close();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Booking Created Successfully');", true);

                if(Session["AdminID"] != null)
                {
                    Response.Redirect("AdminHome.aspx");
                }
            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred '" + ex.Message + "'');", true);
            }
        }
    }
}