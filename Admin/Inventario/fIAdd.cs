using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalTopicos.Admin.Inventario
{
    public partial class fIAdd : Form
    {
        private UserModel agregar;

        public fIAdd()
        {
            InitializeComponent();

            var lTextBoxProduct = new List<TextBox>();
            lTextBoxProduct.Add(tbxProductName);
            lTextBoxProduct.Add(tbxConsole);
            lTextBoxProduct.Add(tbxDescription);
            lTextBoxProduct.Add(tbxCantidad);
            lTextBoxProduct.Add(tbxPrice);

            var lLabelProduct = new List<Label>();
            lLabelProduct.Add(lblProductName);
            lLabelProduct.Add(lblConsole);
            lLabelProduct.Add(lblDescription);
            lLabelProduct.Add(lblCantidad);
            lLabelProduct.Add(lblPrice);

            agregar = new UserModel(lTextBoxProduct, lLabelProduct);
        }

        private void fIAdd_Load(object sender, EventArgs e)
        {

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (tbxProductName.Text == "")
            {
                lblProductName.ForeColor = Color.White;
            }
            else
            {
                lblProductName.ForeColor = Color.Cyan;
                lblProductName.Text = "Nombre del producto: ";
            }
        }

        private void tbxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            agregar.tbxEvent.textKeyPress(e);
        }

        private void tbxConsole_TextChanged(object sender, EventArgs e)
        {
            if (tbxConsole.Text == "")
            {
                lblConsole.ForeColor = Color.White;
            }
            else
            {
                lblConsole.ForeColor = Color.Cyan;
                lblConsole.Text = "Consola: ";
            }
        }

        private void tbxConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            agregar.tbxEvent.textKeyPress(e);
        }

        private void tbxDescription_TextChanged(object sender, EventArgs e)
        {
            if (tbxDescription.Text == "")
            {
                lblDescription.ForeColor = Color.White;
            }
            else
            {
                lblDescription.ForeColor = Color.Cyan;
                lblDescription.Text = "Descripción del producto: ";
            }
        }

        private void tbxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            agregar.tbxEvent.textKeyPress(e);
        }

        private void tbxCantidad_TextChanged(object sender, EventArgs e)
        {
            if (tbxCantidad.Text == "")
            {
                lblCantidad.ForeColor = Color.White;
            }
            else
            {
                lblCantidad.ForeColor = Color.Cyan;
                lblCantidad.Text = "Cantidad del producto: ";
            }
        }

        private void tbxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            agregar.tbxEvent.numberKeyPress(e);
        }

        private void tbxPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbxPrice.Text == "")
            {
                lblPrice.ForeColor = Color.White;
            }
            else
            {
                lblPrice.ForeColor = Color.Cyan;
                lblPrice.Text = "Precio del producto: ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar.Add();
        }
    }
}
