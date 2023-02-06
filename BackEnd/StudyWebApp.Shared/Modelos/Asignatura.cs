using System;
using System.Collections.Generic;

namespace StudyWebApp.Shared.Modelos;

public partial class Asignatura
{
    public string Id { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FechaModificacion { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual ICollection<PreguntaEspacio> PreguntaEspacios { get; } = new List<PreguntaEspacio>();

    public virtual ICollection<PreguntaOpMultiple> PreguntaOpMultiples { get; } = new List<PreguntaOpMultiple>();

    public virtual ICollection<PreguntaOpUnica> PreguntaOpUnicas { get; } = new List<PreguntaOpUnica>();

    public virtual ICollection<PreguntaVF> PreguntaVFs { get; } = new List<PreguntaVF>();

    public virtual ICollection<RankingAlum> RankingAlums { get; } = new List<RankingAlum>();

    public virtual ICollection<RankingProf> RankingProfs { get; } = new List<RankingProf>();

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
