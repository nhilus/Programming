using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorAcessosUrlPermisso
{
    public int Id { get; set; }

    public int IdUtilAcesso { get; set; }

    public string Codigo { get; set; } = null!;

    public object? Valor { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsVisible { get; set; }

    public bool? IsEditable { get; set; }

    public bool IsAllowed { get; set; }
}
