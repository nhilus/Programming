using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ConsumosGologisticLog
{
    public DateTime? DtIntrod { get; set; }

    public int? IdExportacao { get; set; }

    public string? Awb { get; set; }

    public string? Destinatario { get; set; }

    public string? Morada { get; set; }

    public decimal? Peso { get; set; }

    public int? NVolumes { get; set; }

    public string? Ref { get; set; }

    public string? Pod { get; set; }

    public decimal? ValorReemb { get; set; }

    public int? IdManifesto { get; set; }
}
