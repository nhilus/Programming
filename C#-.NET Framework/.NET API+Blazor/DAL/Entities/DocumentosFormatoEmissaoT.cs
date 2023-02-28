using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosFormatoEmissaoT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool IsDefault { get; set; }

    public bool? Activo { get; set; }

    public bool? IsManual { get; set; }
}
