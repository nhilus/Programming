using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ScancodesTranslationsT
{
    public int Id { get; set; }

    public string Scancode { get; set; } = null!;

    public int IdEntidade { get; set; }

    public string? Lingua { get; set; }

    public string? Descricao { get; set; }

    public string? DescWeb { get; set; }
}
