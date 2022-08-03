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
                name: "Carreras",
                columns: table => new
                {
                    CarreraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacultadId = table.Column<int>(type: "INTEGER", nullable: false),
                    DirectorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.CarreraId);
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
                table: "Carreras",
                columns: new[] { "CarreraId", "DirectorId", "FacultadId", "Nombre" },
                values: new object[] { 12, 103, 12, "Ingeniero en Sistemas y Computación" });

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
                values: new object[] { 1, "Salazar", "829-798-5996", "enmanuel@klk.com", "", 0, new DateTime(2022, 7, 30, 18, 43, 1, 550, DateTimeKind.Local).AddTicks(4526), "Republica Dominicana", "Enmanuel", "", 'N', "", "Ramon" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono", "Tutor" },
                values: new object[] { 2, "Abreu", "829-780-5880", "jesus@klk.com", "", 0, new DateTime(2022, 7, 30, 18, 43, 1, 550, DateTimeKind.Local).AddTicks(4548), "Republica Dominicana", "Jesus", "", 'N', "", "Jose" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellidos", "Celular", "CorreoInstitucion", "CorreoPersonal", "DireccionId", "FechaNacimiento", "Nacionalidad", "Nombres", "NumeroCedula", "Sexo", "Telefono", "Tutor" },
                values: new object[] { 3, "Peña Polonia", "829-798-5826", "Klk@klk.com", "", 0, new DateTime(2022, 7, 30, 18, 43, 1, 550, DateTimeKind.Local).AddTicks(4562), "Republica Dominicana", "Mario", "", 'N', "", "RAMÓN FRANCISCO PEÑA GARCÍA" });

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
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Carreras");

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
