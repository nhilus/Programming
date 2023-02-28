using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AviaoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? Matricula { get; set; }

    public int IdPlataforma { get; set; }

    public bool Importacao { get; set; }

    public bool? Activo { get; set; }
}
