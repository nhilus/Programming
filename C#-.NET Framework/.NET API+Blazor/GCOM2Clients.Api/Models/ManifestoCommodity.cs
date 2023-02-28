using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoCommodity
{
    public int Id { get; set; }

    public int? IdMaster { get; set; }

    public int? NumberOfPieces { get; set; }

    public string? Description { get; set; }

    public string? CountryOfManufacture { get; set; }

    public decimal? Weight { get; set; }

    public int? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Amount { get; set; }

    public string? UnitAmount { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
