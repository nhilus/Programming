using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MeuMenuAreasItemsT
{
    public short Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string Title { get; set; } = null!;

    public byte IdArea { get; set; }

    public short? IdMenuUrl { get; set; }

    public short? IdMenuUrlDet { get; set; }

    public bool? Activo { get; set; }
}
