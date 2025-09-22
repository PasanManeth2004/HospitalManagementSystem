using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Dashboard : Form
    {
        private string userRole;
        public Dashboard(string role)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            userRole = role;
        }

        private void btn_registerpatients_Click(object sender, EventArgs e)
        {
            RegisterPatient p = new RegisterPatient(userRole);
            this.Hide();
            p.Show();
        }

        private void btn_tr_Click(object sender, EventArgs e)
        {
            Treatmentrecord tr = new Treatmentrecord(userRole);
            this.Hide();
            tr.Show();
        }

        private void btn_mc_Click(object sender, EventArgs e)
        {
            Medicalrecord mc = new Medicalrecord(userRole);
            this.Hide();
            mc.Show();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Addappointment aapp = new Addappointment(userRole);
            this.Hide();
            aapp.Show();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            Checkappointment capp = new Checkappointment(userRole);
            this.Hide();
            capp.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            int index = comborole.SelectedIndex;

            if (index == 0)
            {
                RegisterReceptionist r = new RegisterReceptionist(userRole);
                this.Hide();
                r.Show();
            }
            else if (index == 1)
            {
                RegisterAdmin a = new RegisterAdmin(userRole);
                this.Hide();
                a.Show();


            }
            else if (index == 2)
            {
                Registerdoctor d = new Registerdoctor(userRole);
                this.Hide();
                d.Show();
            }

        }

        private void comborole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            if (userRole == "Doctor")
            {
                btn_register.Enabled = false;
                btn_add.Enabled = false;
                btn_check.Enabled = true;
                btn_registerpatients.Enabled = false;
                btn_mc.Enabled = true;
                btn_tr.Enabled = true;
                btn_logout.Enabled = true;
            }
            else if (userRole == "Admin")
            {
                btn_register.Enabled = true;
                btn_add.Enabled = true;
                btn_check.Enabled = true;
                btn_registerpatients.Enabled = true;
                btn_mc.Enabled = false;
                btn_tr.Enabled = false;
                btn_logout.Enabled = true;

            }
            else if (userRole == "Receptionist")
            {
                btn_register.Enabled = false;
                btn_add.Enabled = true;
                btn_check.Enabled = true;
                btn_registerpatients.Enabled = true;
                btn_mc.Enabled = false;
                btn_tr.Enabled = false;
                btn_logout.Enabled = true;

            }
        }
    }
}
