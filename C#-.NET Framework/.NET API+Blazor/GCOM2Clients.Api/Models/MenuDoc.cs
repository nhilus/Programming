using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuDoc
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string ServerLocation { get; set; } = null!;
}
