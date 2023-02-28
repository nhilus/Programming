using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DangerousGood
{
    public int Id { get; set; }

    public int? IdProduto { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public decimal? FactClienteKg { get; set; }

    public decimal? FactFedex { get; set; }

    public string? SiglaCosmos { get; set; }

    public bool? Activo { get; set; }
}
