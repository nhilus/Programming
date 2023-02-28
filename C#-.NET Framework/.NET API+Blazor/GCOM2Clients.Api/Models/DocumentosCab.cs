using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosCab
{
    public int Id { get; set; }

    /// <summary>
    /// indica se doc. está emitido/fechado ou é provisorio (apenas documentos fechados sao documentos reais) 
    /// </summary>
    public int IdEstado { get; set; }

    /// <summary>
    /// tipo de documento (DocumentosTipos_T)
    /// </summary>
    public int IdTipoDoc { get; set; }

    /// <summary>
    /// ano do documento
    /// </summary>
    public int AnoDoc { get; set; }

    /// <summary>
    /// departamento de facturacao (DocumentosDepartamentos_T)
    /// </summary>
    public int IdDepartamentoDoc { get; set; }

    /// <summary>
    /// numerador (contador) do documento (tem em conta o tipo, ano e departamento)
    /// </summary>
    public int NumeradorDoc { get; set; }

    /// <summary>
    /// numero do documento
    /// </summary>
    public string NumDoc { get; set; } = null!;

    /// <summary>
    /// data do documento
    /// </summary>
    public DateTime DtDoc { get; set; }

    /// <summary>
    /// codigo do cliente a que o documento diz respeito
    /// </summary>
    public int IdCliente { get; set; }

    /// <summary>
    /// modo de pagamento (DocumentosModosPagamento_T)
    /// </summary>
    public int IdModoPagamento { get; set; }

    /// <summary>
    /// data de vencimento do documento
    /// </summary>
    public DateTime? DtVencimento { get; set; }

    /// <summary>
    /// codigo da moeda (UnidadesMonetarias_T) a que o valor se refere
    /// </summary>
    public int? IdMoeda { get; set; }

    /// <summary>
    /// cambio da moeda em relacao à unidade monetaria “default” do sistema
    /// </summary>
    public decimal? Cambio { get; set; }

    /// <summary>
    /// 1 ou -1 conforme é débito ou crédito ao cliente.
    /// </summary>
    public int? Sentido { get; set; }

    /// <summary>
    /// valor do documento
    /// </summary>
    public decimal? ValorDoc { get; set; }

    /// <summary>
    /// valor sem iva
    /// </summary>
    public decimal? ValorSiva { get; set; }

    /// <summary>
    /// valor total do iva
    /// </summary>
    public decimal? ValorIva { get; set; }

    /// <summary>
    /// indica se documento deve ser referente a apenas um (=1) ou varios (&lt;&gt;1)  items
    /// observacoes
    /// 
    /// </summary>
    public bool? FacturaIndividual { get; set; }

    public string? Observacoes { get; set; }

    /// <summary>
    /// data criacao registo
    /// </summary>
    public DateTime DtIntrod { get; set; }

    /// <summary>
    /// utilizador criacao do registo
    /// </summary>
    public int IdUtilIntrod { get; set; }

    /// <summary>
    /// – data da ultima alteracao ao registo
    /// </summary>
    public DateTime DtUltAct { get; set; }

    /// <summary>
    /// data em que documento foi fechado (passou a ser um documento real)
    /// </summary>
    public DateTime? DtFecho { get; set; }

    /// <summary>
    /// utilizador que fechou (facturou) o documento
    /// </summary>
    public int? IdUtilFecho { get; set; }

    /// <summary>
    /// data em que documento foi emitido (impresso)
    /// </summary>
    public DateTime? DtEmissao { get; set; }

    /// <summary>
    /// utilizador que imprimiu o documento
    /// </summary>
    public int? IdUtilEmissao { get; set; }

    public bool? EmissaoExtra { get; set; }

    /// <summary>
    /// numero de vias emitidas.
    /// </summary>
    public int NumVias { get; set; }

    /// <summary>
    /// data em que documento foi anulado (nao utilizado/implementado, foi decidido com a Dir. Financeira que nao haverá anulacao de documentos)
    /// </summary>
    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    /// <summary>
    /// data em que documento teve todas as suas linhas creditadas
    /// </summary>
    public DateTime? DtCreditada { get; set; }

    /// <summary>
    /// utilizador que creditou
    /// </summary>
    public int? IdUtilCreditada { get; set; }

    /// <summary>
    /// entidade owner (empresa rangel/fedex) associada ao documento
    /// </summary>
    public int IdEntidade { get; set; }

    /// <summary>
    /// data em que foi exportado para o Vanguarda
    /// </summary>
    public DateTime? DtExport { get; set; }

    /// <summary>
    /// codigo “deste” cabecalho na tabela do Vanguarda
    /// </summary>
    public int? IdExport { get; set; }

    /// <summary>
    /// exportar para Debitos Directos
    /// </summary>
    public bool? ExportSdd { get; set; }

    /// <summary>
    /// data em que foi exportado para DD
    /// </summary>
    public DateTime? DtExportSdd { get; set; }

    public DateTime? DtExportSap { get; set; }

    public int? QuebraFactServico { get; set; }

    public string? QuebraFactDepart { get; set; }

    public int? QuebraFactClassOri { get; set; }

    public int? IdClienteQuebra { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdCliMoradaQuebra { get; set; }

    public bool? Libertados { get; set; }

    public string? DescTipoDoc { get; set; }

    public int? NumDocAdos { get; set; }
}
