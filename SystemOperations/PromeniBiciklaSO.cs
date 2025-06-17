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
    public class PromeniBiciklaSO : SystemOperationBase
    {
        private readonly Bicikla b;

        public PromeniBiciklaSO(Bicikla b)
        {
            this.b = b;
        }

        protected override void Execute()
        {
            try
            {
                repository.Update(b);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da promeni biciklu!");
            }
        }
    }
}
