using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DepositoCobranca
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdPlataforma { get; set; }

    public decimal? ValorConferido { get; set; }

    public decimal? ValorDepositado { get; set; }

    public int? IdEstadoOps { get; set; }

    public DateTime? DtEstadoOps { get; set; }

    public int? IdEstadoFin { get; set; }

    public DateTime? DtEstadoFin { get; set; }

    public string? Obs { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? ValidadoFin { get; set; }

    public DateTime? DtvalidadoFin { get; set; }

    public DateTime? DtValidacaoMapa { get; set; }
}
