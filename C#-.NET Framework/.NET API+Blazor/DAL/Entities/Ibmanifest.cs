using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Ibmanifest
{
    public int DucPnum { get; set; }

    public DateTime? DucDtvo { get; set; }

    public string? DuoCpa2 { get; set; }

    public string SinCodi { get; set; } = null!;

    public int Id { get; set; }
}
