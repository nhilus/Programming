using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempRedesCarrovassoura
{
    public string? TipoServiçoPt { get; set; }

    public string? Referencia { get; set; }

    public string? Awb { get; set; }

    public string? Cp4 { get; set; }

    public DateTime? Data { get; set; }

    public string? Transportador { get; set; }

    public string? UltStatReportado { get; set; }

    public string? Dept { get; set; }

    public string? Obs { get; set; }

    public bool? Resolvido { get; set; }
}
