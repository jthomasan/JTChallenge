using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalLoan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoanController : ControllerBase
    {
        [HttpGet("[action]")]
        public IEnumerable<UserLoanDetail> UserDetail(int id)
        {
            var retVal = new List<UserLoanDetail>
            {
                new UserLoanDetail
                {
                    Id = 1,
                    OrderNumber = 1,
                    LoanAccountNumber = 121212,
                    Balance = 1927,
                    Interest = 376,
                    Fee = 76,
                    CarryOverAmount = 1889
                }
            };
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