using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoTnt
{
    public int IdManifesto { get; set; }

    public DateTime DtIntrod { get; set; }

    public DateTime? RouteDate { get; set; }

    public int? IdPlataforma { get; set; }
}
