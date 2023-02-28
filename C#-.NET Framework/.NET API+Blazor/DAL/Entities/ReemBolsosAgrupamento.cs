using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReemBolsosAgrupamento
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? TipoAgrupamento { get; set; }

    public string? Texto { get; set; }

    public int? IdCliMoradaDestino { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? Activo { get; set; }
}
