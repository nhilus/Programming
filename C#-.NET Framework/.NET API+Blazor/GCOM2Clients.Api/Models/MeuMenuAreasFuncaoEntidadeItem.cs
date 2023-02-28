using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MeuMenuAreasFuncaoEntidadeItem
{
    public int? IdAreaItem { get; set; }

    public int? IdUtilizadorFuncaoEntidade { get; set; }

    public bool? Activo { get; set; }

    public byte? Ordem { get; set; }
}
