using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Admin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ctUsuarioLogin_Enter(object sender, EventArgs e)
        {
            if (ctUsuarioLogin.Text == "Usuario")
            {
                ctUsuarioLogin.Text = "";
                ctUsuarioLogin.ForeColor = Color.LightGray;
            }
        }

        private void ctUsuarioLogin_Leave(object sender, EventArgs e)
        {
            if (ctUsuarioLogin.Text == "")
            {
                ctUsuarioLogin.Text = "Usuario";
                ctUsuarioLogin.ForeColor = Color.Silver;
            }
        }

        private void ctContrasenaLogin_Enter(object sender, EventArgs e)
        {
            if (ctContrasenaLogin.Text == "Contraseña")
            {
                ctContrasenaLogin.Text = "";
                ctContrasenaLogin.ForeColor = Color.LightGray;
                ctContrasenaLogin.UseSystemPasswordChar = true;
            }

        }

        private void ctContrasenaLogin_Leave(object sender, EventArgs e)
        {
            if (ctContrasenaLogin.Text == "")
            {
                ctContrasenaLogin.Text = "Contraseña";
                ctContrasenaLogin.ForeColor = Color.Silver;
                ctContrasenaLogin.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
