using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StavkaIznajmljivanja : IDomainObject
    {
        public int Rb { get; set; }
        public double CenaNajma { get; set; }
        public Bicikla Bicikla { get; set; }

        public int IdIznajmljivanje { get; set; }
        public int NewRb { get; set; }
        public int idBicikla;

        public string TableName => "StavkaIznajmljivanja";
        public string InsertColumns => "idIznajmljivanje, rb, cenaNajma, idBicikla";
        public string InsertParameters => "@IdIznajmljivanje, @Rb, @CenaNajma, @IdBicikla";
        public string UpdateStatement => "idIznajmljivanje = @IdIznajmljivanje, rb = @NewRb, cenaNajma = @CenaNajma, idBicikla = @IdBicikla";
        public string Condition => "idIznajmljivanje = @IdIznajmljivanje AND rb = @Rb";
        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdIznajmljivanje", IdIznajmljivanje },
            { "@Rb", Rb },
            { "@CenaNajma", CenaNajma },
            { "@IdBicikla", Bicikla.IdBicikla },
            { "@NewRb", NewRb }
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "idIznajmljivanje", IdIznajmljivanje },
            { "cenaNajma", CenaNajma },
            { "idBicikla", Bicikla.IdBicikla },
        };


        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            StavkaIznajmljivanja si = new StavkaIznajmljivanja();
            si.IdIznajmljivanje = reader.GetInt32(reader.GetOrdinal("idIznajmljivanje"));
            si.Rb = reader.GetInt32(reader.GetOrdinal("rb"));
            si.CenaNajma = reader.GetDouble(reader.GetOrdinal("cenaNajma"));
            si.idBicikla = reader.GetInt32(reader.GetOrdinal("idBicikla"));
            return si;
        }

        public override string ToString()
        {
            return this.Bicikla.Model;
        }
    }
}
