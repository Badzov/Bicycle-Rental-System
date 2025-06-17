using Server.GUIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private ServerController serverController;

        public FrmServer()
        {
            InitializeComponent();
            serverController = ServerController.Instance;
            serverController.Init(this);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            serverController.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            serverController.Minimize(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            serverController.Start(this);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            serverController.Stop(this);
        }

        
    }
}
