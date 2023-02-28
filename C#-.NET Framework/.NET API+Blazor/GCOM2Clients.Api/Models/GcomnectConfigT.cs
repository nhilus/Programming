using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class GcomnectConfigT
{
    public int Id { get; set; }

    public string? TimerName { get; set; }

    public int? Interval { get; set; }

    public bool? Activo { get; set; }

    public int? AlertTime { get; set; }

    public TimeSpan? BeginTime { get; set; }

    public TimeSpan? EndTime { get; set; }

    public string? TimeToRun { get; set; }

    public string? ServiceName { get; set; }

    public string? TimerClass { get; set; }

    public bool? ActivoV2 { get; set; }

    public string? TimerParameter { get; set; }
}
