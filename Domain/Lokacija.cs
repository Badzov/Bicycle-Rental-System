using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Lokacija : IEntity
    {
        public int IdLokacija { get; set; }
        public string Naziv { get; set; }
        public string Opstina { get; set; }

        public string TableName => "Lokacija";
        public string InsertColumns => "naziv, opstina";
        public string InsertParameters => "@Naziv, @Opstina";
        public string UpdateStatement => "naziv = @Naziv, opstina = @Opstina";
        public string Condition => $"idLokacija = @IdLokacija";
        public Dictionary<string, object> Parameters => new Dictionary<string, object>
        {
            { "@IdLokacija", IdLokacija },
            { "@Naziv", Naziv },
            { "@Opstina", Opstina },
        };
        public Dictionary<string, object> SearchableProperties => new Dictionary<string, object>
        {
            { "naziv", Naziv },
            { "opstina", Opstina },
        };

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Lokacija l = new Lokacija();
            l.IdLokacija = reader.GetInt32(reader.GetOrdinal("idLokacija"));
            l.Naziv = reader.GetString(reader.GetOrdinal("naziv"));
            l.Opstina = reader.GetString(reader.GetOrdinal("opstina"));
            return l;
        }

        public override string ToString()
        {
            return this.Naziv + " " + this.Opstina;
        }
    }
}
