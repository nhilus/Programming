using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PrevisoesEntregaT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public int? Activo { get; set; }
}
