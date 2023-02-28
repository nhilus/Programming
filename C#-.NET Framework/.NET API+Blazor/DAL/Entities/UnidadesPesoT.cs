using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UnidadesPesoT
{
    public int Id { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? CodigoGrasp { get; set; }

    public string? CodigoCosmos { get; set; }

    public decimal? TaxaConversao { get; set; }

    public decimal? MultConversaoDef { get; set; }

    public bool? Default { get; set; }

    public bool? Activo { get; set; }
}
