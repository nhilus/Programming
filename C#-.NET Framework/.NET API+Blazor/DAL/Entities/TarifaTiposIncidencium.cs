using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaTiposIncidencium
{
    public int Id { get; set; }

    public int IdTarifa { get; set; }

    public int? IdProduto { get; set; }

    public string? ZonaOrigem { get; set; }

    public string? ZonaDestino { get; set; }

    public int? IdTipoIncidencia { get; set; }

    public decimal? DivVolumetrico { get; set; }

    public bool Activo { get; set; }
}
