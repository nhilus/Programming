using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Tipsa
{
    public int Id { get; set; }

    public string? Ref { get; set; }

    public string? Master { get; set; }

    public int? VBul { get; set; }

    public decimal? FPeso { get; set; }

    public decimal? FAlto { get; set; }

    public decimal? FAncho { get; set; }

    public decimal? FLargo { get; set; }
}
