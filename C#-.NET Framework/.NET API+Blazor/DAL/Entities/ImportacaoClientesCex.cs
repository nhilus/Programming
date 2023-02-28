using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ImportacaoClientesCex
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? ClaimNumber { get; set; }

    public string? ContractNumber { get; set; }

    public string? ClientEmail { get; set; }

    public string? ClientPhone { get; set; }

    public int? IdUtilIntrod { get; set; }

    public string? DtIntrod { get; set; }
}
