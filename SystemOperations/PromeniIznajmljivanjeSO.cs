﻿using Common.Exceptions;
using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PromeniIznajmljivanjeSO : SystemOperationBase
    {
        private readonly Iznajmljivanje i;

        public PromeniIznajmljivanjeSO(Iznajmljivanje i)
        {
            this.i = i;
        }

        protected override void Execute()
        {
            try
            {
                ObrisiStareStavke();
                DodajNoveStavke();

                repository.Update(i);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da promeni iznajmljivanje!");
            }
        }

        private void DodajNoveStavke()
        {
            foreach (StavkaIznajmljivanja stavka in i.Stavke)
            {
                repository.Add(stavka);
            }
        }

        private void ObrisiStareStavke()
        {
            List<StavkaIznajmljivanja> sveStavke = repository.GetAll(new StavkaIznajmljivanja()).OfType<StavkaIznajmljivanja>().ToList();
            List<Bicikla> bicikle = repository.GetAll(new Bicikla()).OfType<Bicikla>().ToList();
            foreach (StavkaIznajmljivanja si in sveStavke)
            {
                foreach (Bicikla b in bicikle)
                {
                    if (si.idBicikla == b.IdBicikla)
                    {
                        si.Bicikla = b;
                        break;
                    }
                }
            }

            foreach (StavkaIznajmljivanja stavka in sveStavke)
            {
                if (stavka.IdIznajmljivanje == i.IdIznajmljivanje)
                {
                    repository.Delete(stavka);
                }
            }
        }
    }
}
