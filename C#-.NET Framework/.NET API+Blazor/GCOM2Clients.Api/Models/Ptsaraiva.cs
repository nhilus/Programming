using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Ptsaraiva
{
    public DateTime? DtEnvio { get; set; }

    public int? IdCliente { get; set; }

    public string? AwbNumber { get; set; }

    public int? NumPacotes { get; set; }

    public decimal? Peso { get; set; }

    public string? RefExp { get; set; }

    public string? Objecto { get; set; }
}
