using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempAtribuitarifasFedexAo
{
    public string? SqlCommand { get; set; }

    public int? Processado { get; set; }

    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public string? Regime { get; set; }

    public string? Servico { get; set; }

    public int? Ano { get; set; }
}
