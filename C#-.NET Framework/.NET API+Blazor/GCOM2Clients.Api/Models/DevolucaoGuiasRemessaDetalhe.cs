using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DevolucaoGuiasRemessaDetalhe
{
    public int Id { get; set; }

    public string AwbOriginal { get; set; } = null!;

    public string? AwbDevolucao { get; set; }

    public int IdEstado { get; set; }

    public int IdUtilEstado { get; set; }

    public DateTime DtEstado { get; set; }
}
