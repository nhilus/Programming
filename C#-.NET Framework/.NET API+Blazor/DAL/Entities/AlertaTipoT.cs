using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AlertaTipoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }

    public bool GeraEmail { get; set; }
}
