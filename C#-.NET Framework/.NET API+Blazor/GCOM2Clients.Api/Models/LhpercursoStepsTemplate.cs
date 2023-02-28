using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LhpercursoStepsTemplate
{
    public int Id { get; set; }

    public int IdTemplate { get; set; }

    public int? Step { get; set; }

    public int? IdPlataformaPrincipal { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdPlataformaOrigem { get; set; }

    public int? IdPlataformaDestino { get; set; }

    public string? Percurso { get; set; }

    public DateTime? HoraPrevPartida { get; set; }

    public DateTime? HoraPrevChegada { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? Activo { get; set; }
}
