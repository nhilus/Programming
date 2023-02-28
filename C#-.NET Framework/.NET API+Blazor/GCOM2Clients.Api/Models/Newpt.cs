using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Newpt
{
    public string? DesTransportador { get; set; }

    public string? Codserviço { get; set; }

    public DateTime? FimAtualTrsp { get; set; }

    public string? Ntransporte { get; set; }

    public string? Nobjecto { get; set; }

    public string? Inferencia { get; set; }

    public string? DataEvento { get; set; }

    public string? UltimoEstado { get; set; }
}
