using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorAusencia
{
    public int Id { get; set; }

    public int IdUtil { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdMotivo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool? Aprovacao { get; set; }

    public int? IdUtilAprovacao { get; set; }

    public DateTime? DtAprovacao { get; set; }

    public string? Observacoes { get; set; }

    public int IdEntidade { get; set; }
}
