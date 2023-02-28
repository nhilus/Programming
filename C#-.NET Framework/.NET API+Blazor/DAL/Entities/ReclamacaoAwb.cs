using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReclamacaoAwb
{
    public int Id { get; set; }

    public int IdReclamacao { get; set; }

    public int? IdManifesto { get; set; }

    public string Awbnumber { get; set; } = null!;

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

    public string? AwbRpi { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? Anulada { get; set; }
}
