using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteResumoFuncaoAcessoPermisso
{
    public int Id { get; set; }

    public int IdResumoFuncAcesso { get; set; }

    public string Codigo { get; set; } = null!;

    public object? Valor { get; set; }

    public bool IsDefault { get; set; }
}
