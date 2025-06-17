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
    public class VratiListuPoslovniPartnerSO : SystemOperationBase
    {
        private readonly PoslovniPartner p;

        public VratiListuPoslovniPartnerSO(PoslovniPartner p)
        {
            this.p = p;
        }
        public List<PoslovniPartner> Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = repository.Search(p).OfType<PoslovniPartner>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da vrati listu poslovnih partnera po zadatom kriterijumu!");
            }
        }
    }
}
