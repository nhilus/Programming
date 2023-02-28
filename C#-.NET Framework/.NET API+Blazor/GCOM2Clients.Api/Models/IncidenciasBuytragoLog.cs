using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class IncidenciasBuytragoLog
{
    public int Id { get; set; }

    public int? IdScan { get; set; }

    public int? CodDelOrig { get; set; }

    public int? CodDelDest { get; set; }

    public string? CodEtiquetado { get; set; }

    public string? NumExpedicao { get; set; }

    public string? CodIncid { get; set; }

    public string? DataExpedicao { get; set; }

    public string? ScanDate { get; set; }

    public string? Texto { get; set; }

    public DateTime? DataEnvio { get; set; }

    public string? Er { get; set; }

    public int? NumSequencia { get; set; }

    public int? IdPickup { get; set; }

    public DateTime? DtVerifPickup { get; set; }
}
