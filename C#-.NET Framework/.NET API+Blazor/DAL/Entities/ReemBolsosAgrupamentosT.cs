using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReemBolsosAgrupamentosT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public int? Activo { get; set; }
}
