using Common.Exceptions;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UbaciLokacijaSO : SystemOperationBase
    {
        private readonly Lokacija l;

        public UbaciLokacijaSO(Lokacija l)
        {
            this.l = l;
        }

        protected override void Execute()
        {
            try
            {
                repository.Add(l);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da ubaci lokaciju!");
            }
        }
    }
}
