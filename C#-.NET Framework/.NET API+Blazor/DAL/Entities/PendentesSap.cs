using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PendentesSap
{
    public int IdEntidade { get; set; }

    public string? NumDoc { get; set; }

    public string? TipoDoc2 { get; set; }

    public DateTime? DataDoc { get; set; }

    public DateTime? DataVence { get; set; }

    public string? DebCred { get; set; }

    public decimal? PendEsc { get; set; }

    public int? CliCounter { get; set; }
}
