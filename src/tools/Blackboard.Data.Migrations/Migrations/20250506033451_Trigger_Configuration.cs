using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blackboard.Data.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Trigger_Configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("ALTER DATABASE BlackBoard SET CHANGE_TRACKING = ON (CHANGE_RETENTION = 2 DAYS, AUTO_CLEANUP = ON)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("ALTER DATABASE BlackBoard SET CHANGE_TRACKING = OFF");
        }
    }
}
