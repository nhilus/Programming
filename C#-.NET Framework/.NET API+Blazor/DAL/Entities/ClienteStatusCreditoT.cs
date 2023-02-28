using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteStatusCreditoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public short DiasCredito { get; set; }

    public int? CodigoVanguarda { get; set; }

    public bool CreditoTransporte { get; set; }

    public bool CreditoAduaneiro { get; set; }

    public int IdModoPagamento { get; set; }

    public string ImgCredito { get; set; } = null!;

    public bool PerdeTarifas { get; set; }

    public bool PerdeDescontos { get; set; }

    public bool Provisorio { get; set; }

    public bool Cortado { get; set; }

    public bool Default { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public string Cor { get; set; } = null!;

    public decimal? FactorMultCredito { get; set; }

    public decimal? PotencialMaximo { get; set; }

    public bool GeraPedidoCredito { get; set; }

    public bool AplicarPvp { get; set; }

    public string? CodigoSap { get; set; }
}
