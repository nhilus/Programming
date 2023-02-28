using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CentrosCustoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool Recolha { get; set; }

    public bool Entrega { get; set; }

    public bool Arrasto { get; set; }

    public bool? Activo { get; set; }
}
