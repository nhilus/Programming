using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesHistory
{
    public int SaleId { get; set; }

    public string Product { get; set; } = null!;

    public DateTime? SaleDate { get; set; }

    public decimal? SalePrice { get; set; }
}
