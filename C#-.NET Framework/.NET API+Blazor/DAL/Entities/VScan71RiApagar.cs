using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VScan71RiApagar
{
    public int Id { get; set; }

    public int? IdManifesto { get; set; }

    public string? AwbNumber { get; set; }

    public string? ScanCourierRoute { get; set; }

    public string? ScanLocation { get; set; }

    public string? ScanCode { get; set; }

    public DateTime? ScanDate { get; set; }

    public string? Comment { get; set; }

    public string? Signature { get; set; }
}
