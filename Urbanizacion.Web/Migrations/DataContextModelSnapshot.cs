﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Urbanizacion.Web.Data;

namespace Urbanizacion.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Aniostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ani_Descripcion")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<string>("Ani_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.HasIndex("Ani_Descripcion")
                        .IsUnique();

                    b.ToTable("Aniostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Egresostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnioId");

                    b.Property<string>("Egr_Descripcion");

                    b.Property<string>("Egr_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("Egr_FechadePago");

                    b.Property<DateTime>("Egr_FechadeRegistro");

                    b.Property<float>("Egr_Valor");

                    b.Property<int?>("MesId");

                    b.Property<int?>("TiposGId");

                    b.HasKey("Id");

                    b.HasIndex("AnioId");

                    b.HasIndex("MesId");

                    b.HasIndex("TiposGId");

                    b.ToTable("Egresostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.EstadosFinancierostbl", b =>
                {
                    b.Property<int>("IdIngresos");

                    b.Property<int>("IdEgresos");

                    b.Property<int?>("EgresosId");

                    b.Property<int?>("IngresosId");

                    b.Property<int?>("PagosDeletetblId");

                    b.HasKey("IdIngresos", "IdEgresos");

                    b.HasIndex("EgresosId");

                    b.HasIndex("IngresosId");

                    b.HasIndex("PagosDeletetblId");

                    b.ToTable("EstadosFinancierostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Managerstbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Managerstbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.MarcasAutostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mar_Descripcion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("MarcasAutostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Mesestbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mes_Descripcion");

                    b.HasKey("Id");

                    b.ToTable("Mesestbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Negociostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Neg_Descripcion");

                    b.Property<string>("Neg_Direccion");

                    b.Property<string>("Neg_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("Neg_FechaCreacion");

                    b.Property<string>("Neg_Nombre");

                    b.Property<string>("Neg_Telefono")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int?>("PropietariosId");

                    b.HasKey("Id");

                    b.HasIndex("PropietariosId");

                    b.ToTable("Negociostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Noticiastbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Not_Autor");

                    b.Property<string>("Not_Descripcion");

                    b.Property<string>("Not_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("Not_Fecha");

                    b.Property<DateTime>("Not_FechaCreacion");

                    b.Property<string>("Not_Titulo");

                    b.HasKey("Id");

                    b.ToTable("Noticiastbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.PagosDeletetbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnioId");

                    b.Property<string>("Borr_Id")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("MesId");

                    b.Property<string>("PAG_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("PAG_FECHACREACION");

                    b.Property<DateTime>("PAG_FECHAPAGADO");

                    b.Property<string>("PAG_PAGADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int?>("PropietarioId");

                    b.Property<int?>("PuntodePagoId");

                    b.Property<int?>("TiposId");

                    b.Property<int?>("ValId");

                    b.HasKey("Id");

                    b.HasIndex("AnioId");

                    b.HasIndex("MesId");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("PuntodePagoId");

                    b.HasIndex("TiposId");

                    b.HasIndex("ValId");

                    b.ToTable("PagosDeletetbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Pagostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnioId");

                    b.Property<int>("Borr_Id");

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("MesId");

                    b.Property<string>("PAG_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("PAG_FECHACREACION");

                    b.Property<DateTime>("PAG_FECHAPAGADO");

                    b.Property<string>("PAG_PAGADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int?>("PropietarioId");

                    b.Property<int?>("PuntodePagoId");

                    b.Property<int?>("TiposId");

                    b.Property<int?>("ValId");

                    b.HasKey("Id");

                    b.HasIndex("AnioId");

                    b.HasIndex("MesId");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("PuntodePagoId");

                    b.HasIndex("TiposId");

                    b.HasIndex("ValId");

                    b.ToTable("Pagostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Productostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("NegocioId");

                    b.Property<string>("Pro_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("Pro_FechaCreacion");

                    b.Property<string>("Pro_Nombre");

                    b.Property<string>("Pro_Precio");

                    b.HasKey("Id");

                    b.HasIndex("NegocioId");

                    b.ToTable("Productostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Propietariostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Propietariostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.PuntosPagotbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pun_Descripcion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Pun_Descripcion")
                        .IsUnique();

                    b.ToTable("PuntosPagotbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Saldostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Saldostbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TipoIdentificaciontbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipI_Descripcion");

                    b.HasKey("Id");

                    b.ToTable("TipoIdentificaciontbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TipoPersonatbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipP_Descripcion");

                    b.HasKey("Id");

                    b.ToTable("TipoPersonastbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TiposGastotbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tip_Descripcion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Tip_Descripcion")
                        .IsUnique();

                    b.ToTable("TiposGastotbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TiposPagotbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tip_Descripcion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Tip_Descripcion")
                        .IsUnique();

                    b.ToTable("TiposPagotbl");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TiposViviendatbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipV_Descripcion");

                    b.HasKey("Id");

                    b.ToTable("TiposViviendatbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Userstbl", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Pro_Apellidos")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Pro_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Pro_Identificacion")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Pro_Lote")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("Pro_Nombres")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Pro_Observaciones");

                    b.Property<string>("Pro_Telefono")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("TipIdeId");

                    b.Property<int?>("TipPerId");

                    b.Property<int?>("TipVivId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("TipIdeId");

                    b.HasIndex("TipPerId");

                    b.HasIndex("TipVivId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Valorestbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Val_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("Val_FechaCreacion");

                    b.Property<string>("Val_Valor")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Val_Valor")
                        .IsUnique();

                    b.ToTable("Valorestbls");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Vehiculostbl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("MarcasAutostblId");

                    b.Property<int?>("PropietarioId");

                    b.Property<DateTime>("Veh_Born");

                    b.Property<string>("Veh_Codigo")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Veh_Detalles");

                    b.Property<string>("Veh_Estado")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Veh_Placa")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.HasKey("Id");

                    b.HasIndex("MarcasAutostblId");

                    b.HasIndex("PropietarioId");

                    b.HasIndex("Veh_Codigo")
                        .IsUnique();

                    b.ToTable("Vehiculostbls");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Userstbl")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Userstbl")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Urbanizacion.Web.Data.Entities.Userstbl")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Userstbl")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Egresostbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Aniostbl", "Anio")
                        .WithMany("Egresos")
                        .HasForeignKey("AnioId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Mesestbl", "Mes")
                        .WithMany("Egresos")
                        .HasForeignKey("MesId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.TiposGastotbl", "TiposG")
                        .WithMany("Egresos")
                        .HasForeignKey("TiposGId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.EstadosFinancierostbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Egresostbl", "Egresos")
                        .WithMany("EstaFinantbls")
                        .HasForeignKey("EgresosId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Pagostbl", "Ingresos")
                        .WithMany("EstaFinantbls")
                        .HasForeignKey("IngresosId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.PagosDeletetbl")
                        .WithMany("EstaFinantbls")
                        .HasForeignKey("PagosDeletetblId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Managerstbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Userstbl", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Negociostbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Propietariostbl", "Propietarios")
                        .WithMany("Negocio")
                        .HasForeignKey("PropietariosId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.PagosDeletetbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Aniostbl", "Anio")
                        .WithMany("PagosDel")
                        .HasForeignKey("AnioId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Mesestbl", "Mes")
                        .WithMany("PagosDel")
                        .HasForeignKey("MesId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Propietariostbl", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.PuntosPagotbl", "PuntodePago")
                        .WithMany("PagosDel")
                        .HasForeignKey("PuntodePagoId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.TiposPagotbl", "Tipos")
                        .WithMany("PagosDel")
                        .HasForeignKey("TiposId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Valorestbl", "Val")
                        .WithMany("PagosDel")
                        .HasForeignKey("ValId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Pagostbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Aniostbl", "Anio")
                        .WithMany("Pagos")
                        .HasForeignKey("AnioId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Mesestbl", "Mes")
                        .WithMany("Pagos")
                        .HasForeignKey("MesId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Propietariostbl", "Propietario")
                        .WithMany("Pagos")
                        .HasForeignKey("PropietarioId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.PuntosPagotbl", "PuntodePago")
                        .WithMany("Pagos")
                        .HasForeignKey("PuntodePagoId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.TiposPagotbl", "Tipos")
                        .WithMany("Pagos")
                        .HasForeignKey("TiposId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Valorestbl", "Val")
                        .WithMany("Pagos")
                        .HasForeignKey("ValId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Productostbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Negociostbl", "Negocio")
                        .WithMany("Producto")
                        .HasForeignKey("NegocioId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Propietariostbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.Userstbl", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Userstbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TipoIdentificaciontbl", "TipIde")
                        .WithMany("Propietarios")
                        .HasForeignKey("TipIdeId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.TipoPersonatbl", "TipPer")
                        .WithMany("Propietarios")
                        .HasForeignKey("TipPerId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.TiposViviendatbl", "TipViv")
                        .WithMany("Propietarios")
                        .HasForeignKey("TipVivId");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.Vehiculostbl", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.MarcasAutostbl")
                        .WithMany("Vehiculos")
                        .HasForeignKey("MarcasAutostblId");

                    b.HasOne("Urbanizacion.Web.Data.Entities.Propietariostbl", "Propietario")
                        .WithMany("Vehiculos")
                        .HasForeignKey("PropietarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
