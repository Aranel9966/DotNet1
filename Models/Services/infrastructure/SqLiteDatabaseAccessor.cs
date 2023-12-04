using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace DotNet1.Models.Services.infrastructure
{
    public class SqLiteDatabaseAccessor : IDatabaseAccessor
    {
        public DataSet Query(string query)
        {
            var conn = new SqliteConnection("Data Source=Data/DotNet1");
            conn.Open();
            var cmd = new SqliteCommand(query, conn);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string title = (string) reader["Title"];
            }
            conn.Dispose();
            throw new NotImplementedException();
        }
    }
}