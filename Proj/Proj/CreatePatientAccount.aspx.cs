using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Proj
{
    public partial class CreatePatientAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BophelongDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter;


        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            create();
        }

        private void create()
        {
            try
            {
                con.Open();
                adapter = new SqlDataAdapter();

                command = new SqlCommand($"INSERT INTO PatientCredentials(Username, Password, Name) VALUES('{txtSurname.Text}', '{txtPassword.Text}', '{txtName.Text}'", con);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                con.Close();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Account Created Successfully');", true);

                Response.Redirect("PatientLogin.aspx");
            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred '" + ex.Message + "'');", true);
            }
        
        }
    }
}