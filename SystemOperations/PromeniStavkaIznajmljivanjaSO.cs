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
    public class PromeniStavkaIznajmljivanjaSO : SystemOperationBase
    {
        private readonly StavkaIznajmljivanja s;

        public PromeniStavkaIznajmljivanjaSO(StavkaIznajmljivanja s)
        {
            this.s = s;
        }

        protected override void Execute()
        {
            try
            {
                repository.Update(s);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da promeni stavku!");
            }
        }
    }
}
