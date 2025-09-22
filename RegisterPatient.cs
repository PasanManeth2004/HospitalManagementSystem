using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagementSystem
{
    public partial class RegisterPatient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAMADHI;Initial Catalog=HMS_db;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter adapter1;
        DataTable dt1;
        private string userRole;
        public RegisterPatient(string userRole)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.userRole = userRole;
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            LoadPatientData();
        }
        private void LoadPatientData()
        {
            adapter1 = new SqlDataAdapter("SELECT * FROM Patient", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter1);
            dt1 = new DataTable();

            adapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter1.Fill(dt1);
            patientdata.DataSource = dt1;



            patientdata.Columns["Patient_Id"].ReadOnly = true;

        }



        private void patientdata_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            saveChanges(adapter1, dt1, patientdata);
        }

        private void patientdata_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            saveChanges(adapter1, dt1, patientdata);
        }





        private void saveChanges(SqlDataAdapter adapter, DataTable table, DataGridView datagrid)
        {
            try
            {
                if (adapter != null && table != null)
                {
                    datagrid.EndEdit();
                    adapter.Update(table);
                }
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Concurrency Exception, refreshing....");

                if (datagrid.Name == "patientdata")
                {
                    LoadPatientData();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
        }


        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ApplyUserSearch()
        {
            List<string> filters = new List<string>();
            if (!string.IsNullOrWhiteSpace(txtPatientID.Text))
            {
                filters.Add($"Convert(Patient_ID,'System.String') LIKE '%{txtPatientID.Text.Trim()}%'");
            }

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                filters.Add($"Name LIKE '%{txtName.Text.Trim()}%'");
            }

            if (!string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                filters.Add($"NIC LIKE '%{txtNIC.Text.Trim()}%'");
            }
            if (!string.IsNullOrWhiteSpace(txtContact.Text))
            {
                filters.Add($"Contact LIKE '%{txtContact.Text.Trim()}%'");
            }
            DataView dv1 = dt1.DefaultView;
            if (filters.Count > 0)
            {
                dv1.RowFilter = string.Join("AND", filters);
            }
            else
            {
                dv1.RowFilter = string.Empty;
            }
            patientdata.DataSource = dv1;
        }
        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            ApplyUserSearch();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ApplyUserSearch();
        }
        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            ApplyUserSearch();
        }
        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            ApplyUserSearch();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(userRole);
            dash.Show();
            this.Close();

        }
    }
}


    

