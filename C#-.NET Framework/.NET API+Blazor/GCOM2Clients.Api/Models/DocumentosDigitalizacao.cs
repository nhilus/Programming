using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosDigitalizacao
{
    public int IdCab { get; set; }

    public int IdTipoDigit { get; set; }

    public int? NumDocAdos { get; set; }

    public DateTime? DtAdos { get; set; }

    public DateTime DtIntrod { get; set; }
}
