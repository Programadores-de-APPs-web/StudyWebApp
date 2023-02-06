﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudyWebApp.Estudio.DataAccess.Configuracion.Context;

#nullable disable

namespace StudyWebApp.Estudio.Migrations
{
    [DbContext(typeof(EstudioContext))]
    [Migration("20230206000439_AddLoggingTable")]
    partial class AddLoggingTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StudyWebApp.Shared.Logging.Loggings", b =>
                {
                    b.Property<int>("IdLog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdLog"));

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LogLevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdLog");

                    b.ToTable("Loggings");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Asignatura", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)")
                        .HasColumnName("nombre");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("asignatura_pkey");

                    b.HasIndex("Usuario");

                    b.ToTable("asignatura", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaEspacio", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("Frase")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("frase");

                    b.Property<string>("IdAsignatura")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_asignatura");

                    b.Property<string>("IdTema")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_tema");

                    b.Property<string>("PalabrasCorrectas")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("palabras_correctas");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("pregunta_espacios_pkey");

                    b.HasIndex("IdAsignatura");

                    b.HasIndex("IdTema");

                    b.HasIndex("Usuario");

                    b.ToTable("pregunta_espacios", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaOpMultiple", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<string>("Correcta1")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("correcta_1");

                    b.Property<string>("Correcta2")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("correcta_2");

                    b.Property<string>("Correcta3")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("correcta_3");

                    b.Property<string>("Correcta4")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("correcta_4");

                    b.Property<string>("Correcta5")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("correcta_5");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("IdAsignatura")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_asignatura");

                    b.Property<string>("IdTema")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_tema");

                    b.Property<string>("Pregunta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("pregunta");

                    b.Property<string>("Respuesta1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_1");

                    b.Property<string>("Respuesta2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_2");

                    b.Property<string>("Respuesta3")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_3");

                    b.Property<string>("Respuesta4")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_4");

                    b.Property<string>("Respuesta5")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_5");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("pregunta_op_multiple_pkey");

                    b.HasIndex("IdAsignatura");

                    b.HasIndex("IdTema");

                    b.HasIndex("Usuario");

                    b.ToTable("pregunta_op_multiple", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaOpUnica", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<string>("Correcta")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("correcta");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("IdAsignatura")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_asignatura");

                    b.Property<string>("IdTema")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_tema");

                    b.Property<string>("Pregunta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("pregunta");

                    b.Property<string>("Respuesta1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_1");

                    b.Property<string>("Respuesta2")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_2");

                    b.Property<string>("Respuesta3")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("respuesta_3");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("pregunta_op_unica_pkey");

                    b.HasIndex("IdAsignatura");

                    b.HasIndex("IdTema");

                    b.HasIndex("Usuario");

                    b.ToTable("pregunta_op_unica", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaVF", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("IdAsignatura")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_asignatura");

                    b.Property<string>("IdTema")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_tema");

                    b.Property<string>("Pregunta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("pregunta");

                    b.Property<string>("Respuesta")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)")
                        .HasColumnName("respuesta");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("pregunta_v_f_pkey");

                    b.HasIndex("IdAsignatura");

                    b.HasIndex("IdTema");

                    b.HasIndex("Usuario");

                    b.ToTable("pregunta_v_f", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.RankingAlum", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("IdAsignatura")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_asignatura");

                    b.Property<string>("IdTema")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_tema");

                    b.Property<long>("NumAciertos")
                        .HasColumnType("bigint")
                        .HasColumnName("num_aciertos");

                    b.Property<long>("NumErrores")
                        .HasColumnType("bigint")
                        .HasColumnName("num_errores");

                    b.Property<long>("NumPreguntas")
                        .HasColumnType("bigint")
                        .HasColumnName("num_preguntas");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("ranking_alum_pkey");

                    b.HasIndex("IdAsignatura");

                    b.HasIndex("IdTema");

                    b.HasIndex("Usuario");

                    b.ToTable("ranking_alum", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.RankingProf", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("IdAsignatura")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_asignatura");

                    b.Property<string>("IdTema")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_tema");

                    b.Property<long>("NumAciertos")
                        .HasColumnType("bigint")
                        .HasColumnName("num_aciertos");

                    b.Property<long>("NumErrores")
                        .HasColumnType("bigint")
                        .HasColumnName("num_errores");

                    b.Property<long>("NumPreguntas")
                        .HasColumnType("bigint")
                        .HasColumnName("num_preguntas");

                    b.Property<string>("UsuarioAlumno")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario_alumno");

                    b.Property<string>("UsuarioProfesor")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario_profesor");

                    b.HasKey("Id")
                        .HasName("ranking_prof_pkey");

                    b.HasIndex("IdAsignatura");

                    b.HasIndex("IdTema");

                    b.HasIndex("UsuarioAlumno");

                    b.HasIndex("UsuarioProfesor");

                    b.ToTable("ranking_prof", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Tema", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("IdAsignatura")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("id_asignatura");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)")
                        .HasColumnName("nombre");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("tema_pkey");

                    b.HasIndex("Usuario");

                    b.ToTable("tema", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Usuario", b =>
                {
                    b.Property<string>("Usuario1")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("usuario");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)")
                        .HasColumnName("apellidos");

                    b.Property<string>("Curso")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)")
                        .HasColumnName("curso");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_alta");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha_modificacion");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)")
                        .HasColumnName("nivel");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)")
                        .HasColumnName("nombre");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)")
                        .HasColumnName("password");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)")
                        .HasColumnName("rol");

                    b.HasKey("Usuario1")
                        .HasName("usuario_pkey");

                    b.ToTable("usuario", "estudio");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Asignatura", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioNavigation")
                        .WithMany("Asignaturas")
                        .HasForeignKey("Usuario")
                        .IsRequired()
                        .HasConstraintName("usuario_fk");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaEspacio", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Asignatura", "IdAsignaturaNavigation")
                        .WithMany("PreguntaEspacios")
                        .HasForeignKey("IdAsignatura")
                        .IsRequired()
                        .HasConstraintName("id_asignatura_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Tema", "IdTemaNavigation")
                        .WithMany("PreguntaEspacios")
                        .HasForeignKey("IdTema")
                        .IsRequired()
                        .HasConstraintName("id_tema_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioNavigation")
                        .WithMany("PreguntaEspacios")
                        .HasForeignKey("Usuario")
                        .IsRequired()
                        .HasConstraintName("usuario_fk");

                    b.Navigation("IdAsignaturaNavigation");

                    b.Navigation("IdTemaNavigation");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaOpMultiple", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Asignatura", "IdAsignaturaNavigation")
                        .WithMany("PreguntaOpMultiples")
                        .HasForeignKey("IdAsignatura")
                        .IsRequired()
                        .HasConstraintName("id_asignatura_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Tema", "IdTemaNavigation")
                        .WithMany("PreguntaOpMultiples")
                        .HasForeignKey("IdTema")
                        .IsRequired()
                        .HasConstraintName("id_tema_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioNavigation")
                        .WithMany("PreguntaOpMultiples")
                        .HasForeignKey("Usuario")
                        .IsRequired()
                        .HasConstraintName("usuario_fk");

                    b.Navigation("IdAsignaturaNavigation");

                    b.Navigation("IdTemaNavigation");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaOpUnica", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Asignatura", "IdAsignaturaNavigation")
                        .WithMany("PreguntaOpUnicas")
                        .HasForeignKey("IdAsignatura")
                        .IsRequired()
                        .HasConstraintName("id_asignatura_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Tema", "IdTemaNavigation")
                        .WithMany("PreguntaOpUnicas")
                        .HasForeignKey("IdTema")
                        .IsRequired()
                        .HasConstraintName("id_tema_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioNavigation")
                        .WithMany("PreguntaOpUnicas")
                        .HasForeignKey("Usuario")
                        .IsRequired()
                        .HasConstraintName("usuario_fk");

                    b.Navigation("IdAsignaturaNavigation");

                    b.Navigation("IdTemaNavigation");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.PreguntaVF", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Asignatura", "IdAsignaturaNavigation")
                        .WithMany("PreguntaVFs")
                        .HasForeignKey("IdAsignatura")
                        .IsRequired()
                        .HasConstraintName("id_asignatura_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Tema", "IdTemaNavigation")
                        .WithMany("PreguntaVFs")
                        .HasForeignKey("IdTema")
                        .IsRequired()
                        .HasConstraintName("id_tema_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioNavigation")
                        .WithMany("PreguntaVFs")
                        .HasForeignKey("Usuario")
                        .IsRequired()
                        .HasConstraintName("usuario_fk");

                    b.Navigation("IdAsignaturaNavigation");

                    b.Navigation("IdTemaNavigation");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.RankingAlum", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Asignatura", "IdAsignaturaNavigation")
                        .WithMany("RankingAlums")
                        .HasForeignKey("IdAsignatura")
                        .IsRequired()
                        .HasConstraintName("id_asignatura_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Tema", "IdTemaNavigation")
                        .WithMany("RankingAlums")
                        .HasForeignKey("IdTema")
                        .IsRequired()
                        .HasConstraintName("id_tema_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioNavigation")
                        .WithMany("RankingAlums")
                        .HasForeignKey("Usuario")
                        .IsRequired()
                        .HasConstraintName("usuario_fk");

                    b.Navigation("IdAsignaturaNavigation");

                    b.Navigation("IdTemaNavigation");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.RankingProf", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Asignatura", "IdAsignaturaNavigation")
                        .WithMany("RankingProfs")
                        .HasForeignKey("IdAsignatura")
                        .IsRequired()
                        .HasConstraintName("id_asignatura_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Tema", "IdTemaNavigation")
                        .WithMany("RankingProfs")
                        .HasForeignKey("IdTema")
                        .IsRequired()
                        .HasConstraintName("id_tema_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioAlumnoNavigation")
                        .WithMany("RankingProfUsuarioAlumnoNavigations")
                        .HasForeignKey("UsuarioAlumno")
                        .IsRequired()
                        .HasConstraintName("usuario_alumno_fk");

                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioProfesorNavigation")
                        .WithMany("RankingProfUsuarioProfesorNavigations")
                        .HasForeignKey("UsuarioProfesor")
                        .IsRequired()
                        .HasConstraintName("usuario_profesor_fk");

                    b.Navigation("IdAsignaturaNavigation");

                    b.Navigation("IdTemaNavigation");

                    b.Navigation("UsuarioAlumnoNavigation");

                    b.Navigation("UsuarioProfesorNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Tema", b =>
                {
                    b.HasOne("StudyWebApp.Shared.Modelos.Usuario", "UsuarioNavigation")
                        .WithMany("Temas")
                        .HasForeignKey("Usuario")
                        .IsRequired()
                        .HasConstraintName("usuario_fk");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Asignatura", b =>
                {
                    b.Navigation("PreguntaEspacios");

                    b.Navigation("PreguntaOpMultiples");

                    b.Navigation("PreguntaOpUnicas");

                    b.Navigation("PreguntaVFs");

                    b.Navigation("RankingAlums");

                    b.Navigation("RankingProfs");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Tema", b =>
                {
                    b.Navigation("PreguntaEspacios");

                    b.Navigation("PreguntaOpMultiples");

                    b.Navigation("PreguntaOpUnicas");

                    b.Navigation("PreguntaVFs");

                    b.Navigation("RankingAlums");

                    b.Navigation("RankingProfs");
                });

            modelBuilder.Entity("StudyWebApp.Shared.Modelos.Usuario", b =>
                {
                    b.Navigation("Asignaturas");

                    b.Navigation("PreguntaEspacios");

                    b.Navigation("PreguntaOpMultiples");

                    b.Navigation("PreguntaOpUnicas");

                    b.Navigation("PreguntaVFs");

                    b.Navigation("RankingAlums");

                    b.Navigation("RankingProfUsuarioAlumnoNavigations");

                    b.Navigation("RankingProfUsuarioProfesorNavigations");

                    b.Navigation("Temas");
                });
#pragma warning restore 612, 618
        }
    }
}