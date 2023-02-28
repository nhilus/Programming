using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClientesGeracaoCodigo
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdManifesto { get; set; }

    public string? AwbNumber { get; set; }

    public int? IdPickup { get; set; }

    public string? Er { get; set; }

    public string? CodCliente { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }

    public int IdTipo { get; set; }
}
