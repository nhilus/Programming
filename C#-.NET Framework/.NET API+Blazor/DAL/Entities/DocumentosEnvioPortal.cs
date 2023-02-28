using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosEnvioPortal
{
    public int Id { get; set; }

    public int? IdClienteEmailing { get; set; }

    public int? IdDoc { get; set; }

    public int? IdAdos { get; set; }

    public bool? Rosto { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? IdUtilEnvioManual { get; set; }
}
