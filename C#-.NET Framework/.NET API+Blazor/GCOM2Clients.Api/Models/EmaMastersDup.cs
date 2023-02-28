using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EmaMastersDup
{
    public string? AwbNumber { get; set; }

    public int? MinId { get; set; }

    public DateTime? MaxDtEnvio { get; set; }

    public DateTime? MinDtEnvio { get; set; }

    public int? NumRecs { get; set; }
}
