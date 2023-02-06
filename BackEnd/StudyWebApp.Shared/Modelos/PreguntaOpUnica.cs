using System;
using System.Collections.Generic;

namespace StudyWebApp.Shared.Modelos;

public partial class PreguntaOpUnica
{
    public string Id { get; set; } = null!;

    public string IdAsignatura { get; set; } = null!;

    public string IdTema { get; set; } = null!;

    public string Pregunta { get; set; } = null!;

    public string Respuesta1 { get; set; } = null!;

    public string Respuesta2 { get; set; } = null!;

    public string Respuesta3 { get; set; } = null!;

    public string Correcta { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual Asignatura IdAsignaturaNavigation { get; set; } = null!;

    public virtual Tema IdTemaNavigation { get; set; } = null!;

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
