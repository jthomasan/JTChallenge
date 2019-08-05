using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalLoan.Interfaces;

namespace PersonalLoan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoanController : ControllerBase
    {
        public IPersonalLoanDetailsRepository _personalLoanDetailsRepository { get; }
        public UserLoanController(IPersonalLoanDetailsRepository personalLoanDetailsRepository)
        {
            _personalLoanDetailsRepository = personalLoanDetailsRepository;
        }
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