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
    public class VratiListuSviStavkaIznajmljivanjaSO : SystemOperationBase
    {
        public List<StavkaIznajmljivanja> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.GetAll(new StavkaIznajmljivanja()).OfType<StavkaIznajmljivanja>().ToList();

                List<Bicikla> bicikle = repository.GetAll(new Bicikla()).OfType<Bicikla>().ToList();
                foreach (var stavka in Result)
                {
                    stavka.Bicikla = bicikle.FirstOrDefault(b => b.IdBicikla == stavka.idBicikla);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da vrati listu svih stavki!");
            }
        }
    }
}
