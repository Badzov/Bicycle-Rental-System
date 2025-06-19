using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AutomatLokacija : IDomainObject
    {
        public Automat Automat { get; set; }
        public Lokacija Lokacija { get; set; }
        public DateTime DatumPostavljanja { get; set; }

        public int idAutomat;
        public int idLokacija;

        public string TableName => "AutomatLokacija";
        public string InsertColumns => "idAutomat, idLokacija, datumPostavljanja";
        public string InsertParameters => "@IdAutomat, @IdLokacija, @DatumPostavljanja";
        public string UpdateStatement => "idAutomat = @IdAutomat, idLokacija = @IdLokacija, datumPostavljanja = @DatumPostavljanja";
        public string Condition => "idAutomat = @IdAutomat AND idLokacija = @IdLokacija";
        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdAutomat", Automat?.IdAutomat },
            { "@IdLokacija", Lokacija?.IdLokacija },
            { "@DatumPostavljanja", DatumPostavljanja },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            
        };

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            AutomatLokacija al = new AutomatLokacija();
            al.idAutomat = reader.GetInt32(reader.GetOrdinal("idAutomat"));
            al.idLokacija = reader.GetInt32(reader.GetOrdinal("idLokacija"));
            al.DatumPostavljanja = reader.GetDateTime(reader.GetOrdinal("datumPostavljanja"));
            return al;
        }

        public override string ToString()
        {
            return $"{Automat?.KorisnickoIme ?? "N/A"} na {Lokacija?.Naziv ?? "N/A"} od {DatumPostavljanja}";
        }
    }
}
