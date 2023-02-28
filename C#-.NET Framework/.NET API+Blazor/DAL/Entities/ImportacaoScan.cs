using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ImportacaoScan
{
    public int Id { get; set; }

    public string? ScanEntry { get; set; }

    public string? Extracted { get; set; }

    public string? ScanCode { get; set; }

    public string? ScanLocation { get; set; }

    public string? ScanCourierRoute { get; set; }

    public int? IdManifesto { get; set; }

    public string? AwbNumber { get; set; }

    /// <summary>
    /// M = MPS
    /// </summary>
    public string? AwbType { get; set; }

    public DateTime? ScanDate { get; set; }

    public string? ScanTime { get; set; }

    public string? Comment { get; set; }

    public string? Signature { get; set; }

    public DateTime? ExtractionDateTime { get; set; }

    public DateTime? PostDate { get; set; }

    public bool Concluido { get; set; }

    public int? IdUtil { get; set; }

    public bool Tratado { get; set; }

    public DateTime? DtTratado { get; set; }

    public int? IdUtilTratado { get; set; }

    public string? ObsTratado { get; set; }

    public DateTime? ImportDate { get; set; }

    public bool EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public int? IdTratamento { get; set; }

    public int? IdRota { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdGps { get; set; }

    public int? IdImpScanTratado { get; set; }

    public int? IdAssinatura { get; set; }

    public int? IdImportacaoManifesto { get; set; }
}
