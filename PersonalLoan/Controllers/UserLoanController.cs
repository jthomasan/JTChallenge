using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalLoan.Interfaces;

namespace PersonalLoan.Controllers
{
    /// <summary>
    /// This api is responsible for supplying personal loan detail bassed on the selected user.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoanController : ControllerBase
    {
        public IPersonalLoanDetailsRepository _personalLoanDetailsRepository { get; }

        /// <summary>
        /// The repository object is injected during runtime.
        /// </summary>
        /// <param name="personalLoanDetailsRepository"></param>
        public UserLoanController(IPersonalLoanDetailsRepository personalLoanDetailsRepository)
        {
            _personalLoanDetailsRepository = personalLoanDetailsRepository;
        }

        /// <summary>
        /// This api accepts a user identity key and return a list of personal loans associated with the user.
        /// </summary>
        /// <param name="id">The user identity key</param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IEnumerable<UserLoanDetail> UserDetail(int id)
        {
            var obj = _personalLoanDetailsRepository.GetPersonalLoanDetails(id);
            int i = 1;
            var retVal = obj.Select(c => new UserLoanDetail()
            {
                Id = c.PersonalLoanId,
                OrderNumber = i++,
                LoanAccountNumber = c.AccountNumber,
                Balance = c.Balance,
                Interest = c.Interest,
                Fee = c.Fee,
                CarryOverAmount = c.CarryOverAmount
            });

            return retVal;
        }

        /// <summary>
        /// An object representing the different attributes of a personal loan.
        /// </summary>
        public class UserLoanDetail
        {
            public long Id { get; set; }
            public int OrderNumber { get; set; }
            public long LoanAccountNumber { get; set; }
            public long Balance { get; set; }
            public long Interest { get; set; }
            public int Fee { get; set; }
            public long CarryOverAmount { get; set; }
        }
    }
}