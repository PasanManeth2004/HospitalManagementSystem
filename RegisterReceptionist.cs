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

namespace HospitalManagementSystem
{
    public partial class RegisterReceptionist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAMADHI;Initial Catalog=HMS_db;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter adapter1;
        SqlDataAdapter adapter2;
        DataTable dt1;
        DataTable dt2;
        private string userRole;

        public RegisterReceptionist(string userRole)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.userRole = userRole;
            InitializeComponent();
        }

        private void RegisterReceptionist_Load(object sender, EventArgs e)
        {
            LoadRcData();
            LoadUserData();

        }
        private void LoadRcData()
        {
            adapter1 = new SqlDataAdapter("SELECT * FROM Receptionist", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter1);
            dt1 = new DataTable();

            adapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter1.Fill(dt1);
            rcdata.DataSource = dt1;



            rcdata.Columns["Receptionist_ID"].ReadOnly = true;
            rcdata.Columns["User_ID"].ReadOnly = false;
        }

        private void LoadUserData()
        {
            adapter2 = new SqlDataAdapter("SELECT * FROM [User]", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter2);
            dt2 = new DataTable();

            adapter2.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter2.Fill(dt2);
            userdata.DataSource = dt2;



            userdata.Columns["User_ID"].ReadOnly = true;
        }

        private void rcdata_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            saveChanges(adapter1, dt1, rcdata);
        }

        private void rcdata_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            saveChanges(adapter1, dt1, rcdata);
        }

        private void userdata_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            saveChanges(adapter2, dt2, userdata);
        }

        private void userdata_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            saveChanges(adapter2, dt2, userdata);
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

                if (datagrid.Name == "rcdata")
                {
                    LoadRcData();
                }
                if (datagrid.Name == "userdata")
                {
                    LoadUserData();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch1.Text.Trim();
            DataView dv1 = dt1.DefaultView;

            if (string.IsNullOrEmpty(searchText))
            {
                dv1.RowFilter = string.Empty;
                rcdata.DataSource = dt1;
            }
            else
            {

                dv1.RowFilter = $"Convert(Receptionist_ID,'System.String') LIKE '%{searchText}%'";
                rcdata.DataSource = dv1;
            }
        }

        private void ApplyUserSearch()
        {
            List<string> filters = new List<string>();
            if (!string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                filters.Add($"Convert(User_ID,'System.String') LIKE '%{txtUserID.Text.Trim()}%'");
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
            DataView dv2 = dt2.DefaultView;
            if (filters.Count > 0)
            {
                dv2.RowFilter = string.Join("AND", filters);
            }
            else
            {
                dv2.RowFilter = string.Empty;
            }
            userdata.DataSource = dv2;
        }
        private void txtUserID_TextChanged(object sender, EventArgs e)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(userRole);
            dash.Show();
            this.Close();


        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadRcData();
            LoadUserData();
        }
    }
}
