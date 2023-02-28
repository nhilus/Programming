using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CodigosPostaisTntstation
{
    public int Id { get; set; }

    public string? CpostalIni { get; set; }

    public string? Cpostalfim { get; set; }

    public string? Town { get; set; }

    public string? Station { get; set; }
}
