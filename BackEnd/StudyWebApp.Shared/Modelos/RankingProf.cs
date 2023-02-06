using System;
using System.Collections.Generic;

namespace StudyWebApp.Shared.Modelos;

public partial class RankingProf
{
    public string Id { get; set; } = null!;

    public string UsuarioProfesor { get; set; } = null!;

    public string UsuarioAlumno { get; set; } = null!;

    public string IdAsignatura { get; set; } = null!;

    public string IdTema { get; set; } = null!;

    public long NumPreguntas { get; set; }

    public long NumAciertos { get; set; }

    public long NumErrores { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual Asignatura IdAsignaturaNavigation { get; set; } = null!;

    public virtual Tema IdTemaNavigation { get; set; } = null!;

    public virtual Usuario UsuarioAlumnoNavigation { get; set; } = null!;

    public virtual Usuario UsuarioProfesorNavigation { get; set; } = null!;
}
