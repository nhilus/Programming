using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class InterfaceBuytragoInternacionalLog
{
    public int Id { get; set; }

    public int? IdManifesto { get; set; }

    public int NumManifestoBuytrago { get; set; }

    public int? IdPickup { get; set; }

    public DateTime? DtIntrod { get; set; }
}
