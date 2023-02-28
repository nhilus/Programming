using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorFuncaoEntidadeAcessosUrlReportsParam
{
    public int Id { get; set; }

    public int IdUfeacessoUrlReport { get; set; }

    public string Codigo { get; set; } = null!;

    public object? Valor { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsVisible { get; set; }

    public bool? IsEditable { get; set; }
}
