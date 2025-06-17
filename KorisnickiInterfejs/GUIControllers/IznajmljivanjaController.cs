using Common.Exceptions;
using Domain;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace KorisnickiInterfejs.GUIControllers
{
    internal class IznajmljivanjaController
    {
        private static IznajmljivanjaController instance;

        public static IznajmljivanjaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new IznajmljivanjaController();
                }
                return instance;
            }
        }
        private IznajmljivanjaController()
        {

        }

        internal async Task Init(UCIznajmljivanja uCIznajmljivanja)
        {
            try
            {
                uCIznajmljivanja.CmbBicikla.DataSource = await Communication.Instance.VratiListuSviBicikla();
                uCIznajmljivanja.CmbBicikla.ValueMember = "IdBicikla";
                //Zanimljivi override - property wrapper postavlja display member da bude prvi property klase, ovde ga overridujemo
                uCIznajmljivanja.CmbBicikla.DisplayMember = null; 
                uCIznajmljivanja.CmbPoslovniPartner.DataSource = await Communication.Instance.VratiListuSviPoslovniPartner();
                uCIznajmljivanja.CmbPoslovniPartner.ValueMember = "IdPoslovniPartner";
                uCIznajmljivanja.CmbPoslovniPartner.DisplayMember = null;
                uCIznajmljivanja.CmbAutomati.DataSource = await Communication.Instance.VratiListuSviAutomat();
                uCIznajmljivanja.CmbAutomati.ValueMember = "IdAutomat";
                uCIznajmljivanja.CmbAutomati.DisplayMember = null;
                uCIznajmljivanja.DgvIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>(await Communication.Instance.VratiListuSviIznajmljivanje());
                FormatIznajmljivanjaDgv(uCIznajmljivanja);
                ClearFields(uCIznajmljivanja);
                uCIznajmljivanja.DgvIznajmljivanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                uCIznajmljivanja.DgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                uCIznajmljivanja.DtpIznajmljivanja.Value = DateTime.Today;
                uCIznajmljivanja.DtpIznajmljivanja.Value = DateTime.Today;
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

        private void FormatIznajmljivanjaDgv(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DgvIznajmljivanja.Columns["TableName"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["InsertColumns"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["InsertParameters"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["UpdateStatement"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["Condition"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["Parameters"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["IdIznajmljivanje"].Visible = false;
            uCIznajmljivanja.DgvIznajmljivanja.Columns["SearchableProperties"].Visible = false;
        }

        private void ClearFields(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DtpIznajmljivanja.Value = DateTime.Now;
            uCIznajmljivanja.DtpPovratka.Value = DateTime.Now;
            uCIznajmljivanja.CmbPoslovniPartner.SelectedItem = null;
            uCIznajmljivanja.TxtCena.Text = "";
            uCIznajmljivanja.CmbBicikla.SelectedItem = null;
            uCIznajmljivanja.CmbAutomati.SelectedItem = null;
        }

        internal void IznajmljivanjaSelectionChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count > 0)
            {
                Iznajmljivanje iznajmljivanje = (Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem;
                uCIznajmljivanja.DgvStavke.DataSource = new BindingList<StavkaIznajmljivanja>(iznajmljivanje.Stavke);
                FormatStavkeDgv(uCIznajmljivanja);
                uCIznajmljivanja.DtpIznajmljivanja.Value = (DateTime)iznajmljivanje.DatumIznajmljivanja;
                uCIznajmljivanja.DtpPovratka.Value = (DateTime)iznajmljivanje.DatumPovratka;
                uCIznajmljivanja.CmbPoslovniPartner.SelectedValue = iznajmljivanje.PoslovniPartner.IdPoslovniPartner;
                uCIznajmljivanja.CmbAutomati.SelectedValue = iznajmljivanje.Automat.IdAutomat;
            }
        }

        internal void StavkeSelectionChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvStavke.SelectedRows.Count > 0)
            {
                StavkaIznajmljivanja stavka = (StavkaIznajmljivanja)uCIznajmljivanja.DgvStavke.SelectedRows[0].DataBoundItem;
                uCIznajmljivanja.TxtCena.Text = stavka.CenaNajma.ToString();
                uCIznajmljivanja.CmbBicikla.SelectedValue = stavka.Bicikla.IdBicikla; 
            }
        }

        private void FormatStavkeDgv(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DgvStavke.Columns["TableName"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["InsertColumns"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["InsertParameters"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["UpdateStatement"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["Condition"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["Parameters"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["SearchableProperties"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["IdIznajmljivanje"].Visible = false;
            uCIznajmljivanja.DgvStavke.Columns["NewRb"].Visible = false;
        }

        private async Task RefreshDgvIznajmljivanja(UCIznajmljivanja uCIznajmljivanja, int rowIndex)
        {
            await Init(uCIznajmljivanja);
            uCIznajmljivanja.DgvIznajmljivanja.ClearSelection();
            uCIznajmljivanja.DgvIznajmljivanja.Rows[rowIndex].Selected = true;
            uCIznajmljivanja.DgvIznajmljivanja.CurrentCell = uCIznajmljivanja.DgvIznajmljivanja.Rows[rowIndex].Cells[1];
        }

        internal async void KreirajStavka(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count < 1)
            {
                MessageBox.Show("Odaberite iznajmljivanje!");
                return;
            }

            try
            {
                int rowIndex = uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].Index;
                StavkaIznajmljivanja stavka = new StavkaIznajmljivanja
                {
                    IdIznajmljivanje = ((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem).IdIznajmljivanje,
                    Rb = ((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem).Stavke.Count + 1,
                    CenaNajma = 1,
                    Bicikla = (Bicikla)uCIznajmljivanja.CmbBicikla.Items[0],
                };

                await Communication.Instance.KreirajStavkaIznajmljivanja(stavka);
                MessageBox.Show("Sistem je kreirao novu stavku!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, rowIndex);
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

        internal async void ObrisiStavka(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrana stavka!");
                return;
            }

            try
            {
                int rowIndex = uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].Index;
                for (int i = 0; i < uCIznajmljivanja.DgvStavke.SelectedRows.Count; i++)
                {
                    StavkaIznajmljivanja stavka = (StavkaIznajmljivanja)uCIznajmljivanja.DgvStavke.SelectedRows[i].DataBoundItem;
                    await Communication.Instance.ObrisiStavkaIznajmljivanja(stavka);
                }
                MessageBox.Show("Sistem je obrisao stavke!");
                await PoredjajStavke(uCIznajmljivanja, rowIndex);
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, rowIndex);
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

        private async Task PoredjajStavke(UCIznajmljivanja uCIznajmljivanja, int rowIndex)
        {
            Iznajmljivanje iznajmljivanje = (Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem;
            for (int i = iznajmljivanje.Stavke.Count-1; i > - 1; i--)
            {
                StavkaIznajmljivanja stavka = iznajmljivanje.Stavke[i];
                stavka.NewRb = stavka.Rb + 1;
                await Communication.Instance.PromeniStavkaIznajmljivanja(stavka);
            }
            await RefreshDgvIznajmljivanja(uCIznajmljivanja, rowIndex);
            iznajmljivanje = (Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem;
            for (int i = 0; i<iznajmljivanje.Stavke.Count; i++)
            {
                StavkaIznajmljivanja stavka = iznajmljivanje.Stavke[i];
                stavka.NewRb = i + 1;
                await Communication.Instance.PromeniStavkaIznajmljivanja(stavka);
            }
        }

        internal async void UbaciStavka(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrano iznajmljivanje!");
                return;
            }

            if (!ValidateFieldsStavka(uCIznajmljivanja))
            {
                return;
            }

            int rowIndex = uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].Index;

            int cenaNajma = Int32.Parse(uCIznajmljivanja.TxtCena.Text);
            Bicikla bicikla = (Bicikla)uCIznajmljivanja.CmbBicikla.SelectedItem;
            int rb = ((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem).Stavke.Count + 1;

            try
            {
                StavkaIznajmljivanja stavka = new StavkaIznajmljivanja
                {
                    Rb = rb,
                    CenaNajma = cenaNajma,
                    Bicikla = bicikla,
                    IdIznajmljivanje = ((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem).IdIznajmljivanje,
                };

                await Communication.Instance.UbaciStavkaIznajmljivanja(stavka);
                MessageBox.Show("Sistem je zapamtio stavku!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, rowIndex);
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

        private bool ValidateFieldsStavka(UCIznajmljivanja uCIznajmljivanja)
        {
            bool temp = true;
            if (!string.IsNullOrWhiteSpace(uCIznajmljivanja.TxtCena.Text))
            {
                if (!double.TryParse(uCIznajmljivanja.TxtCena.Text, out _))
                {
                    uCIznajmljivanja.TxtCena.BackColor = Color.Salmon;
                    temp = false;
                }
                else
                {
                    uCIznajmljivanja.TxtCena.BackColor = Color.White;
                }
            }
            else
            {
                uCIznajmljivanja.TxtCena.BackColor = Color.Salmon;
                temp = false;
            }
            if (uCIznajmljivanja.CmbBicikla.SelectedItem == null)
            {
                uCIznajmljivanja.CmbBicikla.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCIznajmljivanja.CmbBicikla.BackColor = Color.White;
            }
            return temp;
        }

        internal async void ObrisiIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrano iznajmljivanje!");
                return;
            }

            if (((Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem).Stavke.Count > 0)
            {
                MessageBox.Show("Prvo obrišite sve stavke!");
            }

            try
            {
                for (int i = 0; i < uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count; i++)
                {
                    Iznajmljivanje iznajmljivanje = (Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[i].DataBoundItem;
                    await Communication.Instance.ObrisiIznajmljivanje(iznajmljivanje);
                }
                MessageBox.Show("Sistem je obrisao iznajmljivanje!");
                Init(uCIznajmljivanja);
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

        internal async void KreirajIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            try
            {
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje
                {
                    DatumIznajmljivanja = DateTime.Now,
                    DatumPovratka = DateTime.Now,
                    PoslovniPartner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.Items[0],
                    Automat = (Automat)uCIznajmljivanja.CmbAutomati.Items[0]
                };

                await Communication.Instance.KreirajIznajmljivanje(iznajmljivanje);
                MessageBox.Show("Sistem je kreirao novo iznajmljivanje!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, uCIznajmljivanja.DgvIznajmljivanja.RowCount);
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

        internal async void UbaciIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            if (!ValidateFieldsIznajmljivanje(uCIznajmljivanja))
            {
                return;
            }

            DateTime datumIznajmljivanja = uCIznajmljivanja.DtpIznajmljivanja.Value;
            DateTime datumPovratka = uCIznajmljivanja.DtpPovratka.Value;
            PoslovniPartner partner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.SelectedItem;
            Automat automat = (Automat)uCIznajmljivanja.CmbAutomati.SelectedItem;

            try
            {
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje
                {
                    DatumIznajmljivanja = datumIznajmljivanja,
                    DatumPovratka = datumPovratka,
                    PoslovniPartner = partner,
                    Automat = automat,
                };

                await Communication.Instance.UbaciIznajmljivanje(iznajmljivanje);
                MessageBox.Show("Sistem je ubacio iznajmljivanje!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, uCIznajmljivanja.DgvIznajmljivanja.RowCount);
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

        private bool ValidateFieldsIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            bool temp = true;
            if (DateTime.Compare(uCIznajmljivanja.DtpIznajmljivanja.Value, uCIznajmljivanja.DtpPovratka.Value) > 0)
            {
                MessageBox.Show("Datum iznajmljivanja mora biti pre datuma povratka!");
                temp = false;
            }
            if (uCIznajmljivanja.CmbAutomati.SelectedItem == null)
            {
                uCIznajmljivanja.CmbAutomati.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCIznajmljivanja.CmbAutomati.BackColor = Color.White;
            }
            if (uCIznajmljivanja.CmbPoslovniPartner.SelectedItem == null)
            {
                uCIznajmljivanja.CmbPoslovniPartner.BackColor = Color.Salmon;
                temp = false;
            }
            else
            {
                uCIznajmljivanja.CmbPoslovniPartner.BackColor = Color.White;
            }
            return temp;
        }

        internal async void PromeniIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije odabrano iznajmljivanje!");
                return;
            }
            if (uCIznajmljivanja.DgvIznajmljivanja.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite samo jedno iznajmljivanje!");
                return;
            }

            try
            {
                if (!ValidateFieldsIznajmljivanje(uCIznajmljivanja))
                {
                    return;
                }

                Iznajmljivanje iznajmljivanje = (Iznajmljivanje)uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].DataBoundItem;
                iznajmljivanje.DatumIznajmljivanja = uCIznajmljivanja.DtpIznajmljivanja.Value;
                iznajmljivanje.DatumPovratka = uCIznajmljivanja.DtpPovratka.Value;
                iznajmljivanje.Automat = (Automat)uCIznajmljivanja.CmbAutomati.SelectedItem;
                iznajmljivanje.PoslovniPartner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.SelectedItem;

                await Communication.Instance.PromeniIznajmljivanje(iznajmljivanje);
                MessageBox.Show("Sistem je zapamtio iznajmljivanje!");
                await RefreshDgvIznajmljivanja(uCIznajmljivanja, uCIznajmljivanja.DgvIznajmljivanja.SelectedRows[0].Index);
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

        internal async void PretraziIznajmljivanje(UCIznajmljivanja uCIznajmljivanja)
        {
            try
            {
                PoslovniPartner partner = null;
                if (uCIznajmljivanja.CmbPoslovniPartner.SelectedItem != null)
                {
                    partner = (PoslovniPartner)uCIznajmljivanja.CmbPoslovniPartner.SelectedItem;
                }
                Automat automat = null;
                {
                    automat = (Automat)uCIznajmljivanja.CmbAutomati.SelectedItem;
                }
                Iznajmljivanje iznajmljivanje = new Iznajmljivanje
                {
                    Automat = automat,
                    PoslovniPartner = partner
                };

                DialogResult result = MessageBox.Show("Da li želite da uključite i odabrane datume u pretragu?", "Pretraga", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    iznajmljivanje.DatumIznajmljivanja = uCIznajmljivanja.DtpIznajmljivanja.Value;
                    iznajmljivanje.DatumPovratka = uCIznajmljivanja.DtpPovratka.Value;
                }
                else
                {
                    iznajmljivanje.DatumIznajmljivanja = null;
                    iznajmljivanje.DatumPovratka = null;
                }

                uCIznajmljivanja.DgvIznajmljivanja.DataSource = new BindingList<Iznajmljivanje>(await Communication.Instance.VratiListuIznajmljivanje(iznajmljivanje));
                FormatIznajmljivanjaDgv(uCIznajmljivanja);
                uCIznajmljivanja.DgvIznajmljivanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        internal void HandleDtpIznajmljivanjaValueChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DtpIznajmljivanja.Value = uCIznajmljivanja.DtpIznajmljivanja.Value.Date;
        }

        internal void HandleDtpPovratkaValueChanged(UCIznajmljivanja uCIznajmljivanja)
        {
            uCIznajmljivanja.DtpPovratka.Value = uCIznajmljivanja.DtpPovratka.Value.Date;
        }
    }
}
