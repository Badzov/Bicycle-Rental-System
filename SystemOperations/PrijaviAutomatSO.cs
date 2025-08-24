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
    public class PrijaviAutomatSO : SystemOperationBase
    {
        private readonly Automat a;

        public PrijaviAutomatSO(Automat a)
        {
            this.a = a;
        }
        public Automat Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                List<Automat> automati = repository.GetAll(new Automat()).OfType<Automat>().ToList();
                Validate(automati);

                Result = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da prijavi poslovnog partnera!");
            }
        }

        private void Validate(List<Automat> automati)
        {
            foreach (Automat automat in automati)
            {
                if (automat.KorisnickoIme == a.KorisnickoIme && automat.Sifra == a.Sifra)
                {
                    Result = automat;
                    return;
                }
            }
        }
    }
}
