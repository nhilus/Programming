using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MktcampanhaVantagen
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdCampanha { get; set; }
}
