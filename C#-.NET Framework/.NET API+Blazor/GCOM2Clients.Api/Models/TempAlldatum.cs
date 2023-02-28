using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempAlldatum
{
    public int? IdManifesto { get; set; }

    public string? Awb { get; set; }

    public string? UltScanCode { get; set; }

    public DateTime? UltScanDate { get; set; }

    public int? IdUltRota { get; set; }

    public bool? IsP1 { get; set; }

    public string? ScanCodeP2 { get; set; }

    public DateTime? ScanDateP2 { get; set; }

    public bool? IsP2 { get; set; }

    public int? IdPickup { get; set; }

    public DateTime? Dtpup { get; set; }

    public DateTime? Dtrecolha { get; set; }

    public string? IdPlatOrigemRet { get; set; }

    public bool? IsP3 { get; set; }

    public string? NumTelm { get; set; }

    public bool? IsP4 { get; set; }

    public DateTime? Ded { get; set; }

    public TimeSpan? Dedi { get; set; }

    public TimeSpan? Dedf { get; set; }

    public DateTime? DataEntregaRecolha { get; set; }

    public int? IdPlataforma { get; set; }

    public bool? IsP5 { get; set; }

    public bool? IsP6 { get; set; }

    public bool? IsP71 { get; set; }

    public bool? IsP72 { get; set; }

    public bool? P1 { get; set; }

    public bool? P2 { get; set; }

    public bool? P3 { get; set; }

    public bool? P4 { get; set; }

    public bool? P5 { get; set; }

    public bool? P6 { get; set; }

    public bool? P7 { get; set; }

    public string? RefCliente { get; set; }

    public DateTime? Dataanalise { get; set; }
}
