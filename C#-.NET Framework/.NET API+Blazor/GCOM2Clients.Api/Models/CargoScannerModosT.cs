using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CargoScannerModosT
{
    public string Modo { get; set; } = null!;

    public string ScanCode { get; set; } = null!;

    public bool ParaMaster { get; set; }

    public int OrdemScan { get; set; }

    public bool ParaConferir { get; set; }

    public bool ParaScans { get; set; }

    public bool ParaObsPeso { get; set; }

    public bool IsDefault { get; set; }

    public byte IdEntidade { get; set; }

    public bool? PodeScanRepetido { get; set; }

    public int Id { get; set; }
}
