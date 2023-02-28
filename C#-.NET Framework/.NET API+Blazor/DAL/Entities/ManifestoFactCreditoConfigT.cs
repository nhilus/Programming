using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoFactCreditoConfigT
{
    public string TableName { get; set; } = null!;

    public string? ColumnName { get; set; }

    public bool? Activo { get; set; }
}
