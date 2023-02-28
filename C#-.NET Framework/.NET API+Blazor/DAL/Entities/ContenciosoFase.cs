using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ContenciosoFase
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public int IdContencioso { get; set; }

    public int IdFase { get; set; }

    public DateTime DtFase { get; set; }

    public string? ObsFase { get; set; }
}
