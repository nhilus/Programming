using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MeuMenuAreasGrupo
{
    public byte IdArea { get; set; }

    public byte IdGrupo { get; set; }

    public byte IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public byte Ordem { get; set; }

    public bool Aberto { get; set; }
}
