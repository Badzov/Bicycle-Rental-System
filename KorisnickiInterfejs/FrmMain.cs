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
    public partial class FrmMain : Form
    {
        private MainController mainController;
        public FrmMain()
        {
            InitializeComponent();
            this.mainController = MainController.Instance;
            mainController.Init(this);
        }

        private void ibSignOut_Click(object sender, EventArgs e)
        {
            mainController.SignOut(this);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            mainController.Exit(this);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            mainController.Minimize(this);
        }

        private void ibNavicon_Click(object sender, EventArgs e)
        {
            mainController.CollapseMenu(this);
        }

        private void ibPoslovniPartneri_Click(object sender, EventArgs e)
        {
            mainController.PrikaziPoslovniPartneri(this);
        }

        private void ibHome_Click(object sender, EventArgs e)
        {
            mainController.PrikaziPocetna(this);
        }

        private void ibBicikle_Click(object sender, EventArgs e)
        {
            mainController.PrikaziBicikle(this);
        }

        private void ibIznajmljivanja_Click(object sender, EventArgs e)
        {
            mainController.PrikaziIznajmljivanja(this);
        }
    }
}
