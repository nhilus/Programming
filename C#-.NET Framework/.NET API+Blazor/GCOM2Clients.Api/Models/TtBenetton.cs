using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TtBenetton
{
    public string? TrfTipoRec { get; set; }

    public string? TrfDeliveryCode { get; set; }

    public string? TrfCodStatoConsForn { get; set; }

    public string? TrfDtaAggStatoCons { get; set; }

    public string? TrfOraAggStatoCons { get; set; }

    public string? TrfIdnConsegnaForn { get; set; }

    public string? TrfDtaRitiro { get; set; }

    public string? TrfOraRitiro { get; set; }

    public string? TrfDtaConsegna { get; set; }

    public string? TrfOraConsegna { get; set; }

    public string? TrfDtaConsPrenotazione { get; set; }

    public string? TrfOraConsPrenotazione { get; set; }

    public string? TrfNroGgAttForn { get; set; }

    public string? TrfDesPiattaformaPart { get; set; }

    public string? TrfDesPiattaformaDest { get; set; }

    public string? TrfCodTipoConsegna { get; set; }

    public string? TrfDtaInizioGiac { get; set; }

    public string? TrfDtaFineGiac { get; set; }

    public string? TrfCodTipoServizio { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int IdScan { get; set; }
}
