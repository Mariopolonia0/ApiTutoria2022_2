using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTutoria2022_2.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsignaturaAprobadas",
                columns: table => new
                {
                    AsignaturaAprobadaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AsignaturaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Optativa = table.Column<bool>(type: "INTEGER", nullable: false),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignaturaAprobadas", x => x.AsignaturaAprobadaId);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
                columns: table => new
                {
                    AsignaturaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarreraId = table.Column<int>(type: "INTEGER", nullable: false),
                    Codigo = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Credito = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaturas", x => x.AsignaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    CalificacionesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CuatrimestreId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    AsignaturaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nota = table.Column<int>(type: "INTEGER", nullable: false),
                    Calificacion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.CalificacionesId);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    CarreraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacultadId = table.Column<int>(type: "INTEGER", nullable: false),
                    DirectorId = table.Column<int>(type: "INTEGER", nullable: false),
                    cantidadMateriaObligatorias = table.Column<int>(type: "INTEGER", nullable: false),
                    cantidadMateriaOptativas = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.CarreraId);
                });

            migrationBuilder.CreateTable(
                name: "Cuatrimestre",
                columns: table => new
                {
                    CuatrimestreId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    yeard = table.Column<int>(type: "INTEGER", nullable: false),
                    numeroCuatrimestre = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuatrimestre", x => x.CuatrimestreId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarreraId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Matricula = table.Column<string>(type: "TEXT", nullable: false),
                    BalanceTotal = table.Column<float>(type: "REAL", nullable: false),
                    BalancePendiente = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    HorariosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SeccionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Aula = table.Column<string>(type: "TEXT", nullable: false),
                    Dia = table.Column<string>(type: "TEXT", nullable: false),
                    HoraInicio = table.Column<string>(type: "TEXT", nullable: false),
                    HoraFin = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.HorariosId);
                });

            migrationBuilder.CreateTable(
                name: "InscripcionDetalles",
                columns: table => new
                {
                    InscripcionDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InscripcionId = table.Column<int>(type: "INTEGER", nullable: false),
                    AsignaturaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscripcionDetalles", x => x.InscripcionDetalleId);
                });

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    CuatrimestreId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaRegistrada = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaInicioTrimestre = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFinalTrimestre = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UltimaInscripcion = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.InscripcionId);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Usuario = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.LoginId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroCedula = table.Column<string>(type: "TEXT", nullable: false),
                    Tutor = table.Column<string>(type: "TEXT", nullable: false),
                    DireccionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<string>(type: "TEXT", nullable: false),
                    Nacionalidad = table.Column<string>(type: "TEXT", nullable: false),
                    Sexo = table.Column<char>(type: "TEXT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CorreoPersonal = table.Column<string>(type: "TEXT", nullable: false),
                    CorreoInstitucion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Secciones",
                columns: table => new
                {
                    SeccionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DocenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    AsignaturaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secciones", x => x.SeccionId);
                });

            migrationBuilder.CreateTable(
                name: "Transaccion",
                columns: table => new
                {
                    TransaccionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Movimiento = table.Column<decimal>(type: "TEXT", nullable: false),
                    Estado = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaccion", x => x.TransaccionId);
                });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 1, 1, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 2, 2, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 3, 3, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 4, 4, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 5, 5, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 6, 6, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 7, 7, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 8, 8, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 9, 9, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 10, 10, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 11, 11, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 12, 12, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 13, 13, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 14, 14, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 15, 15, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 16, 16, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 17, 17, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 18, 18, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 19, 19, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 20, 20, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 21, 21, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 22, 22, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 23, 23, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 24, 24, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 25, 25, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 26, 26, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 27, 27, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 28, 28, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 29, 29, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 30, 30, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 31, 31, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 32, 32, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 33, 33, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 34, 34, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 35, 35, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 36, 36, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 37, 37, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 38, 38, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 39, 39, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 40, 40, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 41, 41, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 42, 42, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 43, 43, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 44, 44, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 45, 45, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 46, 46, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 47, 47, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 48, 48, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 49, 49, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 50, 50, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 51, 51, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 52, 52, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 53, 53, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 54, 54, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 55, 55, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 56, 56, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 57, 57, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 58, 58, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 59, 59, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 60, 60, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 61, 61, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 62, 62, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 63, 63, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 64, 64, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 65, 65, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 66, 66, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 67, 67, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 68, 68, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 69, 69, 1, false });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 70, 70, 1, false });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 71, 71, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 72, 72, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 73, 73, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 74, 74, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 75, 75, 1, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 200, 200, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 201, 201, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 202, 202, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 203, 203, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 204, 204, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 205, 205, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 206, 206, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 207, 207, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 208, 208, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 209, 209, 2, false });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 210, 210, 2, false });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 211, 211, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 212, 212, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 213, 213, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 214, 214, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 215, 215, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 216, 216, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 217, 217, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 218, 218, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 219, 219, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 220, 220, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 221, 221, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 222, 222, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 223, 223, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 224, 224, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 225, 225, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 226, 226, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 227, 227, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 228, 228, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 229, 229, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 230, 230, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 231, 231, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 232, 232, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 233, 233, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 234, 234, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 235, 235, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 236, 236, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 237, 237, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 238, 238, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 239, 239, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 240, 240, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 241, 241, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 242, 242, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 243, 243, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 244, 244, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 245, 245, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 246, 246, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 247, 247, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 248, 248, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 249, 249, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 250, 250, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 251, 251, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 252, 252, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 253, 253, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 254, 254, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 255, 255, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 256, 256, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 257, 257, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 258, 258, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 259, 259, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 260, 260, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 261, 261, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 262, 262, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 263, 263, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 264, 264, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 265, 265, 2, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 300, 300, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 301, 301, 3, false });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 302, 302, 3, false });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 303, 303, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 304, 304, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 305, 305, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 306, 306, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 307, 307, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 308, 308, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 309, 309, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 310, 310, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 311, 311, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 312, 312, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 313, 313, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 314, 314, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 315, 315, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 316, 316, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 317, 317, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 318, 318, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 319, 319, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 320, 320, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 321, 321, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 322, 322, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 323, 323, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 324, 324, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 325, 325, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 326, 326, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 327, 327, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 328, 328, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 329, 329, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 330, 330, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 331, 331, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 332, 332, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 333, 333, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 334, 334, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 335, 335, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 336, 336, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 337, 337, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 338, 338, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 339, 339, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 340, 340, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 341, 341, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 342, 342, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 343, 343, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 344, 344, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 345, 345, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 346, 346, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 347, 347, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 348, 348, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 349, 349, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 350, 350, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 351, 351, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 352, 352, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 353, 353, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 354, 354, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 355, 355, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 356, 356, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 357, 357, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 358, 358, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 359, 359, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 360, 360, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 361, 361, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 362, 362, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 363, 363, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 364, 364, 3, true });

            migrationBuilder.InsertData(
                table: "AsignaturaAprobadas",
                columns: new[] { "AsignaturaAprobadaId", "AsignaturaId", "EstudianteId", "Optativa" },
                values: new object[] { 365, 365, 3, true });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 20, 12, "ISC-101", 2, "PROGRAMACION APLICADA II" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 21, 12, "ISC-102", 1, "LAB. PROGRAM. APLICADA II" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 22, 12, "ISC-802", 4, "DISEÑO DE SISTEMAS" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 23, 12, "ISC-701", 4, "MERCADEO DE SOFTWARE" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 24, 12, "ISC-702", 4, "LABORATORIO SISTEMAS OPERATIVOS I" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 25, 12, "ISC-704", 4, "BASE DE DATOS" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 26, 12, "ISC-703", 4, "LAB. BASE DE DATOS " });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 27, 12, "ISC-705", 4, "MATENIMIENTO DE HARDWARE" });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 28, 12, "CNT-213", 4, "CONTABILIDAD GENERAL I " });

            migrationBuilder.InsertData(
                table: "Asignaturas",
                columns: new[] { "AsignaturaId", "CarreraId", "Codigo", "Credito", "Nombre" },
                values: new object[] { 29, 12, "ISC-701", 4, "SISTEMAS OPERATIVOS I" });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 1, 20, "A", 100, 1, 90 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 2, 21, "B", 100, 1, 80 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 3, 22, "B+", 100, 1, 85 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 4, 23, "C", 103, 1, 70 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 5, 24, "A", 102, 1, 90 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 6, 25, "A", 102, 1, 90 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 7, 26, "D", 102, 1, 60 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 8, 27, "A", 103, 1, 90 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 9, 28, "A+", 103, 1, 95 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 10, 20, "B", 102, 2, 80 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 12, 21, "B+", 100, 2, 85 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 13, 22, "B", 103, 2, 80 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 14, 23, "C+", 102, 2, 75 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 15, 24, "A+", 102, 2, 95 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 16, 25, "A+", 100, 2, 95 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 17, 26, "D", 100, 2, 60 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 18, 27, "A", 103, 2, 90 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 19, 28, "A", 103, 2, 90 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 20, 25, "B", 102, 3, 80 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 21, 26, "D", 100, 3, 60 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 22, 27, "B", 101, 3, 80 });

            migrationBuilder.InsertData(
                table: "Calificaciones",
                columns: new[] { "CalificacionesId", "AsignaturaId", "Calificacion", "CuatrimestreId", "EstudianteId", "Nota" },
                values: new object[] { 23, 28, "A", 101, 3, 90 });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "CarreraId", "DirectorId", "FacultadId", "Nombre", "cantidadMateriaObligatorias", "cantidadMateriaOptativas" },
                values: new object[] { 12, 103, 12, "Ingeniero en Sistemas y Computación", 75, 4 });

            migrationBuilder.InsertData(
                table: "Cuatrimestre",
                columns: new[] { "CuatrimestreId", "numeroCuatrimestre", "yeard" },
                values: new object[] { 100, 2, 2020 });

            migrationBuilder.InsertData(
                table: "Cuatrimestre",
                columns: new[] { "CuatrimestreId", "numeroCuatrimestre", "yeard" },
                values: new object[] { 101, 1, 2019 });

            migrationBuilder.InsertData(
                table: "Cuatrimestre",
                columns: new[] { "CuatrimestreId", "numeroCuatrimestre", "yeard" },
                values: new object[] { 102, 1, 2020 });

            migrationBuilder.InsertData(
                table: "Cuatrimestre",
                columns: new[] { "CuatrimestreId", "numeroCuatrimestre", "yeard" },
                values: new object[] { 103, 3, 2020 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "BalancePendiente", "BalanceTotal", "CarreraId", "Matricula", "PersonaId" },
                values: new object[] { 1, 0f, 0f, 12, "2016-0037", 1 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "BalancePendiente", "BalanceTotal", "CarreraId", "Matricula", "PersonaId" },
                values: new object[] { 2, 0f, 0f, 12, "2016-0037", 2 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "BalancePendiente", "BalanceTotal", "CarreraId", "Matricula", "PersonaId" },
                values: new object[] { 3, 0f, 0f, 12, "2016-0037", 3 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 200, "LAB. DE INFORMATICA A", "Tuesday", "21:00", "18:00", 200 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 201, "LAB. DE INFORMATICA B", "Tuesday", "21:00", "18:00", 201 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 202, "LAB. DE INFORMATICA A", "Monday", "14:00", "12:00", 202 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 203, "LAB. DE INFORMATICA A", "Tuesday", "14:00", "12:00", 203 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 204, "LAB. DE INFORMATICA C", "Monday", "21:00", "18:00", 204 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 205, "LAB. DE INFORMATICA A", "Thursday", "14:00", "12:00", 205 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 206, "LAB. DE INFORMATICA A", "Friday", "14:00", "12:00", 206 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 207, "LAB. DE INFORMATICA A", "Monday", "14:00", "12:00", 207 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 208, "LAB. DE INFORMATICA A", "Saturday", "14:00", "12:00", 208 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 209, "LAB. DE INFORMATICA A", "Wednesday", "14:00", "12:00", 209 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 90, 20, 104 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 91, 21, 104 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 92, 22, 105 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 93, 23, 105 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 94, 23, 106 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 95, 24, 106 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 96, 25, 106 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 97, 26, 106 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 99, 27, 106 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 100, 28, 106 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 101, 27, 104 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 102, 28, 104 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 103, 25, 105 });

            migrationBuilder.InsertData(
                table: "InscripcionDetalles",
                columns: new[] { "InscripcionDetalleId", "AsignaturaId", "InscripcionId" },
                values: new object[] { 104, 26, 105 });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "InscripcionId", "CuatrimestreId", "EstudianteId", "FechaFinalTrimestre", "FechaInicioTrimestre", "FechaRegistrada", "UltimaInscripcion" },
                values: new object[] { 104, 100, 1, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "InscripcionId", "CuatrimestreId", "EstudianteId", "FechaFinalTrimestre", "FechaInicioTrimestre", "FechaRegistrada", "UltimaInscripcion" },
                values: new object[] { 105, 100, 2, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "InscripcionId", "CuatrimestreId", "EstudianteId", "FechaFinalTrimestre", "FechaInicioTrimestre", "FechaRegistrada", "UltimaInscripcion" },
                values: new object[] { 106, 100, 3, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "InscripcionId", "CuatrimestreId", "EstudianteId", "FechaFinalTrimestre", "FechaInicioTrimestre", "FechaRegistrada", "UltimaInscripcion" },
                values: new object[] { 107, 101, 3, new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "EstudianteId", "Password", "Usuario" },
                values: new object[] { 1, 2, "1234", "Jesus" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "EstudianteId", "Password", "Usuario" },
                values: new object[] { 2, 3, "1234", "2016" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "EstudianteId", "Password", "Usuario" },
                values: new object[] { 3, 1, "1234", "5" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono", "Tutor" },
                values: new object[] { 1, "Salazar", "829-798-5996", "enmanuel@klk.com", "", 0, new DateTime(2022, 8, 13, 20, 49, 35, 400, DateTimeKind.Local).AddTicks(8543), "Republica Dominicana", "Enmanuel", "", 'N', "", "Ramon" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono", "Tutor" },
                values: new object[] { 2, "Abreu", "829-780-5880", "jesus@klk.com", "", 0, new DateTime(2022, 8, 13, 20, 49, 35, 400, DateTimeKind.Local).AddTicks(8587), "Republica Dominicana", "Jesus", "", 'N', "", "Jose" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono", "Tutor" },
                values: new object[] { 3, "Peña Polonia", "829-798-5826", "Klk@klk.com", "", 0, new DateTime(2022, 8, 13, 20, 49, 35, 400, DateTimeKind.Local).AddTicks(8615), "Republica Dominicana", "Mario", "", 'N', "", "RAMÓN FRANCISCO PEÑA GARCÍA" });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 200, 20, 512 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 201, 21, 512 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 202, 23, 1 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 203, 29, 1 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 204, 24, 1 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 205, 25, 9 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 206, 26, 9 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 207, 27, 10 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 208, 28, 10 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 209, 22, 512 });

            migrationBuilder.InsertData(
                table: "Secciones",
                columns: new[] { "SeccionId", "AsignaturaId", "DocenteId" },
                values: new object[] { 210, 22, 514 });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 100, "N/C DESCUENTO 50% ARTE Y CULTURA", 0.0m, 1, new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 101, "PAGO RECIBIDO", 5000m, 1, new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 102, "ABONO A CUENTA MEDIANTE DEPOSITO BR", 4000m, 2, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 103, "INSCRIPCIÓN PERÍODO 3-2020", 10000m, 1, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), -10000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 104, "N/C DESCUENTO 50% ARTE Y CULTURA", 10000m, 2, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 105, "INSCRIPCIÓN PERÍODO 1-2019", 15000m, 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -15000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 106, "N/C DESCUENTO 50% ARTE Y CULTURA", 10000m, 3, new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 107, "N/C DESCUENTO 50% ARTE Y CULTURA", 5000m, 1, new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 108, "PAGO RECIBIDO", 10000m, 3, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 110, "ABONO A CUENTA MEDIANTE DEPOSITO BR", 10000m, 3, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 111, "INSCRIPCIÓN PERÍODO 1-2019", 25000m, 2, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), -15000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 112, "N/C DESCUENTO 50% ARTE Y CULTURA", 17000m, 2, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 113, "PAGO RECIBIDO", 500m, 1, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 114, "PAGO RECIBIDO", 1000m, 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 115, "INSCRIPCIÓN PERÍODO 1-2021", 19000m, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -18000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 116, "PAGO RECIBIDO", 13000m, 1, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m });

            migrationBuilder.InsertData(
                table: "Transaccion",
                columns: new[] { "TransaccionId", "Descripcion", "Estado", "EstudianteId", "FechaRegistro", "Movimiento" },
                values: new object[] { 117, "PAGO RECIBIDO", 10000m, 1, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignaturaAprobadas");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Cuatrimestre");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "InscripcionDetalles");

            migrationBuilder.DropTable(
                name: "Inscripciones");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Secciones");

            migrationBuilder.DropTable(
                name: "Transaccion");
        }
    }
}
