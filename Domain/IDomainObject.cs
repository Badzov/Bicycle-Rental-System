using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomainObject
    {
        string TableName { get; }
        string InsertColumns { get; }     
        string InsertParameters { get; }
        string UpdateStatement { get; }
        string Condition { get; }
        Dictionary<string, object> Parameters { get; }
        Dictionary<string, object> SearchableProperties { get; }

        IDomainObject ReadObjectRow(SqlDataReader reader);
    }
}
