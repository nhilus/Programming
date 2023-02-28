using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ImportacaoFacturasMapServico
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public string? RefOrigem { get; set; }

    public int? IdServico { get; set; }
}
