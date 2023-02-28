using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteEntidade
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public decimal LimiteCredito { get; set; }

    public decimal? LimiteCreditoAdua { get; set; }

    public string? Observacoes { get; set; }

    public decimal VolumeVendas { get; set; }

    public string? CodContab { get; set; }

    public string? NrExpAvencado { get; set; }

    public bool ResponsabilidadeTotal { get; set; }

    public int? IdTipoAbc { get; set; }

    public DateTime DtUltAct { get; set; }

    public int IdUtilUltAct { get; set; }

    public int? IdEnvolvencia { get; set; }

    public bool TemSecurityControl { get; set; }
}
