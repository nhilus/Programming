using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DestinatarioTemp
{
    public int Id { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdCliente { get; set; }

    public string? Nome { get; set; }

    public string? Morada { get; set; }

    public int? IdCpostal { get; set; }

    public string? Cpostal { get; set; }

    public string? Telefone { get; set; }

    public string? Nif { get; set; }

    public bool? PropCli { get; set; }

    public int? IdClassDest { get; set; }

    public int? IdPais { get; set; }

    public string? Localidade { get; set; }

    public int? IdCliMorada { get; set; }

    public int? TotalRepetidas { get; set; }

    public bool? Processado { get; set; }
}
