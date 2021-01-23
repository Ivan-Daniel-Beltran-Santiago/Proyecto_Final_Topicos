using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Support.Cache;

namespace ProyectoFinalTopicos
{
    public partial class FormLogin : Form
    {
        private UserModel login;

        public FormLogin()
        {
            InitializeComponent();
            login = new UserModel();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void tbxUser_Enter(object sender, EventArgs e)
        {
            if (tbxUser.Text == "USUARIO:")
            {
                tbxUser.Text = "";
                tbxUser.ForeColor = Color.LightGray;
            }
        }

        private void tbxUser_Leave(object sender, EventArgs e)
        {
            if (tbxUser.Text == "")
            {
                tbxUser.Text = "USUARIO:";
                tbxUser.ForeColor = Color.White;
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUser.Text != "USUARIO:") 
            {
                if (tbxPass.Text != "CONTRASEÑA:")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(tbxUser.Text, tbxPass.Text);
                    if (validLogin == true)
                    {
                        FormMenu mainMenu = new FormMenu();
                        MessageBox.Show("Bienvenido " + UserLoginCache.FirstName + ", " + UserLoginCache.LastName);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                        tbxPass.Text = "Password";
                        tbxPass.UseSystemPasswordChar = false;
                        tbxUser.Focus();
                    }
                }
                else msgError("Por favor, ingresa la contraseña.");
            }
            else msgError("Por favor, ingresa el nombre de usuario.");
        }

        private void msgError(string msg)
        {
            lblMError.Text = " " + msg;
            lblMError.Visible = true;
        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            if (tbxPass.Text == "CONTRASEÑA:")
            {
                tbxPass.Text = "";
                tbxPass.ForeColor = Color.LightGray;
                tbxPass.UseSystemPasswordChar = true;
            }
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (tbxPass.Text == "")
            {
                tbxPass.Text = "CONTRASEÑA:";
                tbxPass.ForeColor = Color.LightGray;
                tbxPass.UseSystemPasswordChar = false;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            tbxPass.Text = "CONTRASEÑA:";
            tbxPass.UseSystemPasswordChar = false;
            tbxUser.Text = "USUARIO:";
            lblMError.Visible = false;
            this.Show();
            //tbxUser.Focus();
        }

        private void LlLostPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPass = new FormRecoverPass();
            recoverPass.ShowDialog();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lLCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var createProfile = new FormRegister();
            createProfile.ShowDialog();
        }
    }
}
