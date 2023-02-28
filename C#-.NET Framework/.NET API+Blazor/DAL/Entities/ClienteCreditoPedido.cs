using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteCreditoPedido
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdStCreditoPedido { get; set; }

    public decimal? LimiteCreditoPedido { get; set; }

    public string? ObsPedido { get; set; }

    public int IdUtilPedido { get; set; }

    public DateTime DtPedido { get; set; }

    public int? IdTipoCredito { get; set; }

    public int IdStatus { get; set; }

    public DateTime? DtResposta { get; set; }

    public int? IdUtilResposta { get; set; }

    public int? IdStCreditoResposta { get; set; }

    public decimal? LimiteCreditoResposta { get; set; }

    public string? ObsResposta { get; set; }

    public int? IdAlertaPedido { get; set; }

    public int? IdAlertaResposta { get; set; }

    public bool Anulado { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }
}
