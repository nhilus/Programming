using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class RotaClasseT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public bool? Activo { get; set; }
}
