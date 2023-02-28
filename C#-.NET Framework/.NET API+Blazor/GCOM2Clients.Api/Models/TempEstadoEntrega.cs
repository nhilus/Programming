using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempEstadoEntrega
{
    public string Entidade { get; set; } = null!;

    public DateTime? HoraActual { get; set; }

    public string AwbMaster { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string GV { get; set; } = null!;

    public short? Vols { get; set; }

    public decimal? Peso { get; set; }

    public string? Cliente { get; set; }

    public string? SubCliente { get; set; }

    public string? Expedidor { get; set; }

    public string? CppostalExp { get; set; }

    public short? IdPaisExpedidor { get; set; }

    public string? PaisExpedidor { get; set; }

    public string? Destinatário { get; set; }

    public string? MoradaDestinatario { get; set; }

    public string? CpDest { get; set; }

    public string? LocDest { get; set; }

    public string? Ref { get; set; }

    public string? NumExpBuyTrago { get; set; }

    public string? Observacoes { get; set; }

    public DateTime? DataEnvio { get; set; }

    public DateTime? Ded { get; set; }

    public DateTime? FirstDed { get; set; }

    public string PrimScan { get; set; } = null!;

    public DateTime DataPrimeiroScan { get; set; }

    public string? PlatPrimScan { get; set; }

    public string? ScanCodePodDex { get; set; }

    public DateTime? ScanDatePodDex { get; set; }

    public string? Scan { get; set; }

    public DateTime? Datascan { get; set; }

    public string? Rota { get; set; }

    public string? Sel { get; set; }

    public string UltScan { get; set; } = null!;

    public string? CoordGps { get; set; }

    public string? DescScan { get; set; }

    public DateTime DataUltimoScan { get; set; }

    public string PlatUltScan { get; set; } = null!;

    public string RotaUltScan { get; set; } = null!;

    public string? NomeFornecedor { get; set; }

    public string? UltScanNot44Code { get; set; }

    public string? UltScanNot44Rota { get; set; }

    public string Incidência { get; set; } = null!;

    public string NívelServiço { get; set; } = null!;

    public string? Categoria { get; set; }

    public int Digit { get; set; }

    public int Iis { get; set; }

    public int Ncs { get; set; }

    public int Recls { get; set; }

    public int ImpGuia { get; set; }

    public int ImpEtiq { get; set; }

    public string? Servico { get; set; }
}
