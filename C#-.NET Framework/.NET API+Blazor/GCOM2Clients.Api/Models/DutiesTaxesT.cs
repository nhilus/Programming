using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DutiesTaxesT
{
    public int Id { get; set; }

    public string? CodigoAwb { get; set; }

    public string? CodigoGraspIb { get; set; }

    public string? CodigoGraspOb { get; set; }

    public string? CodigoGidwin { get; set; }

    public string Descricao { get; set; } = null!;

    public bool Activo { get; set; }
}
