using Domain;
using Common.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KorisnickiInterfejs.GUIControllers
{
    public class LoginController
    {
        public Automat TrenutniAutomat { get; private set; }
        private static LoginController instance;

        public static LoginController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginController();
                }
                return instance;
            }
        }
        private LoginController()
        {

        }

        internal void Init(FrmLogin frmLogin)
        {
            frmLogin.Icon = Properties.Resources.bicycle;
            frmLogin.TxtPassword.Text = "automat1";
            frmLogin.TxtUsername.Text = "automat1";
        }

        internal async void Exit()
        {
            try
            {
                await Communication.Instance.Close();
            }
            catch (ServerCommunicationException ex)
            {
                Debug.WriteLine(">>>>>> FORMCLOSED EVENT >>>>>>>> " + ex.Message);
            }
            finally
            {
                Environment.Exit(0);
            }
            
        }

        internal void Minimize(FrmLogin frmLogin)
        {
            frmLogin.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        internal async void PrijaviAutomat(FrmLogin frmLogin)
        {
       
            if(!ValidateFields(frmLogin))
            {
                return;
            }

            string korisnickoIme = frmLogin.TxtUsername.Text;
            string sifra = frmLogin.TxtPassword.Text;

            try
            {
                Automat automat = new Automat
                {
                    KorisnickoIme = korisnickoIme,
                    Sifra = sifra,
                };

                Communication.Instance.Connect();
                TrenutniAutomat = await Communication.Instance.PrijaviAutomat(automat);


                if (TrenutniAutomat != null)
                {
                    MessageBox.Show("Korisničko ime i šifra su ispravni!");
                    frmLogin.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Korisničko ime i šifra nisu ispravni!");
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greška pri povezivanju sa serverom!");
                Console.WriteLine(">>>>>> " + ex.Message);
            }
        }

        private bool ValidateFields(FrmLogin frmLogin)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(frmLogin.TxtUsername.Text))
            {
                frmLogin.TxtUsername.BackColor = Color.Salmon;
                temp = false;
            } else
            {
                frmLogin.TxtUsername.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(frmLogin.TxtPassword.Text))
            {
                frmLogin.TxtPassword.BackColor = Color.Salmon;
                temp = false;
            } else
            {
                frmLogin.TxtPassword.BackColor = Color.White;
            }
            return temp;

        }

        internal void PrikaziSifru(FrmLogin frmLogin)
        {
            if (frmLogin.CheckbxShow.Checked)
            {
                frmLogin.TxtPassword.PasswordChar = '\0';
            } else
            {
                frmLogin.TxtPassword.PasswordChar = '*';
            }
        }

        internal void Registruj(FrmLogin frmLogin)
        {
            try
            {
                Communication.Instance.Connect();
                frmLogin.DialogResult = DialogResult.Ignore;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Greška pri povezivanju sa serverom!");
                Console.WriteLine(">>>>>> " + ex.Message);
            }
        }
    }
}
