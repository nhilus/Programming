using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VEtlmanifesto
{
    public int Id { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public string Master { get; set; } = null!;

    public int IdMaster { get; set; }

    public string? RecordType { get; set; }

    public string? FormId { get; set; }

    public bool IsMaster { get; set; }

    public DateTime? DtExpedicao { get; set; }

    public DateTime DtEnvio { get; set; }

    public DateTime? DtEntregaDesejada { get; set; }

    public string? RefExpedidor { get; set; }

    public byte? IdRegime { get; set; }

    public byte? IdSegmento { get; set; }

    public bool TratarVolume { get; set; }

    public byte IdDistribuidor { get; set; }

    public int? IdPickup { get; set; }

    public short? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public short IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool? Anulado { get; set; }

    public string? RefOrig { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public byte? IdTipoManifesto { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public DateTime? Scandate { get; set; }

    public string? ScanCode { get; set; }

    public short? IdPlataforma { get; set; }

    public int? IdRota { get; set; }

    public int? Ordem { get; set; }

    public string? PupScanCode { get; set; }

    public DateTime? PupScanDate { get; set; }

    public int? IdManifestoDev { get; set; }

    public int? IdManifestoOrig { get; set; }

    public DateTime? SwapScanDate { get; set; }
}
