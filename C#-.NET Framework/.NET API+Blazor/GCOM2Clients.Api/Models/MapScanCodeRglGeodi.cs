using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MapScanCodeRglGeodi
{
    public int Id { get; set; }

    public string? ScanCodeRgl { get; set; }

    public string? EventCode { get; set; }

    public string? ReasonCode { get; set; }

    public string? TextoLivre { get; set; }

    public string? Descricao { get; set; }

    public string? DescricaoWeb { get; set; }
}
