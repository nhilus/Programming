using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLeadProspect
{
    public int Id { get; set; }

    public double? IdCliente { get; set; }

    public string? Nome { get; set; }

    public string? Nif { get; set; }

    public string? StatusComercial { get; set; }

    public string? StatusCredito { get; set; }

    public string? Equipa { get; set; }

    public string? Localidade { get; set; }

    public decimal? Facturacao { get; set; }

    public string? Prospect { get; set; }

    public bool? Processada { get; set; }

    public DateTime? DataProcessada { get; set; }
}
