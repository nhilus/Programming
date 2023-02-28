using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PlataformasParceirosM
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdPlataformaRangel { get; set; }

    public string? ReferenciaParceiro { get; set; }

    public string? Descricao { get; set; }
}
