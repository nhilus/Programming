using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Tipsa4
{
    public string Awb { get; set; } = null!;

    public string? Referencia { get; set; }

    public int? Idmanifesto { get; set; }

    public string Master { get; set; } = null!;
}
