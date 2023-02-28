using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteParserConfig
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? Opcao { get; set; }

    public string? Valor { get; set; }
}
