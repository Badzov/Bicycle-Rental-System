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
    public class UbaciAutomatSO : SystemOperationBase
    {
        private readonly Automat a;

        public UbaciAutomatSO(Automat a)
        {
            this.a = a;
        }

        protected override void Execute()
        {
            try
            {
                repository.Add(a);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da ubaci automat!");
            }
        }
    }
}
