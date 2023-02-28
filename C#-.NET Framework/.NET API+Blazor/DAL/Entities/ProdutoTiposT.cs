using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ProdutoTiposT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Material { get; set; }

    public bool? Pickup { get; set; }

    public bool? Entrega { get; set; }

    public bool? FacturaManual { get; set; }

    public string? CodigoAwb { get; set; }

    public string? CodigoFedex { get; set; }

    public int? CodigoDlink { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public bool? TemVolumetrico { get; set; }

    public decimal? PesoMinimo { get; set; }

    public decimal? PesoMaximo { get; set; }

    public decimal? Custo { get; set; }

    public int? IdTipoIvamaterial { get; set; }

    public string? CodigoGrasp { get; set; }

    public string? CodigoGidwin { get; set; }

    public bool? Adicional { get; set; }

    public bool? VariaPeso { get; set; }

    public int? IdProdutoFact { get; set; }

    public bool? CustoIncrementaBase { get; set; }

    public decimal? PesoMinimoFact { get; set; }

    public decimal? ArredondamentoPesoFact { get; set; }

    public decimal? IncrementoPesoMaximoFact { get; set; }

    public decimal? ValorMinimoFact { get; set; }

    public bool? IsentoIva { get; set; }

    public bool? FactZero { get; set; }

    public decimal? TaxaSobreValor { get; set; }

    public int? IdFamiliaProduto { get; set; }

    public int IdEntidade { get; set; }

    public string? CodigoCosmosNovo { get; set; }

    public bool? Comissionavel { get; set; }

    public bool? Activo { get; set; }

    public bool EnvInterface { get; set; }
}
