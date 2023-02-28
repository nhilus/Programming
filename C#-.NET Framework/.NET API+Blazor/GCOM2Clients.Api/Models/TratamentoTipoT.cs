using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TratamentoTipoT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public bool? E { get; set; }

    public bool? R { get; set; }

    public int? IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public bool? Finaliza { get; set; }

    public bool? Pendente { get; set; }

    public string? ScanCode { get; set; }

    public string? DescCurta { get; set; }

    public short? IdServicoDet { get; set; }

    public int? IdDept { get; set; }
}
