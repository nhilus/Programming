using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempAtribuitarifasRexii
{
    public string? SqlCommand { get; set; }

    public int? Processado { get; set; }

    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public string? Regime { get; set; }

    public string? Servico { get; set; }

    public string? Ano { get; set; }

    public string? ServicoDet { get; set; }
}
