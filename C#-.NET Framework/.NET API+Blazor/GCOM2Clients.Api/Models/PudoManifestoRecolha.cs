using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PudoManifestoRecolha
{
    public int Id { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdPudo { get; set; }

    public int? IdMaster { get; set; }

    public string? Master { get; set; }

    public string? TipoDetelhe { get; set; }

    public int? IdManifesto { get; set; }

    public string? Awb { get; set; }

    public int? IdCobranca { get; set; }

    public string? Obs { get; set; }
}
