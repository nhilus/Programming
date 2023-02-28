using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ServicosProvedoresT
{
    public int Id { get; set; }

    public int IdServico { get; set; }

    public int IdProvedor { get; set; }

    public string CodigoServicoProvedor { get; set; } = null!;
}
