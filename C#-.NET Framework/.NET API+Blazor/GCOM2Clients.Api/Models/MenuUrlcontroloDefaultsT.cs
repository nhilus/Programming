using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuUrlcontroloDefaultsT
{
    public int Id { get; set; }

    public int IdControlo { get; set; }

    public int IdGrupo { get; set; }

    public string? DefaultValue { get; set; }
}
