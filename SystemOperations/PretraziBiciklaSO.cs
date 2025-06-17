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
    public class PretraziBiciklaSO : SystemOperationBase
    {
        private readonly Bicikla b;

        public PretraziBiciklaSO(Bicikla b)
        {
            this.b = b;
        }
        public Bicikla Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (Bicikla)repository.Get(b);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da nađe biicklu!");
            }
        }
    }
}
