using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosDatasFecho
{
    public byte IdTipoDoc { get; set; }

    public byte IdDepartamentoDoc { get; set; }

    public byte AnoDoc { get; set; }

    public DateTime? DtFecho { get; set; }
}
