using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PickupcodesT
{
    public string Scancode { get; set; } = null!;

    public int IdEntidade { get; set; }

    public string? Descricao { get; set; }

    public string? DescWeb { get; set; }

    public bool? Poddex { get; set; }

    public bool? Finaliza { get; set; }

    public bool? ComCarga { get; set; }

    public bool? DexAceitavel { get; set; }

    public bool? DexInaceitavel { get; set; }

    public bool? Activo { get; set; }

    public bool Tratamento { get; set; }

    public bool TratamentoCliente { get; set; }

    public int? IdTrataDept { get; set; }

    public int? IdTrataGrupo { get; set; }

    public string? ScanType { get; set; }

    public string? ScanTypeScanCode { get; set; }

    public bool NotifCliente { get; set; }

    public bool? ParaFacturarFornecedor { get; set; }

    public bool? ReAgenda { get; set; }
}
