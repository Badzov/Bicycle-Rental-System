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
    public class PretraziIznajmljivanjeSO : SystemOperationBase
    {
        private readonly Iznajmljivanje i;

        public PretraziIznajmljivanjeSO(Iznajmljivanje i)
        {
            this.i = i;
        }
        public Iznajmljivanje Result { get; private set; }
        protected override void Execute()
        {
            try
            {
                Result = (Iznajmljivanje)repository.Get(i);

                if (Result != null)
                {
                    List<PoslovniPartner> partneri = repository.Search(new PoslovniPartner{IdPoslovniPartner = Result.idPoslovniPartner}).OfType<PoslovniPartner>().ToList();
                    Result.PoslovniPartner = partneri.FirstOrDefault();

                    List<Automat> automati = repository.Search(new Automat{ IdAutomat = Result.idAutomat}).OfType<Automat>().ToList();
                    Result.Automat = automati.FirstOrDefault();

                    List<StavkaIznajmljivanja> stavke = repository.Search(new StavkaIznajmljivanja{IdIznajmljivanje = Result.IdIznajmljivanje}).OfType<StavkaIznajmljivanja>().ToList();
                    foreach (StavkaIznajmljivanja stavka in stavke)
                    {
                        List<Bicikla> bicikle = repository.Search(new Bicikla{IdBicikla = stavka.idBicikla}).OfType<Bicikla>().ToList();
                        stavka.Bicikla = bicikle.FirstOrDefault();
                        Result.Stavke.Add(stavka);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>>>>>> System Operation {this.GetType()}  error: " + ex.Message);
                throw new SystemOperationException("Sistem ne može da nađe iznajmljivanje!");
            }
        }
    }
}
