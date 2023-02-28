using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SalesLeadEstadosLog
{
    public int Id { get; set; }

    public int IdSalesLead { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdLeadStatus { get; set; }

    public int? IdStatusReason { get; set; }

    public int? IdStatusReasonTrf { get; set; }

    public int? IdUtilResp { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdOrigem { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtUtilIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }
}
