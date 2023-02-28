using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ExportacaoManifestoCorreccoesCosmo
{
    public int Id { get; set; }

    public int IdManifesto { get; set; }

    public short? NumPacotes { get; set; }

    public int? IdTipoProduto { get; set; }

    public decimal? Peso { get; set; }

    public short? IdUnidadePeso { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public short? IdUnidadePesoVolumetrico { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public int? IdUnidadeMetrica { get; set; }

    public bool? AlteraValor { get; set; }

    public DateTime? DtAlteraValor { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtAlteracao { get; set; }

    public int? IdUtilAlteracao { get; set; }

    public DateTime? DtAlerta { get; set; }
}
