using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppDemo01.models;

namespace WebAppDemo01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180527055330_xx")]
    partial class xx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppDemo01.models.CatCorreos", b =>
                {
                    b.Property<int>("CodigoCatCorreo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescripcionCatCorreo");

                    b.Property<string>("NombreCatCorreo");

                    b.HasKey("CodigoCatCorreo");

                    b.ToTable("CategoriasCorreos");
                });

            modelBuilder.Entity("WebAppDemo01.models.Correos", b =>
                {
                    b.Property<int>("CodigoCorreo")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CatCorreosCodigoCatCorreo");

                    b.Property<int>("CodigoCategoria");

                    b.Property<string>("DescripCorreo");

                    b.Property<string>("DescripCortaCorreo");

                    b.Property<string>("DescripLargaCorreo");

                    b.Property<bool>("EstadoCorreo");

                    b.Property<string>("FechaIngreso");

                    b.Property<string>("ImagenPreviaURL");

                    b.Property<string>("ImagenURL");

                    b.Property<string>("NombreCorreo");

                    b.HasKey("CodigoCorreo");

                    b.HasIndex("CatCorreosCodigoCatCorreo");

                    b.ToTable("Correos");
                });

            modelBuilder.Entity("WebAppDemo01.models.Correos", b =>
                {
                    b.HasOne("WebAppDemo01.models.CatCorreos", "CatCorreos")
                        .WithMany("Correos")
                        .HasForeignKey("CatCorreosCodigoCatCorreo");
                });
        }
    }
}
