using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Urbanizacion.Web.Migrations
{
    public partial class basecompleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aniostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ani_Descripcion = table.Column<string>(maxLength: 4, nullable: false),
                    Ani_Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aniostbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcasAutostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mar_Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcasAutostbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesestbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mes_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesestbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noticiastbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Not_Titulo = table.Column<string>(nullable: true),
                    Not_Autor = table.Column<string>(nullable: true),
                    Not_Descripcion = table.Column<string>(nullable: true),
                    Not_Fecha = table.Column<DateTime>(nullable: false),
                    Not_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Not_Estado = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticiastbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PuntosPagotbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pun_Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosPagotbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saldostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saldostbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificaciontbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipI_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificaciontbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersonastbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipP_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonastbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposGastotbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tip_Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposGastotbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposPagotbl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tip_Descripcion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPagotbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposViviendatbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipV_Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposViviendatbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valorestbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Val_Valor = table.Column<string>(nullable: false),
                    Val_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Val_Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valorestbls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Egresostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Egr_FechadePago = table.Column<DateTime>(nullable: false),
                    Egr_Descripcion = table.Column<string>(nullable: true),
                    Egr_Valor = table.Column<float>(nullable: false),
                    Egr_FechadeRegistro = table.Column<DateTime>(nullable: false),
                    Egr_Estado = table.Column<string>(nullable: false),
                    AnioId = table.Column<int>(nullable: true),
                    MesId = table.Column<int>(nullable: true),
                    TiposGId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egresostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egresostbls_Aniostbls_AnioId",
                        column: x => x.AnioId,
                        principalTable: "Aniostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Egresostbls_Mesestbls_MesId",
                        column: x => x.MesId,
                        principalTable: "Mesestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Egresostbls_TiposGastotbls_TiposGId",
                        column: x => x.TiposGId,
                        principalTable: "TiposGastotbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Pro_Lote = table.Column<string>(maxLength: 3, nullable: false),
                    Pro_Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Pro_Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Pro_Observaciones = table.Column<string>(nullable: true),
                    Pro_Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Pro_Estado = table.Column<string>(nullable: false),
                    Pro_Identificacion = table.Column<string>(maxLength: 10, nullable: false),
                    TipPerId = table.Column<int>(nullable: true),
                    TipVivId = table.Column<int>(nullable: true),
                    TipIdeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TipoIdentificaciontbls_TipIdeId",
                        column: x => x.TipIdeId,
                        principalTable: "TipoIdentificaciontbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TipoPersonastbls_TipPerId",
                        column: x => x.TipPerId,
                        principalTable: "TipoPersonastbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TiposViviendatbls_TipVivId",
                        column: x => x.TipVivId,
                        principalTable: "TiposViviendatbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Managerstbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managerstbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managerstbls_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propietariostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietariostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Propietariostbls_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Negociostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Neg_Nombre = table.Column<string>(nullable: true),
                    Neg_Descripcion = table.Column<string>(nullable: true),
                    Neg_Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Neg_Direccion = table.Column<string>(nullable: true),
                    Neg_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Neg_Estado = table.Column<string>(nullable: false),
                    PropietariosId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negociostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Negociostbls_Propietariostbls_PropietariosId",
                        column: x => x.PropietariosId,
                        principalTable: "Propietariostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PagosDeletetbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PAG_FECHAPAGADO = table.Column<DateTime>(nullable: false),
                    PAG_FECHACREACION = table.Column<DateTime>(nullable: false),
                    PAG_ESTADO = table.Column<string>(nullable: false),
                    PAG_PAGADO = table.Column<string>(nullable: false),
                    PropietarioId = table.Column<int>(nullable: true),
                    AnioId = table.Column<int>(nullable: true),
                    MesId = table.Column<int>(nullable: true),
                    ValId = table.Column<int>(nullable: true),
                    TiposId = table.Column<int>(nullable: true),
                    PuntodePagoId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Borr_Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosDeletetbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagosDeletetbls_Aniostbls_AnioId",
                        column: x => x.AnioId,
                        principalTable: "Aniostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagosDeletetbls_Mesestbls_MesId",
                        column: x => x.MesId,
                        principalTable: "Mesestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagosDeletetbls_Propietariostbls_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietariostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagosDeletetbls_PuntosPagotbls_PuntodePagoId",
                        column: x => x.PuntodePagoId,
                        principalTable: "PuntosPagotbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagosDeletetbls_TiposPagotbl_TiposId",
                        column: x => x.TiposId,
                        principalTable: "TiposPagotbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagosDeletetbls_Valorestbls_ValId",
                        column: x => x.ValId,
                        principalTable: "Valorestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PAG_FECHAPAGADO = table.Column<DateTime>(nullable: false),
                    PAG_FECHACREACION = table.Column<DateTime>(nullable: false),
                    PAG_ESTADO = table.Column<string>(nullable: false),
                    PAG_PAGADO = table.Column<string>(nullable: false),
                    PropietarioId = table.Column<int>(nullable: true),
                    AnioId = table.Column<int>(nullable: true),
                    MesId = table.Column<int>(nullable: true),
                    ValId = table.Column<int>(nullable: true),
                    TiposId = table.Column<int>(nullable: true),
                    PuntodePagoId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Borr_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Aniostbls_AnioId",
                        column: x => x.AnioId,
                        principalTable: "Aniostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Mesestbls_MesId",
                        column: x => x.MesId,
                        principalTable: "Mesestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Propietariostbls_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietariostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_PuntosPagotbls_PuntodePagoId",
                        column: x => x.PuntodePagoId,
                        principalTable: "PuntosPagotbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_TiposPagotbl_TiposId",
                        column: x => x.TiposId,
                        principalTable: "TiposPagotbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagostbls_Valorestbls_ValId",
                        column: x => x.ValId,
                        principalTable: "Valorestbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Veh_Codigo = table.Column<string>(maxLength: 6, nullable: false),
                    Veh_Placa = table.Column<string>(maxLength: 7, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Veh_Estado = table.Column<string>(nullable: false),
                    Veh_Born = table.Column<DateTime>(nullable: false),
                    Veh_Detalles = table.Column<string>(nullable: true),
                    PropietarioId = table.Column<int>(nullable: true),
                    MarcasAutostblId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculostbls_MarcasAutostbls_MarcasAutostblId",
                        column: x => x.MarcasAutostblId,
                        principalTable: "MarcasAutostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculostbls_Propietariostbls_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietariostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productostbls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pro_Nombre = table.Column<string>(nullable: true),
                    Pro_Precio = table.Column<string>(nullable: true),
                    Pro_FechaCreacion = table.Column<DateTime>(nullable: false),
                    Pro_Estado = table.Column<string>(nullable: false),
                    NegocioId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productostbls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productostbls_Negociostbls_NegocioId",
                        column: x => x.NegocioId,
                        principalTable: "Negociostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstadosFinancierostbls",
                columns: table => new
                {
                    IdIngresos = table.Column<int>(nullable: false),
                    IdEgresos = table.Column<int>(nullable: false),
                    IngresosId = table.Column<int>(nullable: true),
                    EgresosId = table.Column<int>(nullable: true),
                    PagosDeletetblId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosFinancierostbls", x => new { x.IdIngresos, x.IdEgresos });
                    table.ForeignKey(
                        name: "FK_EstadosFinancierostbls_Egresostbls_EgresosId",
                        column: x => x.EgresosId,
                        principalTable: "Egresostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstadosFinancierostbls_Pagostbls_IngresosId",
                        column: x => x.IngresosId,
                        principalTable: "Pagostbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstadosFinancierostbls_PagosDeletetbls_PagosDeletetblId",
                        column: x => x.PagosDeletetblId,
                        principalTable: "PagosDeletetbls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aniostbls_Ani_Descripcion",
                table: "Aniostbls",
                column: "Ani_Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TipIdeId",
                table: "AspNetUsers",
                column: "TipIdeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TipPerId",
                table: "AspNetUsers",
                column: "TipPerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TipVivId",
                table: "AspNetUsers",
                column: "TipVivId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_AnioId",
                table: "Egresostbls",
                column: "AnioId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_MesId",
                table: "Egresostbls",
                column: "MesId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresostbls_TiposGId",
                table: "Egresostbls",
                column: "TiposGId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosFinancierostbls_EgresosId",
                table: "EstadosFinancierostbls",
                column: "EgresosId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosFinancierostbls_IngresosId",
                table: "EstadosFinancierostbls",
                column: "IngresosId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosFinancierostbls_PagosDeletetblId",
                table: "EstadosFinancierostbls",
                column: "PagosDeletetblId");

            migrationBuilder.CreateIndex(
                name: "IX_Managerstbls_UserId",
                table: "Managerstbls",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Negociostbls_PropietariosId",
                table: "Negociostbls",
                column: "PropietariosId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeletetbls_AnioId",
                table: "PagosDeletetbls",
                column: "AnioId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeletetbls_MesId",
                table: "PagosDeletetbls",
                column: "MesId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeletetbls_PropietarioId",
                table: "PagosDeletetbls",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeletetbls_PuntodePagoId",
                table: "PagosDeletetbls",
                column: "PuntodePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeletetbls_TiposId",
                table: "PagosDeletetbls",
                column: "TiposId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDeletetbls_ValId",
                table: "PagosDeletetbls",
                column: "ValId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_AnioId",
                table: "Pagostbls",
                column: "AnioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_MesId",
                table: "Pagostbls",
                column: "MesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_PropietarioId",
                table: "Pagostbls",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_PuntodePagoId",
                table: "Pagostbls",
                column: "PuntodePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_TiposId",
                table: "Pagostbls",
                column: "TiposId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagostbls_ValId",
                table: "Pagostbls",
                column: "ValId");

            migrationBuilder.CreateIndex(
                name: "IX_Productostbls_NegocioId",
                table: "Productostbls",
                column: "NegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Propietariostbls_UserId",
                table: "Propietariostbls",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosPagotbls_Pun_Descripcion",
                table: "PuntosPagotbls",
                column: "Pun_Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TiposGastotbls_Tip_Descripcion",
                table: "TiposGastotbls",
                column: "Tip_Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TiposPagotbl_Tip_Descripcion",
                table: "TiposPagotbl",
                column: "Tip_Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Valorestbls_Val_Valor",
                table: "Valorestbls",
                column: "Val_Valor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_MarcasAutostblId",
                table: "Vehiculostbls",
                column: "MarcasAutostblId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_PropietarioId",
                table: "Vehiculostbls",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculostbls_Veh_Codigo",
                table: "Vehiculostbls",
                column: "Veh_Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EstadosFinancierostbls");

            migrationBuilder.DropTable(
                name: "Managerstbls");

            migrationBuilder.DropTable(
                name: "Noticiastbls");

            migrationBuilder.DropTable(
                name: "Productostbls");

            migrationBuilder.DropTable(
                name: "Saldostbls");

            migrationBuilder.DropTable(
                name: "Vehiculostbls");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Egresostbls");

            migrationBuilder.DropTable(
                name: "Pagostbls");

            migrationBuilder.DropTable(
                name: "PagosDeletetbls");

            migrationBuilder.DropTable(
                name: "Negociostbls");

            migrationBuilder.DropTable(
                name: "MarcasAutostbls");

            migrationBuilder.DropTable(
                name: "TiposGastotbls");

            migrationBuilder.DropTable(
                name: "Aniostbls");

            migrationBuilder.DropTable(
                name: "Mesestbls");

            migrationBuilder.DropTable(
                name: "PuntosPagotbls");

            migrationBuilder.DropTable(
                name: "TiposPagotbl");

            migrationBuilder.DropTable(
                name: "Valorestbls");

            migrationBuilder.DropTable(
                name: "Propietariostbls");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TipoIdentificaciontbls");

            migrationBuilder.DropTable(
                name: "TipoPersonastbls");

            migrationBuilder.DropTable(
                name: "TiposViviendatbls");
        }
    }
}
