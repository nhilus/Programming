using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ScansProvedoresT
{
    public int Id { get; set; }

    public int IdProvedor { get; set; }

    public string CodigoScanProvedor { get; set; } = null!;

    public string IdScan { get; set; } = null!;
}
