using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEntidadesTlog
{
    public int IdTrigger { get; set; }

    public DateTime DtTrigger { get; set; }

    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int IdCliente { get; set; }

    public decimal? LimiteCredito { get; set; }

    public decimal? LimiteCreditoAdua { get; set; }

    public string? Observacoes { get; set; }

    public decimal? VolumeVendas { get; set; }

    public string? CodContab { get; set; }

    public string? NrExpAvencado { get; set; }

    public bool? ResponsabilidadeTotal { get; set; }

    public int? IdTipoAbc { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }
}
