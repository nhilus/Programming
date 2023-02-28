using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoFactAgrupamento
{
    public int Id { get; set; }

    public DateTime? DtProduto { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdServico { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdTipoAgrupa { get; set; }

    public int? IdRegime { get; set; }

    public int? IdclasseOrigem { get; set; }

    public string? CondicoesAgrupamento { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdTarifa { get; set; }
}
