using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TempHdMonitorFact
{
    public int Id { get; set; }

    public int? IdManifesto { get; set; }

    public int IdManifestoItem { get; set; }

    public string? Descricao { get; set; }

    public bool ValorManual { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? DtValor { get; set; }

    public int? IdClienteFact { get; set; }

    public int? IdCliMoradaFact { get; set; }

    public byte? Identidade { get; set; }

    public DateTime? DtEnvio { get; set; }

    public byte? IdRegime { get; set; }

    public byte? IdServico { get; set; }

    public short? IdServicoDet { get; set; }

    public short? IdClasseOrigem { get; set; }

    public string? CPostalOrigem { get; set; }

    public int? IdPaisOrigem { get; set; }

    public string? CPostalDestino { get; set; }

    public int IdPaisDestino { get; set; }

    public short? IdTipoProduto { get; set; }

    public short? NumPacotes { get; set; }

    public double? Peso { get; set; }

    public double? PesoVol { get; set; }

    public double? M3 { get; set; }

    public int? Comprimento { get; set; }

    public int? Largura { get; set; }

    public int? Altura { get; set; }

    public bool? Temvolumetrico { get; set; }

    public decimal? ValorSegurado { get; set; }

    public decimal? ValorFrete { get; set; }

    public DateTime? DtDone { get; set; }
}
