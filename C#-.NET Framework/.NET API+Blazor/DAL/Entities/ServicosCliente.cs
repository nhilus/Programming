using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ServicosCliente
{
    public int Id { get; set; }

    public int IdServico { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }
}
