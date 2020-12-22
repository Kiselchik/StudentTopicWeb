using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTopicWeb.Migrations
{
    public partial class work : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Work",
                columns: table => new
                {
                    WorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxStudents = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentTopicAllow = table.Column<bool>(type: "bit", nullable: false),
                    MaxTopics = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work", x => x.WorkId);
                    table.ForeignKey(
                        name: "FK_Work_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Topic_WorkId",
                table: "Topic",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_TypeId",
                table: "Work",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Work_WorkId",
                table: "Topic",
                column: "WorkId",
                principalTable: "Work",
                principalColumn: "WorkId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Work_WorkId",
                table: "Topic");

            migrationBuilder.DropTable(
                name: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Topic_WorkId",
                table: "Topic");
        }
    }
}
