using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ScanTypeT
{
    public string ScanType { get; set; } = null!;

    public string ScanTypeCode { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public string Descricao { get; set; } = null!;

    public string Definicao { get; set; } = null!;
}
