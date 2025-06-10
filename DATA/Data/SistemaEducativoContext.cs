using System;
using System.Collections.Generic;
using DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace DATA.Data;

public partial class SistemaEducativoContext : DbContext
{
    public SistemaEducativoContext()
    {
    }

    public SistemaEducativoContext(DbContextOptions<SistemaEducativoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AsignacionesProfesore> AsignacionesProfesores { get; set; }

    public virtual DbSet<Auditorium> Auditoria { get; set; }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<Calificacione> Calificaciones { get; set; }

    public virtual DbSet<Comunicacione> Comunicaciones { get; set; }

    public virtual DbSet<ConceptosPago> ConceptosPagos { get; set; }

    public virtual DbSet<CuentasPorCobrar> CuentasPorCobrars { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DestinatariosComunicacion> DestinatariosComunicacions { get; set; }

    public virtual DbSet<Diassemana> Diassemanas { get; set; }

    public virtual DbSet<DireccionesInstituto> DireccionesInstitutos { get; set; }

    public virtual DbSet<DireccionesPersona> DireccionesPersonas { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<Evaluacione> Evaluaciones { get; set; }

    public virtual DbSet<Grado> Grados { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Inscripcione> Inscripciones { get; set; }

    public virtual DbSet<Instituto> Institutos { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<MateriasGrado> MateriasGrados { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<NivelesEducativo> NivelesEducativos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<PeriodosClase> PeriodosClases { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }

    public virtual DbSet<RolesUsuario> RolesUsuarios { get; set; }

    public virtual DbSet<TiposAula> TiposAulas { get; set; }

    public virtual DbSet<TiposComunicacion> TiposComunicacions { get; set; }

    public virtual DbSet<TiposDocumento> TiposDocumentos { get; set; }

    public virtual DbSet<TiposEvaluacion> TiposEvaluacions { get; set; }

    public virtual DbSet<TiposInstituto> TiposInstitutos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuariosRole> UsuariosRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=S4LV4D0R\\SQLEXPRESS;Database=SistemaEducativoMultiInstituto;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AsignacionesProfesore>(entity =>
        {
            entity.HasKey(e => e.AsignacionID).HasName("PK__Asignaci__D82B5BB769DC49CB");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.EstadoAsignacion).HasDefaultValue("Activa");
            entity.Property(e => e.FechaAsignacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MateriaGrado).WithMany(p => p.AsignacionesProfesores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__Mater__282DF8C2");

            entity.HasOne(d => d.Profesor).WithMany(p => p.AsignacionesProfesores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__Profe__2739D489");
        });

        modelBuilder.Entity<Auditorium>(entity =>
        {
            entity.HasKey(e => e.AuditoriaID).HasName("PK__Auditori__095694E3141F9053");

            entity.Property(e => e.FechaOperacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Auditoria).HasConstraintName("FK__Auditoria__Usuar__7755B73D");
        });

        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.AulaID).HasName("PK__Aulas__A8529A18038DC5ED");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Instituto).WithMany(p => p.Aulas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Aulas__Instituto__4E53A1AA");

            entity.HasOne(d => d.TipoAula).WithMany(p => p.Aulas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Aulas__TipoAulaI__4F47C5E3");
        });

        modelBuilder.Entity<Calificacione>(entity =>
        {
            entity.HasKey(e => e.CalificacionID).HasName("PK__Califica__4CF54ABE3DC25EE6");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCalificacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.Calificaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Calificac__Estud__3864608B");

            entity.HasOne(d => d.Evaluacion).WithMany(p => p.Calificaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Calificac__Evalu__37703C52");
        });

        modelBuilder.Entity<Comunicacione>(entity =>
        {
            entity.HasKey(e => e.ComunicacionID).HasName("PK__Comunica__8A986DF3197A2E55");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaEnvio).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RequiereConfirmacion).HasDefaultValue(false);
            entity.Property(e => e.Urgente).HasDefaultValue(false);

            entity.HasOne(d => d.Instituto).WithMany(p => p.Comunicaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comunicac__Insti__6CD828CA");

            entity.HasOne(d => d.TipoComunicacion).WithMany(p => p.Comunicaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comunicac__TipoC__6DCC4D03");

            entity.HasOne(d => d.UsuarioEnviaNavigation).WithMany(p => p.Comunicaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comunicac__Usuar__6EC0713C");
        });

        modelBuilder.Entity<ConceptosPago>(entity =>
        {
            entity.HasKey(e => e.ConceptoID).HasName("PK__Concepto__BB30F115E9EAC5C2");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Instituto).WithMany(p => p.ConceptosPagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Conceptos__Insti__55009F39");
        });

        modelBuilder.Entity<CuentasPorCobrar>(entity =>
        {
            entity.HasKey(e => e.CuentaID).HasName("PK__CuentasP__40072EA1A1DEF08A");

            entity.Property(e => e.Estado).HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.MontoDescuento).HasDefaultValue(0m);

            entity.HasOne(d => d.Concepto).WithMany(p => p.CuentasPorCobrars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentasPo__Conce__5BAD9CC8");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.CuentasPorCobrars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentasPo__Estud__5AB9788F");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.DepartamentoID).HasName("PK__Departam__66BB0E1E899AACF1");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Pais).WithMany(p => p.Departamentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Departame__PaisI__3D5E1FD2");
        });

        modelBuilder.Entity<DestinatariosComunicacion>(entity =>
        {
            entity.HasKey(e => e.DestinatarioID).HasName("PK__Destinat__C8526AD91EE1E77A");

            entity.Property(e => e.Activo).HasDefaultValue(true);

            entity.HasOne(d => d.Comunicacion).WithMany(p => p.DestinatariosComunicacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Destinata__Comun__72910220");

            entity.HasOne(d => d.Persona).WithMany(p => p.DestinatariosComunicacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Destinata__Perso__73852659");
        });

        modelBuilder.Entity<Diassemana>(entity =>
        {
            entity.HasKey(e => e.DiaSemanaID).HasName("PK__Diassema__C5898FE1F12B26BF");

            entity.Property(e => e.DiaSemanaID).ValueGeneratedNever();
        });

        modelBuilder.Entity<DireccionesInstituto>(entity =>
        {
            entity.HasKey(e => e.DireccionID).HasName("PK__Direccio__68906D44F008E698");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.EsDireccionPrincipal).HasDefaultValue(false);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Instituto).WithMany(p => p.DireccionesInstitutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Direccion__Insti__5165187F");

            entity.HasOne(d => d.Municipio).WithMany(p => p.DireccionesInstitutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Direccion__Munic__52593CB8");
        });

        modelBuilder.Entity<DireccionesPersona>(entity =>
        {
            entity.HasKey(e => e.DireccionPersonaID).HasName("PK__Direccio__A407137A41866A2C");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.EsDireccionPrincipal).HasDefaultValue(false);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TipoDireccion).HasDefaultValue("Residencial");

            entity.HasOne(d => d.Municipio).WithMany(p => p.DireccionesPersonas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Direccion__Munic__797309D9");

            entity.HasOne(d => d.Persona).WithMany(p => p.DireccionesPersonas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Direccion__Perso__787EE5A0");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.EstudianteID).HasName("PK__Estudian__6F76833887203583");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.EstadoEstudiante).HasDefaultValue("Activo");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Persona).WithMany(p => p.Estudiantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Estudiant__Perso__1332DBDC");
        });

        modelBuilder.Entity<Evaluacione>(entity =>
        {
            entity.HasKey(e => e.EvaluacionID).HasName("PK__Evaluaci__99ABA8A59C1D917E");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Asignacion).WithMany(p => p.Evaluaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Evaluacio__Asign__31B762FC");

            entity.HasOne(d => d.TipoEvaluacion).WithMany(p => p.Evaluaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Evaluacio__TipoE__32AB8735");
        });

        modelBuilder.Entity<Grado>(entity =>
        {
            entity.HasKey(e => e.GradoID).HasName("PK__Grados__5A8DF634610DF9C1");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Instituto).WithMany(p => p.Grados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grados__Institut__5AEE82B9");

            entity.HasOne(d => d.NivelEducativo).WithMany(p => p.Grados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grados__NivelEdu__5BE2A6F2");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.HorarioID).HasName("PK__Horarios__BB881A9E37B61814");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Asignacion).WithMany(p => p.Horarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Horarios__Asigna__43D61337");

            entity.HasOne(d => d.Aula).WithMany(p => p.Horarios).HasConstraintName("FK__Horarios__AulaID__503BEA1C");

            entity.HasOne(d => d.DiaSemana).WithMany(p => p.Horarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Horarios__DiaSem__44CA3770");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Horarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Horarios__Period__45BE5BA9");
        });

        modelBuilder.Entity<Inscripcione>(entity =>
        {
            entity.HasKey(e => e.InscripcionID).HasName("PK__Inscripc__168316999138A813");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.EstadoInscripcion).HasDefaultValue("Activa");
            entity.Property(e => e.FechaInscripcion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.Inscripciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inscripci__Estud__18EBB532");

            entity.HasOne(d => d.Grado).WithMany(p => p.Inscripciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inscripci__Grado__19DFD96B");
        });

        modelBuilder.Entity<Instituto>(entity =>
        {
            entity.HasKey(e => e.InstitutoID).HasName("PK__Institut__0B609D07E3B55516");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.TipoInstituto).WithMany(p => p.Institutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Instituto__TipoI__4BAC3F29");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.MateriaID).HasName("PK__Materias__0D019D817EF18D0B");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CreditosAcademicos).HasDefaultValue(0);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.HorasSemanales).HasDefaultValue(0);
        });

        modelBuilder.Entity<MateriasGrado>(entity =>
        {
            entity.HasKey(e => e.MateriaGradoID).HasName("PK__Materias__802332DA0E2253C1");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.EsObligatoria).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Grado).WithMany(p => p.MateriasGrados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MateriasG__Grado__6754599E");

            entity.HasOne(d => d.Materia).WithMany(p => p.MateriasGrados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MateriasG__Mater__68487DD7");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.MunicipioID).HasName("PK__Municipi__1EEFE56E2846097D");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Departamento).WithMany(p => p.Municipios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Municipio__Depar__4222D4EF");
        });

        modelBuilder.Entity<NivelesEducativo>(entity =>
        {
            entity.HasKey(e => e.NivelEducativoID).HasName("PK__NivelesE__E627E6B73F2041D1");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.PagoID).HasName("PK__Pagos__F00B615850A29532");

            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaPago).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Cuenta).WithMany(p => p.Pagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pagos__CuentaID__607251E5");

            entity.HasOne(d => d.UsuarioRegistroNavigation).WithMany(p => p.Pagos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pagos__UsuarioRe__6166761E");
        });

        modelBuilder.Entity<Paise>(entity =>
        {
            entity.HasKey(e => e.PaisID).HasName("PK__Paises__B501E1A5DD1C705A");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoISO).IsFixedLength();
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<PeriodosClase>(entity =>
        {
            entity.HasKey(e => e.PeriodoID).HasName("PK__Periodos__0ADD35CA3773E387");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Instituto).WithMany(p => p.PeriodosClases)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PeriodosC__Insti__3D2915A8");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaID).HasName("PK__Personas__7C34D3233945712B");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Genero).IsFixedLength();

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Personas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Personas__TipoDo__71D1E811");
        });

        modelBuilder.Entity<Profesore>(entity =>
        {
            entity.HasKey(e => e.ProfesorID).HasName("PK__Profesor__4DF3F0282129FD46");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.AniosExperiencia).HasDefaultValue(0);
            entity.Property(e => e.EstadoProfesor).HasDefaultValue("Activo");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Persona).WithMany(p => p.Profesores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Profesore__Perso__2180FB33");
        });

        modelBuilder.Entity<RolesUsuario>(entity =>
        {
            entity.HasKey(e => e.RolID).HasName("PK__RolesUsu__F92302D128E60B64");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TiposAula>(entity =>
        {
            entity.HasKey(e => e.TipoAulaID).HasName("PK__TiposAul__F57D9FBB952013A2");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TiposComunicacion>(entity =>
        {
            entity.HasKey(e => e.TipoComunicacionID).HasName("PK__TiposCom__787036AB0CA69A25");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TiposDocumento>(entity =>
        {
            entity.HasKey(e => e.TipoDocumentoID).HasName("PK__TiposDoc__A329EAA74BD8955E");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TiposEvaluacion>(entity =>
        {
            entity.HasKey(e => e.TipoEvaluacionID).HasName("PK__TiposEva__45583039A200EBF1");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PorcentajeMaximo).HasDefaultValue(100.00m);
        });

        modelBuilder.Entity<TiposInstituto>(entity =>
        {
            entity.HasKey(e => e.TipoInstitutoID).HasName("PK__TiposIns__E3A878F7DA67D732");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioID).HasName("PK__Usuarios__2B3DE798C9286CBB");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Bloqueado).HasDefaultValue(false);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IntentosLogin).HasDefaultValue(0);
            entity.Property(e => e.RequiereCambioPassword).HasDefaultValue(true);

            entity.HasOne(d => d.Persona).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuarios__Person__05D8E0BE");
        });

        modelBuilder.Entity<UsuariosRole>(entity =>
        {
            entity.HasKey(e => e.UsuarioRolID).HasName("PK__Usuarios__C869CD2A4BC115CA");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaAsignacion).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Instituto).WithMany(p => p.UsuariosRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuariosR__Insti__0C85DE4D");

            entity.HasOne(d => d.Rol).WithMany(p => p.UsuariosRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuariosR__RolID__0B91BA14");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuariosRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuariosR__Usuar__0A9D95DB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
