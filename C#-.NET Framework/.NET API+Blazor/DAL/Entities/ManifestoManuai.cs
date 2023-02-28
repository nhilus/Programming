using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoManuai
{
    public string? Awb { get; set; }

    public DateTime? DtGeracao { get; set; }
}
