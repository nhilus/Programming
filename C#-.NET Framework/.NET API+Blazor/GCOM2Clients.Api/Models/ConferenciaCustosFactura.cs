using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ConferenciaCustosFactura
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliente { get; set; }

    public string? NumeroDocumento { get; set; }

    public DateTime? DataDocumento { get; set; }

    public string? TipoDocumento { get; set; }

    public decimal? ValorTotal { get; set; }

    public string? IdMoeda { get; set; }

    public int? QuantidadeEnvios { get; set; }

    public string? NumContaAfacturar { get; set; }

    public string? PaisFacturacao { get; set; }

    public string? CodigoResolucao { get; set; }

    public string? CodigoResolucaoMotivo { get; set; }

    public decimal? ValorReclamado { get; set; }

    public decimal? ValorCreditado { get; set; }

    public decimal? ValorTotalAjustado { get; set; }

    public string? ValorOriginalAjuste { get; set; }

    public string? ImportObjectName { get; set; }

    public int? ImportObjectId { get; set; }

    public DateTime? DtIntrod { get; set; }
}
