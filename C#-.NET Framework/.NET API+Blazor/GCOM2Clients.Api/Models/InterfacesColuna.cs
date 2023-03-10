using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class InterfacesColuna
{
    public int Id { get; set; }

    public int IdInterface { get; set; }

    public string TableName { get; set; } = null!;

    public string? ColumnName { get; set; }

    public byte? Ordem { get; set; }
}
