using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosNumeroMaskT
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int? IdTipoDoc { get; set; }

    public int? IdDepartamento { get; set; }

    public string Mask { get; set; } = null!;

    public int? Length { get; set; }

    public bool? Activo { get; set; }
}
