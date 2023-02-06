using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using StudyWebApp.Shared.Logging;
using StudyWebApp.Shared.Modelos;

namespace StudyWebApp.Estudio.DataAccess.Configuracion.Context
{
    public partial class EstudioContext : DbContext
    {
        private readonly IConfiguration configuration;
        public EstudioContext()
        {
        }
        public EstudioContext(DbContextOptions<EstudioContext> options)
    : base(options)
        {

        }
        public virtual DbSet<Loggings> Loggings { get; set; } = null!;
        public virtual DbSet<Asignatura> Asignaturas { get; set; }

        public virtual DbSet<PreguntaEspacio> PreguntaEspacios { get; set; }

        public virtual DbSet<PreguntaOpMultiple> PreguntaOpMultiples { get; set; }

        public virtual DbSet<PreguntaOpUnica> PreguntaOpUnicas { get; set; }

        public virtual DbSet<PreguntaVF> PreguntaVFs { get; set; }

        public virtual DbSet<RankingAlum> RankingAlums { get; set; }

        public virtual DbSet<RankingProf> RankingProfs { get; set; }

        public virtual DbSet<Tema> Temas { get; set; }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(configuration.GetConnectionString("ConnectionEstudio"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("asignatura_pkey");

                entity.ToTable("asignatura", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Asignaturas)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<PreguntaEspacio>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("pregunta_espacios_pkey");

                entity.ToTable("pregunta_espacios", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.Frase)
                    .HasMaxLength(300)
                    .HasColumnName("frase");
                entity.Property(e => e.IdAsignatura)
                    .HasMaxLength(18)
                    .HasColumnName("id_asignatura");
                entity.Property(e => e.IdTema)
                    .HasMaxLength(18)
                    .HasColumnName("id_tema");
                entity.Property(e => e.PalabrasCorrectas)
                    .HasMaxLength(100)
                    .HasColumnName("palabras_correctas");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.PreguntaEspacios)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_asignatura_fk");

                entity.HasOne(d => d.IdTemaNavigation).WithMany(p => p.PreguntaEspacios)
                    .HasForeignKey(d => d.IdTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_tema_fk");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.PreguntaEspacios)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<PreguntaOpMultiple>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("pregunta_op_multiple_pkey");

                entity.ToTable("pregunta_op_multiple", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.Correcta1)
                    .HasMaxLength(1)
                    .HasColumnName("correcta_1");
                entity.Property(e => e.Correcta2)
                    .HasMaxLength(1)
                    .HasColumnName("correcta_2");
                entity.Property(e => e.Correcta3)
                    .HasMaxLength(1)
                    .HasColumnName("correcta_3");
                entity.Property(e => e.Correcta4)
                    .HasMaxLength(1)
                    .HasColumnName("correcta_4");
                entity.Property(e => e.Correcta5)
                    .HasMaxLength(1)
                    .HasColumnName("correcta_5");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.IdAsignatura)
                    .HasMaxLength(18)
                    .HasColumnName("id_asignatura");
                entity.Property(e => e.IdTema)
                    .HasMaxLength(18)
                    .HasColumnName("id_tema");
                entity.Property(e => e.Pregunta)
                    .HasMaxLength(100)
                    .HasColumnName("pregunta");
                entity.Property(e => e.Respuesta1)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_1");
                entity.Property(e => e.Respuesta2)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_2");
                entity.Property(e => e.Respuesta3)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_3");
                entity.Property(e => e.Respuesta4)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_4");
                entity.Property(e => e.Respuesta5)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_5");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.PreguntaOpMultiples)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_asignatura_fk");

                entity.HasOne(d => d.IdTemaNavigation).WithMany(p => p.PreguntaOpMultiples)
                    .HasForeignKey(d => d.IdTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_tema_fk");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.PreguntaOpMultiples)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<PreguntaOpUnica>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("pregunta_op_unica_pkey");

                entity.ToTable("pregunta_op_unica", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.Correcta)
                    .HasMaxLength(1)
                    .HasColumnName("correcta");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.IdAsignatura)
                    .HasMaxLength(18)
                    .HasColumnName("id_asignatura");
                entity.Property(e => e.IdTema)
                    .HasMaxLength(18)
                    .HasColumnName("id_tema");
                entity.Property(e => e.Pregunta)
                    .HasMaxLength(100)
                    .HasColumnName("pregunta");
                entity.Property(e => e.Respuesta1)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_1");
                entity.Property(e => e.Respuesta2)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_2");
                entity.Property(e => e.Respuesta3)
                    .HasMaxLength(100)
                    .HasColumnName("respuesta_3");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.PreguntaOpUnicas)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_asignatura_fk");

