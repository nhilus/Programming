using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MapEstadosFedexScan
{
    public int Id { get; set; }

    public string? EventCode { get; set; }

    public string? Descricao { get; set; }

    public string? ScanCode { get; set; }
}
