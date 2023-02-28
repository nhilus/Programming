using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoScansTempBuytragoDuplicado
{
    public int Id { get; set; }

    public string ScanEntry { get; set; } = null!;

    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public byte IdDistribuidor { get; set; }

    public int? IdRota { get; set; }

    public string CodRota { get; set; } = null!;

    public short? IdPlataforma { get; set; }

    public string CodPlataforma { get; set; } = null!;

    public string ScanCode { get; set; } = null!;

    public DateTime ScanDate { get; set; }

    public string Comment { get; set; } = null!;

    public string Signature { get; set; } = null!;

    public DateTime PostDate { get; set; }

    public short IdUtil { get; set; }

    public int? IdGps { get; set; }

    public int? IdAssinatura { get; set; }

    public DateTime? ScanDateDt { get; set; }

    public TimeSpan? ScanDateTm { get; set; }
}
