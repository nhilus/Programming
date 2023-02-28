using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class LocaisLevantamento
{
    public int Id { get; set; }

    public string? Morada { get; set; }

    public string? CodPostal { get; set; }
}
