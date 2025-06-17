﻿using Common.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ObrisiPoslovniPartnerSO : SystemOperationBase
    {
        private readonly PoslovniPartner p;

        public ObrisiPoslovniPartnerSO(PoslovniPartner p)
        {
            this.p = p;
        }

        protected override void Execute()
        {
            try
            {
                repository.Delete(p);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da obriše poslovnog partnera!");
            }
        }
    }
}
