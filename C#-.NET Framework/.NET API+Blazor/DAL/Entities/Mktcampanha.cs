using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Mktcampanha
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public bool? Activo { get; set; }
}
