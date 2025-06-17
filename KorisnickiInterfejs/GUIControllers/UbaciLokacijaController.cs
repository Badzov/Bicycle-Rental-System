using Domain;
using Common.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIControllers
{
    public class UbaciLokacijaController
    {
        private static UbaciLokacijaController instance;

        public static UbaciLokacijaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UbaciLokacijaController();
                }
                return instance;
            }
        }
        private UbaciLokacijaController()
        {

        }

        internal async void UbaciLokacija(UCUbaciLokacija uCUbaciLokacija, UserControlDialog frmDialog)
        {
            if (!ValidateFields(uCUbaciLokacija))
            {
                return;
            }

            string naziv = uCUbaciLokacija.TxtNaziv.Text;
            string opstina = uCUbaciLokacija.TxtOpstina.Text;

            try
            {
                Lokacija lokacija = new Lokacija
                {
                    Naziv = naziv,
                    Opstina = opstina
                };

                await Communication.Instance.UbaciLokacija(lokacija);

                MessageBox.Show("Sistem je ubacio lokaciju!");
                frmDialog.DialogResult = DialogResult.OK;
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

        private bool ValidateFields(UCUbaciLokacija uCUbaciLokacija)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(uCUbaciLokacija.TxtNaziv.Text))
            {
                uCUbaciLokacija.TxtNaziv.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciLokacija.TxtNaziv.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCUbaciLokacija.TxtOpstina.Text))
            {
                uCUbaciLokacija.TxtOpstina.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCUbaciLokacija.TxtOpstina.BackColor = Color.White;
            }
            return temp;
        }

        internal void Close(UCUbaciLokacija uCUbaciLokacija, UserControlDialog frmDialog)
        {
            frmDialog.DialogResult = DialogResult.Cancel;
        }
    }
}
