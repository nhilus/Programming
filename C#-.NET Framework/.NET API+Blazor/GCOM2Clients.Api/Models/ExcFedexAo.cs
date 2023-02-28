using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ExcFedexAo
{
    public double? IdCliente { get; set; }

    public string? Cliente { get; set; }

    public string? ZonaInt { get; set; }

    public string GcomCp { get; set; } = null!;
}
