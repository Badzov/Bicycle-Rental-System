using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.UserControls
{
    public class UserControlDialog : Form
    {
        public UserControlDialog()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.None;
            this.Icon = Properties.Resources.bicycle;
        }

        public void Add(UserControl control)
        {
            this.ClientSize = control.Size;
            this.Controls.Add(control);

        }

    }

}
