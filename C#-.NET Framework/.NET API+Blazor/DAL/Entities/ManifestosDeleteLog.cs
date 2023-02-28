using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestosDeleteLog
{
    public int Id { get; set; }

    public int IdManifesto { get; set; }

    public DateTime Data { get; set; }
}
