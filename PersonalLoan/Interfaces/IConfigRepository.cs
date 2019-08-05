using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Interfaces
{
    /// <summary>
    /// This interface provides the signature for reading the configuration object.
    /// </summary>
    public interface IConfigRepository
    {
        string ConnectionString { get; }
    }
}
