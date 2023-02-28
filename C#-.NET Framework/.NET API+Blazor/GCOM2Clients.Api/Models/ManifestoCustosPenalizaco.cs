using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoCustosPenalizaco
{
    public int Id { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdScan { get; set; }

    public DateTime? ScanDate { get; set; }

    public DateTime? ScanDateDt { get; set; }

    public TimeSpan? ScanDateTm { get; set; }

    public string? ScanCode { get; set; }

    public int? IdUtil { get; set; }

    public int? IdRota { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdFornecedor { get; set; }

    public int? IdAgente { get; set; }

    public bool? ParaFacturar { get; set; }

    public int? IdMotivoNf { get; set; }

    public decimal? Valor { get; set; }

    public int? IdTarifa { get; set; }

    public int? IdTarifaPenalizacao { get; set; }

    public decimal? ValorManual { get; set; }

    public bool Recalcular { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
