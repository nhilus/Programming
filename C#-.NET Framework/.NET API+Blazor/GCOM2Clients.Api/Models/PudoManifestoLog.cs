using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PudoManifestoLog
{
    public int Id { get; set; }

    public DateTime? DtTrigger { get; set; }

    public int IdPudoManifesto { get; set; }

    public int? IdMaster { get; set; }

    public int? IdPudoOrigem { get; set; }

    public int? IdPudoDestino { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilintrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public bool? ParaDevolver { get; set; }

    public DateTime? DtParaDevolver { get; set; }

    public bool? Devolvido { get; set; }

    public bool? Entregue { get; set; }

    public DateTime? DtEntregue { get; set; }

    public bool? Concluido { get; set; }

    public DateTime? DtConcluido { get; set; }
}
