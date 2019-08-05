using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Interfaces
{
    public interface IConfigRepository
    {
        string ConnectionString { get; }
    }
}
