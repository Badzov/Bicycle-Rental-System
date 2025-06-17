using KorisnickiInterfejs.GUIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;

        public FrmLogin()
        {
            InitializeComponent();
            loginController = LoginController.Instance;
            loginController.Init(this);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            loginController.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            loginController.Minimize(this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            loginController.Registruj(this);
        }

        private void checkbxShow_CheckedChanged(object sender, EventArgs e)
        {
            loginController.PrikaziSifru(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginController.PrijaviAutomat(this);
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                
            }
        }
    }
}
