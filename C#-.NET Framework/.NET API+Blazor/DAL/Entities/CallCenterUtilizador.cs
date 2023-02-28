using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CallCenterUtilizador
{
    public int Id { get; set; }

    public int? IdUtilGcom { get; set; }

    public int? Agent { get; set; }

    public bool? Activo { get; set; }

    public string? Fila { get; set; }
}
