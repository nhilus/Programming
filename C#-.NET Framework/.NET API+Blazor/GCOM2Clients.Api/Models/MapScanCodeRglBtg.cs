using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MapScanCodeRglBtg
{
    public int Id { get; set; }

    public string? CodInc { get; set; }

    public string? ScanCodeRgl { get; set; }

    public string? Descricao { get; set; }

    public bool? Recolha { get; set; }

    public int? Nivel { get; set; }
}
