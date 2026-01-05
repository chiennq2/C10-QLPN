using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C10.Migrations
{
    /// <inheritdoc />
    public partial class AddDanhMucPhamNhan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DM_PHAM_NHAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Code = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
                    NoiDung = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CreatorUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DeleterUserId = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DM_PHAM_NHAN", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DM_PHAM_NHAN");
        }
    }
}
