namespace ProyectoFinalTopicos
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pLogo = new System.Windows.Forms.Panel();
            this.lLCreateAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LlLostPass = new System.Windows.Forms.LinkLabel();
            this.lblMError = new System.Windows.Forms.Label();
            this.pbxMin = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(196)))));
            this.pLogo.Controls.Add(this.lLCreateAccount);
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(250, 350);
            this.pLogo.TabIndex = 0;
            this.pLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pLogo_MouseDown);
            // 
            // lLCreateAccount
            // 
            this.lLCreateAccount.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(196)))));
            this.lLCreateAccount.AutoSize = true;
            this.lLCreateAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLCreateAccount.LinkColor = System.Drawing.Color.White;
            this.lLCreateAccount.Location = new System.Drawing.Point(2, 283);
            this.lLCreateAccount.Name = "lLCreateAccount";
            this.lLCreateAccount.Size = new System.Drawing.Size(245, 18);
            this.lLCreateAccount.TabIndex = 11;
            this.lLCreateAccount.TabStop = true;
            this.lLCreateAccount.Text = "¿Es su primera vez con nosotros?";
            this.lLCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLCreateAccount_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoFinalTopicos.Properties.Resources.plantilla_logotipo_tema_tienda_videojuegos___copia;
            this.pictureBox1.Location = new System.Drawing.Point(5, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(300, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 3);
            this.panel1.TabIndex = 1;
            // 
            // tbxUser
            // 
            this.tbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUser.ForeColor = System.Drawing.Color.White;
            this.tbxUser.Location = new System.Drawing.Point(300, 77);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(400, 26);
            this.tbxUser.TabIndex = 1;
            this.tbxUser.Text = "USUARIO:";
            this.tbxUser.Enter += new System.EventHandler(this.tbxUser_Enter);
            this.tbxUser.Leave += new System.EventHandler(this.tbxUser_Leave);
            // 
            // tbxPass
            // 
            this.tbxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPass.ForeColor = System.Drawing.Color.White;
            this.tbxPass.Location = new System.Drawing.Point(300, 158);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(400, 26);
            this.tbxPass.TabIndex = 2;
            this.tbxPass.Text = "CONTRASEÑA:";
            this.tbxPass.Enter += new System.EventHandler(this.tbxPass_Enter);
            this.tbxPass.Leave += new System.EventHandler(this.tbxPass_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(300, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 3);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(300, 265);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LlLostPass
            // 
            this.LlLostPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(196)))));
            this.LlLostPass.AutoSize = true;
            this.LlLostPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LlLostPass.LinkColor = System.Drawing.Color.White;
            this.LlLostPass.Location = new System.Drawing.Point(402, 320);
            this.LlLostPass.Name = "LlLostPass";
            this.LlLostPass.Size = new System.Drawing.Size(197, 16);
            this.LlLostPass.TabIndex = 0;
            this.LlLostPass.TabStop = true;
            this.LlLostPass.Text = "¿Ha olvidado su contraseña?";
            this.LlLostPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlLostPass_LinkClicked);
            // 
            // lblMError
            // 
            this.lblMError.AutoSize = true;
            this.lblMError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMError.ForeColor = System.Drawing.Color.White;
            this.lblMError.Location = new System.Drawing.Point(300, 220);
            this.lblMError.Name = "lblMError";
            this.lblMError.Size = new System.Drawing.Size(113, 20);
            this.lblMError.TabIndex = 10;
            this.lblMError.Text = "Error Message";
            this.lblMError.Visible = false;
            // 
            // pbxMin
            // 
            this.pbxMin.BackColor = System.Drawing.Color.Transparent;
            this.pbxMin.Image = global::ProyectoFinalTopicos.Properties.Resources.kisspng_computer_icons_window_free_files_minimize_5ab137710e9725_5982463615215635050598;
            this.pbxMin.Location = new System.Drawing.Point(668, 10);
            this.pbxMin.Name = "pbxMin";
            this.pbxMin.Size = new System.Drawing.Size(32, 32);
            this.pbxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMin.TabIndex = 9;
            this.pbxMin.TabStop = false;
            this.pbxMin.Click += new System.EventHandler(this.pbxMin_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.BackColor = System.Drawing.Color.Transparent;
            this.pbxClose.Image = global::ProyectoFinalTopicos.Properties.Resources.images__1_;
            this.pbxClose.Location = new System.Drawing.Point(708, 10);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(32, 32);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 8;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.lblMError);
            this.Controls.Add(this.pbxMin);
            this.Controls.Add(this.pbxClose);
            this.Controls.Add(this.LlLostPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel LlLostPass;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMError;
        private System.Windows.Forms.LinkLabel lLCreateAccount;
    }
}

