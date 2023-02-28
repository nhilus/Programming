using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MeuMenuAreasFuncaoEntidade
{
    public int? IdArea { get; set; }

    public int? IdUtilizadorFuncaoEntidade { get; set; }

    public bool? Activo { get; set; }

    public byte? Ordem { get; set; }

    public bool? Aberto { get; set; }
}
