using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEmailingTiposCliente
{
    public int Id { get; set; }

    public int IdClienteEmailing { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }
}
