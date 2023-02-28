using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MapScanCodeGeodisRgl
{
    public int Id { get; set; }

    public string? ScanCodeRgl { get; set; }

    public string? EventCode { get; set; }

    public string? ReasonCode { get; set; }

    public string? TextoLivre { get; set; }

    public string? Descricao { get; set; }

    public string? DescricaoWeb { get; set; }
}
