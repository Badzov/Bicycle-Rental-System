﻿using Common.Exceptions;
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
    public class UbaciIznajmljivanjeSO : SystemOperationBase
    {
        private readonly Iznajmljivanje i;

        public UbaciIznajmljivanjeSO(Iznajmljivanje i)
        {
            this.i = i;
        }

        protected override void Execute()
        {
            try
            {
                repository.Add(i);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da ubaci iznajmljivanje!");
            }
        }
    }
}
