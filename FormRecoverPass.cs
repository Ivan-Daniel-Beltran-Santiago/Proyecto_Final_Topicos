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
    public partial class FormRecoverPass : Form
    {
        public FormRecoverPass()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var user = new UserModel(idUser: UserLoginCache.IDUser, loginName: tbxURequest.Text,
                password: null, firstName: null, lastName: null, position: null, email: tbxURequest.Text);
            var result = user.recoverPass(tbxURequest.Text);
            lblResult.Text = "Resultado: " + result;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbxURequest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
