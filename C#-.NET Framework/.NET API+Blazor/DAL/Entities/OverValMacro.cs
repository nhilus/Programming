using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class OverValMacro
{
    public int Id { get; set; }

    public string? Master { get; set; }

    public string? Screen { get; set; }

    public DateTime? Data { get; set; }
}
