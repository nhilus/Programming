using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PjManifestosNomes3
{
    public int IdMaster { get; set; }

    public string? Nome { get; set; }

    public string? MoradaExp { get; set; }

    public string? MoradaDest { get; set; }
}
