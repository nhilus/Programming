using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ZIuqTempIndexKey
{
    public int FObjId { get; set; }

    public string? FObjName { get; set; }

    public int FIndId { get; set; }

    public int IndexColumnId { get; set; }

    public string? IndexKey { get; set; }

    public string? IndexKeyList { get; set; }
}
