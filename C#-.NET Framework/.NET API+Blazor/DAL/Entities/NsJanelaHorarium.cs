using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class NsJanelaHorarium
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string Designacao { get; set; } = null!;

    public TimeSpan? Hhinicio { get; set; }

    public TimeSpan? Hhfim { get; set; }
}
