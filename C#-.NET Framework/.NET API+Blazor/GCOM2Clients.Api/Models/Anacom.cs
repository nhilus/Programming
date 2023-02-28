using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Anacom
{
    public string? EmpresaFaturação { get; set; }

    public string Awb { get; set; } = null!;

    public decimal? ValorFaturadoPorAwb { get; set; }

    public decimal? PesoPorAwb { get; set; }

    public string? CodContabilidadeCliente { get; set; }

    public string? CodContabClienteFact { get; set; }

    public string Serviço { get; set; } = null!;

    public int? Ano { get; set; }

    public int? Mês { get; set; }

    public string Regime { get; set; } = null!;

    public string? PaisDestinatarioSigla { get; set; }

    public string? PaisDestinatarioDescricao { get; set; }

    public string? PaisExpedidorSigla { get; set; }

    public string? PaisExpedidorDescricao { get; set; }
}
