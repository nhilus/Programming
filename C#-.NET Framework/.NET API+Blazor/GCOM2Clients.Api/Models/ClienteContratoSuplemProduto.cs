using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteContratoSuplemProduto
{
    public int Id { get; set; }

    public int IdClienteContrato { get; set; }

    public string? IdSuplemento { get; set; }

    public string? IdServiceDetGcom { get; set; }

    public string? CodigoServiceDetGcom { get; set; }

    public string? CodProdutoSalesForce { get; set; }

    public string? IdServicoGcom { get; set; }

    public string? CodigoServicoGcom { get; set; }
}
