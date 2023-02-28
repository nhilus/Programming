using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CodigosPostaisBuytragoT
{
    public int Id { get; set; }

    public int? IdPais { get; set; }

    public string? CodPais { get; set; }

    public string? Cpostal { get; set; }

    public int? ZonaCpostalOrig { get; set; }

    public int? ZonaCpostalDest { get; set; }

    public string? NomeDelegacao { get; set; }

    public int? CodRota { get; set; }

    public int? CodZonaDistrib { get; set; }

    public string? RotaInternacional { get; set; }

    public int? IdPaisZona { get; set; }
}
