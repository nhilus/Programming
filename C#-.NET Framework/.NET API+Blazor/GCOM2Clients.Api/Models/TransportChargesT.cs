using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TransportChargesT
{
    public int Id { get; set; }

    public string? CodigoGrasp { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }

    public string? Sigla { get; set; }
}
