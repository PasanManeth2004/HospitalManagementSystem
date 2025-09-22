namespace HospitalManagementSystem
{
    partial class RegisterReceptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterReceptionist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.rcdata = new System.Windows.Forms.DataGridView();
            this.userdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 1055);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Exit.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(55, 570);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(131, 40);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Close";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.TextChanged += new System.EventHandler(this.btn_exit_Click);
            this.btn_Exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(55, 442);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(131, 40);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btnback_Click);
            // 
            // rcdata
            // 
            this.rcdata.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rcdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rcdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.rcdata.Location = new System.Drawing.Point(341, 127);
            this.rcdata.Name = "rcdata";
            this.rcdata.RowHeadersWidth = 51;
            this.rcdata.RowTemplate.Height = 24;
            this.rcdata.Size = new System.Drawing.Size(400, 600);
            this.rcdata.TabIndex = 1;
            this.rcdata.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.rcdata_RowValidated);
            this.rcdata.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.rcdata_UserDeletedRow);
            // 
            // userdata
            // 
            this.userdata.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.userdata.Location = new System.Drawing.Point(785, 127);
            this.userdata.Name = "userdata";
            this.userdata.RowHeadersWidth = 51;
            this.userdata.RowTemplate.Height = 24;
            this.userdata.Size = new System.Drawing.Size(1000, 600);
            this.userdata.TabIndex = 2;
            this.userdata.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdata_RowValidated);
            this.userdata.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.userdata_UserDeletedRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Receptionist";
            // 
            // txtSearch1
            // 
            this.txtSearch1.BackColor = System.Drawing.Color.Silver;
            this.txtSearch1.Location = new System.Drawing.Point(640, 89);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(101, 22);
            this.txtSearch1.TabIndex = 4;
            this.txtSearch1.TextChanged += new System.EventHandler(this.txtSearch1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Receptionist_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(805, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1033, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "User_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1221, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1428, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "NIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1635, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contact";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.Silver;
            this.txtUserID.Location = new System.Drawing.Point(1028, 89);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(145, 22);
            this.txtUserID.TabIndex = 11;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.Location = new System.Drawing.Point(1216, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 22);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.Silver;
            this.txtNIC.Location = new System.Drawing.Point(1432, 89);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(145, 22);
            this.txtNIC.TabIndex = 13;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Silver;
            this.txtContact.Location = new System.Drawing.Point(1639, 89);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(145, 22);
            this.txtContact.TabIndex = 14;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_refresh.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(1804, 26);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(108, 44);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // RegisterReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userdata);
            this.Controls.Add(this.rcdata);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterReceptionist";
            this.Text = "RegisterReceptionist";
            this.Load += new System.EventHandler(this.RegisterReceptionist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView rcdata;
        private System.Windows.Forms.DataGridView userdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_refresh;
    }
}