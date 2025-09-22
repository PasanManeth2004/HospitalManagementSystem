using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class RegisterAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAMADHI;Initial Catalog=HMS_db;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter adapter1;
        SqlDataAdapter adapter2;
        DataTable dt1;
        DataTable dt2;
        private string userRole;

        public RegisterAdmin(string userRole)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.userRole = userRole;

            InitializeComponent();
        }

        private void RegisterAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminData();
            LoadUserData();

        }

        private void LoadAdminData()
        {
            adapter1 = new SqlDataAdapter("SELECT * FROM Admin", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter1);
            dt1 = new DataTable();

            adapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter1.Fill(dt1);
            admindata.DataSource = dt1;



            admindata.Columns["Admin_ID"].ReadOnly = true;
            admindata.Columns["User_ID"].ReadOnly = false;
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

        private void admindata_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            saveChanges(adapter1, dt1, admindata);
        }

        private void admindata_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            saveChanges(adapter1, dt1, admindata);
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

                if (datagrid.Name == "admindata")
                {
                    LoadAdminData();
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
                admindata.DataSource = dt1;
            }
            else
            {

                dv1.RowFilter = $"Convert(Admin_ID,'System.String') LIKE '%{searchText}%'";
                admindata.DataSource = dv1;
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

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadAdminData();
            LoadUserData();
        }
    }

    
    
}
