using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VManifestoPendentesEntrega
{
    public int IdManifesto { get; set; }

    public byte IdEntidade { get; set; }

    public byte IdDistribuidor { get; set; }

    public int? NumDias { get; set; }

    public string Awb { get; set; } = null!;

    public string Master { get; set; } = null!;

    public bool IsMaster { get; set; }

    public int IdMaster { get; set; }

    public DateTime DtEnvio { get; set; }

    public DateTime? DtEntregaDesejada { get; set; }

    public short IdUtil { get; set; }

    public string CodPlataforma { get; set; } = null!;

    public string CodRota { get; set; } = null!;

    public string ScanCode { get; set; } = null!;

    public DateTime ScanDate { get; set; }

    public string? Comment { get; set; }

    public short? IdPlataforma { get; set; }

    public int? IdCliente { get; set; }

    public byte? IdServico { get; set; }

    public short? IdPltOrigem { get; set; }

    public short? IdPltDestino { get; set; }

    public long? RowNum { get; set; }
}
