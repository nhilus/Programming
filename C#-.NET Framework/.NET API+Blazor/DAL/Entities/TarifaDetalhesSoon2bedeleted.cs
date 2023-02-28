using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaDetalhesSoon2bedeleted
{
    public int Id { get; set; }

    public int IdTarifa { get; set; }

    public int? IdProdutoFact { get; set; }

    public string? Zona0 { get; set; }

    public string? Zona { get; set; }

    public decimal PesoMax { get; set; }

    public decimal PesoMaxSeg { get; set; }

    public decimal PesoBruto { get; set; }

    public decimal PesoBrutoSeg { get; set; }

    public decimal Cubicagem { get; set; }

    public decimal CubicagemSeg { get; set; }

    public int NumVolumes { get; set; }

    public int NumVolumesSeg { get; set; }

    public decimal ValorMerc { get; set; }

    public decimal ValorMercSeg { get; set; }

    public decimal Valor { get; set; }

    public int IdTipoValor { get; set; }

    public decimal UnidIncremento { get; set; }

    public decimal? Escalao { get; set; }

    public decimal? EscalaoSeg { get; set; }
}
