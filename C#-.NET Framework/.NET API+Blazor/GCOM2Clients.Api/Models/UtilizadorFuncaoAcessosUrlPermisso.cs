using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncaoAcessosUrlPermisso
{
    public int Id { get; set; }

    public int IdUtilFuncAcesso { get; set; }

    public string Codigo { get; set; } = null!;

    public object? Valor { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsVisible { get; set; }

    public bool? IsEditable { get; set; }
}
