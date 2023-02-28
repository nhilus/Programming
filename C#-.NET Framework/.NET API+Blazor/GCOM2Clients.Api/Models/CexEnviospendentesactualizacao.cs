using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CexEnviospendentesactualizacao
{
    public string NumEnvio { get; set; } = null!;

    public bool? Processado { get; set; }

    public DateTime? Dtprocessado { get; set; }

    public int? IdPickup { get; set; }

    public DateTime? DtIntrod { get; set; }

    public string? Msg { get; set; }
}
