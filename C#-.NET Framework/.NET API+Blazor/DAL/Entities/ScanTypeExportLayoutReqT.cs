using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ScanTypeExportLayoutReqT
{
    public string ScanType { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public string Field { get; set; } = null!;

    public string AdicCriteria { get; set; } = null!;

    public string ScanCode { get; set; } = null!;

    public string? ReqType { get; set; }

    public string? DataColumnValue { get; set; }
}
