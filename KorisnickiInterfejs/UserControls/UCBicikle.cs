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
    public partial class UCBicikle : UserControl
    {
        private BicikleController bicikleController;
        public UCBicikle()
        {
            InitializeComponent();
            this.bicikleController = BicikleController.Instance;
            bicikleController.Init(this);
        }

        private void dgvBicikle_SelectionChanged(object sender, EventArgs e)
        {
            bicikleController.SelectionChanged(this);
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            bicikleController.Ubaci(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            bicikleController.Pretrazi(this);
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            bicikleController.Promeni(this);
        }

        private void brnObrisi_Click(object sender, EventArgs e)
        {
            bicikleController.Obrisi(this);
        }

        private void buttonKreiraj_Click(object sender, EventArgs e)
        {
            bicikleController.Kreiraj(this);
        }
    }
}
