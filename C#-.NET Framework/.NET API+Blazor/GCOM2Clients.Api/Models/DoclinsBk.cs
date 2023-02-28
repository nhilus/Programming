using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DoclinsBk
{
    public int Id { get; set; }

    public int IdCab { get; set; }

    public int Lin { get; set; }

    public int? IdProduto { get; set; }

    public string? DescProduto { get; set; }

    public DateTime DtProduto { get; set; }

    public int? NumVolumes { get; set; }

    public string? Awbnumber { get; set; }

    public decimal? Peso { get; set; }

    public decimal? PesoVol { get; set; }

    public decimal? M3 { get; set; }

    public string? Dimensoes { get; set; }

    public string? Servico { get; set; }

    public string? ProdEmpresa { get; set; }

    public string? ProdMorada { get; set; }

    public string? ProdCpostal { get; set; }

    public string? ProdCidade { get; set; }

    public int? ProdIdPais { get; set; }

    public string? ProdPais { get; set; }

    public string? ProdRef { get; set; }

    public string? ExtEmpresa { get; set; }

    public string? ExtMorada { get; set; }

    public string? ExtCpostal { get; set; }

    public string? ExtCidade { get; set; }

    public int? ExtIdPais { get; set; }

    public string? ExtPais { get; set; }

    public DateTime? PodDate { get; set; }

    public string? PodSignature { get; set; }

    public decimal Quantidade { get; set; }

    public decimal ValorUnitario { get; set; }

    public bool FaltaValorUnitario { get; set; }

    public int? IdTipoIva { get; set; }

    public decimal TaxaIva { get; set; }

    public decimal ValorProduto { get; set; }

    public decimal? ValorCiva { get; set; }

    public decimal ValorSiva { get; set; }

    public decimal ValorIva { get; set; }

    public string? Observacoes { get; set; }

    public int? IdTarifa { get; set; }

    public int? IdExportacao { get; set; }

    public int? IdImportacao { get; set; }

    public int? IdEntregaMaterial { get; set; }

    public bool? LinhaAuto { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdLinOrigem { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public DateTime? DtCreditada { get; set; }

    public int? IdUtilCreditada { get; set; }

    public DateTime? DtExport { get; set; }

    public int? IdExport { get; set; }

    public string? ObsOrig { get; set; }

    public int? IdExportacaoItem { get; set; }

    public int? IdImportacaoItem { get; set; }

    public int? IdEntregaMaterialItem { get; set; }

    public DateTime? DtExportSap { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public int? IdServicoDet { get; set; }

    public int? IdEquipaComis { get; set; }

    public int? IdUtilComis { get; set; }

    public decimal? ValComis { get; set; }

    public DateTime? DtComis { get; set; }

    public int? IdTipoComis { get; set; }

    public string? RefTipoComis { get; set; }

    public int? IdIvareg { get; set; }

    public string? CodIva { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdManifestoItem { get; set; }

    public int? IdAgrupamento { get; set; }

    public int? IdMoeda { get; set; }

    public decimal? Cambio { get; set; }
}
