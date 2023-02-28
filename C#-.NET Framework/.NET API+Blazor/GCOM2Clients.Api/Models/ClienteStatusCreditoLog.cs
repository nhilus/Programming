using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteStatusCreditoLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int? IdTipoCredito { get; set; }

    public int IdStatus { get; set; }

    public decimal? LimiteCredito { get; set; }

    public int IdUtilizador { get; set; }

    public DateTime Data { get; set; }

    public string? Observacoes { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdRegistoAnterior { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }
}
