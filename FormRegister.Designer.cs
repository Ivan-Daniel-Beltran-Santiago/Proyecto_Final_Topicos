namespace ProyectoFinalTopicos
{
    partial class FormRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxImageProfile = new System.Windows.Forms.GroupBox();
            this.pbxImageProfile = new System.Windows.Forms.PictureBox();
            this.lblChooseIP = new System.Windows.Forms.Label();
            this.lblCreateA = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxNames = new System.Windows.Forms.TextBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxLastNames = new System.Windows.Forms.TextBox();
            this.lblLastNames = new System.Windows.Forms.Label();
            this.tbxConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxImageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.gbxImageProfile);
            this.panel1.Controls.Add(this.lblChooseIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(650, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 375);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(140, 317);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(100, 35);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Confirmar";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxImageProfile
            // 
            this.gbxImageProfile.Controls.Add(this.pbxImageProfile);
            this.gbxImageProfile.Location = new System.Drawing.Point(10, 65);
            this.gbxImageProfile.Name = "gbxImageProfile";
            this.gbxImageProfile.Size = new System.Drawing.Size(230, 230);
            this.gbxImageProfile.TabIndex = 3;
            this.gbxImageProfile.TabStop = false;
            // 
            // pbxImageProfile
            // 
            this.pbxImageProfile.Image = global::ProyectoFinalTopicos.Properties.Resources._44948;
            this.pbxImageProfile.Location = new System.Drawing.Point(15, 15);
            this.pbxImageProfile.Name = "pbxImageProfile";
            this.pbxImageProfile.Size = new System.Drawing.Size(200, 200);
            this.pbxImageProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImageProfile.TabIndex = 0;
            this.pbxImageProfile.TabStop = false;
            this.pbxImageProfile.Click += new System.EventHandler(this.pbxImageProfile_Click);
            // 
            // lblChooseIP
            // 
            this.lblChooseIP.AutoSize = true;
            this.lblChooseIP.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseIP.ForeColor = System.Drawing.Color.White;
            this.lblChooseIP.Location = new System.Drawing.Point(24, 18);
            this.lblChooseIP.Name = "lblChooseIP";
            this.lblChooseIP.Size = new System.Drawing.Size(197, 28);
            this.lblChooseIP.TabIndex = 2;
            this.lblChooseIP.Text = "Perfil de Usuario";
            // 
            // lblCreateA
            // 
            this.lblCreateA.AutoSize = true;
            this.lblCreateA.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateA.ForeColor = System.Drawing.Color.White;
            this.lblCreateA.Location = new System.Drawing.Point(220, 18);
            this.lblCreateA.Name = "lblCreateA";
            this.lblCreateA.Size = new System.Drawing.Size(186, 28);
            this.lblCreateA.TabIndex = 1;
            this.lblCreateA.Text = "Crea tu cuenta";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(32, 57);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(162, 19);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Nombre de Usuario:";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUserName.Location = new System.Drawing.Point(36, 88);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(572, 27);
            this.tbxUserName.TabIndex = 3;
            this.tbxUserName.TextChanged += new System.EventHandler(this.tbxUserName_TextChanged);
            this.tbxUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUserName_KeyPress);
            // 
            // tbxNames
            // 
            this.tbxNames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNames.Location = new System.Drawing.Point(36, 164);
            this.tbxNames.Name = "tbxNames";
            this.tbxNames.Size = new System.Drawing.Size(260, 27);
            this.tbxNames.TabIndex = 5;
            this.tbxNames.TextChanged += new System.EventHandler(this.tbxNames_TextChanged);
            this.tbxNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNames_KeyPress);
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNames.ForeColor = System.Drawing.Color.White;
            this.lblNames.Location = new System.Drawing.Point(32, 133);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(95, 19);
            this.lblNames.TabIndex = 4;
            this.lblNames.Text = "Nombre(s):";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxEmail.Location = new System.Drawing.Point(36, 240);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(572, 27);
            this.tbxEmail.TabIndex = 7;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(32, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPassword.Location = new System.Drawing.Point(36, 317);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(260, 27);
            this.tbxPassword.TabIndex = 9;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(32, 286);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 19);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Contraseña:";
            // 
            // tbxLastNames
            // 
            this.tbxLastNames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastNames.Location = new System.Drawing.Point(348, 164);
            this.tbxLastNames.Name = "tbxLastNames";
            this.tbxLastNames.Size = new System.Drawing.Size(260, 27);
            this.tbxLastNames.TabIndex = 11;
            this.tbxLastNames.TextChanged += new System.EventHandler(this.tbxLastNames_TextChanged);
            this.tbxLastNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastNames_KeyPress);
            // 
            // lblLastNames
            // 
            this.lblLastNames.AutoSize = true;
            this.lblLastNames.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNames.ForeColor = System.Drawing.Color.White;
            this.lblLastNames.Location = new System.Drawing.Point(344, 133);
            this.lblLastNames.Name = "lblLastNames";
            this.lblLastNames.Size = new System.Drawing.Size(85, 19);
            this.lblLastNames.TabIndex = 10;
            this.lblLastNames.Text = "Apellidos:";
            // 
            // tbxConfirmPass
            // 
            this.tbxConfirmPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxConfirmPass.Location = new System.Drawing.Point(348, 317);
            this.tbxConfirmPass.Name = "tbxConfirmPass";
            this.tbxConfirmPass.Size = new System.Drawing.Size(260, 27);
            this.tbxConfirmPass.TabIndex = 13;
            this.tbxConfirmPass.TextChanged += new System.EventHandler(this.tbxConfirmPass_TextChanged);
            this.tbxConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxConfirmPass_KeyPress);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPass.Location = new System.Drawing.Point(344, 286);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(181, 19);
            this.lblConfirmPass.TabIndex = 12;
            this.lblConfirmPass.Text = "Confirmar contraseña:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Enabled = false;
            this.lblClient.Location = new System.Drawing.Point(461, 18);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 14;
            this.lblClient.Text = "Client";
            this.lblClient.Visible = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 375);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.tbxConfirmPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.tbxLastNames);
            this.Controls.Add(this.lblLastNames);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxNames);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCreateA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxImageProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChooseIP;
        private System.Windows.Forms.Label lblCreateA;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbxImageProfile;
        private System.Windows.Forms.PictureBox pbxImageProfile;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxNames;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxLastNames;
        private System.Windows.Forms.Label lblLastNames;
        private System.Windows.Forms.TextBox tbxConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblClient;
    }
}