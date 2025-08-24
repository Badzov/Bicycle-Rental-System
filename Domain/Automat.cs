using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain
{
    public class Automat : IEntity
    {
        public int IdAutomat { get; set; }
        public DateTime DatumProizvodnje { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }

        public string TableName => "Automat";
        public string InsertColumns => "datumProizvodnje, korisnickoIme, sifra";
        public string InsertParameters => "@DatumProizvodnje, @KorisnickoIme, @Sifra";
        public string UpdateStatement => "datumProizvodnje = @DatumProizvodnje, korisnickoIme = @KorisnickoIme, sifra = @Sifra";
        public string Condition => $"idAutomat = @IdAutomat";
        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdAutomat", IdAutomat },
            { "@DatumProizvodnje", DatumProizvodnje },
            { "@KorisnickoIme", KorisnickoIme },
            { "@Sifra", Sifra },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "korisnickoIme", KorisnickoIme },
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Automat a = new Automat();
            a.IdAutomat = reader.GetInt32(reader.GetOrdinal("idAutomat"));
            a.DatumProizvodnje = reader.GetDateTime(reader.GetOrdinal("datumProizvodnje"));
            a.KorisnickoIme = reader.GetString(reader.GetOrdinal("korisnickoIme"));
            a.Sifra = reader.GetString(reader.GetOrdinal("sifra"));
            return a;
        }

        public override string ToString()
        {
            return this.KorisnickoIme;
        }
    }
}
