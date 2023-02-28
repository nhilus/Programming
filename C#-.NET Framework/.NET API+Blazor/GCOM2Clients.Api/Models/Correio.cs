using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Correio
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtRecepcao { get; set; }

    public string? Codigo { get; set; }

    public int? IdDepartDest { get; set; }

    public int? IdUtilDest { get; set; }

    public string? Obs { get; set; }

    public int? IdEstado { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int IdEntidade { get; set; }
}
