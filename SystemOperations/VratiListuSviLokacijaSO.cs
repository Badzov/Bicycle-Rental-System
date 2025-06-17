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
    public class VratiListuSviLokacijaSO : SystemOperationBase
    {
        public List<Lokacija> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.GetAll(new Lokacija()).OfType<Lokacija>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da vrati listu svih lokacija!");
            }
        }
    }
}
