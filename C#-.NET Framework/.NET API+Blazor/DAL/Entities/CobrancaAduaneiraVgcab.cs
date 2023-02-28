using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CobrancaAduaneiraVgcab
{
    public int Id { get; set; }

    public short? Status { get; set; }

    public short Peri { get; set; }

    public string Depart { get; set; } = null!;

    public string DocId { get; set; } = null!;

    public string DocNum { get; set; } = null!;

    public DateTime? DocData { get; set; }

    public DateTime? CargaData { get; set; }

    public string? CargaHora { get; set; }

    public string? TemGr { get; set; }

    public string? Arm { get; set; }

    public short? TpEnt { get; set; }

    public int? Entidade { get; set; }

    public int? IdTerc { get; set; }

    public int? Entrega { get; set; }

    public string? Transp { get; set; }

    public string? Comercial { get; set; }

    public decimal? TxComis { get; set; }

    public string? Vrefer { get; set; }

    public string StatusCred { get; set; } = null!;

    public DateTime? DtVto { get; set; }

    public string MeioPto { get; set; } = null!;

    public short? ModoPto { get; set; }

    public string Moeda { get; set; } = null!;

    public float? Cambio { get; set; }

    public string Ivaincl { get; set; } = null!;

    public decimal ValDoc { get; set; }

    public decimal? ValProd { get; set; }

    public decimal? ValDescLinha { get; set; }

    public decimal? ValDescCab { get; set; }

    public decimal? ValDescPp { get; set; }

    public decimal? ValOutros { get; set; }

    public decimal? ValIva { get; set; }

    public decimal? ValAjuste { get; set; }

    public decimal? ValTaras { get; set; }

    public float? TxDescCab { get; set; }

    public float? TxDescCab1 { get; set; }

    public float? TxDescCab2 { get; set; }

    public float? TxDescPp { get; set; }

    public decimal MvalDoc { get; set; }

    public decimal? MvalProd { get; set; }

    public decimal? MvalDescLinha { get; set; }

    public decimal? MvalDescCab { get; set; }

    public decimal? MvalDescPp { get; set; }

    public decimal? MvalOutros { get; set; }

    public decimal? MvalIva { get; set; }

    public decimal? MvalAjuste { get; set; }

    public decimal? MvalTaras { get; set; }

    public short? Utiliz { get; set; }

    public string? Autoriza { get; set; }

    public decimal? CustoVendas { get; set; }

    public short? NoViasEmit { get; set; }

    public short? ViasaEmit { get; set; }

    public DateTime? DataEmit { get; set; }

    public string? Obs { get; set; }

    public short? Iva0Cod { get; set; }

    public decimal? Iva0Inc { get; set; }

    public decimal? Iva0Val { get; set; }

    public decimal? Iva0IncM { get; set; }

    public decimal? Iva0ValM { get; set; }

    public short? Iva1Cod { get; set; }

    public decimal? Iva1Inc { get; set; }

    public decimal? Iva1Val { get; set; }

    public decimal? Iva1IncM { get; set; }

    public decimal? Iva1ValM { get; set; }

    public short? Iva2Cod { get; set; }

    public decimal? Iva2Inc { get; set; }

    public decimal? Iva2Val { get; set; }

    public decimal? Iva2IncM { get; set; }

    public decimal? Iva2ValM { get; set; }

    public short? Iva3Cod { get; set; }

    public decimal? Iva3Inc { get; set; }

    public decimal? Iva3Val { get; set; }

    public decimal? Iva3IncM { get; set; }

    public decimal? Iva3ValM { get; set; }

    public short? StatusAnul { get; set; }

    public decimal? Comissao { get; set; }

    public string? MatViat { get; set; }

    public string? MotViat { get; set; }

    public short? NoVolumes { get; set; }

    public int? CounterCcor { get; set; }

    public decimal? PesoDoc { get; set; }

    public string? TpMercadoria { get; set; }

    public decimal? ValReemb { get; set; }

    public DateTime? DtManu { get; set; }

    public string? Ccusto { get; set; }

    public decimal? SinValor { get; set; }

    public string? Descarga { get; set; }

    public short? IsRegDest { get; set; }

    public short? IsCondEntr { get; set; }

    public string? IsNatTrans1 { get; set; }

    public string? IsNatTrans2 { get; set; }

    public short? IsLocEs { get; set; }

    public string? IsModoTransp { get; set; }

    public short? TrajV { get; set; }

    public short? TrajE { get; set; }

    public string? ES { get; set; }

    public string? PaisDest { get; set; }

    public short? StEnvio { get; set; }

    public short? Process { get; set; }

    public string? Psicotropicos { get; set; }

    public string? RecusaDescontos { get; set; }

    public byte? TpLiq { get; set; }

    public string? DocContab { get; set; }

    public string? Contrato { get; set; }

    public short? TrjEOrdem { get; set; }

    public short? TrajC { get; set; }

    public short? TrjCOrdem { get; set; }

    public string? TabPrecos { get; set; }

    public short? Transitario { get; set; }

    public short? Despachante { get; set; }

    public short? TpTransp { get; set; }

    public short? TpEntrega { get; set; }

    public decimal? PesoSaida { get; set; }

    public string? ModoPtoTxt { get; set; }

    public decimal? ValMSDesc { get; set; }

    public short? Agrupa { get; set; }

    public byte? Resumo { get; set; }

    public string? ValorExtenso { get; set; }

    public int? Nlinhas { get; set; }

    public string? Awb { get; set; }

    public int? IdFicheiro { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool Integrada { get; set; }

    public int? IdUtilIntegr { get; set; }

    public DateTime? DtIntegr { get; set; }

    public int? CounterCabSaidasA { get; set; }

    public string? CodGidWin { get; set; }

    public string? Natureza { get; set; }

    public int? NumeroProcesso { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdEntidade { get; set; }

    public string? AwbGidwin { get; set; }
}
