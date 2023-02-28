using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifasPenalizaco
{
    public int Id { get; set; }

    public int? IdTarifa { get; set; }

    public int? IdPenalizacaoTipo { get; set; }

    public int? IdTipoValor { get; set; }

    public decimal? Valor { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
