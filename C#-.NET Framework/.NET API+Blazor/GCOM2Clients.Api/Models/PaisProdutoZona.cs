using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PaisProdutoZona
{
    public int Id { get; set; }

    public int IdPais { get; set; }

    public int IdTipoProduto { get; set; }

    public string? Zona { get; set; }

    public decimal TaxaIvaexport { get; set; }

    public int? IdTipoIvaexport { get; set; }

    public string? ZonaImport { get; set; }

    public decimal TaxaIvaimport { get; set; }

    public int? IdTipoIvaimport { get; set; }
}
