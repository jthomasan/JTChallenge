using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalLoan.Migrations
{
    public partial class UpdateNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Loan_UserID",
                table: "PersonalLoanDetails",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loan_UserID",
                table: "PersonalLoanDetails");
        }
    }
}
