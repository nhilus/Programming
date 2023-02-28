using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempSafira
{
    public string Master { get; set; } = null!;

    public int Idmaster { get; set; }

    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public DateTime? Dtenvio { get; set; }

    public decimal? PesoRealVol { get; set; }

    public decimal? PesoVol { get; set; }

    public decimal? PesoOrigVol { get; set; }

    public decimal? PesoPesado { get; set; }

    public decimal? Peso { get; set; }

    public decimal? PesoOrig { get; set; }

    public decimal? PesoReal { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public double? M3 { get; set; }
}
