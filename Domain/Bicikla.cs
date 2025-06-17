using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bicikla : IDomainObject
    {
        public int IdBicikla { get; set; }
        public string Model { get; set; }
        public string Boja { get; set; }
        public int? GodinaProizvodnje { get; set; }
        public double? CenaBicikle { get; set; }

        public string TableName => "Bicikla";
        public string InsertColumns => "model, boja, godinaProizvodnje, cenaBicikle";
        public string InsertParameters => "@Model, @Boja, @GodinaProizvodnje, @CenaBicikle";
        public string UpdateStatement => "model = @Model, boja = @Boja, godinaProizvodnje = @GodinaProizvodnje, cenaBicikle = @CenaBicikle";
        public string Condition => $"idBicikla = @IdBicikla";
        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdBicikla", IdBicikla },
            { "@Model", Model },
            { "@Boja", Boja },
            { "@GodinaProizvodnje", GodinaProizvodnje },
            { "@CenaBicikle", CenaBicikle },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "model", Model },
            { "boja", Boja },
            { "godinaProizvodnje", GodinaProizvodnje },
            { "cenaBicikle", CenaBicikle },
        };

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Bicikla b = new Bicikla();
            b.IdBicikla = reader.GetInt32(reader.GetOrdinal("idBicikla"));
            b.Model = reader.GetString(reader.GetOrdinal("model"));
            b.Boja = reader.GetString(reader.GetOrdinal("boja"));
            b.GodinaProizvodnje = reader.GetInt32(reader.GetOrdinal("godinaProizvodnje"));
            b.CenaBicikle = reader.GetDouble(reader.GetOrdinal("cenaBicikle"));
            return b;
        }

        public override string ToString()
        {
            return this.Model + " " + this.GodinaProizvodnje + " " + this.Boja;
        }
    }
}
