using ApiTutoria2022_2.Models;
using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Asignatura>? Asignaturas { set; get; }
    public DbSet<Carrera>? Carreras { set; get; }
    public DbSet<Estudiante>? Estudiantes { set; get; }
    public DbSet<Horario>? Horarios { set; get; }
    public DbSet<Inscripcion>? Inscripciones { set; get; }
    public DbSet<InscripcionDetalle>? InscripcionDetalles { set; get; }
    public DbSet<Login>? Logins { set; get; }
    public DbSet<Persona>? Personas { set; get; }
    public DbSet<Seccion>? Secciones { set; get; }
    public DbSet<Transaccion>? Transaccion { set; get; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //AGREGAR ASIGNATURA POR DEFAULT
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 20, CarreraId = 12, Codigo = "ISC-101", Nombre = "PROGRAMACION APLICADA II", Credito = 2 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 21, CarreraId = 12, Codigo = "ISC-102", Nombre = "LAB. PROGRAM. APLICADA II", Credito = 1 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 22, CarreraId = 12, Codigo = "ISC-802", Nombre = "DISEÑO DE SISTEMAS", Credito = 4 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 29, CarreraId = 12, Codigo = "ISC-701", Nombre = "SISTEMAS OPERATIVOS I", Credito = 4 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 23, CarreraId = 12, Codigo = "ISC-701", Nombre = "MERCADEO DE SOFTWARE", Credito = 4 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 24, CarreraId = 12, Codigo = "ISC-702", Nombre = "LABORATORIO SISTEMAS OPERATIVOS I", Credito = 4 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 25, CarreraId = 12, Codigo = "ISC-704", Nombre = "BASE DE DATOS", Credito = 4 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 26, CarreraId = 12, Codigo = "ISC-703", Nombre = "LAB. BASE DE DATOS ", Credito = 4 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 27, CarreraId = 12, Codigo = "ISC-705", Nombre = "MATENIMIENTO DE HARDWARE", Credito = 4 });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 28, CarreraId = 12, Codigo = "CNT-213", Nombre = "CONTABILIDAD GENERAL I ", Credito = 4 });

        //AGREGAR CARRERA POR DEFAUTLT
        modelBuilder.Entity<Carrera>().HasData(new Carrera { CarreraId = 12, FacultadId = 12, DirectorId = 103, Nombre = "Ingeniero en Sistemas y Computación" });

        //AGREGAR ESTUDIANTE POR DEFAULT
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante { EstudianteId = 2, CarreraId = 12, PersonaId = 2, Matricula = "2016-0037", BalanceTotal = 0.0f, BalancePendiente = 0.0f });
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante { EstudianteId = 3, CarreraId = 12, PersonaId = 3, Matricula = "2016-0037", BalanceTotal = 0.0f, BalancePendiente = 0.0f });
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante { EstudianteId = 1, CarreraId = 12, PersonaId = 1, Matricula = "2016-0037", BalanceTotal = 0.0f, BalancePendiente = 0.0f });

        //AGREGAR HORARIO POR DEFAULT
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 200,
            SeccionId = 200,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Tuesday",
            HoraInicio = "18:00",
            HoraFin = "21:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 201,
            SeccionId = 201,
            Aula = "LAB. DE INFORMATICA B",
            Dia = "Tuesday",
            HoraInicio = "18:00",
            HoraFin = "21:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 202,
            SeccionId = 202,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Monday",
            HoraInicio = "12:00",
            HoraFin = "14:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 203,
            SeccionId = 203,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Tuesday",
            HoraInicio = "12:00",
            HoraFin = "14:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 204,
            SeccionId = 204,
            Aula = "LAB. DE INFORMATICA C",
            Dia = "Monday",
            HoraInicio = "18:00",
            HoraFin = "21:00"
        });

        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 205,
            SeccionId = 205,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Thursday",
            HoraInicio = "12:00",
            HoraFin = "14:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 206,
            SeccionId = 206,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Friday",
            HoraInicio = "12:00",
            HoraFin = "14:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 207,
            SeccionId = 207,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Monday",
            HoraInicio = "12:00",
            HoraFin = "14:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 208,
            SeccionId = 208,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Saturday",
            HoraInicio = "12:00",
            HoraFin = "14:00"
        });
        modelBuilder.Entity<Horario>().HasData(new Horario
        {
            HorariosId = 209,
            SeccionId = 209,
            Aula = "LAB. DE INFORMATICA A",
            Dia = "Wednesday",
            HoraInicio = "12:00",
            HoraFin = "14:00"
        });

        //AGREGAR INSCRIPCION  POR DEFAULT//12 Juni 2008
        modelBuilder.Entity<Inscripcion>().HasData(new Inscripcion { InscripcionId = 104, EstudianteId = 1, FechaRegistrada = DateTime.Parse("2022-04-25"), FechaInicioTrimestre = DateTime.Parse("2022-05-03"), FechaFinalTrimestre = DateTime.Parse("2022-08-13"), UltimaInscripcion = true });
        modelBuilder.Entity<Inscripcion>().HasData(new Inscripcion { InscripcionId = 105, EstudianteId = 2, FechaRegistrada = DateTime.Parse("2022-04-25"), FechaInicioTrimestre = DateTime.Parse("2022-05-03"), FechaFinalTrimestre = DateTime.Parse("2022-08-13"), UltimaInscripcion = true });
        modelBuilder.Entity<Inscripcion>().HasData(new Inscripcion { InscripcionId = 106, EstudianteId = 3, FechaRegistrada = DateTime.Parse("2022-04-25"), FechaInicioTrimestre = DateTime.Parse("2022-05-03"), FechaFinalTrimestre = DateTime.Parse("2022-08-13"), UltimaInscripcion = true });

        //AGREGAR INSCRIPCIONDETALLE POR DEFAULT
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 90, InscripcionId = 104, AsignaturaId = 20 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 91, InscripcionId = 104, AsignaturaId = 21 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 92, InscripcionId = 105, AsignaturaId = 22 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 93, InscripcionId = 105, AsignaturaId = 23 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 94, InscripcionId = 106, AsignaturaId = 23 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 95, InscripcionId = 106, AsignaturaId = 24 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 96, InscripcionId = 106, AsignaturaId = 25 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 97, InscripcionId = 106, AsignaturaId = 26 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 99, InscripcionId = 106, AsignaturaId = 27 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 100, InscripcionId = 106, AsignaturaId = 28 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 101, InscripcionId = 104, AsignaturaId = 27 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 102, InscripcionId = 104, AsignaturaId = 28 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 103, InscripcionId = 105, AsignaturaId = 25 });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 104, InscripcionId = 105, AsignaturaId = 26 });

        //AGREGAR LOGIN POR DEFAULT
        modelBuilder.Entity<Login>().HasData(new Login { LoginId = 1, EstudianteId = 2, Usuario = "Jesus", Password = "1234" });
        modelBuilder.Entity<Login>().HasData(new Login { LoginId = 2, EstudianteId = 3, Usuario = "2016", Password = "1234" });
        modelBuilder.Entity<Login>().HasData(new Login { LoginId = 3, EstudianteId = 1, Usuario = "5", Password = "1234" });

        //AGREGAR PERSONA POR DEFAULT
        modelBuilder.Entity<Persona>().HasData(new Persona { PersonaId = 1, Nombres = "Enmanuel", Apellidos = "Salazar", Nacionalidad = "Republica Dominicana", Tutor = "Ramon", CorreoInstitucion = "enmanuel@klk.com", Celular = "829-798-5996" });
        modelBuilder.Entity<Persona>().HasData(new Persona { PersonaId = 2, Nombres = "Jesus", Apellidos = "Abreu", Nacionalidad = "Republica Dominicana", Tutor = "Jose", CorreoInstitucion = "jesus@klk.com", Celular = "829-780-5880" });
        modelBuilder.Entity<Persona>().HasData(new Persona { PersonaId = 3, Nombres = "Mario", Apellidos = "Peña Polonia", Nacionalidad = "Republica Dominicana", Tutor = "RAMÓN FRANCISCO PEÑA GARCÍA", CorreoInstitucion = "Klk@klk.com", Celular = "829-798-5826" });

        //AGREGAR SECCION POR DEFAULT
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 200, DocenteId = 512, AsignaturaId = 20 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 201, DocenteId = 512, AsignaturaId = 21 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 209, DocenteId = 512, AsignaturaId = 22 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 202, DocenteId = 1, AsignaturaId = 23 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 203, DocenteId = 1, AsignaturaId = 29 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 204, DocenteId = 1, AsignaturaId = 24 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 205, DocenteId = 9, AsignaturaId = 25 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 206, DocenteId = 9, AsignaturaId = 26 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 207, DocenteId = 10, AsignaturaId = 27 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 208, DocenteId = 10, AsignaturaId = 28 });

        //AGREGAR TRANSACCIONES POR DEFAULT
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 107,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2022-04-25"),
            Descripcion = "N/C DESCUENTO 50% ARTE Y CULTURA",
            Movimiento = 5000,
            Estado = 5000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 117,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2021-09-01"),
            Descripcion = "PAGO RECIBIDO",
            Movimiento = 3000,
            Estado = 10000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 116,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2021-09-01"),
            Descripcion = "PAGO RECIBIDO",
            Movimiento = 5000,
            Estado = 13000
        }); modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 115,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2021-01-01"),
            Descripcion = "INSCRIPCIÓN PERÍODO 1-2021",
            Movimiento = -18000,
            Estado = 19000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 114,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2020-09-01"),
            Descripcion = "PAGO RECIBIDO",
            Movimiento = 2000,
            Estado = 1000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 113,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2020-10-01"),
            Descripcion = "PAGO RECIBIDO",
            Movimiento = 500,
            Estado = 500
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 103,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2020-08-02"),
            Descripcion = "INSCRIPCIÓN PERÍODO 3-2020",
            Movimiento = -10000,
            Estado = 10000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 100,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2020-04-25"),
            Descripcion = "N/C DESCUENTO 50% ARTE Y CULTURA",
            Movimiento = 5000,
            Estado = 0.0m
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 101,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2020-03-21"),
            Descripcion = "PAGO RECIBIDO",
            Movimiento = 10000,
            Estado = 5000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 105,
            EstudianteId = 1,
            FechaRegistro = DateTime.Parse("2019-01-01"),
            Descripcion = "INSCRIPCIÓN PERÍODO 1-2019",
            Movimiento = -15000,
            Estado = 15000
        });

        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 104,
            EstudianteId = 2,
            FechaRegistro = DateTime.Parse("2022-04-22"),
            Descripcion = "N/C DESCUENTO 50% ARTE Y CULTURA",
            Movimiento = 15000,
            Estado = 10000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 111,
            EstudianteId = 2,
            FechaRegistro = DateTime.Parse("2019-01-03"),
            Descripcion = "INSCRIPCIÓN PERÍODO 1-2019",
            Movimiento = -15000,
            Estado = 25000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 112,
            EstudianteId = 2,
            FechaRegistro = DateTime.Parse("2019-01-03"),
            Descripcion = "N/C DESCUENTO 50% ARTE Y CULTURA",
            Movimiento = 8000,
            Estado = 17000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 102,
            EstudianteId = 2,
            FechaRegistro = DateTime.Parse("2019-01-03"),
            Descripcion = "ABONO A CUENTA MEDIANTE DEPOSITO BR",
            Movimiento = 13000,
            Estado = 4000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 106,
            EstudianteId = 3,
            FechaRegistro = DateTime.Parse("2019-04-8"),
            Descripcion = "N/C DESCUENTO 50% ARTE Y CULTURA",
            Movimiento = 15000,
            Estado = 10000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 108,
            EstudianteId = 3,
            FechaRegistro = DateTime.Parse("2022-04-5"),
            Descripcion = "PAGO RECIBIDO",
            Movimiento = 15000,
            Estado = 10000
        });
        modelBuilder.Entity<Transaccion>().HasData(new Transaccion
        {
            TransaccionId = 110,
            EstudianteId = 3,
            FechaRegistro = DateTime.Parse("2019-04-2"),
            Descripcion = "ABONO A CUENTA MEDIANTE DEPOSITO BR",
            Movimiento = 15000,
            Estado = 10000
        });
    }
}