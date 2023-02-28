using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Tipsa4
{
    public string Awb { get; set; } = null!;

    public string? Referencia { get; set; }

    public int? Idmanifesto { get; set; }

    public string Master { get; set; } = null!;
}
