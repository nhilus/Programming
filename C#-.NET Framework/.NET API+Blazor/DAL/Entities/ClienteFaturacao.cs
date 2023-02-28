using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteFaturacao
{
    public int? IdCliente { get; set; }

    public string? Descricao { get; set; }

    public DateTime? DataInicio { get; set; }
}
