using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuUrlreportsT
{
    public int Id { get; set; }

    public int IdUrl { get; set; }

    public int IdReport { get; set; }

    public short Posicao { get; set; }

    public bool? Activo { get; set; }
}
