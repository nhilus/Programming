using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEntidadesLogin
{
    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public int IdTipoLogin { get; set; }

    public string? Login { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public string Guid { get; set; } = null!;
}
