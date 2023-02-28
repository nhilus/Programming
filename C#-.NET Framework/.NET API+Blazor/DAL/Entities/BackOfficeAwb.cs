using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class BackOfficeAwb
{
    public int Id { get; set; }

    public int IdBackOffice { get; set; }

    public string Awb { get; set; } = null!;

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool? Activo { get; set; }

    public int? IdManifesto { get; set; }

    public string? Referencia { get; set; }
}
