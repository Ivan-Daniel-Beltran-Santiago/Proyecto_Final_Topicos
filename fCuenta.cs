using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Support.Cache;
using Dominio;

namespace ProyectoFinalTopicos
{
    public partial class fCuenta : Form
    {
        private UserModel imagenes = new UserModel();

        public fCuenta()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fCuenta_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializeEditPassControls();
        }

        private void loadUserData()
        {
            lblShowUN.Text = UserLoginCache.LoginName;
            lblShowN.Text = UserLoginCache.FirstName;
            lblShowLN.Text = UserLoginCache.LastName;
            lblShowE.Text = UserLoginCache.Email;

            tbxEditUserName.Text = UserLoginCache.LoginName;
            tbxEditName.Text = UserLoginCache.FirstName;
            tbxEditLastName.Text = UserLoginCache.LastName;
            tbxEditEmail.Text = UserLoginCache.Email;
            tbxPassword.Text = UserLoginCache.Password;
            tbxConfirmPass.Text = UserLoginCache.Password;
            tbxActualPass.Text = "";
        }

        private void initializeEditPassControls()
        {
            lLabelEditPass.Text = "Editar";
            tbxPassword.Enabled = false;
            tbxPassword.UseSystemPasswordChar = true;
            tbxConfirmPass.Enabled = false;
            tbxConfirmPass.UseSystemPasswordChar = true;
        }

        private void reset()
        {
            loadUserData();
            initializeEditPassControls();
        }

        private void lLabelEditP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pEdit.Visible = true;
            loadUserData();
        }

        private void lLabelEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lLabelEditPass.Text == "Editar")
            {
                lLabelEditPass.Text = "Cancelar";
                tbxPassword.Enabled = true;
                tbxPassword.Text = "";
                tbxConfirmPass.Enabled = true;
                tbxConfirmPass.Text = "";
            }
            else if (lLabelEditPass.Text == "Cancelar")
            {
                reset();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text.Length >= 5)
            {
                if (tbxPassword.Text == tbxConfirmPass.Text)
                {
                    if (tbxActualPass.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(idUser: UserLoginCache.IDUser,
                            loginName: tbxEditUserName.Text, password: tbxPassword.Text,
                            firstName: tbxEditName.Text, lastName: tbxEditLastName.Text,
                            position: null, email: tbxEditEmail.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        pEdit.Visible = false;
                    }
                    else MessageBox.Show("contraseña actual incorrecta. Por favor, inténtelo de nuevo");
                }
                else MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo");
            }
            else MessageBox.Show("La contraseña debe tener un mínimo de 5 caracteres");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pEdit.Visible = false;
            reset();
        }

        private void pbxCurrentIP_Click(object sender, EventArgs e)
        {
            imagenes.uImage.loadImage(pbxCurrentIP);
        }

        private void tbxConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
