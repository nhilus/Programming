using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ViaturaCombustiveisT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal? CustoLitro { get; set; }
}
