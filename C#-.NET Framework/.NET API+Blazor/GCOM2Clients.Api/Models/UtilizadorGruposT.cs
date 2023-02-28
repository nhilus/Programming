using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorGruposT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int? IdDepartamento { get; set; }

    public byte? Nivel { get; set; }

    public bool? AssociaClientes { get; set; }

    public bool? Visivel { get; set; }

    public bool? Activo { get; set; }

    public bool ApenasCarteira { get; set; }

    public bool IsDirector { get; set; }

    public bool IsEstDis { get; set; }
}
