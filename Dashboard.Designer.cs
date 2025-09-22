namespace HospitalManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_registerpatients = new System.Windows.Forms.Button();
            this.btn_tr = new System.Windows.Forms.Button();
            this.btn_mc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comborole = new System.Windows.Forms.ComboBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registerpatients
            // 
            this.btn_registerpatients.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_registerpatients.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registerpatients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registerpatients.Location = new System.Drawing.Point(1359, 139);
            this.btn_registerpatients.Name = "btn_registerpatients";
            this.btn_registerpatients.Size = new System.Drawing.Size(464, 81);
            this.btn_registerpatients.TabIndex = 0;
            this.btn_registerpatients.Text = "Register Patients";
            this.btn_registerpatients.UseVisualStyleBackColor = false;
            this.btn_registerpatients.Click += new System.EventHandler(this.btn_registerpatients_Click);
            // 
            // btn_tr
            // 
            this.btn_tr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_tr.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tr.Location = new System.Drawing.Point(1359, 307);
            this.btn_tr.Name = "btn_tr";
            this.btn_tr.Size = new System.Drawing.Size(464, 73);
            this.btn_tr.TabIndex = 1;
            this.btn_tr.Text = "Treatment Records";
            this.btn_tr.UseVisualStyleBackColor = false;
            this.btn_tr.Click += new System.EventHandler(this.btn_tr_Click);
            // 
            // btn_mc
            // 
            this.btn_mc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mc.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mc.Location = new System.Drawing.Point(1359, 483);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(464, 81);
            this.btn_mc.TabIndex = 2;
            this.btn_mc.Text = "Medical Records";
            this.btn_mc.UseVisualStyleBackColor = false;
            this.btn_mc.Click += new System.EventHandler(this.btn_mc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appointments";
            // 
            // comborole
            // 
            this.comborole.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborole.FormattingEnabled = true;
            this.comborole.Items.AddRange(new object[] {
            "Receptionist",
            "Admin",
            "Doctor"});
            this.comborole.Location = new System.Drawing.Point(119, 139);
            this.comborole.Name = "comborole";
            this.comborole.Size = new System.Drawing.Size(445, 47);
            this.comborole.TabIndex = 5;
            this.comborole.SelectedIndexChanged += new System.EventHandler(this.comborole_SelectedIndexChanged);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_register.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_register.Location = new System.Drawing.Point(119, 212);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(244, 61);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(103, 530);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(476, 76);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add Appointments";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_check.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_check.Location = new System.Drawing.Point(103, 659);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(476, 90);
            this.btn_check.TabIndex = 8;
            this.btn_check.Text = "Check Appointments";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(1582, 909);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(241, 82);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.comborole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mc);
            this.Controls.Add(this.btn_tr);
            this.Controls.Add(this.btn_registerpatients);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registerpatients;
        private System.Windows.Forms.Button btn_tr;
        private System.Windows.Forms.Button btn_mc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comborole;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_logout;
    }
}