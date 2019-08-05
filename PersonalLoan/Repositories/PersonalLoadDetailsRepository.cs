using PersonalLoan.Data.Models;
using PersonalLoan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Repositories
{
    public class PersonalLoadDetailsRepository : IPersonalLoanDetailsRepository
    {
        public PersonalLoanContext _context { get; }

        public PersonalLoadDetailsRepository(PersonalLoanContext personalLoanContext)
        {
            _context = personalLoanContext;
        }

        public List<PersonalLoanDetail> GetPersonalLoanDetails(long id)
        {
           return _context.PersonalLoanDetails.Where(c => c.Loan_UserID == id).ToList();
        }
    }
}
