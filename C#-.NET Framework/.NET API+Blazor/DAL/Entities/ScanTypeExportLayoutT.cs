using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ScanTypeExportLayoutT
{
    public string ScanType { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public string Field { get; set; } = null!;

    public byte Length { get; set; }

    public string DataType { get; set; } = null!;

    public string? DataFormat { get; set; }

    public string? DataColumn { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public byte Ordem { get; set; }
}
