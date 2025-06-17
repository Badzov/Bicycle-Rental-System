using Domain;
using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SystemOperations
{
    public class VratiListuSviPoslovniPartnerSO : SystemOperationBase
    {
        public List<PoslovniPartner> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.GetAll(new PoslovniPartner()).OfType<PoslovniPartner>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da vrati listu svih poslovnih partnera!");
            }
        }
    }
}
