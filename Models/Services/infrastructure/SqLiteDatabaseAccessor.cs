using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet1.Models.Services.infrastructure
{
    public class SqLiteDatabaseAccessor : IDatabaseAccessor
    {
        public DataSet Query(string query)
        {
            throw new NotImplementedException();
        }
    }
}