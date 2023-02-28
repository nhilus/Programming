﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class RotaSegmentosT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public int? MaxVols { get; set; }

    public decimal? MaxPesoVol { get; set; }

    public string? Codigo { get; set; }
}
