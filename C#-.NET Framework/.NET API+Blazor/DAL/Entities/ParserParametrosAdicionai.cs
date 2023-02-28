using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserParametrosAdicionai
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string FileName { get; set; } = null!;

    public DateTime DtIntrod { get; set; }

    public DateTime? PaArrivalDate { get; set; }

    public DateTime? PaDtEntregaDesejada { get; set; }

    public string? PaRefOrigem { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdUtilIntrod { get; set; }
}
