using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ServicosUnixGcommap
{
    public int? IdGcom { get; set; }

    public int? IdUnix { get; set; }

    public string? DescricaoUnix { get; set; }
}
