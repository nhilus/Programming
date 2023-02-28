using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MenuUrlcontroloDefaultsT
{
    public int Id { get; set; }

    public int IdControlo { get; set; }

    public int IdGrupo { get; set; }

    public string? DefaultValue { get; set; }
}
