using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoRecolhaLog
{
    public int Id { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdPickup { get; set; }

    public int? IdUtilintrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime DtIntrodTabela { get; set; }

    public int? IdUtilIntrodtabela { get; set; }
}
