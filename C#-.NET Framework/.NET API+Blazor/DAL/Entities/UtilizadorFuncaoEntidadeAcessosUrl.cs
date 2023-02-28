using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorFuncaoEntidadeAcessosUrl
{
    public int Id { get; set; }

    public short IdUtilizadorFuncaoEntidade { get; set; }

    public short IdMenuUrl { get; set; }

    public bool IsVisible { get; set; }

    public bool IsDefault { get; set; }

    public bool Activo { get; set; }
}
