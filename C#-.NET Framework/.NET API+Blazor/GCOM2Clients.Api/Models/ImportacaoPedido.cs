using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ImportacaoPedido
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public string? Awb { get; set; }

    public int? IdCliente { get; set; }

    public string? Contacto { get; set; }

    public string? MoradaAlt { get; set; }

    public int? IdCpostalAlt { get; set; }

    public int? TelefoneAlt { get; set; }

    public int? IdPaisOrigem { get; set; }

    public int? IdProduto { get; set; }

    public decimal? PesoEstimado { get; set; }

    public decimal? ValorEstimado { get; set; }

    public decimal? CustoEstimado { get; set; }

    public string? Observacoes { get; set; }

    public int? IdManifesto { get; set; }

    public DateTime? DtMatch { get; set; }

    public int? IdUtilMatch { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public string? Referencia { get; set; }

    public bool? VendaDinheiro { get; set; }

    public int? IdCliMorada { get; set; }
}
