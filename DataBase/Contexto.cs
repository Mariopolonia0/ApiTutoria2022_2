using ApiTutoria2022_2.Models;
using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Asignatura>? Asignaturas { set; get; }
    public DbSet<AsignaturaAprobada>? AsignaturaAprobadas { set; get; }
    public DbSet<Carrera>? Carreras { set; get; }
    public DbSet<Estudiante>? Estudiantes { set; get; }
    public DbSet<Horario>? Horarios { set; get; }
    public DbSet<Inscripcion>? Inscripciones { set; get; }
    public DbSet<InscripcionDetalle>? InscripcionDetalles { set; get; }
    public DbSet<Login>? Logins { set; get; }
    public DbSet<Persona>? Personas { set; get; }
    public DbSet<Seccion>? Secciones { set; get; }
    public DbSet<Transaccion>? Transaccion { set; get; }
    public DbSet<Cuatrimestre>? Cuatrimestre { set; get; }
    public DbSet<Calificaciones>? Calificaciones { set; get; }
    public DbSet<Indice>? Indices { set; get; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 1,
            CuatrimestreId = 100,
            EstudianteId = 1,
            AsignaturaId = 20,
            Nota = 90,
            Calificacion = "A"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 2,
            CuatrimestreId = 100,
            EstudianteId = 1,
            AsignaturaId = 21,
            Nota = 80,
            Calificacion = "B"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 3,
            CuatrimestreId = 100,
            EstudianteId = 1,
            AsignaturaId = 22,
            Nota = 85,
            Calificacion = "B+"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 4,
            CuatrimestreId = 103,
            EstudianteId = 1,
            AsignaturaId = 23,
            Nota = 70,
            Calificacion = "C"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 5,
            CuatrimestreId = 102,
            EstudianteId = 1,
            AsignaturaId = 24,
            Nota = 90,
            Calificacion = "A"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 6,
            CuatrimestreId = 102,
            EstudianteId = 1,
            AsignaturaId = 25,
            Nota = 90,
            Calificacion = "A"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 7,
            CuatrimestreId = 102,
            EstudianteId = 1,
            AsignaturaId = 26,
            Nota = 60,
            Calificacion = "D"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 8,
            CuatrimestreId = 103,
            EstudianteId = 1,
            AsignaturaId = 27,
            Nota = 90,
            Calificacion = "A"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 9,
            CuatrimestreId = 103,
            EstudianteId = 1,
            AsignaturaId = 28,
            Nota = 95,
            Calificacion = "A+"
        });
        //
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 10,
            CuatrimestreId = 102,
            EstudianteId = 2,
            AsignaturaId = 20,
            Nota = 80,
            Calificacion = "B"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 12,
            CuatrimestreId = 100,
            EstudianteId = 2,
            AsignaturaId = 21,
            Nota = 85,
            Calificacion = "B+"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 13,
            CuatrimestreId = 103,
            EstudianteId = 2,
            AsignaturaId = 22,
            Nota = 80,
            Calificacion = "B"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 14,
            CuatrimestreId = 102,
            EstudianteId = 2,
            AsignaturaId = 23,
            Nota = 75,
            Calificacion = "C+"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 15,
            CuatrimestreId = 102,
            EstudianteId = 2,
            AsignaturaId = 24,
            Nota = 95,
            Calificacion = "A+"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 16,
            CuatrimestreId = 100,
            EstudianteId = 2,
            AsignaturaId = 25,
            Nota = 95,
            Calificacion = "A+"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 17,
            CuatrimestreId = 100,
            EstudianteId = 2,
            AsignaturaId = 26,
            Nota = 60,
            Calificacion = "D"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 18,
            CuatrimestreId = 103,
            EstudianteId = 2,
            AsignaturaId = 27,
            Nota = 90,
            Calificacion = "A"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 19,
            CuatrimestreId = 103,
            EstudianteId = 2,
            AsignaturaId = 28,
            Nota = 90,
            Calificacion = "A"
        });
        //
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 20,
            CuatrimestreId = 102,
            EstudianteId = 3,
            AsignaturaId = 25,
            Nota = 80,
            Calificacion = "B"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 21,
            CuatrimestreId = 100,
            EstudianteId = 3,
            AsignaturaId = 26,
            Nota = 60,
            Calificacion = "D"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 22,
            CuatrimestreId = 101,
            EstudianteId = 3,
            AsignaturaId = 27,
            Nota = 80,
            Calificacion = "B"
        });
        modelBuilder.Entity<Calificaciones>().HasData(new Calificaciones
        {
            CalificacionesId = 23,
            CuatrimestreId = 101,
            EstudianteId = 3,
            AsignaturaId = 28,
            Nota = 90,
            Calificacion = "A"
        });

        //Cuatrimestre
        modelBuilder.Entity<Cuatrimestre>().HasData(new Cuatrimestre
        {
            CuatrimestreId = 100,
            yeard = 2020,
            numeroCuatrimestre = 2,
            Meses = "Abril - Agosto"
        });
        modelBuilder.Entity<Cuatrimestre>().HasData(new Cuatrimestre
        {
            CuatrimestreId = 101,
            yeard = 2019,
            numeroCuatrimestre = 1,
            Meses = "Enero-abril"
        });
        modelBuilder.Entity<Cuatrimestre>().HasData(new Cuatrimestre
        {
            CuatrimestreId = 102,
            yeard = 2020,
            numeroCuatrimestre = 1,
            Meses = "Enero - Abril"
        });
        modelBuilder.Entity<Cuatrimestre>().HasData(new Cuatrimestre
        {
            CuatrimestreId = 103,
            yeard = 2020,
            numeroCuatrimestre = 3,
            Meses = "Octubre - Diciembre"
        });

        modelBuilder.Entity<Indice>().HasData(new Indice
        {
            IndiceId = 1,
            CuatrimestreId = 100,
            EstudianteId = 1,
            indicePeriodo = "3.0",
            indiceAcumulado = "3.2"
        });

        modelBuilder.Entity<Indice>().HasData(new Indice
        {
            IndiceId = 2,
            CuatrimestreId = 102,
            EstudianteId = 1,
            indicePeriodo = "3.0",
            indiceAcumulado = "2.9"
        });

        modelBuilder.Entity<Indice>().HasData(new Indice
        {
            IndiceId = 3,
            CuatrimestreId = 103,
            EstudianteId = 1,
            indicePeriodo = "2.0",
            indiceAcumulado = "3.1"
        });
        modelBuilder.Entity<Indice>().HasData(new Indice
        {
            IndiceId = 4,
            CuatrimestreId = 100,
            EstudianteId = 2,
            indicePeriodo = "2.0",
            indiceAcumulado = "3.1"
        });
        modelBuilder.Entity<Indice>().HasData(new Indice
        {
            IndiceId = 5,
            CuatrimestreId = 102,
            EstudianteId = 2,
            indicePeriodo = "2.0",
            indiceAcumulado = "3.1"
        });
        modelBuilder.Entity<Indice>().HasData(new Indice
        {
            IndiceId = 6,
            CuatrimestreId = 103,
            EstudianteId = 2,
            indicePeriodo = "2.0",
            indiceAcumulado = "3.1"
        });

        //AGREGAR ASIGNATURA POR DEFAULT
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 20,
            CarreraId = 12,
            Codigo = "ISC-101",
            Nombre = "PROGRAMACION APLICADA II",
            Credito = 2
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 21,
            CarreraId = 12,
            Codigo = "ISC-102",
            Nombre = "LAB. PROGRAM. APLICADA II",
            Credito = 1
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 22,
            CarreraId = 12,
            Codigo = "ISC-802",
            Nombre = "DISEÑO DE SISTEMAS",
            Credito = 4
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 29,
            CarreraId = 12,
            Codigo = "ISC-701",
            Nombre = "SISTEMAS OPERATIVOS I",
            Credito = 4
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 23,
            CarreraId = 12,
            Codigo = "ISC-701",
            Nombre = "MERCADEO DE SOFTWARE",
            Credito = 4
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 24,
            CarreraId = 12,
            Codigo = "ISC-702",
            Nombre = "LABORATORIO SISTEMAS OPERATIVOS I",
            Credito = 4
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 25,
            CarreraId = 12,
            Codigo = "ISC-704",
            Nombre = "BASE DE DATOS",
            Credito = 4
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 26,
            CarreraId = 12,
            Codigo = "ISC-703",
            Nombre = "LAB. BASE DE DATOS ",
            Credito = 4
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 27,
            CarreraId = 12,
            Codigo = "ISC-705",
            Nombre = "MATENIMIENTO DE HARDWARE",
            Credito = 4
        });
        modelBuilder.Entity<Asignatura>().HasData(new Asignatura
        {
            AsignaturaId = 28,
            CarreraId = 12,
            Codigo = "CNT-213",
            Nombre = "CONTABILIDAD GENERAL I ",
            Credito = 4
        });


        //AGREGAR CARRERA POR DEFAUTLT
        modelBuilder.Entity<Carrera>().HasData(new Carrera
        {
            CarreraId = 12,
            FacultadId = 12,
            DirectorId = 103,
            cantidadMateriaObligatorias = 75,
            cantidadMateriaOptativas = 4,
            Nombre = "Ingeniero en Sistemas y Computación"
        });

        //AGREGAR ESTUDIANTE POR DEFAULT
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante
        {
            EstudianteId = 2,
            CarreraId = 12,
            PersonaId = 2,
            Matricula = "2016-0037",
            BalanceTotal = 0.0f,
            BalancePendiente = 0.0f
        });
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante
        {
            EstudianteId = 3,
            CarreraId = 12,
            PersonaId = 3,
            Matricula = "2016-0037",
            BalanceTotal = 0.0f,
            BalancePendiente = 0.0f
        });
        modelBuilder.Entity<Estudiante>().HasData(new Estudiante
        {
            EstudianteId = 1,
            CarreraId = 12,
            PersonaId = 1,
            Matricula = "2016-0037",
            BalanceTotal = 0.0f,
            BalancePendiente = 0.0f
        });

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
        modelBuilder.Entity<Inscripcion>().HasData(new Inscripcion
        {
            InscripcionId = 104,
            EstudianteId = 1,
            CuatrimestreId = 100,
            FechaRegistrada = DateTime.Parse("2022-04-25"),
            FechaInicioTrimestre = DateTime.Parse("2022-05-03"),
            FechaFinalTrimestre = DateTime.Parse("2022-08-13"),
            UltimaInscripcion = true
        });
        modelBuilder.Entity<Inscripcion>().HasData(new Inscripcion
        {
            InscripcionId = 105,
            EstudianteId = 2,
            CuatrimestreId = 100,
            FechaRegistrada = DateTime.Parse("2022-04-25"),
            FechaInicioTrimestre = DateTime.Parse("2022-05-03"),
            FechaFinalTrimestre = DateTime.Parse("2022-08-13"),
            UltimaInscripcion = true
        });
        modelBuilder.Entity<Inscripcion>().HasData(new Inscripcion
        {
            InscripcionId = 106,
            EstudianteId = 3,
            CuatrimestreId = 100,
            FechaRegistrada = DateTime.Parse("2022-04-25"),
            FechaInicioTrimestre = DateTime.Parse("2022-05-03"),
            FechaFinalTrimestre = DateTime.Parse("2022-08-13"),
            UltimaInscripcion = true
        });
        modelBuilder.Entity<Inscripcion>().HasData(new Inscripcion
        {
            InscripcionId = 107,
            EstudianteId = 3,
            CuatrimestreId = 101,
            FechaRegistrada = DateTime.Parse("2020-01-01"),
            FechaInicioTrimestre = DateTime.Parse("2020-01-03"),
            FechaFinalTrimestre = DateTime.Parse("2020-04-05"),
            UltimaInscripcion = false
        });

        //AGREGAR INSCRIPCIONDETALLE POR DEFAULT
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 90,
            InscripcionId = 104,
            AsignaturaId = 20
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 91,
            InscripcionId = 104,
            AsignaturaId = 21

        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 92,
            InscripcionId = 105,
            AsignaturaId = 22
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 93,
            InscripcionId = 105,
            AsignaturaId = 23
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 94,
            InscripcionId = 106,
            AsignaturaId = 23
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 95,
            InscripcionId = 106,
            AsignaturaId = 24
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 96,
            InscripcionId = 106,
            AsignaturaId = 25
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 97,
            InscripcionId = 106,
            AsignaturaId = 26
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 99,
            InscripcionId = 106,
            AsignaturaId = 27
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 100,
            InscripcionId = 106,
            AsignaturaId = 28
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 101,
            InscripcionId = 104,
            AsignaturaId = 27
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 102,
            InscripcionId = 104,
            AsignaturaId = 28
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 103,
            InscripcionId = 105,
            AsignaturaId = 25
        });
        modelBuilder.Entity<InscripcionDetalle>().HasData(new InscripcionDetalle
        {
            InscripcionDetalleId = 104,
            InscripcionId = 105,
            AsignaturaId = 26
        });

        //AGREGAR LOGIN POR DEFAULT
        modelBuilder.Entity<Login>().HasData(new Login
        {
            LoginId = 1,
            EstudianteId = 2,
            Usuario = "Jesus",
            Password = "1234"
        });
        modelBuilder.Entity<Login>().HasData(new Login
        {
            LoginId = 2,
            EstudianteId = 3,
            Usuario = "2016",
            Password = "1234"
        });
        modelBuilder.Entity<Login>().HasData(new Login
        {
            LoginId = 3,
            EstudianteId = 1,
            Usuario = "5",
            Password = "1234"
        });

        //AGREGAR PERSONA POR DEFAULT
        modelBuilder.Entity<Persona>().HasData(new Persona
        {
            PersonaId = 1,
            Nombres = "Enmanuel",
            Apellidos = "Salazar",
            Nacionalidad = "Republica Dominicana",
            Tutor = "Ramon",
            CorreoInstitucion = "enmanuel@klk.com",
            Celular = "829-798-5996"
        });
        modelBuilder.Entity<Persona>().HasData(new Persona
        {
            PersonaId = 2,
            Nombres = "Jesus",
            Apellidos = "Abreu",
            Nacionalidad = "Republica Dominicana",
            Tutor = "Jose",
            CorreoInstitucion = "jesus@klk.com",
            Celular = "829-780-5880"
        });
        modelBuilder.Entity<Persona>().HasData(new Persona
        {
            PersonaId = 3,
            Nombres = "Mario",
            Apellidos = "Peña Polonia",
            Nacionalidad = "Republica Dominicana",
            Tutor = "RAMÓN FRANCISCO PEÑA GARCÍA",
            CorreoInstitucion = "Klk@klk.com",
            Celular = "829-798-5826"
        });

        //AGREGAR SECCION POR DEFAULT
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 200,
            DocenteId = 512,
            AsignaturaId = 20
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 201,
            DocenteId = 512,
            AsignaturaId = 21
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 209,
            DocenteId = 512,
            AsignaturaId = 22
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 202,
            DocenteId = 1,
            AsignaturaId = 23
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 203,
            DocenteId = 1,
            AsignaturaId = 29
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 204,
            DocenteId = 1,
            AsignaturaId = 24
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 205,
            DocenteId = 9,
            AsignaturaId = 25
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 206,
            DocenteId = 9,
            AsignaturaId = 26
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 207,
            DocenteId = 10,
            AsignaturaId = 27
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 208,
            DocenteId = 10,
            AsignaturaId = 28
        });
        modelBuilder.Entity<Seccion>().HasData(new Seccion
        {
            SeccionId = 210,
            DocenteId = 514,
            AsignaturaId = 22
        });

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

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 1,
            AsignaturaId = 1,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 2,
            AsignaturaId = 2,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 3,
            AsignaturaId = 3,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 4,
            AsignaturaId = 4,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 5,
            AsignaturaId = 5,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 6,
            AsignaturaId = 6,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 7,
            AsignaturaId = 7,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 8,
            AsignaturaId = 8,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 9,
            AsignaturaId = 9,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 10,
            AsignaturaId = 10,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 11,
            AsignaturaId = 11,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada

        {
            AsignaturaAprobadaId = 12,
            AsignaturaId = 12,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 13,
            AsignaturaId = 13,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 14,
            AsignaturaId = 14,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 15,
            AsignaturaId = 15,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 16,
            AsignaturaId = 16,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 17,
            AsignaturaId = 17,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 18,
            AsignaturaId = 18,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 19,
            AsignaturaId = 19,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 20,
            AsignaturaId = 20,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 21,
            AsignaturaId = 21,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 22,
            AsignaturaId = 22,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 23,
            AsignaturaId = 23,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 24,
            AsignaturaId = 24,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 25,
            AsignaturaId = 25,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 26,
            AsignaturaId = 26,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 27,
            AsignaturaId = 27,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 28,
            AsignaturaId = 28,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 29,
            AsignaturaId = 29,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 30,
            AsignaturaId = 30,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 31,
            AsignaturaId = 31,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 32,
            AsignaturaId = 32,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 33,
            AsignaturaId = 33,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 34,
            AsignaturaId = 34,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 35,
            AsignaturaId = 35,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 36,
            AsignaturaId = 36,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 37,
            AsignaturaId = 37,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 38,
            AsignaturaId = 38,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 39,
            AsignaturaId = 39,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 40,
            AsignaturaId = 40,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 41,
            AsignaturaId = 41,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 42,
            AsignaturaId = 42,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 43,
            AsignaturaId = 43,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 44,
            AsignaturaId = 44,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 45,
            AsignaturaId = 45,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 46,
            AsignaturaId = 46,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 47,
            AsignaturaId = 47,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 48,
            AsignaturaId = 48,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 49,
            AsignaturaId = 49,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 50,
            AsignaturaId = 50,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 51,
            AsignaturaId = 51,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 52,
            AsignaturaId = 52,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 53,
            AsignaturaId = 53,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 54,
            AsignaturaId = 54,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 55,
            AsignaturaId = 55,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 56,
            AsignaturaId = 56,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 57,
            AsignaturaId = 57,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 58,
            AsignaturaId = 58,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 59,
            AsignaturaId = 59,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 60,
            AsignaturaId = 60,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 61,
            AsignaturaId = 61,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 62,
            AsignaturaId = 62,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 63,
            AsignaturaId = 63,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 64,
            AsignaturaId = 64,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 65,
            AsignaturaId = 65,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 66,
            AsignaturaId = 66,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 67,
            AsignaturaId = 67,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 68,
            AsignaturaId = 68,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 69,
            AsignaturaId = 69,
            Optativa = false,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 70,
            AsignaturaId = 70,
            Optativa = false,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 71,
            AsignaturaId = 71,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 72,
            AsignaturaId = 72,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 73,
            AsignaturaId = 73,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 74,
            AsignaturaId = 74,
            EstudianteId = 1
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 75,
            AsignaturaId = 75,
            EstudianteId = 1
        });


        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 200,
            AsignaturaId = 200,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 201,
            AsignaturaId = 201,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 202,
            AsignaturaId = 202,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 203,
            AsignaturaId = 203,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada

        {
            AsignaturaAprobadaId = 204,
            AsignaturaId = 204,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 205,
            AsignaturaId = 205,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 206,
            AsignaturaId = 206,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 207,
            AsignaturaId = 207,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 208,
            AsignaturaId = 208,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 209,
            AsignaturaId = 209,
            Optativa = false,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 210,
            AsignaturaId = 210,
            Optativa = false,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 211,
            AsignaturaId = 211,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 212,
            AsignaturaId = 212,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 213,
            AsignaturaId = 213,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 214,
            AsignaturaId = 214,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 215,
            AsignaturaId = 215,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 216,
            AsignaturaId = 216,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 217,
            AsignaturaId = 217,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 218,
            AsignaturaId = 218,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 219,
            AsignaturaId = 219,
            EstudianteId = 2
        });
        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 220,
            AsignaturaId = 220,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 221,
            AsignaturaId = 221,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 222,
            AsignaturaId = 222,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 223,
            AsignaturaId = 223,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 224,
            AsignaturaId = 224,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 225,
            AsignaturaId = 225,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 226,
            AsignaturaId = 226,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 227,
            AsignaturaId = 227,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 228,
            AsignaturaId = 228,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 229,
            AsignaturaId = 229,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 230,
            AsignaturaId = 230,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 231,
            AsignaturaId = 231,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 232,
            AsignaturaId = 232,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 233,
            AsignaturaId = 233,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 234,
            AsignaturaId = 234,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 235,
            AsignaturaId = 235,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 236,
            AsignaturaId = 236,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 237,
            AsignaturaId = 237,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 238,
            AsignaturaId = 238,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 239,
            AsignaturaId = 239,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 240,
            AsignaturaId = 240,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 241,
            AsignaturaId = 241,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 242,
            AsignaturaId = 242,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 243,
            AsignaturaId = 243,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 244,
            AsignaturaId = 244,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 245,
            AsignaturaId = 245,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 246,
            AsignaturaId = 246,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 247,
            AsignaturaId = 247,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 248,
            AsignaturaId = 248,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 249,
            AsignaturaId = 249,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 250,
            AsignaturaId = 250,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 251,
            AsignaturaId = 251,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 252,
            AsignaturaId = 252,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 253,
            AsignaturaId = 253,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 254,
            AsignaturaId = 254,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 255,
            AsignaturaId = 255,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 256,
            AsignaturaId = 256,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 257,
            AsignaturaId = 257,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 258,
            AsignaturaId = 258,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 259,
            AsignaturaId = 259,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 260,
            AsignaturaId = 260,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 261,
            AsignaturaId = 261,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 262,
            AsignaturaId = 262,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 263,
            AsignaturaId = 263,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 264,
            AsignaturaId = 264,
            EstudianteId = 2
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 265,
            AsignaturaId = 265,
            EstudianteId = 2
        });





        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 300,
            AsignaturaId = 300,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 301,
            AsignaturaId = 301,
            Optativa = false,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 302,
            AsignaturaId = 302,
            Optativa = false,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 303,
            AsignaturaId = 303,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 304,
            AsignaturaId = 304,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 305,
            AsignaturaId = 305,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 306,
            AsignaturaId = 306,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 307,
            AsignaturaId = 307,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 308,
            AsignaturaId = 308,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 309,
            AsignaturaId = 309,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 310,
            AsignaturaId = 310,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 311,
            AsignaturaId = 311,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 312,
            AsignaturaId = 312,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 313,
            AsignaturaId = 313,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 314,
            AsignaturaId = 314,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 315,
            AsignaturaId = 315,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 316,
            AsignaturaId = 316,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 317,
            AsignaturaId = 317,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 318,
            AsignaturaId = 318,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 319,
            AsignaturaId = 319,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 320,
            AsignaturaId = 320,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 321,
            AsignaturaId = 321,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 322,
            AsignaturaId = 322,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 323,
            AsignaturaId = 323,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 324,
            AsignaturaId = 324,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 325,
            AsignaturaId = 325,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 326,
            AsignaturaId = 326,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 327,
            AsignaturaId = 327,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 328,
            AsignaturaId = 328,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 329,
            AsignaturaId = 329,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 330,
            AsignaturaId = 330,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 331,
            AsignaturaId = 331,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 332,
            AsignaturaId = 332,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 333,
            AsignaturaId = 333,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 334,
            AsignaturaId = 334,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 335,
            AsignaturaId = 335,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 336,
            AsignaturaId = 336,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 337,
            AsignaturaId = 337,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 338,
            AsignaturaId = 338,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 339,
            AsignaturaId = 339,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 340,
            AsignaturaId = 340,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 341,
            AsignaturaId = 341,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 342,
            AsignaturaId = 342,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 343,
            AsignaturaId = 343,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 344,
            AsignaturaId = 344,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 345,
            AsignaturaId = 345,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 346,
            AsignaturaId = 346,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 347,
            AsignaturaId = 347,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 348,
            AsignaturaId = 348,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 349,
            AsignaturaId = 349,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 350,
            AsignaturaId = 350,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 351,
            AsignaturaId = 351,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 352,
            AsignaturaId = 352,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 353,
            AsignaturaId = 353,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 354,
            AsignaturaId = 354,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 355,
            AsignaturaId = 355,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 356,
            AsignaturaId = 356,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 357,
            AsignaturaId = 357,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 358,
            AsignaturaId = 358,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 359,
            AsignaturaId = 359,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 360,
            AsignaturaId = 360,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 361,
            AsignaturaId = 361,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 362,
            AsignaturaId = 362,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 363,
            AsignaturaId = 363,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 364,
            AsignaturaId = 364,
            EstudianteId = 3
        });

        modelBuilder.Entity<AsignaturaAprobada>().HasData(new AsignaturaAprobada
        {
            AsignaturaAprobadaId = 365,
            AsignaturaId = 365,
            EstudianteId = 3
        });
    }
}


