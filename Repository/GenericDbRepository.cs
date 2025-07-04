﻿using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {

        private Broker broker = new Broker();

        public void OpenConnection()
        {
            broker.OpenConnection();
        }
        public void CloseConnection()
        {
            broker.CloseConnection();
        }
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }
        public void Commit()
        {
            broker.Commit();
        }
        public void Rollback()
        {
            broker.Rollback();
        }

        public List<IDomainObject> GetAll(IDomainObject obj)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT * FROM {obj.TableName}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = obj.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            command.Dispose();
            return result;
        }

        public IDomainObject Get(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"SELECT * FROM {obj.TableName} WHERE {obj.Condition}";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return obj.ReadObjectRow(reader);
                }
            }
            return null; 
        }

        public void Add(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"INSERT INTO {obj.TableName} ({obj.InsertColumns}) VALUES ({obj.InsertParameters})";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public int AddReturnId(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"INSERT INTO {obj.TableName} ({obj.InsertColumns}) VALUES ({obj.InsertParameters}); SELECT SCOPE_IDENTITY();";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            int result = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            return result;
        }

        public void Delete(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"DELETE FROM {obj.TableName} WHERE {obj.Condition}";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public List<IDomainObject> Search(IDomainObject criteria)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();

            var props = criteria.SearchableProperties;
            List<string> conditions = new List<string>();

            foreach (var pair in props)
            {
                var value = pair.Value;

                if (value == null)
                    continue;

                if (value is string)
                {
                    conditions.Add($"{pair.Key} LIKE @{pair.Key}");
                    command.Parameters.AddWithValue($"@{pair.Key}", $"%{value}%");
                }
                else if (value is DateTime)
                {
                    conditions.Add($"{pair.Key} = @{pair.Key}");
                    command.Parameters.AddWithValue($"@{pair.Key}", value);
                }
                else
                {
                    conditions.Add($"{pair.Key} = @{pair.Key}");
                    command.Parameters.AddWithValue($"@{pair.Key}", value);
                }
            }

            string whereClause = conditions.Count > 0 ? "WHERE " + string.Join(" AND ", conditions) : "";
            command.CommandText = $"SELECT * FROM {criteria.TableName} {whereClause}";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = criteria.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }

            return result;
        }

        public void Update(IDomainObject obj)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"UPDATE {obj.TableName} SET {obj.UpdateStatement} WHERE {obj.Condition}";

            foreach (var param in obj.Parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
