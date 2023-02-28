using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoItem
{
    public int Id { get; set; }

    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public int IdServicoDet { get; set; }

    public string? Observacoes { get; set; }

    public decimal? ValorRef { get; set; }

    public int? IdScan { get; set; }

    public bool Activo { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }
}
