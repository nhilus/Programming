using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SalesHistory
{
    public int SaleId { get; set; }

    public string Product { get; set; } = null!;

    public DateTime? SaleDate { get; set; }

    public decimal? SalePrice { get; set; }
}
