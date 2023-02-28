using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Consolidado
{
    public int Id { get; set; }

    public string Consolidado1 { get; set; } = null!;

    public string Awb { get; set; } = null!;

    public int Idempresa { get; set; }

    public DateTime? DtInsert { get; set; }

    public bool Linehaul { get; set; }

    public bool? Activo { get; set; }
}
