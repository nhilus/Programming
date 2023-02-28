using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConferenciaCustosFedEx
{
    public int Id { get; set; }

    public int IdDlinkInvoice { get; set; }

    public string Factura { get; set; } = null!;

    public DateTime? DtFactura { get; set; }

    public int IdDlinkShipment { get; set; }

    public string Awbnumber { get; set; } = null!;

    public string? TipoServico { get; set; }

    public int? IdExportacao { get; set; }

    public int? IdImportacao { get; set; }

    public decimal? CustoPrevistoOriginal { get; set; }

    public decimal? ValorFacturadoOriginal { get; set; }

    public decimal? CustoPrevisto { get; set; }

    public decimal? CustoReal { get; set; }

    public decimal? ValorFacturado { get; set; }

    public decimal? CustoDadosDlink { get; set; }

    public decimal? ValorFactDadosDlink { get; set; }

    public decimal? CustoReclamado { get; set; }

    public DateTime? DtCustoReclamado { get; set; }

    public decimal? CustoCreditado { get; set; }

    public DateTime? DtCustoCreditado { get; set; }

    public bool? Conferida { get; set; }

    public DateTime? DtConferida { get; set; }

    public int? IdUtilConferida { get; set; }

    public int? IdTipoConferencia { get; set; }

    public string? Observacoes { get; set; }

    public int? IdManifesto { get; set; }
}
