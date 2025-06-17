using Common.Exceptions;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class PocetnaController
    {
        private static PocetnaController instance;

        public static PocetnaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PocetnaController();
                }
                return instance;
            }
        }
        private PocetnaController()
        {

        }

        internal async void Init(UCPocetna uCPocetna)
        {
            try
            {
                uCPocetna.LblBrBicikle.Text = (await Communication.Instance.VratiListuSviBicikla()).Count.ToString();
                uCPocetna.LblBrPartneri.Text = (await Communication.Instance.VratiListuSviPoslovniPartner()).Count.ToString();
                uCPocetna.LblBrAutomati.Text = (await Communication.Instance.VratiListuSviAutomat()).Count.ToString();

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
    }
}
