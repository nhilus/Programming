using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ScancodesOpDistribuicao
{
    public string Scancode { get; set; } = null!;

    public byte IdEntidade { get; set; }
}
