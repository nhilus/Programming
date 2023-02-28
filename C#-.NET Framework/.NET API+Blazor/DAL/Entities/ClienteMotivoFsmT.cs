using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteMotivoFsmT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }
}
