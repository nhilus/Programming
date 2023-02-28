using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteResumoT
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int? IdUrlLocal { get; set; }

    public byte PosicaoDef { get; set; }

    public bool? Activo { get; set; }

    public bool? Visivel { get; set; }
}
