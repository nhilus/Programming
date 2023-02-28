using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ViaturaCustosExtra
{
    public int Id { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? Data { get; set; }

    public int? IdRota { get; set; }

    public int? IdCondutor { get; set; }

    public int? IdTipoCusto { get; set; }

    public string? Observacoes { get; set; }

    public decimal? Custo { get; set; }
}
