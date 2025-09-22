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
    public partial class Checkappointment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAMADHI;Initial Catalog=HMS_db;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter adapter1;
        DataTable dt1;
        private string userRole;
        public Checkappointment(string userRole)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.userRole = userRole;
        }

        private void Checkappointment_Load(object sender, EventArgs e)
        {
            LoadAppointmentData();
        }
        private void LoadAppointmentData()
        {
            adapter1 = new SqlDataAdapter("SELECT * FROM Appointment", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter1);
            dt1 = new DataTable();

            adapter1.Fill(dt1);
            appointmentdata.DataSource = dt1;



            appointmentdata.ReadOnly = true;
            appointmentdata.AllowUserToAddRows = false;
            appointmentdata.AllowUserToDeleteRows = false;

            appointmentdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentdata.MultiSelect = false;

        }     
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ApplyUserSearch()
        {
            List<string> filters = new List<string>();
            if (!string.IsNullOrWhiteSpace(txtPatientID.Text))
            {
                filters.Add($"Convert(Patient_Id,'System.String') LIKE '%{txtPatientID.Text.Trim()}%'");
            }

            if (!string.IsNullOrWhiteSpace(txtDate.Text))
            {
                filters.Add($"Convert(Date,'System.String') LIKE '%{txtDate.Text.Trim()}%'");
            }

            if (!string.IsNullOrWhiteSpace(txtDoctorID.Text))
            {
                filters.Add($"Convert(Doctor_ID,'System.String') LIKE '%{txtDoctorID.Text.Trim()}%'");
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
            appointmentdata.DataSource = dv1;
        }
        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            ApplyUserSearch();
        }
        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            ApplyUserSearch();
        }
        private void txtDoctorID_TextChanged(object sender, EventArgs e)
        {
            ApplyUserSearch();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(userRole);
            dash.Show();
            this.Close();
        }
    }
}
    

