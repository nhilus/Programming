using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ScancodesOpDistribuicao
{
    public string Scancode { get; set; } = null!;

    public byte IdEntidade { get; set; }
}
