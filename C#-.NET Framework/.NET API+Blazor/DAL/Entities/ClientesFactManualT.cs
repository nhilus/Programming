using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClientesFactManualT
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }
}
