using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppDemo01.Migrations
{
    public partial class xx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasCorreos",
                columns: table => new
                {
                    CodigoCatCorreo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionCatCorreo = table.Column<string>(nullable: true),
                    NombreCatCorreo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasCorreos", x => x.CodigoCatCorreo);
                });

            migrationBuilder.CreateTable(
                name: "Correos",
                columns: table => new
                {
                    CodigoCorreo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatCorreosCodigoCatCorreo = table.Column<int>(nullable: true),
                    CodigoCategoria = table.Column<int>(nullable: false),
                    DescripCorreo = table.Column<string>(nullable: true),
                    DescripCortaCorreo = table.Column<string>(nullable: true),
                    DescripLargaCorreo = table.Column<string>(nullable: true),
                    EstadoCorreo = table.Column<bool>(nullable: false),
                    FechaIngreso = table.Column<string>(nullable: true),
                    ImagenPreviaURL = table.Column<string>(nullable: true),
                    ImagenURL = table.Column<string>(nullable: true),
                    NombreCorreo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correos", x => x.CodigoCorreo);
                    table.ForeignKey(
                        name: "FK_Correos_CategoriasCorreos_CatCorreosCodigoCatCorreo",
                        column: x => x.CatCorreosCodigoCatCorreo,
                        principalTable: "CategoriasCorreos",
                        principalColumn: "CodigoCatCorreo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Correos_CatCorreosCodigoCatCorreo",
                table: "Correos",
                column: "CatCorreosCodigoCatCorreo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Correos");

            migrationBuilder.DropTable(
                name: "CategoriasCorreos");
        }
    }
}
