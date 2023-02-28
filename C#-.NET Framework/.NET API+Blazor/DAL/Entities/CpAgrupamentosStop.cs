using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CpAgrupamentosStop
{
    public int Id { get; set; }

    public int? IdStop { get; set; }

    public string? Morada { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? Activo { get; set; }

    public int? CsMorada { get; set; }

    public string? Morada2 { get; set; }

    public int? CsMorada2 { get; set; }
}
