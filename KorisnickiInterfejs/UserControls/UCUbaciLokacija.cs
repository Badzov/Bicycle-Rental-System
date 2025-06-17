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

namespace KorisnickiInterfejs.UserControls
{
    public partial class UCUbaciLokacija : UserControl
    {
        private UbaciLokacijaController ubaciLokacijaController;
        internal UserControlDialog frmDialog;

        public UCUbaciLokacija(UserControlDialog frmDialog)
        {
            this.frmDialog = frmDialog;
            this.ubaciLokacijaController = UbaciLokacijaController.Instance;
            InitializeComponent();
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            ubaciLokacijaController.UbaciLokacija(this, frmDialog);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            ubaciLokacijaController.Close(this, frmDialog);
        }
    }
}
