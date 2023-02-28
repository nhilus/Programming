using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class VReclamaco
{
    public int Id { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public int IdCliente { get; set; }

    public string? Contacto { get; set; }

    public long? Awb { get; set; }

    public bool? Concluida { get; set; }

    public DateTime? DtConclusao { get; set; }

    public bool? Encerrada { get; set; }

    public DateTime? DtEncerramento { get; set; }

    public int? IdRegime { get; set; }

    public string? Regime { get; set; }

    public int? IdCategoria { get; set; }

    public string? Categoria { get; set; }

    public int? IdTipo { get; set; }

    public string? Tipo { get; set; }

    public int? IdLocalOcorrencia { get; set; }

    public string? LocalOcorrencia { get; set; }

    public int? IdCausa { get; set; }

    public string? Causa { get; set; }

    public int? IdResolucao { get; set; }

    public string? Resolucao { get; set; }

    public DateTime DtAbertura { get; set; }

    public string? MoradaParticular { get; set; }

    public string? TelfParticular { get; set; }

    public string? FaxParticular { get; set; }

    public string? NrContaFedex { get; set; }

    public DateTime? DtMbgpedido { get; set; }

    public decimal? CreditoMbg { get; set; }

    public DateTime? DtMbg { get; set; }

    public DateTime? DtPedidoseguro { get; set; }

    public decimal? CreditoSeguro { get; set; }

    public DateTime? DtSeguro { get; set; }

    public DateTime? DtPedidoCreditoTransporte { get; set; }

    public decimal? CreditoTransporte { get; set; }

    public DateTime? DtCreditoTransporte { get; set; }

    public DateTime? DtPedidoDanos { get; set; }

    public decimal? CreditoDanos { get; set; }

    public DateTime? DtDanos { get; set; }

    public int? IdUtilConclusao { get; set; }

    public int? IdUtilEncerramento { get; set; }

    public bool? Pac { get; set; }
}
