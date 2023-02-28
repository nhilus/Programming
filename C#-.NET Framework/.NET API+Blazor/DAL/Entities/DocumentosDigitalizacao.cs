using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosDigitalizacao
{
    public int IdCab { get; set; }

    public int IdTipoDigit { get; set; }

    public int? NumDocAdos { get; set; }

    public DateTime? DtAdos { get; set; }

    public DateTime DtIntrod { get; set; }
}
