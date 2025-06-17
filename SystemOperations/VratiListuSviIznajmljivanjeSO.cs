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
    public class VratiListuSviIznajmljivanjeSO : SystemOperationBase
    {
        public List<Iznajmljivanje> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.GetAll(new Iznajmljivanje()).OfType<Iznajmljivanje>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da vrati listu svih iznajmljivanja!");
            }
        }
    }
}
