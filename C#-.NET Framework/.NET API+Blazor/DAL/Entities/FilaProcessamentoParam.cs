using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class FilaProcessamentoParam
{
    public int Id { get; set; }

    public int IdFila { get; set; }

    public string CodParam { get; set; } = null!;

    public object? ValParam { get; set; }
}
