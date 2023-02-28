using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteContactosTipoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }

    public int? IdEntidade { get; set; }
}
