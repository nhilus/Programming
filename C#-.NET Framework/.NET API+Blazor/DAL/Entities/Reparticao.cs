using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Reparticao
{
    public double? IdCliente { get; set; }

    public string? ZonasFinal { get; set; }

    public string? SplitFinal { get; set; }
}
