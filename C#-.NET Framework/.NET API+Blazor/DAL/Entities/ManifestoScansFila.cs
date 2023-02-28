using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoScansFila
{
    public int Id { get; set; }

    public int? IdScan { get; set; }

    public string? ScanEntry { get; set; }

    public string? ScanCode { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdRota { get; set; }

    public int? IdManifesto { get; set; }

    public DateTime? ScanDate { get; set; }

    public string? Comment { get; set; }

    public string? Signature { get; set; }

    public int? IdUtil { get; set; }

    public string? Origem { get; set; }

    public bool? Interface { get; set; }

    public int? IdImpScanTratado { get; set; }

    public byte? IdTipoTrata { get; set; }

    public bool Processado { get; set; }

    public DateTime? DtProcessado { get; set; }
}
