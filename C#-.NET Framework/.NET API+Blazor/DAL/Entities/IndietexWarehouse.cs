using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class IndietexWarehouse
{
    public int IndietexWarehousesId { get; set; }

    public string WarehouseName { get; set; } = null!;

    public string WarehouseCode { get; set; } = null!;

    public string WarehouseAddress { get; set; } = null!;

    public string WarehousePostalcode { get; set; } = null!;

    public string WarehouseCity { get; set; } = null!;

    public string WarehouseCountry { get; set; } = null!;
}
