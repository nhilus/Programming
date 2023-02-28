using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ImportacaoScansImagen
{
    public int Id { get; set; }

    public int? IdScan { get; set; }

    public string? Foto { get; set; }

    public DateTime? DtFoto { get; set; }

    public int? IdDocAdos { get; set; }
}
