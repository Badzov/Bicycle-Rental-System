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
    public class UbaciStavkaIznajmljivanjaSO : SystemOperationBase
    {
        private readonly StavkaIznajmljivanja s;

        public UbaciStavkaIznajmljivanjaSO(StavkaIznajmljivanja s)
        {
            this.s = s;
        }

        protected override void Execute()
        {
            try
            {
                repository.Add(s);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da ubaci stavku!");
            }
        }
    }
}
