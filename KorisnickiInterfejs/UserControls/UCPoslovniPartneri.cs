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
    public partial class UCPoslovniPartneri : UserControl
    {
        private PoslovniPartneriController poslovniPartneriController;
        public UCPoslovniPartneri()
        {
            InitializeComponent();
            this.poslovniPartneriController = PoslovniPartneriController.Instance;
            poslovniPartneriController.Init(this);
        }

        private void dgvPoslovniPartneri_SelectionChanged(object sender, EventArgs e)
        {
            poslovniPartneriController.SelectionChanged(this);
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            poslovniPartneriController.Ubaci(this);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            poslovniPartneriController.Obrisi(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            poslovniPartneriController.Pretrazi(this);
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            poslovniPartneriController.Promeni(this);
        }

        private void buttonKreiraj_Click(object sender, EventArgs e)
        {
            poslovniPartneriController.Kreiraj(this);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            poslovniPartneriController.DodajMesto(this);
        }
    }
}
