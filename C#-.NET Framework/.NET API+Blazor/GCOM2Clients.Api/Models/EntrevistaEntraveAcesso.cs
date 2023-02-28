using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaEntraveAcesso
{
    public int Id { get; set; }

    public int IdEntrave { get; set; }

    public int IdUtilizadorDepartamento { get; set; }
}
