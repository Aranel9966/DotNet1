using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet1.Models.Services.infrastructure
{
    public interface IDatabaseAccessor
    {
        DataSet Query(string query);
    }
}