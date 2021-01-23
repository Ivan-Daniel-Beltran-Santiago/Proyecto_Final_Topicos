using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Support.Cache;
using System.Windows.Forms;
using Dominio;

namespace ProyectoFinalTopicos
{
    public partial class FormRegister : Form
    {
        private UserModel registrar;

        public FormRegister()
        {
            InitializeComponent();
            var lTextBoxProfile = new List<TextBox>();
            lTextBoxProfile.Add(tbxUserName);
            lTextBoxProfile.Add(tbxNames);
            lTextBoxProfile.Add(tbxLastNames);
            lTextBoxProfile.Add(tbxEmail);
            lTextBoxProfile.Add(tbxPassword);
            lTextBoxProfile.Add(tbxConfirmPass);

            var lLabelProfile = new List<Label>();
            lLabelProfile.Add(lblUserName);
            lLabelProfile.Add(lblNames);
            lLabelProfile.Add(lblLastNames);
            lLabelProfile.Add(lblEmail);
            lLabelProfile.Add(lblPassword);
            lLabelProfile.Add(lblConfirmPass);

            Object[] objetos = { pbxImageProfile};

            registrar = new UserModel(lTextBoxProfile, lLabelProfile, objetos);
        }

        private void pbxImageProfile_Click(object sender, EventArgs e)
        {
            registrar.uImage.loadImage(pbxImageProfile);
        }

        private void tbxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            registrar.tbxEvent.textKeyPress(e);
        }

        private void tbxUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbxUserName.Text == "")
            {
                lblUserName.ForeColor = Color.White;
            }
            else
            {
                lblUserName.ForeColor = Color.Cyan;
                lblUserName.Text = "Nombre de usuario: ";
            }
        }

        private void tbxNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            registrar.tbxEvent.textKeyPress(e);
        }

        private void tbxNames_TextChanged(object sender, EventArgs e)
        {
            if (tbxNames.Text == "")
            {
                lblNames.ForeColor = Color.White;
            }
            else
            {
                lblNames.ForeColor = Color.Cyan;
                lblNames.Text = "Nombre de usuario: ";
            }
        }

        private void tbxLastNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            registrar.tbxEvent.textKeyPress(e);
        }

        private void tbxLastNames_TextChanged(object sender, EventArgs e)
        {
            if (tbxLastNames.Text == "")
            {
                lblLastNames.ForeColor = Color.White;
            }
            else
            {
                lblLastNames.ForeColor = Color.Cyan;
                lblLastNames.Text = "Nombre de usuario: ";
            }
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "")
            {
                lblEmail.ForeColor = Color.White;
            }
            else
            {
                lblEmail.ForeColor = Color.Cyan;
                lblEmail.Text = "Nombre de usuario: ";
            }
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            registrar.tbxEvent.numberKeyPress(e);
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                lblPassword.ForeColor = Color.White;
            }
            else
            {
                lblPassword.ForeColor = Color.Cyan;
                lblPassword.Text = "Nombre de usuario: ";
            }
        }

        private void tbxConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            registrar.tbxEvent.numberKeyPress(e);
        }

        private void tbxConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (tbxConfirmPass.Text == "")
            {
                lblConfirmPass.ForeColor = Color.White;
            }
            else
            {
                lblConfirmPass.ForeColor = Color.Cyan;
                lblConfirmPass.Text = "Nombre de usuario: ";
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            registrar.Register();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
