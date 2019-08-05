using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalLoan.Migrations
{
    public partial class UpdateData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonalLoanDetails",
                columns: new[] { "PersonalLoanId", "AccountNumber", "Balance", "CarryOverAmount", "Fee", "Interest", "Loan_UserID" },
                values: new object[] { 1L, 4155988172687L, 1927L, 1889L, 76, 376L, 1L });

            migrationBuilder.InsertData(
                table: "PersonalLoanDetails",
                columns: new[] { "PersonalLoanId", "AccountNumber", "Balance", "CarryOverAmount", "Fee", "Interest", "Loan_UserID" },
                values: new object[] { 2L, 545917281918L, 1138L, 1748L, 27, 341L, 1L });

            migrationBuilder.InsertData(
                table: "PersonalLoanDetails",
                columns: new[] { "PersonalLoanId", "AccountNumber", "Balance", "CarryOverAmount", "Fee", "Interest", "Loan_UserID" },
                values: new object[] { 3L, 43523141662514L, 1243L, 1578L, 87, 321L, 1L });

            migrationBuilder.InsertData(
                table: "PersonalLoanDetails",
                columns: new[] { "PersonalLoanId", "AccountNumber", "Balance", "CarryOverAmount", "Fee", "Interest", "Loan_UserID" },
                values: new object[] { 4L, 4155988172687L, 1927L, 1889L, 76, 376L, 2L });

            migrationBuilder.InsertData(
                table: "PersonalLoanDetails",
                columns: new[] { "PersonalLoanId", "AccountNumber", "Balance", "CarryOverAmount", "Fee", "Interest", "Loan_UserID" },
                values: new object[] { 5L, 545917281918L, 1138L, 1748L, 27, 341L, 2L });

            migrationBuilder.InsertData(
                table: "PersonalLoanDetails",
                columns: new[] { "PersonalLoanId", "AccountNumber", "Balance", "CarryOverAmount", "Fee", "Interest", "Loan_UserID" },
                values: new object[] { 6L, 43523141662514L, 1243L, 1578L, 87, 321L, 3L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonalLoanDetails",
                keyColumn: "PersonalLoanId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PersonalLoanDetails",
                keyColumn: "PersonalLoanId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PersonalLoanDetails",
                keyColumn: "PersonalLoanId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PersonalLoanDetails",
                keyColumn: "PersonalLoanId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PersonalLoanDetails",
                keyColumn: "PersonalLoanId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PersonalLoanDetails",
                keyColumn: "PersonalLoanId",
                keyValue: 6L);
        }
    }
}
