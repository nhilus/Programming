using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TmpSaraiva
{
    public int? Id { get; set; }

    public string? Nome { get; set; }

    public int? Cae { get; set; }

    public string? Morada { get; set; }

    public string? Cpostal { get; set; }

    public string? Localidade { get; set; }

    public string? NomeContacto { get; set; }

    public long? Telefone { get; set; }

    public string? NumeroContribuinte { get; set; }

    public string? NumeroContaFedEx { get; set; }

    public int? TotalPotencialExp { get; set; }

    public int? TotalNegociadoExp { get; set; }

    public int? TotalPotencialImp { get; set; }

    public int? TotalNegociadoImp { get; set; }

    public int? PotencialNac { get; set; }

    public int? NegociadoNac { get; set; }

    public string? StatusComercial { get; set; }

    public DateTime? DataUltStatusComercial { get; set; }

    public string? StatusCredito { get; set; }

    public DateTime? DataUltStatusComercial2 { get; set; }

    public string? NomeUtilizador { get; set; }

    public string? PlatUtilResp { get; set; }

    public string? UtilizadorResp { get; set; }

    public DateTime? UltEntrev { get; set; }

    public DateTime? UltEncom { get; set; }

    public string? Email { get; set; }

    public string? TarImp { get; set; }

    public string? TarExp { get; set; }

    public string? Equipa { get; set; }
}
