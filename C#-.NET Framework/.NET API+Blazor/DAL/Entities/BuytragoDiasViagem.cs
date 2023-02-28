using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class BuytragoDiasViagem
{
    public int? IdPlatOrig { get; set; }

    public string? DescPlatOrig { get; set; }

    public int? IdPlatDest { get; set; }

    public string? DescPlatDest { get; set; }

    public int? NDias { get; set; }
}
