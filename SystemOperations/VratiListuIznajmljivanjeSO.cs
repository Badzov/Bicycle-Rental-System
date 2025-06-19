using Common.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class VratiListuIznajmljivanjeSO : SystemOperationBase
    {
        private readonly Iznajmljivanje i;

        public VratiListuIznajmljivanjeSO(Iznajmljivanje i)
        {
            this.i = i;
        }
        public List<Iznajmljivanje> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.Search(i).OfType<Iznajmljivanje>().ToList();

                List<PoslovniPartner> partneri = repository.GetAll(new PoslovniPartner()).OfType<PoslovniPartner>().ToList();
                List<Automat> automati = repository.GetAll(new Automat()).OfType<Automat>().ToList();
                List<StavkaIznajmljivanja> stavke = repository.GetAll(new StavkaIznajmljivanja()).OfType<StavkaIznajmljivanja>().ToList();
                List<Bicikla> bicikle = repository.GetAll(new Bicikla()).OfType<Bicikla>().ToList();

                foreach (Iznajmljivanje iznajmljivanje in Result)
                {
                    iznajmljivanje.PoslovniPartner = partneri.FirstOrDefault(p => p.IdPoslovniPartner == iznajmljivanje.idPoslovniPartner);
                    iznajmljivanje.Automat = automati.FirstOrDefault(a => a.IdAutomat == iznajmljivanje.idAutomat);

                    foreach (StavkaIznajmljivanja stavka in stavke.Where(s => s.IdIznajmljivanje == iznajmljivanje.IdIznajmljivanje))
                    {
                        stavka.Bicikla = bicikle.FirstOrDefault(b => b.IdBicikla == stavka.idBicikla);
                        iznajmljivanje.Stavke.Add(stavka);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da vrati listu iznajmljivanja po zadatom kriterijumu!");
            }
        }
    }
}
