using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLead
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public byte? IdTipoOrigem { get; set; }

    public int? IdCliente { get; set; }

    public string? Nome { get; set; }

    public string? Nif { get; set; }

    public string? Morada { get; set; }

    public int? IdCpostal { get; set; }

    public string? Cpostal { get; set; }

    public string? Localidade { get; set; }

    public int? IdPais { get; set; }

    public string? Contacto { get; set; }

    public string? Telefone { get; set; }

    public int? IdConcorrente { get; set; }

    public int? Potencial { get; set; }

    public string? Observacoes { get; set; }

    public int? IdEstado { get; set; }

    public string? ObsEstado { get; set; }

    public int? IdUtilEstado { get; set; }

    public DateTime? DtEstado { get; set; }

    public int? IdAcordo { get; set; }

    public string? ObsAcordo { get; set; }

    public int? IdUtilAcordo { get; set; }

    public DateTime? DtAcordo { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public decimal? Valor1 { get; set; }

    public DateTime? DtValor1 { get; set; }

    public decimal? Valor2 { get; set; }

    public DateTime? DtValor2 { get; set; }

    public int? IdOrigem { get; set; }

    public int? IdStatusReason { get; set; }

    public int? IdCae { get; set; }

    public string? Email { get; set; }

    public int? IdStatusReasonTrf { get; set; }

    public int? IdUtilResp { get; set; }

    public bool? Fechada { get; set; }

    public int? IdleadstatusMotivo { get; set; }

    public string? LeadstatusTrfobs { get; set; }

    public int? IdCliMorada { get; set; }
}
