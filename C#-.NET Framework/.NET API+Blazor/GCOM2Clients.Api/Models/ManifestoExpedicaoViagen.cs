using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoExpedicaoViagen
{
    public int IdManifesto { get; set; }

    public int LegNbr { get; set; }

    public string? RouteNbr { get; set; }

    public DateTime? RouteDt { get; set; }

    public string? Origem { get; set; }

    public string? Destino { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public TimeSpan? ArrivalTime { get; set; }

    public DateTime? DepartDate { get; set; }

    public TimeSpan? DepartTime { get; set; }

    public string? RouteOrigCntry { get; set; }

    public string? RouteDestCntry { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
