using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosLin
{
    public int Id { get; set; }

    /// <summary>
    /// id do cabecalho (DocumentosCab)
    /// </summary>
    public int IdCab { get; set; }

    /// <summary>
    /// numerador da linha
    /// </summary>
    public int Lin { get; set; }

    /// <summary>
    /// produto de facturacao (ProdutoTipos_T)
    /// </summary>
    public int? IdProduto { get; set; }

    /// <summary>
    /// descricao do produto facturado
    /// </summary>
    public string? DescProduto { get; set; }

    /// <summary>
    /// data do produto facturado
    /// </summary>
    public DateTime DtProduto { get; set; }

    /// <summary>
    /// numero de volumes associados ao produto facturado
    /// </summary>
    public int? NumVolumes { get; set; }

    /// <summary>
    /// awb facturada
    /// </summary>
    public string? Awbnumber { get; set; }

    /// <summary>
    /// peso
    /// </summary>
    public decimal? Peso { get; set; }

    /// <summary>
    /// peso volumetrico
    /// </summary>
    public decimal? PesoVol { get; set; }

    public decimal? M3 { get; set; }

    /// <summary>
    /// dimensoes
    /// </summary>
    public string? Dimensoes { get; set; }

    /// <summary>
    /// descricao do servico facturado
    /// </summary>
    public string? Servico { get; set; }

    /// <summary>
    /// empresa assoc. ao servico
    /// </summary>
    public string? ProdEmpresa { get; set; }

    /// <summary>
    /// morada
    /// </summary>
    public string? ProdMorada { get; set; }

    /// <summary>
    /// cpostal
    /// </summary>
    public string? ProdCpostal { get; set; }

    /// <summary>
    /// cidade
    /// </summary>
    public string? ProdCidade { get; set; }

    public int? ProdIdPais { get; set; }

    /// <summary>
    /// pais assoc. ao servico
    /// </summary>
    public string? ProdPais { get; set; }

    /// <summary>
    /// referencia do servico (introd. pelo cliente) 
    /// </summary>
    public string? ProdRef { get; set; }

    /// <summary>
    /// empresa assoc. ao servico
    /// </summary>
    public string? ExtEmpresa { get; set; }

    /// <summary>
    /// morada
    /// </summary>
    public string? ExtMorada { get; set; }

    /// <summary>
    /// cpostal
    /// </summary>
    public string? ExtCpostal { get; set; }

    /// <summary>
    /// cidade
    /// </summary>
    public string? ExtCidade { get; set; }

    public int? ExtIdPais { get; set; }

    /// <summary>
    /// pais assoc. ao servico
    /// </summary>
    public string? ExtPais { get; set; }

    /// <summary>
    /// data de entrega do produto
    /// </summary>
    public DateTime? PodDate { get; set; }

    /// <summary>
    /// assinatura da entrega do produto
    /// </summary>
    public string? PodSignature { get; set; }

    /// <summary>
    /// quantidade associada ao servico
    /// </summary>
    public decimal Quantidade { get; set; }

    /// <summary>
    /// valor unitario
    /// </summary>
    public decimal ValorUnitario { get; set; }

    public bool FaltaValorUnitario { get; set; }

    /// <summary>
    /// tipo de iva associado ao servico (IVATipo_T)
    /// </summary>
    public int? IdTipoIva { get; set; }

    /// <summary>
    /// taxa de iva a aplicar
    /// </summary>
    public decimal TaxaIva { get; set; }

    /// <summary>
    /// valor do produto (valorunitario * quantidade)
    /// </summary>
    public decimal ValorProduto { get; set; }

    /// <summary>
    /// valor total com iva incluido
    /// </summary>
    public decimal? ValorCiva { get; set; }

    /// <summary>
    /// valor total sem iva
    /// </summary>
    public decimal ValorSiva { get; set; }

    /// <summary>
    /// valor do iva
    /// </summary>
    public decimal ValorIva { get; set; }

    public string? Observacoes { get; set; }

    /// <summary>
    /// tarifa utilizada para obter valor
    /// </summary>
    public int? IdTarifa { get; set; }

    /// <summary>
    /// codigo da exportacao (ExportacaoManifesto)
    /// </summary>
    public int? IdExportacao { get; set; }

    /// <summary>
    /// codigo da importacao (ImportacaoManifesto)
    /// </summary>
    public int? IdImportacao { get; set; }

    /// <summary>
    /// codigo da entrega de material (MaterialPedido)
    /// </summary>
    public int? IdEntregaMaterial { get; set; }

    /// <summary>
    /// linha criada automaticamente
    /// </summary>
    public bool? LinhaAuto { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    /// <summary>
    /// codigo da linha (documentosLin) que deu origem a esta
    /// </summary>
    public int? IdLinOrigem { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    /// <summary>
    /// data em que linha foi creditada
    /// </summary>
    public DateTime? DtCreditada { get; set; }

    public int? IdUtilCreditada { get; set; }

    public DateTime? DtExport { get; set; }

    public int? IdExport { get; set; }

    /// <summary>
    /// observacoes relativas a correccoes automaticas de dados do servico
    /// </summary>
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
