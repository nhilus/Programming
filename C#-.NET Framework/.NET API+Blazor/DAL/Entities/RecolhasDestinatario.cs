using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class RecolhasDestinatario
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string CodigoCliente { get; set; } = null!;

    public string? NomeDest { get; set; }

    public string? NifDest { get; set; }

    public string? MoradaDest { get; set; }

    public string? CpostalDest { get; set; }

    public string? LocalidadeDest { get; set; }

    public string? TelefoneDest { get; set; }

    public string? EmailDest { get; set; }

    public bool? Activo { get; set; }

    public int? IdEntidade { get; set; }

    public string? PaisDest { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdProduto { get; set; }

    public string? DescricaoProduto { get; set; }
}
