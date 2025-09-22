using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class Login_Form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAMADHI;Initial Catalog=HMS_db;Integrated Security=True;TrustServerCertificate=True");
        //private object ChkShowPassword;

        public Login_Form()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_un.Clear();
            txt_pw.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_un.Text.Trim();
            string password = txt_pw.Text.Trim();
            string role = cmb_role.SelectedItem.ToString();
            

            string ConnectionString = "Data Source=SAMADHI;Initial Catalog=HMS_db;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {


                String query = "SELECT COUNT(*) FROM [User] WHERE User_Name=@username AND Password=@password AND Role=@role";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                cmd.Parameters.AddWithValue("@password", password);

                cmd.Parameters.AddWithValue("@role", role);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                if (count > 0)
                {
                    MessageBox.Show("Login Successful!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard d = new Dashboard(role);
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkpw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpw.Checked == true)
            {
                txt_pw.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pw.UseSystemPasswordChar = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_un_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
