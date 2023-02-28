using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PlataformaRegT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;
}
