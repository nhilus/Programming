using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EntrevistaTipoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public bool? PedeResultado { get; set; }

    public bool Manutencao { get; set; }

    public bool Captacao { get; set; }

    public bool Acordo { get; set; }
}
