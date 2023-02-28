using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ViaturaCombustiveisT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal? CustoLitro { get; set; }
}
