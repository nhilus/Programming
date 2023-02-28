using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class BuytragoRec
{
    public int Id { get; set; }

    public int? CodDelOrigem { get; set; }

    public int? CodDelDestino { get; set; }

    public string? NumExpedicao { get; set; }

    public string? CodIncidencia { get; set; }

    public DateTime? DtExpedicao { get; set; }

    public DateTime? DtIncidencia { get; set; }

    public string? Obs { get; set; }

    public string? FileName { get; set; }

    public int? LineIndex { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool? Tratado { get; set; }

    public string? CodEtiquetado { get; set; }

    public string? ScanCodeRgl { get; set; }
}
