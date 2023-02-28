using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoVolume
{
    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public short? IdTipoProduto { get; set; }

    public decimal? Peso { get; set; }

    public byte? IdUnidadePeso { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public byte? IdUnidadePesoVolumetrico { get; set; }

    public double? M3 { get; set; }

    public byte? IdUnidM3 { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public byte? IdUnidadeMetrica { get; set; }

    public decimal? ValorMercadoria { get; set; }

    public byte? IdMoeda { get; set; }

    public string? Descricao { get; set; }

    public short? IdPaisManufactura { get; set; }

    public short? IdTipoProdutoOrig { get; set; }

    public decimal? PesoOrig { get; set; }

    public byte? IdUnidadePesoOrig { get; set; }

    public decimal? PesoVolumetricoOrig { get; set; }

    public byte? IdUnidadePesoVolumetricoOrig { get; set; }

    public double? M3orig { get; set; }

    public byte? IdUnidM3orig { get; set; }

    public decimal? ComprimentoOrig { get; set; }

    public decimal? LarguraOrig { get; set; }

    public decimal? AlturaOrig { get; set; }

    public byte? IdUnidadeMetricaOrig { get; set; }

    public DateTime? DtConfOrig { get; set; }

    public short IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public decimal? PesoReal { get; set; }

    public double? M3real { get; set; }

    public decimal? LarguraReal { get; set; }

    public decimal? AlturaReal { get; set; }

    public decimal? ComprimentoReal { get; set; }
}
