using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MenuUrlDoc
{
    public int Id { get; set; }

    public int IdMenuUrl { get; set; }

    public int IdMenuDoc { get; set; }

    public int IdEntidade { get; set; }
}
