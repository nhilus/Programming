using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TaxasAdicionaisConfigDetalhe
{
    public int Id { get; set; }

    public int? IdTaxaAdicionalConfig { get; set; }

    public string? ZonaOri { get; set; }

    public string? ZonaDest { get; set; }

    public bool? AplicaValor { get; set; }
}
