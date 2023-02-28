using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PlataformasEntidadesM
{
    public int Id { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdEntidade { get; set; }

    public string? Descricao { get; set; }

    public bool? Activa { get; set; }
}
