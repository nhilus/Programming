using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Reclamacao
{
    public int Id { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtAbertura { get; set; }

    public string? Codigo { get; set; }

    public int IdCliente { get; set; }

    public string? Contacto { get; set; }

    public string? MoradaParticular { get; set; }

    public string? TelfParticular { get; set; }

    public string? FaxParticular { get; set; }

    public long? Awb { get; set; }

    public string? Factura { get; set; }

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

    public bool Concluida { get; set; }

    public DateTime? DtConclusao { get; set; }

    public int? IdUtilConclusao { get; set; }

    public bool Encerrada { get; set; }

    public DateTime? DtEncerramento { get; set; }

    public int? IdUtilEncerramento { get; set; }

    public int? IdRegime { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdTipo { get; set; }

    public int? IdLocalOcorrencia { get; set; }

    public int? IdCausa { get; set; }

    public int? IdResolucao { get; set; }

    public bool Pac { get; set; }

    public bool Anulada { get; set; }

    public DateTime? DtAnulada { get; set; }

    public int? IdUtilAnulada { get; set; }

    public int? IdReclamacaoPai { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCausaDetalhe { get; set; }

    public bool? Pertinente { get; set; }

    public int? IdMeioEntrada { get; set; }

    public string? LocalDeteccao { get; set; }

    public decimal? Peso { get; set; }

    public int? IdCliMorada { get; set; }
}
