using PersonalLoan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Repositories
{
    public class ConfigRepository : IConfigRepository
    {
        public string ConnectionString { get; set; }
    }
}
