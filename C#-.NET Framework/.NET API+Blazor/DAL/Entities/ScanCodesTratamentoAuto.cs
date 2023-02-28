using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ScanCodesTratamentoAuto
{
    public int Id { get; set; }

    public string? ScanDex { get; set; }

    public string? ScanTratamento { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public string? Observacoes { get; set; }
}
