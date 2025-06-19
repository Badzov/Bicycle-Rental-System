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
            SystemOperationBase so = new PrijaviAutomatSO(a);
            so.ExecuteTemplate();
            return ((PrijaviAutomatSO)so).Result;

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

        public void UbaciLokacija(Lokacija l)
        {
            SystemOperationBase so = new UbaciLokacijaSO(l);
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
            return ((VratiListuSviPoslovniPartnerSO)so).Result;
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

        public List<PoslovniPartner> VratiListuPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new VratiListuPoslovniPartnerSO(p);
            so.ExecuteTemplate();
            return ((VratiListuPoslovniPartnerSO)so).Result;
        }

        public PoslovniPartner PretraziPoslovniPartner(PoslovniPartner p)
        {
            SystemOperationBase so = new PretraziPoslovniPartnerSO(p);
            so.ExecuteTemplate();
            return ((PretraziPoslovniPartnerSO)so).Result;

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
            return ((VratiListuSviIznajmljivanjeSO)so).Result;
        }

        private List<StavkaIznajmljivanja> VratiListuSviStavkaIznajmljivanja()
        {
            SystemOperationBase so = new VratiListuSviStavkaIznajmljivanjaSO();
            so.ExecuteTemplate();
            return ((VratiListuSviStavkaIznajmljivanjaSO)so).Result;
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

        public List<Iznajmljivanje> VratiListuIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new VratiListuIznajmljivanjeSO(i);
            so.ExecuteTemplate();
            return ((VratiListuIznajmljivanjeSO)so).Result;
        }

        public Iznajmljivanje PretraziIznajmljivanje(Iznajmljivanje i)
        {
            SystemOperationBase so = new PretraziIznajmljivanjeSO(i);
            so.ExecuteTemplate();
            return ((PretraziIznajmljivanjeSO)so).Result;
        }
    }
}
