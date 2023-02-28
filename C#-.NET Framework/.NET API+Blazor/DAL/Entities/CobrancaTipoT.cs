using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CobrancaTipoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool Manual { get; set; }

    public bool? Activo { get; set; }

    public string? DescWeb { get; set; }

    public bool? E { get; set; }

    public bool? R { get; set; }
}
