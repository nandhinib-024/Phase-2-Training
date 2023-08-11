using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCF1.Migrations
{
    /// <inheritdoc />
    public partial class createdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Depno = table.Column<int>(type: "int", nullable: false),
                    Dname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Depno);
                });

            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    Empno = table.Column<int>(type: "int", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deptno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptnonavDepno = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.Empno);
                    table.ForeignKey(
                        name: "FK_Emps_Depts_DeptnonavDepno",
                        column: x => x.DeptnonavDepno,
                        principalTable: "Depts",
                        principalColumn: "Depno");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emps_DeptnonavDepno",
                table: "Emps",
                column: "DeptnonavDepno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emps");

            migrationBuilder.DropTable(
                name: "Depts");
        }
    }
}
