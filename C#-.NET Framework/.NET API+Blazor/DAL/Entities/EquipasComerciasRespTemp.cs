using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EquipasComerciasRespTemp
{
    public int Id { get; set; }

    public int? Cliente { get; set; }

    public string? Entidade { get; set; }

    public string? DinamicaC { get; set; }

    public string? Equipa { get; set; }

    public string? Resp { get; set; }

    public int? Idutil { get; set; }

    public DateTime? DtUltAct { get; set; }
}
