using Common.Exceptions;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class BicikleController
    {

        private static BicikleController instance;

        public static BicikleController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BicikleController();
                }
                return instance;
            }
        }
        private BicikleController()
        {

        }

        internal async void Init(UCBicikle uCBicikle)
        {
            try
            {
                ClearFields(uCBicikle);
                uCBicikle.DgvBicikle.DataSource = new BindingList<Bicikla>(await Communication.Instance.VratiListuSviBicikla());
                FormatDgv(uCBicikle);
                uCBicikle.DgvBicikle.ClearSelection();
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

        private void FormatDgv(UCBicikle uCBicikle)
        {
            uCBicikle.DgvBicikle.Columns["TableName"].Visible = false;
            uCBicikle.DgvBicikle.Columns["InsertColumns"].Visible = false;
            uCBicikle.DgvBicikle.Columns["InsertParameters"].Visible = false;
            uCBicikle.DgvBicikle.Columns["UpdateStatement"].Visible = false;
            uCBicikle.DgvBicikle.Columns["Condition"].Visible = false;
            uCBicikle.DgvBicikle.Columns["Parameters"].Visible = false;
            uCBicikle.DgvBicikle.Columns["IdBicikla"].Visible = false;
            uCBicikle.DgvBicikle.Columns["SearchableProperties"].Visible = false;
            uCBicikle.DgvBicikle.Columns["Model"].Width = 68;
            uCBicikle.DgvBicikle.Columns["Boja"].Width = 68;
            uCBicikle.DgvBicikle.Columns["CenaBicikle"].Width = 100;
            uCBicikle.DgvBicikle.Columns["GodinaProizvodnje"].Width = 100;
        }

        private void ClearFields(UCBicikle uCBicikle)
        {
            uCBicikle.TxtModel.Text = "";
            uCBicikle.TxtBoja.Text = "";
            uCBicikle.TxtCena.Text = "";
            uCBicikle.TxtGodina.Text = "";

        }

        internal async void SelectionChanged(UCBicikle uCBicikle)
        {
            if (uCBicikle.DgvBicikle.SelectedRows.Count > 0)
            {
                Bicikla bicikla = await Communication.Instance.PretraziBicikla((Bicikla)uCBicikle.DgvBicikle.SelectedRows[0].DataBoundItem);

                uCBicikle.TxtModel.Text = bicikla.Model;
                uCBicikle.TxtBoja.Text = bicikla.Boja;
                uCBicikle.TxtCena.Text = bicikla.CenaBicikle.ToString();
                uCBicikle.TxtGodina.Text = bicikla.GodinaProizvodnje.ToString();

                uCBicikle.TxtModel.BackColor = Color.White;
                uCBicikle.TxtBoja.BackColor = Color.White;
                uCBicikle.TxtCena.BackColor = Color.White;
                uCBicikle.TxtGodina.BackColor = Color.White;
            }
        }

        private bool ValidateFields(UCBicikle uCBicikle)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(uCBicikle.TxtModel.Text))
            {
                uCBicikle.TxtModel.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCBicikle.TxtModel.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(uCBicikle.TxtBoja.Text))
            {
                uCBicikle.TxtBoja.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCBicikle.TxtBoja.BackColor = Color.White;
            }
            if (!int.TryParse(uCBicikle.TxtGodina.Text, out _))
            {
                uCBicikle.TxtGodina.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCBicikle.TxtGodina.BackColor = Color.White;
            }
            if (!double.TryParse(uCBicikle.TxtCena.Text, out _))
            {
                uCBicikle.TxtCena.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCBicikle.TxtCena.BackColor = Color.White;
            }

            return temp;
        }

        private bool ValidateFieldsForSearch(UCBicikle uCBicikle)
        {
            bool temp = true;
            if (!string.IsNullOrWhiteSpace(uCBicikle.TxtGodina.Text)) {

                if (!int.TryParse(uCBicikle.TxtGodina.Text, out _))
                {
                    uCBicikle.TxtGodina.BackColor = Color.Salmon;
                    temp = false;
                }
                else
                {
                    uCBicikle.TxtGodina.BackColor = Color.White;
                }
            }
            else
            {
                uCBicikle.TxtGodina.BackColor = Color.White;
            }

            if (!string.IsNullOrWhiteSpace(uCBicikle.TxtCena.Text))
            {
                if (!double.TryParse(uCBicikle.TxtCena.Text, out _))
                {
                    uCBicikle.TxtCena.BackColor = Color.Salmon;
                    temp = false;
                }
                else
                {
                    uCBicikle.TxtCena.BackColor = Color.White;
                }
            }
            else
            {
                uCBicikle.TxtCena.BackColor = Color.White;
            }

            return temp;
        }

        internal async void Kreiraj(UCBicikle uCBicikle)
        {
            try
            {
                Bicikla bicikla = new Bicikla
                {
                    Model = "Nova Bicikla",
                    Boja = "/",
                    GodinaProizvodnje = DateTime.Now.Year,
                    CenaBicikle = 1,
                };

                await Communication.Instance.KreirajBicikla(bicikla);
                MessageBox.Show("Sistem je kreirao novu biciklu!");
                Init(uCBicikle);
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

        internal async void Obrisi(UCBicikle uCBicikle)
        {
            if (uCBicikle.DgvBicikle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrana bicikla!");
                return;
            }

            try
            {
                for (int i = 0; i < uCBicikle.DgvBicikle.SelectedRows.Count; i++)
                {
                    Bicikla bicikla = (Bicikla)uCBicikle.DgvBicikle.SelectedRows[i].DataBoundItem;
                    await Communication.Instance.ObrisiBicikla(bicikla);
                }
                MessageBox.Show("Sistem je obrisao bicikle!");
                Init(uCBicikle);
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

        internal async void Pretrazi(UCBicikle uCBicikle)
        {
            try
            {
                if (!ValidateFieldsForSearch(uCBicikle))
                {
                    return;
                }
                Bicikla bicikla = new Bicikla
                {
                    Model = uCBicikle.TxtModel.Text,
                    Boja = uCBicikle.TxtBoja.Text,
                    GodinaProizvodnje = string.IsNullOrWhiteSpace(uCBicikle.TxtGodina.Text) ? (int?)null : int.Parse(uCBicikle.TxtGodina.Text),
                    CenaBicikle = string.IsNullOrWhiteSpace(uCBicikle.TxtCena.Text) ? (double?)null : double.Parse(uCBicikle.TxtCena.Text),
                };
                uCBicikle.DgvBicikle.DataSource = new BindingList<Bicikla>(await Communication.Instance.VratiListuBicikla(bicikla));
                FormatDgv(uCBicikle);
                uCBicikle.DgvBicikle.ClearSelection();
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

        internal async void Promeni(UCBicikle uCBicikle)
        {
            if (uCBicikle.DgvBicikle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrana bicikla");
                return;
            }
            if (uCBicikle.DgvBicikle.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite samo jednu biciklu!");
                return;
            }

            try
            {
                if (!ValidateFields(uCBicikle))
                {
                    return;
                }
                Bicikla bicikla = (Bicikla)uCBicikle.DgvBicikle.SelectedRows[0].DataBoundItem;
                bicikla.Model = uCBicikle.TxtModel.Text;
                bicikla.Boja = uCBicikle.TxtBoja.Text;
                bicikla.GodinaProizvodnje = Int32.Parse(uCBicikle.TxtGodina.Text);
                bicikla.CenaBicikle = Double.Parse(uCBicikle.TxtCena.Text);

                await Communication.Instance.PromeniBicikla(bicikla);
                MessageBox.Show("Sistem je zapamtio biciklu!");
                Init(uCBicikle);
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

        internal async void Ubaci(UCBicikle uCBicikle)
        {
            if (!ValidateFields(uCBicikle))
            {
                return;
            }

            string model = uCBicikle.TxtModel.Text;
            string boja = uCBicikle.TxtBoja.Text;
            int godina = Int32.Parse(uCBicikle.TxtGodina.Text);
            Double cena = Double.Parse(uCBicikle.TxtCena.Text);

            try
            {
                Bicikla bicikla = new Bicikla
                {
                    Model = model,
                    Boja = boja,
                    GodinaProizvodnje = godina,
                    CenaBicikle = cena,
                };

                await Communication.Instance.UbaciBicikla(bicikla);
                MessageBox.Show("Sistem je ubacio biciklu!");
                Init(uCBicikle);
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
