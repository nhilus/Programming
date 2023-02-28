using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ProducaoCustosPenalizaco
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public int? IdUtil { get; set; }

    public int? IdRota { get; set; }

    public int? NumEntrs { get; set; }

    public int? NumEntrsInt { get; set; }

    public int? NumEntrsDom { get; set; }

    public decimal? ValorEntrs { get; set; }

    public int? NumPenalEntrs { get; set; }

    public decimal? ValorPenalEntrs { get; set; }

    public int? NumRecs { get; set; }

    public int? NumRecsInt { get; set; }

    public int? NumRecsDom { get; set; }

    public decimal? ValorRecs { get; set; }

    public int? NumPenalRecs { get; set; }

    public decimal? ValorPenalRecs { get; set; }

    public decimal? TotalCusto { get; set; }

    public decimal? TotalPenal { get; set; }

    public decimal? ValAdicional { get; set; }

    public int? IdTipoValAdicional { get; set; }

    public decimal? ValPenalAdicional { get; set; }

    public int? IdTipoPenalAdicional { get; set; }

    public decimal? TotalCustoManual { get; set; }

    public decimal? TotalPenalManual { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUtlAct { get; set; }

    public bool Validado { get; set; }

    public DateTime? DtValidado { get; set; }

    public int? IdUtilValidado { get; set; }

    public bool? Confirmado { get; set; }

    public DateTime? DtConfirmado { get; set; }

    public int? IdUtilConfirmado { get; set; }
}
