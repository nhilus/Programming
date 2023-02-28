using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorLoginMirrorsT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Port { get; set; } = null!;

    public bool Default { get; set; }

    public bool? Activo { get; set; }

    public bool IsDev { get; set; }
}
