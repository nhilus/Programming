using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AbatimentosDebrief
{
    public int Id { get; set; }

    public int? IdUtil { get; set; }

    public DateTime? DtAccao { get; set; }

    public string? TipoAbatimento { get; set; }

    public int? IdObjecto { get; set; }

    public string? ScanCode { get; set; }
}
