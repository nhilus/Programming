using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PerguntasRespostasT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public bool AbreBo { get; set; }

    public string? DestinoBo { get; set; }

    public bool TrataFalha { get; set; }

    public int? IdEntidade { get; set; }

    public int IdCliente { get; set; }

    public bool Activo { get; set; }

    public DateTime DtInsert { get; set; }

    public int? IdUtilInsert { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilultAct { get; set; }

    public string? Tipo { get; set; }

    public string? Descricao { get; set; }

    public string? ScanCode { get; set; }

    public string? TextoDescritivo { get; set; }
}
