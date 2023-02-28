using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaSugestaoCriteriosLog
{
    public int Id { get; set; }

    public short IdCriterio { get; set; }

    public byte? IdEntidade { get; set; }

    public DateTime DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public object? ValorMin { get; set; }

    public object? ValorMax { get; set; }

    public short? Valorizacao { get; set; }

    public decimal? MultValor { get; set; }

    public short? IdEntrevistaTipo { get; set; }

    public short? NumDiasSemContacto { get; set; }
}
