using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MbTeste
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Morada { get; set; }

    public string? Cpostal { get; set; }

    public string? Localidade { get; set; }

    public string? NomeContacto { get; set; }

    public long? Telefone { get; set; }

    public long? Fax { get; set; }

    public bool? Default { get; set; }

    public string? NumeroContribuinte { get; set; }

    public string? NumeroContaFedEx { get; set; }

    public decimal? PotencialExpIe { get; set; }

    public decimal? PotencialExpIc { get; set; }

    public decimal? NegociadoExpIe { get; set; }

    public decimal? NegociadoExpIc { get; set; }

    public decimal? PotencialImpIe { get; set; }

    public decimal? PotencialImpIc { get; set; }

    public decimal? NegociadoImpIe { get; set; }

    public decimal? NegociadoImpIc { get; set; }

    public decimal VolumeVendas { get; set; }

    public bool TemFsm { get; set; }

    public DateTime? DtFsm { get; set; }

    public int? IdTipoCliente { get; set; }

    public string? DescricaoTipo { get; set; }

    public int IdStatusComercial { get; set; }

    public string? StatusComercial { get; set; }

    public bool Captado { get; set; }

    public bool Negociacao { get; set; }

    public int IdStatusCredito { get; set; }

    public string? StatusCredito { get; set; }

    public decimal LimiteCredito { get; set; }

    public int? IdStatusCreditoAdua { get; set; }

    public string? StatusCreditoAdua { get; set; }

    public short? DiasCreditoAdua { get; set; }

    public decimal? LimiteCreditoAdua { get; set; }

    public string NomeUtilizador { get; set; } = null!;

    public DateTime? UltEntrev { get; set; }

    public DateTime? UltEncom { get; set; }

    public string? Email { get; set; }

    public bool Fsm { get; set; }

    public string? TarImp { get; set; }

    public string? TarExp { get; set; }

    public string Equipa { get; set; } = null!;
}
