using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoFedexGraspLeg
{
    public int Id { get; set; }

    public int? IdManifFedex { get; set; }

    public string? LegRouteNbr { get; set; }

    public DateTime? LegRouteDt { get; set; }

    public string? LegRouteOrigLoc { get; set; }

    public string? LegRouteDestLoc { get; set; }

    public int? LegNbr { get; set; }

    public DateTime? LegArrivalDtLoc { get; set; }

    public TimeSpan? LegArrivalTmLoc { get; set; }

    public DateTime? LegDeptDtLoc { get; set; }

    public TimeSpan? LegDeptTmLoc { get; set; }

    public string? LegRouteOrigLocCntryCd { get; set; }

    public string? LegRouteDestLocCntryCd { get; set; }

    public DateTime? DtIntrod { get; set; }
}
