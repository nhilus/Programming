using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoScansInterfaceRejection
{
    public int Id { get; set; }

    public int IdFicheiro { get; set; }

    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public DateTime? ScanDate { get; set; }

    public TimeSpan? ScanTime { get; set; }

    public string? ScanLocation { get; set; }

    public string? ScanRoute { get; set; }

    public string ScanCode { get; set; } = null!;

    public string? ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? DtIntrod { get; set; }

    public TimeSpan? TmIntrod { get; set; }

    public DateTime? DtResolved { get; set; }

    public TimeSpan? TmResolved { get; set; }

    public short? IdUtilResolved { get; set; }

    public int? IdScan { get; set; }

    public int? IdEntidade { get; set; }
}
