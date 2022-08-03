using ApiTutoria2022_2.Models;
using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Asignatura>? Asignaturas { set; get; }
    public DbSet<Estudiante>? Estudiantes { set; get; }
    public DbSet<Horario>? Horarios { set; get; }
    public DbSet<Inscripcion>? Inscripciones { set; get; }
    public DbSet<InscripcionDetalle>? InscripcionDetalles { set; get; }
    public DbSet<Login>? Logins { set; get; }
    public DbSet<Persona>? Personas { set; get; }
    public DbSet<Seccion>? Secciones { set; get; }
    public DbSet<MateriaObligatoria>? MateriasObligatorias { set; get; }
    public DbSet<MateriaOptativa>? MateriasOptativas { set; get; }

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
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura { AsignaturaId = 23, CarreraId = 12, Codigo = "ISC-116", Nombre = "MERCADEO DE SOFTWARE", Credito = 4 });

        //AGREGAR ESTUDIANTE POR DEFAULT
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante { EstudianteId = 1, CarreraId = 2, PersonaId = 1, Matricula = "2016-0037", BalanceTotal = 0.0f, BalancePendiente = 0.0f });
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante { EstudianteId = 2, CarreraId = 2, PersonaId = 2, Matricula = "2016-0037", BalanceTotal = 0.0f, BalancePendiente = 0.0f });
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante { EstudianteId = 3, CarreraId = 2, PersonaId = 3, Matricula = "2016-0037", BalanceTotal = 0.0f, BalancePendiente = 0.0f });

        //AGREGAR HORARIO POR DEFAULT
        modelBuilder.Entity<Horario>().HasData(new Horario { HorariosId = 202, SeccionId = 202, Aula = "LAB. DE INFORMATICA A", Dia = "Jueves", HoraInicio = "12:00", HoraFin = "14:00" });
        modelBuilder.Entity<Horario>().HasData(new Horario { HorariosId = 200, SeccionId = 200, Aula = "LAB. DE INFORMATICA A", Dia = "Miercole", HoraInicio = "18:00", HoraFin = "21:00" });
        modelBuilder.Entity<Horario>().HasData(new Horario { HorariosId = 201, SeccionId = 201, Aula = "LAB. DE INFORMATICA B", Dia = "Miercole", HoraInicio = "18:00", HoraFin = "21:00" });
        modelBuilder.Entity<Horario>().HasData(new Horario { HorariosId = 204, SeccionId = 204, Aula = "LAB. DE INFORMATICA C", Dia = "Jueves", HoraInicio = "18:00", HoraFin = "21:00" });

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
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle { InscripcionDetalleId = 95, InscripcionId = 106, AsignaturaId = 20 });

        //AGREGAR LOGIN POR DEFAULT
        modelBuilder.Entity<Login>().HasData(new Login { LoginId = 1, EstudianteId = 1, Usuario = "Jesus", Password = "1234" });
        modelBuilder.Entity<Login>().HasData(new Login { LoginId = 2, EstudianteId = 2, Usuario = "2016", Password = "1234" });
        modelBuilder.Entity<Login>().HasData(new Login { LoginId = 3, EstudianteId = 3, Usuario = "5", Password = "1234" });

        //AGREGAR PERSONA POR DEFAULT
        modelBuilder.Entity<Persona>().HasData(new Persona { PersonaId = 1, Nombres = "Enmanuel" });
        modelBuilder.Entity<Persona>().HasData(new Persona { PersonaId = 2, Nombres = "Jesus", Apellidos = "Abreu" });
        modelBuilder.Entity<Persona>().HasData(new Persona { PersonaId = 3, Nombres = "Mario", Apellidos = "Peña Polonia" });

        //AGREGAR SECCION POR DEFAULT
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 200, DocenteId = 512, AsignaturaId = 20 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 201, DocenteId = 512, AsignaturaId = 21 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 202, DocenteId = 1, AsignaturaId = 23 });
        modelBuilder.Entity<Seccion>().HasData(new Seccion { SeccionId = 204, DocenteId = 514, AsignaturaId = 22 });
    }
}