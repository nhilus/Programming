using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ScansObfedex
{
    public string? EventCode { get; set; }

    public string? ExcepCode { get; set; }

    public string? EventDescription { get; set; }

    public string? ExcepDescription { get; set; }

    public string? Awb { get; set; }

    public DateTime? ScanDate { get; set; }

    public DateTime? Ded { get; set; }

    public int? IdScanDado { get; set; }

    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }
}
