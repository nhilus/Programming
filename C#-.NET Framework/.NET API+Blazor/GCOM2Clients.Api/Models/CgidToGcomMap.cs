using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CgidToGcomMap
{
    public int IdMap { get; set; }

    public int? IdGcom { get; set; }

    public string? CodGcom { get; set; }

    public int? IdCgid { get; set; }

    public string? CodCgid { get; set; }
}
