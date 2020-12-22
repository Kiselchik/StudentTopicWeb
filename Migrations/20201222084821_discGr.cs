using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTopicWeb.Migrations
{
    public partial class discGr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplineGroupDisciplineId",
                table: "Work",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisciplineGroupGroupId",
                table: "Work",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DisciplineGroup",
                columns: table => new
                {
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineGroup", x => new { x.DisciplineId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_DisciplineGroup_Discipline_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Discipline",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplineGroup_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Work_DisciplineGroupDisciplineId_DisciplineGroupGroupId",
                table: "Work",
                columns: new[] { "DisciplineGroupDisciplineId", "DisciplineGroupGroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineGroup_GroupId",
                table: "DisciplineGroup",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Work_DisciplineGroup_DisciplineGroupDisciplineId_DisciplineGroupGroupId",
                table: "Work",
                columns: new[] { "DisciplineGroupDisciplineId", "DisciplineGroupGroupId" },
                principalTable: "DisciplineGroup",
                principalColumns: new[] { "DisciplineId", "GroupId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Work_DisciplineGroup_DisciplineGroupDisciplineId_DisciplineGroupGroupId",
                table: "Work");

            migrationBuilder.DropTable(
                name: "DisciplineGroup");

            migrationBuilder.DropIndex(
                name: "IX_Work_DisciplineGroupDisciplineId_DisciplineGroupGroupId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "DisciplineGroupDisciplineId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "DisciplineGroupGroupId",
                table: "Work");
        }
    }
}
