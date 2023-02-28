using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EntrevistaEntraveAcesso
{
    public int Id { get; set; }

    public int IdEntrave { get; set; }

    public int IdUtilizadorDepartamento { get; set; }
}
