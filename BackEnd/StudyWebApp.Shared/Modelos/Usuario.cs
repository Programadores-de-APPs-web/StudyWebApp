using System;
using System.Collections.Generic;

namespace StudyWebApp.Shared.Modelos;

public partial class Usuario
{
    public string Usuario1 { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Curso { get; set; } = null!;

    public string Nivel { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime FechaModificacion { get; set; }

    public virtual ICollection<Asignatura> Asignaturas { get; } = new List<Asignatura>();

    public virtual ICollection<PreguntaEspacio> PreguntaEspacios { get; } = new List<PreguntaEspacio>();

    public virtual ICollection<PreguntaOpMultiple> PreguntaOpMultiples { get; } = new List<PreguntaOpMultiple>();

    public virtual ICollection<PreguntaOpUnica> PreguntaOpUnicas { get; } = new List<PreguntaOpUnica>();

    public virtual ICollection<PreguntaVF> PreguntaVFs { get; } = new List<PreguntaVF>();

    public virtual ICollection<RankingAlum> RankingAlums { get; } = new List<RankingAlum>();

    public virtual ICollection<RankingProf> RankingProfUsuarioAlumnoNavigations { get; } = new List<RankingProf>();

    public virtual ICollection<RankingProf> RankingProfUsuarioProfesorNavigations { get; } = new List<RankingProf>();

    public virtual ICollection<Tema> Temas { get; } = new List<Tema>();
}
