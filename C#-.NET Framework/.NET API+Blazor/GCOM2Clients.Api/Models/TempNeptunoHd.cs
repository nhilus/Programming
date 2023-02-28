using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempNeptunoHd
{
    public string? Nome { get; set; }

    public string? Nif { get; set; }

    public string? Locaidade { get; set; }

    public string? Cpostal { get; set; }

    public string? Telf1 { get; set; }

    public string? Telf2 { get; set; }

    public decimal? Potencial { get; set; }

    public string? Gestor { get; set; }

    public int? IdCliente { get; set; }

    public bool? Repetido { get; set; }

    public bool? Anulado { get; set; }

    public string? Localidade { get; set; }
}
