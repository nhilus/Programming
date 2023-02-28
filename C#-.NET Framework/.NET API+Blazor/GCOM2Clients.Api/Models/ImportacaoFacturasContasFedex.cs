using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ImportacaoFacturasContasFedex
{
    public int Id { get; set; }

    public string? AccountNumber { get; set; }

    public int IdEntidade { get; set; }

    public string? SiglaPais { get; set; }
}
