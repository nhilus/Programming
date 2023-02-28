using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class RegimeManifesto
{
    public int Id { get; set; }

    public int IdRegime { get; set; }

    public string CodigoManif { get; set; } = null!;
}
