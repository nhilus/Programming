using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MktcampanhaVantagen
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdCampanha { get; set; }
}
