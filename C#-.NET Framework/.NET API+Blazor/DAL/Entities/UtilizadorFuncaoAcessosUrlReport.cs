using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorFuncaoAcessosUrlReport
{
    public int Id { get; set; }

    public int IdFuncao { get; set; }

    public int IdMenuReport { get; set; }

    public bool? IsVisible { get; set; }

    public bool? Activo { get; set; }

    public bool IsDefault { get; set; }
}
