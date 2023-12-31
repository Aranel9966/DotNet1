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
            using (var conn = new SqliteConnection("Data Source=Data/DotNet1.db"))
            {

            conn.Open();
            using (var cmd = new SqliteCommand(query, conn))
            {

            using (var reader = cmd.ExecuteReader())
            {
                var dataSet = new DataSet();
                var dataTable = new DataTable();
                dataSet.Tables.Add(dataTable);
                dataTable.Load(reader);
                return dataSet;
            
            }
            }
            }
            
            throw new NotImplementedException();
        }
    }
}