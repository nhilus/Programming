using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Feriado
{
    public int Id { get; set; }

    public DateTime Dia { get; set; }

    public string? Descricao { get; set; }

    public bool? Fixo { get; set; }

    public bool? Local { get; set; }
}
