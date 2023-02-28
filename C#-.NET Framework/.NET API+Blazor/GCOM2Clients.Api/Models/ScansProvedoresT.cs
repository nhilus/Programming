﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ScansProvedoresT
{
    public int Id { get; set; }

    public int IdProvedor { get; set; }

    public string CodigoScanProvedor { get; set; } = null!;

    public string IdScan { get; set; } = null!;
}
