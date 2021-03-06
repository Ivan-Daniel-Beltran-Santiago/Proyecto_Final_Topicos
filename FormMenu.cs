﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Support.Cache;

namespace ProyectoFinalTopicos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            security();
        }

        #region Funciones del formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pContainer.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro de querer cerrar la aplicación?", "Advertencia", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

        private void pTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxRestore_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            pbxMax.Visible = true;
            pbxRestore.Visible = false;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenForm<fVentas>();
            btnSales.BackColor = Color.Cyan;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenForm<fInventario>();
            btnInventory.BackColor = Color.Cyan;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenForm<fProductos>();
            btnProducts.BackColor = Color.Cyan;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenForm<fUsuarios>();
            btnUsers.BackColor = Color.Cyan;
        }

        private void pbxMax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pbxMax.Visible = false;
            pbxRestore.Visible = true;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenForm<fCuenta>();
            btnAccount.BackColor = Color.Cyan;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de querer cerrar sesión?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void security()
        {
            var userModel = new UserModel();
            if (userModel.securityLogin() == false)
            {
                MessageBox.Show("Error Fatal, se detectó que está intentando acceder al sistema sin credenciales, por favor inicie sesión e indentifiquese");
                Application.Exit();
            }
        }

        private void OpenForm<MyForm>()where MyForm : Form, new()
        {
            Form formulario;
            formulario = pForms.Controls.OfType<MyForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MyForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pForms.Controls.Add(formulario);
                pForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            LoadUserData();
            if (UserLoginCache.Position == Cargos.Administrator)
            {

            }
            if (UserLoginCache.Position == Cargos.Client)
            {
                btnSales.Enabled = false;
                btnSales.Visible = false;
                btnInventory.Enabled = false;
                btnInventory.Enabled = false;
                btnProducts.Enabled = false;
                btnUsers.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de querer cerrar sesión?", "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["fVentas"] == null)
            {
                btnSales.BackColor = Color.MidnightBlue;
            }
            if (Application.OpenForms["fInventario"] == null)
            {
                btnInventory.BackColor = Color.MidnightBlue;
            }
            if (Application.OpenForms["fProductos"] == null)
            {
                btnProducts.BackColor = Color.MidnightBlue;
            }
            if (Application.OpenForms["fUsuarios"] == null)
            {
                btnUsers.BackColor = Color.MidnightBlue;
            }
            if (Application.OpenForms["fCuenta"] == null)
            {
                btnAccount.BackColor = Color.MidnightBlue;
            }
        }

        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName + ", " + UserLoginCache.LastName;
            lblPosition.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
        }
    }
}
