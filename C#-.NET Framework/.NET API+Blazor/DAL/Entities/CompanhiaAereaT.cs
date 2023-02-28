using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CompanhiaAereaT
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public bool Activo { get; set; }
}
