using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PersonalLoan.Data.Models
{
    /// <summary>
    /// This is the db context class which is responsible for maintaining the schema of the database.
    /// The project is set up with code first approach. Hence running a migration and updating the database based on this schema will
    /// modify the database accordingly 
    /// </summary>
    public class PersonalLoanContext : DbContext
    {
        public PersonalLoanContext(DbContextOptions<PersonalLoanContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalLoanDetail> PersonalLoanDetails { get; set; }
    }

    /// <summary>
    /// Schema for PersonalLoanDetail table
    /// </summary>
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
