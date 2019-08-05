using PersonalLoan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Repositories
{
    /// <summary>
    /// Implements the config repository interface in order to populate the configuration object.
    /// </summary>
    public class ConfigRepository : IConfigRepository
    {
        public string ConnectionString { get; set; }
    }
}
