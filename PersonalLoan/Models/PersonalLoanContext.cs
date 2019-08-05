using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalLoan.Data.Models
{
    public class PersonalLoanContext : DbContext
    {
        public PersonalLoanContext(DbContextOptions<PersonalLoanContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalLoanDetail> PersonalLoanDetails { get; set; }
    }

    public class PersonalLoanDetail
    {
        [Key]
        public long PersonalLoanId { get; set; }
        public long Loan_UserID { get; set; }
        public long AccountNumber { get; set; }
        public long Balance { get; set; }
        public long Interest { get; set; }
        public int Fee { get; set; }
        public long CarryOverAmount { get; set; }
    }
}
