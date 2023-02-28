using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CobrancaAduaneiraVglin
{
    public int Id { get; set; }

    public short? Status { get; set; }

    public short Peri { get; set; }

    public string Depart { get; set; } = null!;

    public string DocId { get; set; } = null!;

    public string DocNum { get; set; } = null!;

    public short Lin { get; set; }

    public DateTime? Data { get; set; }

    public string? ES { get; set; }

    public string MovGen { get; set; } = null!;

    public string MovTipo { get; set; } = null!;

    public int? EncLin { get; set; }

    public short? MovQuant { get; set; }

    public string? ProdCurto { get; set; }

    public string? ProdNome { get; set; }

    public string? Familia { get; set; }

    public string Arm { get; set; } = null!;

    public string? Ccusto { get; set; }

    public string? Comercial { get; set; }

    public string? ZonaVendas { get; set; }

    public short? TpEnt { get; set; }

    public int? Entidade { get; set; }

    public string? Unid { get; set; }

    public decimal? Quant { get; set; }

    public decimal? QuantStock { get; set; }

    public string? Moeda { get; set; }

    public float? Cambio { get; set; }

    public float? TxDescLin { get; set; }

    public float? TxDescLin1 { get; set; }

    public float? TxDescLin2 { get; set; }

    public float? TxIva { get; set; }

    public decimal? ValPrUnit { get; set; }

    public decimal? ValQt { get; set; }

    public decimal? ValDescLin { get; set; }

    public decimal? ValDescDoc { get; set; }

    public decimal? ValCustoQt { get; set; }

    public decimal? ValCustoAdicional { get; set; }

    public decimal? ValIva { get; set; }

    public int? FichaDespesas { get; set; }

    public string? Obs { get; set; }

    public int? Medidas { get; set; }

    public decimal? ValMPrUnit { get; set; }

    public decimal? ValMQt { get; set; }

    public decimal? ValMDescLin { get; set; }

    public decimal? ValMIva { get; set; }

    public string Ivaincl { get; set; } = null!;

    public short? StatusAnul { get; set; }

    public short? StFase { get; set; }

    public decimal? ValCustoMs { get; set; }

    public int? CountLote { get; set; }

    public short? TipoAreg { get; set; }

    public decimal? ValRegMs { get; set; }

    public short? StatusTr { get; set; }

    public string? RefYx { get; set; }

    public decimal? TxCom { get; set; }

    public int? CalcE { get; set; }

    public decimal? IsValStat { get; set; }

    public short? TipoBonus { get; set; }

    public decimal? ValPromLin { get; set; }

    public decimal? ValMPromLin { get; set; }

    public string? Promocao { get; set; }

    public short? Ciclo { get; set; }

    public string? ContaPocD { get; set; }

    public string? ContaPocC { get; set; }

    public int? PromCounter { get; set; }

    public string? StArrum { get; set; }

    public decimal? PaQtStockMs { get; set; }

    public decimal? PaValStockMs { get; set; }

    public DateTime? DataRegisto { get; set; }

    public int? MotivoCg { get; set; }

    public string? MotivoDesc { get; set; }

    public short? TipoDesc { get; set; }

    public string? TabPrecos { get; set; }

    public decimal? ValDescForn { get; set; }

    public int? PrazoVto { get; set; }

    public int? CgTipVis { get; set; }

    public string? SerieEq { get; set; }

    public decimal? ValCustoMsContab { get; set; }

    public int? IdFicheiro { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool Integrada { get; set; }

    public int? IdUtilIntegr { get; set; }

    public DateTime? DtIntegr { get; set; }

    public int? IdEntidade { get; set; }

    public string? CodIva { get; set; }
}
