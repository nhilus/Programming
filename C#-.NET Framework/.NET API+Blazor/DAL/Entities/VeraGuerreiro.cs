using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VeraGuerreiro
{
    public int IdScan { get; set; }

    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public string ScanCode { get; set; } = null!;

    public string? EventCode { get; set; }

    public string? ReasonCode { get; set; }

    public string? ScanDateDt { get; set; }

    public string? ScanTime { get; set; }

    public string Signature { get; set; } = null!;

    public DateTime PostDate { get; set; }

    public string Ms { get; set; } = null!;

    public string? CodClienteParceiro { get; set; }

    public string? IdManifParceiro { get; set; }

    public string? Refparcliente { get; set; }

    public string? Comment { get; set; }

    public string? Descricao { get; set; }

    public string? Plataforma { get; set; }

    public string CodigoProvedor { get; set; } = null!;

    public string CodigoDelagacionCex { get; set; } = null!;

    public string DelegacaoProvedor { get; set; } = null!;

    public string CodigoDevolucao { get; set; } = null!;

    public string NumeroGiro { get; set; } = null!;

    public string Numerotransferencia { get; set; } = null!;

    public string Expedicao { get; set; } = null!;
}
