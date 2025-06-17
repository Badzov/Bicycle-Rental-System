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
    public class VratiListuIznajmljivanjeSO : SystemOperationBase
    {
        private readonly Iznajmljivanje i;

        public VratiListuIznajmljivanjeSO(Iznajmljivanje i)
        {
            this.i = i;
        }
        public List<Iznajmljivanje> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.Search(i).OfType<Iznajmljivanje>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da vrati listu iznajmljivanja po zadatom kriterijumu!");
            }
        }
    }
}
