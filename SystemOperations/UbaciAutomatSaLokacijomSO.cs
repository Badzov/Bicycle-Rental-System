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
    public class UbaciAutomatSaLokacijomSO : SystemOperationBase
    {
        private readonly Automat a;
        private readonly Lokacija l;

        public UbaciAutomatSaLokacijomSO(Automat a, Lokacija l)
        {
            this.a = a;
            this.l = l;
        }

        protected override void Execute()
        {
            try
            {
                a.IdAutomat = repository.AddReturnId(a);

                if (l != null)
                {
                    AutomatLokacija automatLokacija = new AutomatLokacija
                    {
                        Automat = a,
                        Lokacija = l,
                        DatumPostavljanja = DateTime.Now
                    };
                    repository.Add(automatLokacija);
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da ubaci automat!");
            }
        }
    }
}
