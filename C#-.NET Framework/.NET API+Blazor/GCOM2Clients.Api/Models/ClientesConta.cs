using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClientesConta
{
    public int Id { get; set; }

    public string ContaPai { get; set; } = null!;

    public string ContaFilho { get; set; } = null!;

    public bool? Activo { get; set; }
}