                entity.HasOne(d => d.IdTemaNavigation).WithMany(p => p.PreguntaOpUnicas)
                    .HasForeignKey(d => d.IdTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_tema_fk");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.PreguntaOpUnicas)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<PreguntaVF>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("pregunta_v_f_pkey");

                entity.ToTable("pregunta_v_f", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.IdAsignatura)
                    .HasMaxLength(18)
                    .HasColumnName("id_asignatura");
                entity.Property(e => e.IdTema)
                    .HasMaxLength(18)
                    .HasColumnName("id_tema");
                entity.Property(e => e.Pregunta)
                    .HasMaxLength(100)
                    .HasColumnName("pregunta");
                entity.Property(e => e.Respuesta)
                    .HasMaxLength(1)
                    .HasColumnName("respuesta");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.PreguntaVFs)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_asignatura_fk");

                entity.HasOne(d => d.IdTemaNavigation).WithMany(p => p.PreguntaVFs)
                    .HasForeignKey(d => d.IdTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_tema_fk");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.PreguntaVFs)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<RankingAlum>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("ranking_alum_pkey");

                entity.ToTable("ranking_alum", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.IdAsignatura)
                    .HasMaxLength(18)
                    .HasColumnName("id_asignatura");
                entity.Property(e => e.IdTema)
                    .HasMaxLength(18)
                    .HasColumnName("id_tema");
                entity.Property(e => e.NumAciertos).HasColumnName("num_aciertos");
                entity.Property(e => e.NumErrores).HasColumnName("num_errores");
                entity.Property(e => e.NumPreguntas).HasColumnName("num_preguntas");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.RankingAlums)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_asignatura_fk");

                entity.HasOne(d => d.IdTemaNavigation).WithMany(p => p.RankingAlums)
                    .HasForeignKey(d => d.IdTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_tema_fk");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.RankingAlums)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<RankingProf>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("ranking_prof_pkey");

                entity.ToTable("ranking_prof", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.IdAsignatura)
                    .HasMaxLength(18)
                    .HasColumnName("id_asignatura");
                entity.Property(e => e.IdTema)
                    .HasMaxLength(18)
                    .HasColumnName("id_tema");
                entity.Property(e => e.NumAciertos).HasColumnName("num_aciertos");
                entity.Property(e => e.NumErrores).HasColumnName("num_errores");
                entity.Property(e => e.NumPreguntas).HasColumnName("num_preguntas");
                entity.Property(e => e.UsuarioAlumno)
                    .HasMaxLength(18)
                    .HasColumnName("usuario_alumno");
                entity.Property(e => e.UsuarioProfesor)
                    .HasMaxLength(18)
                    .HasColumnName("usuario_profesor");

                entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.RankingProfs)
                    .HasForeignKey(d => d.IdAsignatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_asignatura_fk");

                entity.HasOne(d => d.IdTemaNavigation).WithMany(p => p.RankingProfs)
                    .HasForeignKey(d => d.IdTema)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_tema_fk");

                entity.HasOne(d => d.UsuarioAlumnoNavigation).WithMany(p => p.RankingProfUsuarioAlumnoNavigations)
                    .HasForeignKey(d => d.UsuarioAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_alumno_fk");

                entity.HasOne(d => d.UsuarioProfesorNavigation).WithMany(p => p.RankingProfUsuarioProfesorNavigations)
                    .HasForeignKey(d => d.UsuarioProfesor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_profesor_fk");
            });

            modelBuilder.Entity<Tema>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("tema_pkey");

                entity.ToTable("tema", "estudio");

                entity.Property(e => e.Id)
                    .HasMaxLength(18)
                    .HasColumnName("id");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.IdAsignatura)
                    .HasMaxLength(18)
                    .HasColumnName("id_asignatura");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Temas)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Usuario1).HasName("usuario_pkey");

                entity.ToTable("usuario", "estudio");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(18)
                    .HasColumnName("usuario");
                entity.Property(e => e.Apellidos)
                    .HasMaxLength(45)
                    .HasColumnName("apellidos");
                entity.Property(e => e.Curso)
                    .HasMaxLength(45)
                    .HasColumnName("curso");
                entity.Property(e => e.FechaAlta)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_alta");
                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fecha_modificacion");
                entity.Property(e => e.Nivel)
                    .HasMaxLength(45)
                    .HasColumnName("nivel");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                entity.Property(e => e.Password)
                    .HasMaxLength(18)
                    .HasColumnName("password");
                entity.Property(e => e.Rol)
                    .HasMaxLength(13)
                    .HasColumnName("rol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
