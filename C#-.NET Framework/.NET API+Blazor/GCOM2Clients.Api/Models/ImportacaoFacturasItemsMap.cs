using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ImportacaoFacturasItemsMap
{
    public int Id { get; set; }

    public int FileType { get; set; }

    public string? NomeColuna { get; set; }

    public string? ChargeMiscCode { get; set; }

    public int IdEntidade { get; set; }

    public int? IdServicoDet { get; set; }

    public string? Description { get; set; }

    public string? Codigo { get; set; }
}
