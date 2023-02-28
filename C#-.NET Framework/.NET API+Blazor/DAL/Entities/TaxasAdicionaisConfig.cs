using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TaxasAdicionaisConfig
{
    public int Id { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdServicoDet { get; set; }

    public int? IdServico { get; set; }

    public string? CodBaseIncidencia { get; set; }

    public DateTime? DtIni { get; set; }

    public DateTime? DtFim { get; set; }
}
