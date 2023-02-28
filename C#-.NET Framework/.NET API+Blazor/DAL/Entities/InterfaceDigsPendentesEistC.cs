using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class InterfaceDigsPendentesEistC
{
    public int Id { get; set; }

    public string? Awb { get; set; }

    public string? FileLocation { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdDocAdos { get; set; }

    public int? IdManifesto { get; set; }
}
