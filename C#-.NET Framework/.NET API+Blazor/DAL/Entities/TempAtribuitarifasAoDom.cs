using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TempAtribuitarifasAoDom
{
    public string? SqlCommand { get; set; }

    public int? Processado { get; set; }

    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public string? Regime { get; set; }

    public string? Servico { get; set; }

    public string? Ano { get; set; }
}
