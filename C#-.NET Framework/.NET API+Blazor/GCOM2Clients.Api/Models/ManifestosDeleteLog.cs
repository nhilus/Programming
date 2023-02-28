using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestosDeleteLog
{
    public int Id { get; set; }

    public int IdManifesto { get; set; }

    public DateTime Data { get; set; }
}
