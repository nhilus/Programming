using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CorreioDetalhe
{
    public int Id { get; set; }

    public int IdCorreio { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public int? IdEstado { get; set; }

    public int? IdDepart { get; set; }

    public int? IdUtil { get; set; }

    public string? Obs { get; set; }
}
