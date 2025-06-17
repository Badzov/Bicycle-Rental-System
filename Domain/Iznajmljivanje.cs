using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Iznajmljivanje : IDomainObject
    {
        public int IdIznajmljivanje { get; set; }
        public DateTime? DatumIznajmljivanja { get; set; }
        public DateTime? DatumPovratka { get; set; }
        public Automat Automat { get; set; }
        public PoslovniPartner PoslovniPartner {get; set;}

        public List<StavkaIznajmljivanja> Stavke { get; set; }

        public Iznajmljivanje()
        {
            Stavke = new List<StavkaIznajmljivanja>();
        }

        public int idAutomat;
        public int idPoslovniPartner;

        public string TableName => "Iznajmljivanje";
        public string InsertColumns => "datumIznajmljivanja, datumPovratka, idAutomat, idPoslovniPartner";
        public string InsertParameters => "@DatumIznajmljivanja, @DatumPovratka, @IdAutomat, @IdPoslovniPartner";
        public string UpdateStatement => "datumIznajmljivanja = @DatumIznajmljivanja, datumPovratka = @DatumPovratka, idAutomat = @IdAutomat, idPoslovniPartner = @IdPoslovniPartner";
        public string Condition => $"idIznajmljivanje = @IdIznajmljivanje";
        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdIznajmljivanje", IdIznajmljivanje },
            { "@DatumIznajmljivanja", DatumIznajmljivanja },
            { "@DatumPovratka", DatumPovratka },
            { "@IdAutomat", Automat?.IdAutomat },
            { "@IdPoslovniPartner", PoslovniPartner?.IdPoslovniPartner },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "idAutomat", Automat?.IdAutomat },
            { "idPoslovniPartner", PoslovniPartner?.IdPoslovniPartner },
            { "datumIznajmljivanja", DatumIznajmljivanja },
            { "datumPovratka", DatumPovratka }
        };

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Iznajmljivanje i = new Iznajmljivanje();
            i.IdIznajmljivanje = reader.GetInt32(reader.GetOrdinal("idIznajmljivanje"));
            i.DatumIznajmljivanja = reader.GetDateTime(reader.GetOrdinal("datumIznajmljivanja"));
            i.DatumPovratka = reader.GetDateTime(reader.GetOrdinal("datumPovratka"));
            i.idAutomat = reader.GetInt32(reader.GetOrdinal("idAutomat"));
            i.idPoslovniPartner = reader.GetInt32(reader.GetOrdinal("idPoslovniPartner"));
            return i;
        }

        public override string ToString()
        {
            return this.Automat + "-" + this.PoslovniPartner + ": " + this.DatumIznajmljivanja + "-" + this.DatumPovratka;
        }

    }
}
