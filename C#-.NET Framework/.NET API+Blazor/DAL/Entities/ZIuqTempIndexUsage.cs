using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ZIuqTempIndexUsage
{
    public string FTableName { get; set; } = null!;

    public int FIndId { get; set; }

    public string? FIndexName { get; set; }

    public int? NoOfUpdates { get; set; }

    public int? UserReads { get; set; }

    public DateTime? LastUsedForReads { get; set; }

    public string IndexType { get; set; } = null!;

    public DateTime? LastUserSeek { get; set; }

    public DateTime? LastUserScan { get; set; }

    public DateTime? LastUserLookup { get; set; }

    public string? IndexKeys { get; set; }
}
