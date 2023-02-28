using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AlertaDetalhe
{
    public int Id { get; set; }

    public int IdAlerta { get; set; }

    public int? IdDeptDestino { get; set; }

    public int? IdUtilDestino { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IdUtilFecho { get; set; }

    public bool Fechado { get; set; }
}
