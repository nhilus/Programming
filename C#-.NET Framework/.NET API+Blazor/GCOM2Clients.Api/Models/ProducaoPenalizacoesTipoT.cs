using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ProducaoPenalizacoesTipoT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public decimal? ValorDefault { get; set; }

    public bool Activo { get; set; }

    public string? Codigo { get; set; }
}
