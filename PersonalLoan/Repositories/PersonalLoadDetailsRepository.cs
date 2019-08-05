using PersonalLoan.Data.Models;
using PersonalLoan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Repositories
{
    /// <summary>
    /// The below repository class is responsible for retrieving the personal loan details from
    /// the database based on the user id provided.
    /// </summary>
    public class PersonalLoadDetailsRepository : IPersonalLoanDetailsRepository
    {
        public PersonalLoanContext Context { get; }

        public PersonalLoadDetailsRepository(PersonalLoanContext personalLoanContext)
        {
            Context = personalLoanContext;
        }

        /// <summary>
        /// Takes the user id as input and returns a list of personal loan details associated with the user.
        /// </summary>
        /// <param name="id">User identification number.</param>
        /// <returns>List of personal loan details associated with the supplied user id.</returns>
        public List<PersonalLoanDetail> GetPersonalLoanDetails(long id)
        {
           return Context.PersonalLoanDetails.Where(c => c.Loan_UserID == id).ToList();
        }
    }
}
