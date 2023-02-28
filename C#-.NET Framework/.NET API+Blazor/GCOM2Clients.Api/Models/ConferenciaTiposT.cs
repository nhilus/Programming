using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ConferenciaTiposT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public bool Automatico { get; set; }

    public bool Factura { get; set; }

    public bool Reclama { get; set; }

    public bool Aceita { get; set; }

    public bool? ObrigaObs { get; set; }

    public bool? Visivel { get; set; }

    public string? Descricao { get; set; }
}
