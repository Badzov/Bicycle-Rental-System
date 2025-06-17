using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                //Sibni ovde thread safe 
                if (instance == null)
                {
                    instance = new Controller();
                }

                return instance;
            }
        }
        private Controller() { }

        public Automat PrijaviAutomat(Automat a)
        {
            List<Automat> automati = VratiListuSviAutomat();

            foreach (Automat automat in automati)
            {
                if (automat.KorisnickoIme == a.KorisnickoIme && automat.Sifra == a.Sifra)
                {
                    return automat;
                }
            }
            return null;

        }

        public List<Automat> VratiListuSviAutomat()
        {
            SystemOperationBase so = new VratiListuSviAutomatSO();
            so.ExecuteTemplate();
            return ((VratiListuSviAutomatSO)so).Result;
        }

        public void UbaciAutomat(Automat a)
        {
            SystemOperationBase so = new UbaciAutomatSO(a);
            so.ExecuteTemplate();
        }

        public void UbaciAutomatSaLokacijom(Automat a, Lokacija l)
        {
            SystemOperationBase so = new UbaciAutomatSaLokacijomSO(a, l);
            so.ExecuteTemplate();
        }

        public List<Lokacija> VratiListuSviLokacija()
        {
            SystemOperationBase so = new VratiListuSviLokacijaSO();
            so.ExecuteTemplate();
            return ((VratiListuSviLokacijaSO)so).Result;
        }

        public void UbaciLokacija(Lokacija lokacija)
        {
            SystemOperationBase so = new UbaciLokacijaSO(lokacija);
            so.ExecuteTemplate();
        }

        public List<Mesto> VratiListuSviMesto()
        {
            SystemOperationBase so = new VratiListuSviMestoSO();
            so.ExecuteTemplate();
            return ((VratiListuSviMestoSO)so).Result;
        }

        public List<PoslovniPartner> VratiListuSviPoslovniPartner()
        {
            SystemOperationBase so = new VratiListuSviPoslovniPartnerSO();
            so.ExecuteTemplate();
            List<PoslovniPartner> poslovniPartneri = ((VratiListuSviPoslovniPartnerSO)so).Result;
            List<Mesto> mesta = VratiListuSviMesto();
            foreach(PoslovniPartner p in poslovniPartneri)
            {
                foreach(Mesto m in mesta)
                {
                    if(p.idMesto == m.IdMesto)
                    {
                        p.Mesto = m;
                        break;
                    }
                }
            }
            return poslovniPartneri;
        }

        public void UbaciPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new UbaciPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public void ObrisiPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new ObrisiPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public void PromeniPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new PromeniPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public List<PoslovniPartner> VratiListuPoslovniPartner(PoslovniPartner partner)
        {
            SystemOperationBase so = new VratiListuPoslovniPartnerSO(partner);
            so.ExecuteTemplate();
            List<PoslovniPartner> poslovniPartneri = ((VratiListuPoslovniPartnerSO)so).Result;
            List<Mesto> mesta = VratiListuSviMesto();
            foreach (PoslovniPartner p in poslovniPartneri)
            {
                foreach (Mesto m in mesta)
                {
                    if (p.idMesto == m.IdMesto)
                    {
                        p.Mesto = m;
                        break;
                    }
                }
            }
            return poslovniPartneri;
        }

        public PoslovniPartner PretraziPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new PretraziPoslovniPartnerSO(p);
            so.ExecuteTemplate();
            PoslovniPartner partner = ((PretraziPoslovniPartnerSO)so).Result;
            List<Mesto> mesta = VratiListuSviMesto();
            foreach (Mesto m in mesta)
            {
                if (p.Mesto.IdMesto == m.IdMesto)
                {
                    partner.Mesto = m;
                    break;
                }
            }
            return partner;

        }

        public void KreirajPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new KreirajPoslovniPartnerSO(p);
            so.ExecuteTemplate();
        }

        public void UbaciMesto(Mesto m)
        {
            SystemOperationBase so = new UbaciMestoSO(m);
            so.ExecuteTemplate();
        }

        public List<Bicikla> VratiListuSviBicikla()
        {
            SystemOperationBase so = new VratiListuSviBiciklaSO();
            so.ExecuteTemplate();
            return ((VratiListuSviBiciklaSO)so).Result;
        }

        public Bicikla PretraziBicikla(Bicikla b)
        {
            SystemOperationBase so = new PretraziBiciklaSO(b);
            so.ExecuteTemplate();
            return ((PretraziBiciklaSO)so).Result;
        }

        public void KreirajBicikla(Bicikla b)
        {
            SystemOperationBase so = new KreirajBiciklaSO(b);
            so.ExecuteTemplate();
        }

        public void ObrisiBicikla(Bicikla b)
        {
            SystemOperationBase so = new ObrisiBiciklaSO(b);
            so.ExecuteTemplate();
        }

        public void UbaciBicikla(Bicikla b)
        {
            SystemOperationBase so = new UbaciBiciklaSO(b);
            so.ExecuteTemplate();
        }

        public void PromeniBicikla(Bicikla b)
        {
            SystemOperationBase so = new PromeniBiciklaSO(b);
            so.ExecuteTemplate();
        }

        public List<Bicikla> VratiListuBicikla(Bicikla b)
        {
            SystemOperationBase so = new VratiListuBiciklaSO(b);
            so.ExecuteTemplate();
            return ((VratiListuBiciklaSO)so).Result;
        }

        public List<Iznajmljivanje> VratiListuSviIznajmljivanje()
        {
            SystemOperationBase so = new VratiListuSviIznajmljivanjeSO();
            so.ExecuteTemplate();
            List<Iznajmljivanje> iznajmljivanja = ((VratiListuSviIznajmljivanjeSO)so).Result;
            List<PoslovniPartner> partneri = VratiListuSviPoslovniPartner();
            List<Automat> automati = VratiListuSviAutomat();
            List<StavkaIznajmljivanja> stavke = VratiListuSviStavkaIznajmljivanja();
            foreach(Iznajmljivanje i in iznajmljivanja)
            {
                foreach(PoslovniPartner p in partneri)
                {
                    if (i.idPoslovniPartner == p.IdPoslovniPartner)
                    {
                        i.PoslovniPartner = p;
                        break;
                    }
                }
                foreach(Automat a in automati)
                {
                    if (i.idAutomat == a.IdAutomat)
                    {
                        i.Automat = a;
                        break;
                    }
                }
                foreach(StavkaIznajmljivanja si in stavke)
                {
                    if (i.IdIznajmljivanje == si.IdIznajmljivanje)
                    {
                        i.Stavke.Add(si);
                    }
                }
            }
            return iznajmljivanja;
        }

        private List<StavkaIznajmljivanja> VratiListuSviStavkaIznajmljivanja()
        {
            SystemOperationBase so = new VratiListuSviStavkaIznajmljivanjaSO();
            so.ExecuteTemplate();
            List<StavkaIznajmljivanja> stavke = ((VratiListuSviStavkaIznajmljivanjaSO)so).Result;
            List<Bicikla> bicikle = VratiListuSviBicikla();
            foreach (StavkaIznajmljivanja si in stavke)
            {
                foreach (Bicikla b in bicikle)
                {
                    if (si.idBicikla == b.IdBicikla)
                    {
                        si.Bicikla = b;
                        break;
                    }
                }
            }
            return stavke;
        }

        public void KreirajStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            SystemOperationBase so = new KreirajStavkaIznajmljivanjaSO(s);
            so.ExecuteTemplate();
        }

        public void ObrisiStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            SystemOperationBase so = new ObrisiStavkaIznajmljivanjaSO(s);
            so.ExecuteTemplate();
        }

        public void PromeniStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            SystemOperationBase so = new PromeniStavkaIznajmljivanjaSO(s);
            so.ExecuteTemplate();
        }

        public void UbaciStavkaIznajmljivanja(StavkaIznajmljivanja s)
        {
            SystemOperationBase so = new UbaciStavkaIznajmljivanjaSO(s);
            so.ExecuteTemplate();
        }

        public void ObrisiIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new ObrisiIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public void KreirajIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new KreirajIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public void UbaciIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new UbaciIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public void PromeniIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new PromeniIznajmljivanjeSO(i);
            so.ExecuteTemplate();
        }

        public List<Iznajmljivanje> VratiListuIznajmljivanje(Iznajmljivanje iznajmljivanje)
        {
            SystemOperationBase so = new VratiListuIznajmljivanjeSO(iznajmljivanje);
            so.ExecuteTemplate();
            List<Iznajmljivanje> iznajmljivanja = ((VratiListuIznajmljivanjeSO)so).Result;
            List<PoslovniPartner> partneri = VratiListuSviPoslovniPartner();
            List<Automat> automati = VratiListuSviAutomat();
            List<StavkaIznajmljivanja> stavke = VratiListuSviStavkaIznajmljivanja();
            foreach (Iznajmljivanje i in iznajmljivanja)
            {
                foreach (PoslovniPartner p in partneri)
                {
                    if (i.idPoslovniPartner == p.IdPoslovniPartner)
                    {
                        i.PoslovniPartner = p;
                        break;
                    }
                }
                foreach (Automat a in automati)
                {
                    if (i.idAutomat == a.IdAutomat)
                    {
                        i.Automat = a;
                        break;
                    }
                }
                foreach (StavkaIznajmljivanja si in stavke)
                {
                    if (i.IdIznajmljivanje == si.IdIznajmljivanje)
                    {
                        i.Stavke.Add(si);
                    }
                }
            }
            return iznajmljivanja;
        }
    }
}
