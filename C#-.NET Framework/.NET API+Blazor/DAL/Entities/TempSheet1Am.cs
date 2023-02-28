using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TempSheet1Am
{
    public double? IdCliente { get; set; }

    public string? Cliente { get; set; }

    public double? ContaFedex { get; set; }

    public double? Contribuinte { get; set; }

    public string? TipoTarifa { get; set; }
}
