﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ZzzConvPortal
{
    public int Idunico { get; set; }

    public string? Awb { get; set; }

    public int? IdManifesto { get; set; }

    public bool? IsMaster { get; set; }

    public string? Masternum { get; set; }
}
