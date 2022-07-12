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
                values: new object[] { 23, 12, "ISC-116", 4, "MERCADEO DE SOFTWARE" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "BalancePendiente", "BalanceTotal", "CarreraId", "Matricula", "PersonaId" },
                values: new object[] { 1, 0f, 0f, 2, "2016-0037", 1 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "BalancePendiente", "BalanceTotal", "CarreraId", "Matricula", "PersonaId" },
                values: new object[] { 2, 0f, 0f, 2, "2016-0037", 2 });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "BalancePendiente", "BalanceTotal", "CarreraId", "Matricula", "PersonaId" },
                values: new object[] { 3, 0f, 0f, 2, "2016-0037", 3 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 200, "LAB. DE INFORMATICA A", "Miercole", "21:00", "18:00", 200 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 201, "LAB. DE INFORMATICA B", "Miercole", "21:00", "18:00", 201 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 202, "LAB. DE INFORMATICA A", "Jueves", "14:00", "12:00", 202 });

            migrationBuilder.InsertData(
                table: "Horarios",
                columns: new[] { "HorariosId", "Aula", "Dia", "HoraFin", "HoraInicio", "SeccionId" },
                values: new object[] { 204, "LAB. DE INFORMATICA C", "Jueves", "21:00", "18:00", 204 });

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
                values: new object[] { 95, 20, 106 });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "InscripcionId", "EstudianteId", "FechaFinalTrimestre", "FechaInicioTrimestre", "FechaRegistrada", "UltimaInscripcion" },
                values: new object[] { 104, 1, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "InscripcionId", "EstudianteId", "FechaFinalTrimestre", "FechaInicioTrimestre", "FechaRegistrada", "UltimaInscripcion" },
                values: new object[] { 105, 2, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "InscripcionId", "EstudianteId", "FechaFinalTrimestre", "FechaInicioTrimestre", "FechaRegistrada", "UltimaInscripcion" },
                values: new object[] { 106, 3, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "EstudianteId", "Password", "Usuario" },
                values: new object[] { 1, 1, "1234", "Jesus" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "EstudianteId", "Password", "Usuario" },
                values: new object[] { 2, 2, "1234", "2016" });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "EstudianteId", "Password", "Usuario" },
                values: new object[] { 3, 3, "1234", "5" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono" },
                values: new object[] { 1, "", "", "", "", 0, new DateTime(2022, 7, 10, 22, 36, 41, 904, DateTimeKind.Local).AddTicks(6119), "", "Enmanuel", "", 'N', "" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono" },
                values: new object[] { 2, "Abreu", "", "", "", 0, new DateTime(2022, 7, 10, 22, 36, 41, 904, DateTimeKind.Local).AddTicks(6187), "", "Jesus", "", 'N', "" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono" },
                values: new object[] { 3, "Peña Polonia", "", "", "", 0, new DateTime(2022, 7, 10, 22, 36, 41, 904, DateTimeKind.Local).AddTicks(6212), "", "Mario", "", 'N', "" });

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
                values: new object[] { 204, 22, 514 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignaturas");

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
        }
    }
}
