using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LocaisLevantamento
{
    public int Id { get; set; }

    public string? Morada { get; set; }

    public string? CodPostal { get; set; }
}
