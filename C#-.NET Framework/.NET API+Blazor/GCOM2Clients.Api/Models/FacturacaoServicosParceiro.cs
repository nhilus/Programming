using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FacturacaoServicosParceiro
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdManifesto { get; set; }

    public byte IdRegime { get; set; }

    public byte IdEntidade { get; set; }

    public int IdClienteFact { get; set; }

    public int IdCliMoradaFact { get; set; }

    public int? IdScan { get; set; }

    public int? IdPickup { get; set; }

    public decimal? PesoFact { get; set; }

    public string? ScanCode { get; set; }

    public DateTime? ScanDate { get; set; }

    public int? IdParent { get; set; }

    public decimal? SumPeso { get; set; }

    public short? SumPacs { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? DtValor { get; set; }

    public bool? ParaFacturar { get; set; }

    public byte? IdMotivoNaoFacturar { get; set; }

    public DateTime? DtParaFacturar { get; set; }

    public bool Facturada { get; set; }

    public DateTime? DtFacturada { get; set; }

    public short? IdUtilFacturada { get; set; }

    public string? Obs { get; set; }

    public int? IdDoc { get; set; }

    public string? Obs2 { get; set; }
}
