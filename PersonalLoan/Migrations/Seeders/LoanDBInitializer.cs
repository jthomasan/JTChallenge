using PersonalLoan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalLoan.Migrations.Seeders
{
    public class LoanDBInitializer 
    {
        public LoanDBInitializer(PersonalLoanContext context)
        {
            IList<PersonalLoanDetail> defaultLoanDetails = new List<PersonalLoanDetail>
            {
                new PersonalLoanDetail()
                {
                    PersonalLoanId = 1,
                    AccountNumber = 4155988172687,
                    Balance = 1927,
                    Interest = 376,
                    CarryOverAmount = 1889,
                    Fee = 76,
                    Loan_UserID = 1
                },

                new PersonalLoanDetail()
                {
                    PersonalLoanId = 2,
                    AccountNumber = 545917281918,
                    Balance = 1138,
                    Interest = 341,
                    CarryOverAmount = 1748,
                    Fee = 27,
                    Loan_UserID = 1
                },

                new PersonalLoanDetail()
                {
                    PersonalLoanId = 3,
                    AccountNumber = 43523141662514,
                    Balance = 1243,
                    Interest = 321,
                    CarryOverAmount = 1578,
                    Fee = 87,
                    Loan_UserID = 1
                }
            };

            context.PersonalLoanDetails.AddRange(defaultLoanDetails);
            context.SaveChanges();

            //base.Seed(context);
        }
    }
}
