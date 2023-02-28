using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ErrosEtiquetasTdnlog
{
    public int Id { get; set; }

    public string? AwbOriginal { get; set; }

    public string? AwbDeduzida { get; set; }

    public string? RefExpedidor { get; set; }

    public int? IdPlataforma { get; set; }

    public DateTime? DtIntrod { get; set; }
}
