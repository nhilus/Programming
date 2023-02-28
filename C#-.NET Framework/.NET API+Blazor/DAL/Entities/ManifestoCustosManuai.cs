using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoCustosManuai
{
    public int Id { get; set; }

    public int? IdManifestoCustoReal { get; set; }

    public int? IdServicoDet { get; set; }

    public string? Obs { get; set; }

    public decimal? Valor { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
