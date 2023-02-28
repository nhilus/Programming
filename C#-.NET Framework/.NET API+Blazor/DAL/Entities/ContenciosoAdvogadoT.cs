using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ContenciosoAdvogadoT
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int IdEntidade { get; set; }
}
