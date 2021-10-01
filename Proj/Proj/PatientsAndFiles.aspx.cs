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
    public partial class PatientsAndFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayPatients();
            displayFiles();

            DateTime date = DateTime.Today;
            lblTimeStamp.Text = date.ToShortDateString() + " " + date.ToShortTimeString();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BophelongDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;

        private void displayPatients()
        {
            try
            {
                string sortPatients = "Ascending";
                if(Session["SortPatients"] != null)
                {
                    sortPatients = Session["SortPatients"].ToString();
                }

                con.Open();
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                command = new SqlCommand($"SELECT * FROM Patient ORDER BY Patient_ID' {sortPatients}'", con);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Patients");

                gvPatients.DataSource = ds;
                gvPatients.DataBind();

                con.Close();

            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred '" + ex.Message + "'');", true);

            }
        }

        private void displayFiles()
        {
            try
            {
                string sortFiles = "Ascending";
                if (Session["SortFiles"] != null)
                {
                    sortFiles = Session["SortFiles"].ToString();
                }

                con.Open();
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                command = new SqlCommand($"SELECT * FROM File ORDER BY Patient_ID '{sortFiles}'", con);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "Files");

                gvPatients.DataSource = ds;
                gvPatients.DataBind();

                con.Close();

            }
            catch (SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Error: An error occurred '" + ex.Message + "'');", true);

            }
        }

        protected void rbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbPatients.SelectedItem.ToString() == "Ascending")
            {
                Session["SortPatients"] = "Ascending";
            }
            if(rbPatients.SelectedItem.ToString() == "Descending")
            {
                Session["Sort"] = "Descending";
            }
        }

        protected void rbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbFiles.SelectedItem.ToString() == "Ascending")
            {
                Session["SortFiles"] = "Ascending";
            }
            if (rbFiles.SelectedItem.ToString() == "Descending")
            {
                Session["SortFiles"] = "Descending";
            }
        }
    }
}