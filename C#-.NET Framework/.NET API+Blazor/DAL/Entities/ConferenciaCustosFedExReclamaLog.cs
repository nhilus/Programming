using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConferenciaCustosFedExReclamaLog
{
    public int Id { get; set; }

    public int IdConf { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public string Observacoes { get; set; } = null!;

    public decimal? Credito { get; set; }
}
