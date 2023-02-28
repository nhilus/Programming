using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TblDelete
{
    public int Id { get; set; }

    public int IdUtil { get; set; }

    public DateTime DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public string Sproc { get; set; } = null!;

    public string Query { get; set; } = null!;

    public int? SpId { get; set; }

    public string? Hostname { get; set; }

    public int? Passo { get; set; }

    public int? IdParent { get; set; }
}
