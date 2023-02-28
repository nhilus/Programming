using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AwbcounterAo
{
    public string AwbPrefix { get; set; } = null!;

    public int Counter { get; set; }

    public int? IdEntidade { get; set; }

    public bool? Activo { get; set; }
}
