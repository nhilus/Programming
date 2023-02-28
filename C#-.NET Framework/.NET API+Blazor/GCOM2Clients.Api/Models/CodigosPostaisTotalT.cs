using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CodigosPostaisTotalT
{
    public int Id { get; set; }

    public string? Distrito { get; set; }

    public string? Concelho { get; set; }

    public string? Localidade { get; set; }

    public string? Morada { get; set; }

    public string? Cpostal { get; set; }

    public string? Cp4 { get; set; }

    public string? Cp3 { get; set; }

    public string? LocalCp { get; set; }

    public int? IdPais { get; set; }

    public bool? Activo { get; set; }
}
