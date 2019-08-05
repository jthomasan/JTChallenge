using PersonalLoan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Interfaces
{
    public interface IPersonalLoanDetailsRepository
    {
        List<PersonalLoanDetail> GetPersonalLoanDetails(long id);
    }
}
